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
            //Damos formato a las columnas
            dgvVentas.Columns["Id"].Visible = false;
            dgvVentas.AutoResizeColumn(1);//fecha

            dgvVentas.Columns["montototal"].DefaultCellStyle.Format = "C2";
            dgvVentas.Columns["montototal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvVentas.AutoResizeColumn(3);//monto total

            dgvVentas.Columns["montopago"].DefaultCellStyle.Format = "C2";
            dgvVentas.Columns["montopago"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvVentas.AutoResizeColumn(4);//monto pago

            dgvVentas.Columns["vuelto"].DefaultCellStyle.Format = "C2";
            dgvVentas.Columns["vuelto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvVentas.AutoResizeColumn(5);//vuelto
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
