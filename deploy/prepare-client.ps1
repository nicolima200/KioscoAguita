param(
    [string]$Configuration = "Release",
    [string]$Platform = "x64"
)

$ErrorActionPreference = "Stop"
$deployDir = $PSScriptRoot
$root = Split-Path -Parent $deployDir
$project = Join-Path $root "frmPrincipal\Gestor kiosco.csproj"
$outputDir = Join-Path $root "frmPrincipal\bin\$Platform\$Configuration"
$stagingDir = Join-Path $deployDir "client"
$obfuscatedDir = Join-Path $outputDir "Obfuscated"
$runtimeIdentifier = "win-x64"
$excludedOutputItems = @(
    "app.publish",
    "Obfuscated",
    "imágenes",
    "Kiosco26.application",
    "Kiosco26.exe.manifest",
    "service.dll.config",
    "libSkiaSharp.dylib"
)

$vswhere = Join-Path ${env:ProgramFiles(x86)} "Microsoft Visual Studio\Installer\vswhere.exe"
$msbuild = $null
if (Test-Path -LiteralPath $vswhere) {
    $vsPath = & $vswhere -latest -products * -requires Microsoft.Component.MSBuild -property installationPath
    if ($vsPath) {
        $candidate = Join-Path $vsPath "MSBuild\Current\Bin\MSBuild.exe"
        if (Test-Path -LiteralPath $candidate) {
            $msbuild = $candidate
        }
    }
}

Write-Host "=== Compilando cliente ($Configuration | $Platform) ==="
if ($msbuild) {
    & $msbuild $project /t:Restore,Build /p:Configuration=$Configuration /p:Platform=$Platform /p:RuntimeIdentifier=$runtimeIdentifier
} else {
    dotnet build $project --configuration $Configuration -p:Platform=$Platform -p:RuntimeIdentifier=$runtimeIdentifier
}
if ($LASTEXITCODE -ne 0) {
    throw "La compilación falló."
}

if (-not (Test-Path $outputDir)) {
    throw "No se encontró salida de compilación: $outputDir"
}

Write-Host "=== Preparando carpeta para Advanced Installer ==="
if (Test-Path $stagingDir) {
    Remove-Item -LiteralPath $stagingDir -Recurse -Force
}
New-Item -ItemType Directory -Path $stagingDir | Out-Null
Get-ChildItem -LiteralPath $outputDir |
    Where-Object { $_.Name -notin $excludedOutputItems } |
    Copy-Item -Destination $stagingDir -Recurse -Force

$obfuscatedExe = Join-Path $obfuscatedDir "Kiosco26.exe"
if (-not (Test-Path -LiteralPath $obfuscatedExe)) {
    throw "No se encontró ejecutable ofuscado: $obfuscatedExe"
}
Copy-Item -LiteralPath $obfuscatedExe -Destination (Join-Path $stagingDir "Kiosco26.exe") -Force

Get-ChildItem -LiteralPath $stagingDir -Recurse -File |
    Where-Object { $_.Extension -in ".pdb", ".xml" } |
    Remove-Item -Force -Confirm:$false

Write-Host ""
Write-Host "Carpeta lista: $stagingDir"
Write-Host "En Advanced Installer, agregá esta carpeta una sola vez y activá sincronización automática."
