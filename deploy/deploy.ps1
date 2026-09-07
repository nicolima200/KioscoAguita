# Prepara actualizaciones del cliente para publicar en el VPS
param(
    [string]$VpsUser = "root",
    [string]$VpsHost = "TU_IP_DEL_VPS",
    [string]$MsiPath = "",      # Ruta al MSI generado por Advanced Installer (ej. C:\releases\Kiosco26.msi)
    [string]$Version = "",      # Version nueva, ej. 1.1.0.0 (debe coincidir con AssemblyVersion del build)
    [string]$Changelog = "Nueva versión del Kiosco26."
)

$ErrorActionPreference = "Stop"
$deployDir = $PSScriptRoot
$updatesDir = "$deployDir\updates"

Write-Host "=== Staging de actualización del cliente ==="
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

Write-Host "=== Listo para subir ==="
Write-Host ""
Write-Host "Subí updates al VPS:"
Write-Host "  scp -r '$updatesDir\*' ${VpsUser}@${VpsHost}:/opt/kiosco-updates/"
Write-Host ""
Write-Host "IMPORTANTE: Editá VpsHost con la IP real del VPS."
