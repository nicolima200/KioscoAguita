using dominio;
using dominio.enums;
using service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmPrincipal
{
    public partial class frmCobro : Form
    {
        decimal montoTotal=0;
        decimal montoEfectivo=0;
        decimal vuelto=0;
        List<DetalleVenta> listaVenta;
        public frmCobro()
        {
            InitializeComponent();
        }

        public frmCobro(decimal montoTotal, BindingList<DetalleVenta> listaVenta) : this()
        {
            this.montoTotal = montoTotal;
            this.listaVenta = listaVenta.ToList();
            aplicarTema();
        }

        private void aplicarTema()
        {
            //Color fondo
            //azul oscuro
            this.BackColor = ColorTranslator.FromHtml("#1E1E2F");

            //Labels
            lblTotal.ForeColor = ColorTranslator.FromHtml("#00D25B");
            lblMontoTotal.Text = montoTotal.ToString("N2");

            lblClientePagaEfectivo.BackColor = ColorTranslator.FromHtml("#27293D");
            lblVuelto.BackColor = ColorTranslator.FromHtml("#27293D");
            lblNombreCliente.BackColor = ColorTranslator.FromHtml("#27293D");


            lblMontoVuelto.Text = "$ 0,00";

            //TextBox
            

            btnVolver.BackColor = ColorTranslator.FromHtml("#27293D");

        }

        private void tbxMontoEfectivo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnCobrar.PerformClick();
        }

        private void tbxMontoEfectivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.soloDecimal(e, tbxMontoEfectivo);
        }

        private void tbxMontoEfectivo_Click(object sender, EventArgs e)
        {
            tbxMontoEfectivo.SelectionStart = tbxMontoEfectivo.Text.Length;
        }

        private void btnPagoTransferencia_CheckedChanged(object sender, EventArgs e)
        {
            pnlPagoTransferencia.Visible = btnPagoTransferencia.Checked;
            pnlPagoEfectivo.Visible = btnPagoEfectivo.Checked;

            //Pago con transferencia
            if (btnPagoTransferencia.Checked)
            {
                lblAvisoEfectivo.Visible=false;
                tbxNombreCliente.Focus();
                tbxNombreCliente.SelectAll();
            }
            //Pago en efectivo
            else
            {
                tbxMontoEfectivo.Focus();
                tbxMontoEfectivo.SelectAll();
            }
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (btnPagoEfectivo.Checked)
                    realizarVentaEfectivo();
                else
                    realizarVentaTransferencia();

                MessageBox.Show("¡Venta realizada con éxito!");
                DialogResult = DialogResult.OK;
                Close();
            }
            catch(ArgumentNullException){
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar la venta: " + ex.Message);
            }
        }

        private void realizarVentaTransferencia()
        {
            if (string.IsNullOrEmpty(tbxNombreCliente.Text.Trim()))
            {
                DialogResult respuesta = MessageBox.Show("Desea guardar la venta sin nombre de cliente?", "Confirmar", MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.No)
                {
                    tbxNombreCliente.Focus();
                    tbxNombreCliente.SelectAll();
                    return; 
                }
            } 

            VentaService ventaService = new VentaService();
            Venta nuevaVenta = new Venta();

            nuevaVenta.Fecha = DateTime.Now;
            nuevaVenta.MontoTotal = montoTotal;
            nuevaVenta.MontoPago = montoTotal;
            nuevaVenta.Vuelto = 0;
            nuevaVenta.FormaPago = FormaPago.Transferencia;
            if (tbxNombreCliente.Text.Trim().Equals(""))
                nuevaVenta.referencia = "Sin referencia";
            else
                nuevaVenta.referencia = tbxNombreCliente.Text.Trim();

            ventaService.guardarVentaCompleta(nuevaVenta, listaVenta);
        }

        private void realizarVentaEfectivo()
        {

            if (obtenerMontoEfectivoLimpio().Equals("") || montoEfectivo < montoTotal)
            {
                montoEfectivo = 0;
                lblAvisoEfectivo.Visible = true;
                tbxMontoEfectivo.Focus();
                tbxMontoEfectivo.SelectAll();
                throw new ArgumentNullException();
            }

            VentaService ventaService = new VentaService();
            Venta nuevaVenta = new Venta();

            nuevaVenta.Fecha = DateTime.Now;
            nuevaVenta.MontoTotal = montoTotal;
            montoEfectivo = decimal.Parse(obtenerMontoEfectivoLimpio());
            nuevaVenta.MontoPago = montoEfectivo;
            nuevaVenta.Vuelto = montoEfectivo - montoTotal;
            nuevaVenta.FormaPago = FormaPago.Efectivo;
            nuevaVenta.referencia = "-";

            ventaService.guardarVentaCompleta(nuevaVenta, listaVenta);
        }



        private void tbxMontoEfectivo_KeyUp(object sender, KeyEventArgs e)
        {

                if (tbxMontoEfectivo.Text.IndexOf(",") == 0)
                {
                    tbxMontoEfectivo.Text = "0" + tbxMontoEfectivo.Text;
                    tbxMontoEfectivo.SelectionStart = tbxMontoEfectivo.TextLength;
                }

                if (!string.IsNullOrEmpty(obtenerMontoEfectivoLimpio()))
                {
                    montoEfectivo = decimal.Parse(obtenerMontoEfectivoLimpio());

                }
                else
                {
                    return;
                }
                if (montoTotal != 0)
                {
                    if (montoEfectivo > montoTotal)
                    {
                        vuelto = montoEfectivo - montoTotal;
                        lblMontoVuelto.Text = "$ " + vuelto.ToString();
                    }
                    else{
                        vuelto = 0;
                        lblMontoVuelto.Text = "$ 0,00";
                    }
                }
        }

        private string obtenerMontoEfectivoLimpio()
        {
            return tbxMontoEfectivo.Text.Replace("$", "").Trim().TrimEnd(',');
        }

        private void frmCobro_Shown(object sender, EventArgs e)
        {

            tbxMontoEfectivo.Focus();
            tbxMontoEfectivo.SelectAll();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbxMontoEfectivo_Leave(object sender, EventArgs e)
        {
            tbxMontoEfectivo.Text = agregarSimboloDinero(obtenerMontoEfectivoLimpio());
        }

        private string agregarSimboloDinero(string monto)
        {
            return "$ " + monto;
        }

        private void tbxMontoEfectivo_Enter(object sender, EventArgs e)
        {
            tbxMontoEfectivo.Text=obtenerMontoEfectivoLimpio();
        }

        private void tbxMontoEfectivo_TextChanged(object sender, EventArgs e)
        {
            lblAvisoEfectivo.Visible = false;

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Tab)
            {
                if (btnPagoEfectivo.Checked)
                    btnPagoTransferencia.Checked = true;
                else
                    btnPagoEfectivo.Checked = true;
                return true; // Indica que la tecla ha sido manejada
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        //private void frmCobro_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Tab)
        //    {
        //        e.
        //        btnPagoEfectivo.Checked = !btnPagoEfectivo.Checked;
        //    }
        //}
    }
}