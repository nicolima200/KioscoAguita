using dominio;
using dominio.enums;
using service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmPrincipal
{
    public partial class frmRegistroVentas : Form
    {
        private List<Venta> ventas = new List<Venta>();
        private List<DetalleVenta> detallesVenta= new List<DetalleVenta>();
        private RegistroVentasService registroVentasService = new RegistroVentasService();
        private Venta ventaSeleccionada;
        private DetalleVenta detalleVentaSeleccionado;
        private decimal totalTransferencia=0;
        private decimal totalEfectivo=0;
        private decimal total=0;


        public frmRegistroVentas()
        {
            InitializeComponent();
        }
        private void frmRegistroVentas_Load(object sender, EventArgs e)
        {
            cargarListaVentas();
            ventaSeleccionada = seleccionarVenta();

            cargarListaDetalleVenta();
            detalleVentaSeleccionado = seleccionarDetalleVenta();
        }

        private void cargarListaDetalleVenta()
        {
            if (ventaSeleccionada != null)
            {
                detallesVenta = registroVentasService.listarDetalleVentaPorIdVenta(ventaSeleccionada.Id);
                dgvDetalleVenta.DataSource = detallesVenta;
                configColumnasDgvDetalleVentas();
                configFilasDgvDetalleVentas();
            }
        }

        private void configFilasDgvDetalleVentas()
        {
            dgvDetalleVenta.RowHeadersVisible = false;

            setCeldaActivaDgvDetalleVentas();
        }

        private void setCeldaActivaDgvDetalleVentas()
        {
            if (dgvDetalleVenta.Rows.Count > 0)
            {
                var primerColumnaVisible = dgvDetalleVenta.Columns.Cast<DataGridViewColumn>().FirstOrDefault(c => c.Visible);

                if (primerColumnaVisible != null)
                {
                    dgvDetalleVenta.CurrentCell = dgvDetalleVenta.Rows[0].Cells[primerColumnaVisible.Index];
                }

            }
            else
            {
                detalleVentaSeleccionado = null;
                //limpiarLabelsDetalle();
            }
        }

        private void configColumnasDgvDetalleVentas()
        {
            dgvDetalleVenta.Columns["Id"].Visible = false;
            dgvDetalleVenta.Columns["IdVenta"].Visible = false;
            dgvDetalleVenta.Columns["IdProducto"].Visible = false;
        }

        private void cargarListaVentas()
        {
            ventas = registroVentasService.listar().ToList();
            dgvVentas.DataSource = ventas;


            configColumnasDgvVentas();

            configFilasDgvVentas();

            calcularYMostrarTotales(ventas);
        }

        private void calcularYMostrarTotales(List<Venta> ventas)
        {
            totalEfectivo= 0;
            totalTransferencia= 0;
            total = 0;

            foreach (Venta venta in ventas)
            {
                if (venta.FormaPago == FormaPago.Transferencia)
                {
                    totalTransferencia += venta.MontoTotal;
                }
                else if (venta.FormaPago == FormaPago.Efectivo)
                {
                    totalEfectivo += venta.MontoTotal;
                }
                total += venta.MontoTotal;
            }
           
            lblTotalEfectivo.Text = totalEfectivo.ToString("C2");
            lblTotalTransferencia.Text = totalTransferencia.ToString("C2");
            lblTotalTOTAL.Text = total.ToString("C2");
        }

        private void configFilasDgvVentas()
        {
            dgvVentas.RowHeadersVisible = false;

            setCeldaActivaDgvVentas();
        }

        private void setCeldaActivaDgvVentas()
        {
            if (dgvVentas.Rows.Count > 0)
            {
                var primerColumnaVisible = dgvVentas.Columns.Cast<DataGridViewColumn>().FirstOrDefault(c => c.Visible);

                if (primerColumnaVisible != null)
                {
                    dgvVentas.CurrentCell = dgvVentas.Rows[0].Cells[primerColumnaVisible.Index];
                }

            }
            else
            {
                ventaSeleccionada = null;
                //limpiarLabelsDetalle();
            }
        }

        private void configColumnasDgvVentas()
        {
            if (dgvVentas.Columns.Count == 0) return;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvVentas.ColumnHeadersHeight = 32;
            dgvVentas.RowTemplate.Height = 26;
            dgvVentas.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvVentas.ColumnHeadersDefaultCellStyle.Padding = new Padding(0);
            dgvVentas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Id oculto
            if (dgvVentas.Columns["Id"] != null) dgvVentas.Columns["Id"].Visible = false;

            // Fecha - izquierda, ancho para "2/9/2026 13:03"
            var colFecha = dgvVentas.Columns["Fecha"];
            if (colFecha != null)
            {
                colFecha.HeaderText = "Fecha";
                colFecha.FillWeight = 16;
                colFecha.MinimumWidth = 95;
                colFecha.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                colFecha.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                colFecha.DefaultCellStyle.Format = "g";
            }
            // Forma de pago
            var colPago = dgvVentas.Columns["FormaPago"];
            if (colPago != null)
            {
                colPago.HeaderText = "Forma de pago";
                colPago.FillWeight = 18;
                colPago.MinimumWidth = 100;
                colPago.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                colPago.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }
            // TOTAL
            var colTotal = dgvVentas.Columns["MontoTotal"] ?? dgvVentas.Columns["montototal"];
            if (colTotal != null)
            {
                colTotal.HeaderText = "Total";
                colTotal.FillWeight = 16;
                colTotal.MinimumWidth = 95;
                colTotal.DefaultCellStyle.Format = "C2";
                colTotal.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                colTotal.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            // Cliente pagó con / Pagó con
            var colMontoPago = dgvVentas.Columns["MontoPago"] ?? dgvVentas.Columns["montopago"];
            if (colMontoPago != null)
            {
                colMontoPago.HeaderText = "Pagó con";
                colMontoPago.FillWeight = 18;
                colMontoPago.MinimumWidth = 105;
                colMontoPago.DefaultCellStyle.Format = "C2";
                colMontoPago.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                colMontoPago.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            // Vuelto
            var colVuelto = dgvVentas.Columns["Vuelto"] ?? dgvVentas.Columns["vuelto"];
            if (colVuelto != null)
            {
                colVuelto.HeaderText = "Vuelto";
                colVuelto.FillWeight = 16;
                colVuelto.MinimumWidth = 95;
                colVuelto.DefaultCellStyle.Format = "C2";
                colVuelto.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                colVuelto.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            // Referencia
            var colRef = dgvVentas.Columns["referencia"];
            if (colRef != null)
            {
                colRef.HeaderText = "Referencia";
                colRef.FillWeight = 24;
                colRef.MinimumWidth = 110;
                colRef.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                colRef.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }
            // Asegurar estilos modernos sin grilla vertical pesada
            dgvVentas.EnableHeadersVisualStyles = false;
            dgvVentas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(233, 237, 243);
            dgvVentas.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(71, 85, 105);
            dgvVentas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvVentas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvVentas.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgvVentas.GridColor = Color.FromArgb(212, 219, 232);
            dgvVentas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvVentas.BackgroundColor = Color.White;
        }

        //private void limpiarLabelsDetalle()
        //{
        //    lblNombre.Text = "";
        //    lblMarca.Text = "";
        //    lblDescripcion.Text = "";
        //    lblPrecio.Text = "";
        //}

        private Venta seleccionarVenta()
        {
            if (dgvVentas.CurrentCell == null) return null;

            return (Venta)dgvVentas.CurrentRow.DataBoundItem;

        }
        private DetalleVenta seleccionarDetalleVenta()
        {
            if (dgvDetalleVenta.CurrentCell == null) return null;

            return (DetalleVenta)dgvDetalleVenta.CurrentRow.DataBoundItem;

        }

        private void dgvVentas_CurrentCellChanged(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                ventaSeleccionada = seleccionarVenta();
                detalleVentaSeleccionado = seleccionarDetalleVenta();
                cargarListaDetalleVenta();
                actualizarLabels();
            }));
        }

        private void actualizarLabels()
        {
            if (detalleVentaSeleccionado != null)
            {
                //lblNombre.Text = detalleVentaSeleccionado.Nombre;
                //lblMarca.Text = detalleVentaSeleccionado.Marca;
                //lblDescripcion.Text = detalleVentaSeleccionado.Descripcion;
                //lblPrecio.Text = detalleVentaSeleccionado.PrecioUnitario.ToString("C2");
                lblMontoTotal.Text = ventaSeleccionada.MontoTotal.ToString("C2");
                lblFecha.Text = ventaSeleccionada.Fecha.ToString("g");
                if (ventaSeleccionada != null && dgvDetalleVenta.Rows.Count > 0)
                {
                    int cantidadProductos = 0;
                    foreach (DetalleVenta detalle in detallesVenta)
                    {

                        if (!detalle.TipoVenta.ToString().Equals("Unidad"))
                            cantidadProductos += 1;
                        else
                            cantidadProductos += (int)detalle.Cantidad;
                    }
                    lblCantProductosLista.Text = "Cantidad de productos: "+cantidadProductos.ToString();
                }
                else
                {
                    lblCantProductosLista.Text = "Cantidad de productos: 0";
                }
            }
        }

        private void dgvDetalleVenta_CurrentCellChanged(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                detalleVentaSeleccionado = seleccionarDetalleVenta();
                actualizarLabels();
            }));
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            RegistroVentasService registroVentasService = new RegistroVentasService();

            if (dtpDesde.Value > dtpHasta.Value)
            {
                MessageBox.Show("La fecha 'Desde' no puede ser mayor a la fecha 'Hasta'.", "Error de fechas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime desde = dtpDesde.Value.Date;
            DateTime hasta = dtpHasta.Value.Date;

            List<Venta> listaFiltrada = registroVentasService.listarPorFecha(desde, hasta).ToList();
            dgvVentas.DataSource = listaFiltrada;
            configColumnasDgvVentas();
            configFilasDgvVentas();
            dgvVentas_CurrentCellChanged(sender, e);

            calcularYMostrarTotales(listaFiltrada);
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Now;
            dtpHasta.Value = DateTime.Now;
            cargarListaVentas();
        }
    }
}
