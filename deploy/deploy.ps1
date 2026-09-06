# Publica LicenciasApi y prepara carpeta deploy lista para subir al VPS
param(
    [string]$VpsUser = "root",
    [string]$VpsHost = "TU_IP_DEL_VPS",
    [string]$MsiPath = "",      # Ruta al MSI generado por Advanced Installer (ej. C:\releases\Kiosco26.msi)
    [string]$Version = "",      # Version nueva, ej. 1.1.0.0 (debe coincidir con AssemblyVersion del build)
    [string]$Changelog = "Nueva versión del Kiosco26."
)

$ErrorActionPreference = "Stop"
$root = Split-Path -Parent $PSScriptRoot

Write-Host "=== 1. Publicando LicenciasApi (linux-x64) ==="
Push-Location "$root\LicenciasApi"
dotnet publish -c Release -r linux-x64 --self-contained false -o publish
Pop-Location

Write-Host "=== 2. Copiando archivos a deploy/publish/ ==="
$deployDir = "$PSScriptRoot"
$publishDir = "$root\LicenciasApi\publish"
$publishTarget = "$deployDir\publish"

if (Test-Path $publishTarget) { Remove-Item -Recurse -Force $publishTarget }
Copy-Item -Path $publishDir -Destination $publishTarget -Recurse -Force

Write-Host "=== 2b. Staging de actualizaciones del cliente ==="
$updatesDir = "$deployDir\updates"

if ($MsiPath -and $Version) {
    if (-not (Test-Path $MsiPath)) { throw "No existe el MSI: $MsiPath" }
    if ($Version -notmatch '^\d+\.\d+\.\d+\.\d+$') { throw "Version debe tener formato ej. 1.1.0.0" }

    if (-not (Test-Path $updatesDir)) { New-Item -ItemType Directory -Path $updatesDir | Out-Null }

    $msiName = "Kiosco26_$Version.msi"
    Copy-Item -Path $MsiPath -Destination "$updatesDir\$msiName" -Force
    $hash = (Get-FileHash -Algorithm SHA256 "$updatesDir\$msiName").Hash

    $xml = @"
<?xml version="1.0" encoding="UTF-8"?>
<item>
    <version>$Version</version>
    <url>https://api.kiosco26.com/updates/$msiName</url>
    <changelog>$Changelog</changelog>
    <mandatory>false</mandatory>
    <checksum algorithm="SHA256">$hash</checksum>
</item>
"@
    Set-Content -Path "$updatesDir\update.xml" -Value $xml -Encoding UTF8
    Write-Host "update.xml generado (versión $Version) en $updatesDir"
} else {
    Write-Host "Sin MsiPath/Version: se omite staging de actualizaciones."
}

Write-Host "=== 3. Listo para subir ==="
Write-Host ""
Write-Host "Subí la carpeta deploy al VPS:"
Write-Host "  scp -r '$deployDir' ${VpsUser}@${VpsHost}:/tmp/deploy-kiosco"
Write-Host ""
Write-Host "Después entrá por SSH y ejecutá:"
Write-Host "  ssh ${VpsUser}@${VpsHost}"
Write-Host "  cd /tmp/deploy-kiosco"
Write-Host "  chmod +x setup.sh"
Write-Host "  sudo ./setup.sh"
Write-Host ""
Write-Host "IMPORTANTE: Editá VpsHost al principio del script con la IP real de tu VPS."
