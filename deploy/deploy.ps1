# Publica LicenciasApi y prepara carpeta deploy lista para subir al VPS
param(
    [string]$VpsUser = "root",
    [string]$VpsHost = "TU_IP_DEL_VPS"
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
