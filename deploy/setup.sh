#!/bin/bash
set -e

# === Config ===
APP_DIR="/opt/kiosco-licencias"
SERVICE_NAME="kiosco-licencias-api"
DOMAIN="api.kiosco26.com"
DOTNET_VERSION="10.0"

echo "=== Kiosco26 Licencias API - Setup ==="

# --- 1. Instalar .NET Runtime ---
if ! command -v dotnet &> /dev/null; then
    echo "[1/6] Instalando .NET Runtime ${DOTNET_VERSION}..."
    wget -q https://packages.microsoft.com/config/ubuntu/$(lsb_release -rs)/packages-microsoft-prod.deb -O /tmp/packages-microsoft-prod.deb
    sudo dpkg -i /tmp/packages-microsoft-prod.deb
    sudo apt-get update -qq
    sudo apt-get install -y -qq aspnetcore-runtime-${DOTNET_VERSION}
    rm /tmp/packages-microsoft-prod.deb
else
    echo "[1/6] .NET ya instalado: $(dotnet --version)"
fi

# --- 2. Crear usuario kiosco ---
if ! id -u kiosco &>/dev/null; then
    echo "[2/6] Creando usuario kiosco..."
    sudo useradd -r -s /bin/false kiosco
else
    echo "[2/6] Usuario kiosco ya existe."
fi

# --- 3. Copiar archivos de la API ---
echo "[3/6] Copiando archivos de la API..."
sudo mkdir -p ${APP_DIR}
sudo cp -r publish/* ${APP_DIR}/
sudo chown -R kiosco:kiosco ${APP_DIR}

# --- 4. Instalar y configurar Nginx ---
echo "[4/6] Configurando Nginx..."
if ! command -v nginx &> /dev/null; then
    sudo apt-get install -y -qq nginx
fi

sudo cp nginx-kiosco-licencias.conf /etc/nginx/sites-available/${SERVICE_NAME}
sudo ln -sf /etc/nginx/sites-available/${SERVICE_NAME} /etc/nginx/sites-enabled/
sudo rm -f /etc/nginx/sites-enabled/default
sudo nginx -t
sudo systemctl reload nginx

# --- 5. HTTPS con Let's Encrypt ---
echo "[5/6] Configurando HTTPS con Let's Encrypt..."
if ! command -v certbot &> /dev/null; then
    sudo apt-get install -y -qq certbot python3-certbot-nginx
fi
sudo certbot --nginx -d ${DOMAIN} --non-interactive --agree-tos --email admin@kiosco26.com

# --- 6. Instalar y arrancar systemd service ---
echo "[6/6] Instalando servicio systemd..."
sudo cp ${SERVICE_NAME}.service /etc/systemd/system/
sudo systemctl daemon-reload
sudo systemctl enable ${SERVICE_NAME}
sudo systemctl restart ${SERVICE_NAME}

echo ""
echo "=== Deploy completado ==="
echo "API: https://${DOMAIN}"
echo "Logs: sudo journalctl -u ${SERVICE_NAME} -f"
echo "Status: sudo systemctl status ${SERVICE_NAME}"
echo ""
echo "IMPORTANTE: Copiá clave-publica.txt del servidor al proyecto cliente:"
echo "  scp kiosco@tu-vps:${APP_DIR}/clave-publica.txt service/clave-publica.txt"
