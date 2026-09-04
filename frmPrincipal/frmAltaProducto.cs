using dominio;
using dominio.enums;
using service;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;

namespace frmPrincipal
{
    public partial class frmAltaProducto : Form
    {
        Producto producto = null;
        OpenFileDialog archivo = null;
        public frmAltaProducto()
        {
            InitializeComponent();
        }
        public frmAltaProducto(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;
            Text = "Kiosco26 - Modificar producto";
        }

        private void actualizarEncabezado()
        {
            if (producto != null)
            {
                lblHeaderTitle.Text = "KIOSCO26  -  MODIFICAR PRODUCTO";
                Text = "Kiosco26 - Modificar producto";
            }
            else
            {
                lblHeaderTitle.Text = "KIOSCO26  -  AGREGAR PRODUCTO";
                Text = "Kiosco26 - Agregar producto";
            }
        }

        private void frmAltaProducto_Load(object sender, EventArgs e)
        {
            actualizarEncabezado();
            CategoriaService categoriaService = new CategoriaService();
            MarcaService marcaService = new MarcaService();
            //List<string> tipoDeVenta= new List<string>() { "Unidad", "Kilos", "Litros", "Metros" };

            try
            {
                //Cargamos la lista de categorías
                cboCategoria.DataSource = categoriaService.listar().OrderBy(x=>x).ToList();
                cboCategoria.Text = "Varios";

                //Cargamos la lista de marcas
                cboMarca.DataSource = marcaService.listar();
                cboMarca.Text = "Sin marca";

                //Cargamos la lista de tipo de venta
                cboTipoVenta.DataSource = Enum.GetValues(typeof(TipoVenta));
                cboTipoVenta.SelectedIndex = 0;
                //cboTipoVenta.ValueMember

                if (producto != null)
                {
                    //Si producto no es null precargamos los datos en los textbox
                    cargarTextBox();
                    //txbDescripcion.ForeColor = System.Drawing.Color.Black;
                }
                else
                {
                    //Si es null, solo establecemos por defecto la categoria varios
                    //cboCategoria.Text = "Varios";
                    //cboTipoVenta.Text = "Unidad";
                    //txbDescripcion.ForeColor = System.Drawing.Color.DimGray;
                    //txbDescripcion.Text = "Peso, cant. unidades, sabor, etc...";

                }
                Helper.cargarImg(pbxAlta, txbUrlImagen.Text);
                txbCodBarras.Focus();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void frmAltaProducto_Shown(object sender, EventArgs e)
        {
            //Foco directo en codigo de barras para permitir escaneo inmediato (flujo alta)
            if (producto == null)
            {
                ActiveControl = txbCodBarras;
                txbCodBarras.Focus();
                txbCodBarras.SelectAll();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {

            ProductoService productoService = new ProductoService();

            try
            {
                if (producto == null) //Si es nulo, quiere decir que estamos AGREGANDO
                {
                    producto = new Producto();
                }
                else // Si no es nulo, estamos MODIFICANDO. Entonces tomamos el id precargado en el textbox
                {
                    producto.Id = int.Parse(txbId.Text);
                }

                //if (txbCodBarras.Text.Length == 0)
                //    throw new ArgumentException("El código de barras no puede estar vacío");

                if (!validarTodosTxb())
                {
                    //MessageBox.Show("Los campos de Código de barras, Precio y Stock deben contener solo números.");
                    if (producto.Id == 0)
                        producto = null;
                    return;
                }
                if (txbCodBarras.Text.Length > 13)
                {
                    if (producto.Id == 0)
                        producto = null;
                    MessageBox.Show("El código de barras no puede tener más de 13 dígitos.");
                    return;
                }

                producto.CodBarras = txbCodBarras.Text;

                producto.Nombre = txbNombre.Text;

                producto.Descripcion = txbDescripcion.Text;
                producto.Categoria = (string)cboCategoria.SelectedValue;

                //Los precios y el stock se validan en los KeyPress
                //if (Helper.validarTxbNumericos(txbPrecioKiosco))
                producto.PrecioMayorista = decimal.Parse(txbPrecioMayorista.Text);

                //if (Helper.validarTxbNumericos(txbPrecioKiosco))
                producto.PrecioPublico = decimal.Parse(txbPrecioKiosco.Text);
                
                producto.Stock = txbStock.Text.Length != 0? double.Parse(txbStock.Text): 0;

                producto.StockMinimo = txbStockMinimo.Text.Length != 0? int.Parse(txbStockMinimo.Text): 0;

                producto.TipoVenta = (TipoVenta)cboTipoVenta.SelectedValue;

                producto.Marca = (string)cboMarca.Text;

                //Cada vez que se agrega o modifica, el producto queda activo
                producto.Activo = 1;

                //Guardamos la url anterior para poder liberar el archivo si deja de usarse
                string urlImagenAnterior = producto.UrlImagen;

                
                    if (archivo != null && !(txbUrlImagen.Text.ToLower().Contains("http")))
                    {
                        if (!guardarImagenLocal())
                            return;
                    }
                    else if (txbUrlImagen.Text.ToLower().Contains("http"))
                    {
                        if (!guardarImagenWeb())
                            return;
                    }
                    else
                    {
                        if (txbUrlImagen.Text.Trim().Length == 0)
                            producto.UrlImagen = null;
                        else
                            producto.UrlImagen = txbUrlImagen.Text;
                        //if (txbUrlImagen.Text.Length != 0)
                        //    producto.UrlImagen = txbUrlImagen.Text;
                    }

                    
                    if (producto.Id == 0) // id== 0 significa producto nuevo
                    {
                        productoService.agregar(producto);
                        eliminarImagenHuerfana(urlImagenAnterior);
                        MessageBox.Show("Producto agregado exitosamente.", "Alta de producto");
                    }
                    else
                    {
                        productoService.modificar(producto);
                        eliminarImagenHuerfana(urlImagenAnterior);
                        MessageBox.Show("Producto modificado exitosamente.", "Modificación");
                    }

                    DialogResult = DialogResult.OK;
                    Close();

                

            }
            catch (ArgumentException ae)
            {
                if (producto.Id == 0)
                    producto = null;
                MessageBox.Show(ae.Message);
            }
            catch (Exception ex)
            {
                //Si el id == 0, estábamos agregando un producto, entonces 'reseteamos' el producto
                //Si id !=0 quiere decir que estábamos modificando, entonces no lo 'reseteamos'
                if (producto.Id == 0)
                    producto = null;
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnAgregarImg_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog()
            {
                Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tif;*.tiff;*.webp"
            };

            if (archivo.ShowDialog() == DialogResult.OK)
            {

                txbUrlImagen.Text = archivo.FileName;
                Helper.cargarImg(pbxAlta, archivo.FileName);
            }
        }
        private void btnLimpiarImagen_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar la imagen?","Eliminar imagen",MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                txbUrlImagen.Clear();
                if (producto != null) producto.UrlImagen = null;
                Helper.cargarImg(pbxAlta, "");
            }
        }

        private void txbCodBarras_Leave(object sender, EventArgs e)
        {
            if (producto == null)
            {
                try
                {
                    ProductoService productoService = new ProductoService();
                    producto = productoService.buscarCodBarras(txbCodBarras.Text);
                    if (producto != null)
                    {
                        string estado;
                        string cadenaProd = producto.CodBarras + " \"" + producto.Nombre + " " + producto.Descripcion;
                        if (producto.Activo == 1)
                            estado = "ACTIVO";
                        else if (producto.Eliminado == 1)
                            estado = "en la PAPELERA";
                        else
                            estado = "inactivo (aún no dado de alta)";

                        DialogResult resultado = MessageBox.Show("El producto con Codigo de barras: " + cadenaProd + "\" ya existe y está " + estado + ".\n" +
                            "¿Desea modificarlo?", "Producto existente", MessageBoxButtons.YesNo);

                        if (resultado == DialogResult.Yes)
                        {
                            cargarTextBox();
                            actualizarEncabezado();
                            txbCodBarras.ReadOnly = true;
                        }
                        else
                        {
                            txbCodBarras.Clear();
                            txbCodBarras.Focus();
                            MessageBox.Show("El Codigo de barras ya existe. Intente con otro o elimine definitivamente el producto.");
                            producto = null;
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        private void cargarTextBox()
        {
            txbId.Text = producto.Id.ToString();
            txbCodBarras.Text = producto.CodBarras;
            txbNombre.Text = producto.Nombre;
            cboMarca.Text = producto.Marca;
            txbDescripcion.Text = producto.Descripcion;
            cboCategoria.Text = producto.Categoria;
            txbPrecioKiosco.Text = producto.PrecioPublico.ToString();
            txbPrecioMayorista.Text = producto.PrecioMayorista.ToString();
            txbStock.Text = producto.Stock.ToString();
            txbStockMinimo.Text = producto.StockMinimo.ToString();
            txbUrlImagen.Text = producto.UrlImagen;
            cboTipoVenta.Text = producto.TipoVenta.ToString();
        }


        private bool guardarImagenLocal()
        {
            if (archivo == null) return true;

            string carpeta = ConfigurationManager.AppSettings["images-folder"] ?? "imágenes";
            string nombreArchivo = archivo.SafeFileName;
            string carpetaArchivo = Path.GetDirectoryName(archivo.FileName) + "\\";
            string rutaAchivoNuevo = Path.Combine(carpeta, nombreArchivo);

            string rutaNuevaCompleta = Path.GetFullPath(rutaAchivoNuevo);
            string rutaOrigenCompleta = Path.GetFullPath(archivo.FileName);

            //Si el archivo seleccionado ya se encuentra dentro de la carpeta de recursos,
            //no lo copia, solamente cambia la url
            if (rutaOrigenCompleta.Equals(rutaNuevaCompleta, StringComparison.OrdinalIgnoreCase))
            {
                producto.UrlImagen = rutaAchivoNuevo;
                return true;
            }

            if (File.Exists(rutaAchivoNuevo))// Comprobamos si hay un archivo con ese nombre en esa ruta
            {
                if (rutaAchivoNuevo.Equals(producto.UrlImagen)) return true;

                DialogResult respuesta = MessageBox.Show("Ya existe una imagen con ese nombre. ¿Desea sobrescribirla?", "Imagen existente", MessageBoxButtons.YesNo);

                if (respuesta == DialogResult.Yes)
                {
                    try
                    {
                        if (pbxAlta.Image != null)
                        {
                            pbxAlta.Image.Dispose(); // Liberamos el recurso de la imagen para poder sobrescribirla
                            pbxAlta.Image = null;
                        }
                        pbxAlta.ImageLocation = null;

                        File.Copy(archivo.FileName, rutaAchivoNuevo, true);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Error al sobreescribir: " + ex.ToString());
                        return false;
                    }

                }
                else
                {
                    return false;
                }
            }
            else //el archivo no existe
            {
                try
                {
                    File.Copy(archivo.FileName, rutaAchivoNuevo);

                }
                catch (Exception ex)
                {

                    MessageBox.Show("El archivo no se pudo guardar: " + ex.ToString());
                }
            }
            producto.UrlImagen = rutaAchivoNuevo;
            return true;
        }

        private void eliminarImagenHuerfana(string urlAnterior)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(urlAnterior)) return;
                if (urlAnterior.ToLower().Contains("http")) return; //las URLs externas no se borran
                if (urlAnterior.Equals(producto.UrlImagen, StringComparison.OrdinalIgnoreCase)) return; //la imagen sigue en uso

                //Si otro producto usa la misma imagen, no se borra
                ProductoService productoService = new ProductoService();
                if (productoService.contarPorUrlImagen(urlAnterior) > 0) return;

                //Solo se borran archivos dentro de la carpeta de imágenes
                string carpeta = Path.GetFullPath(ConfigurationManager.AppSettings["images-folder"] ?? "imágenes");
                string rutaCompleta = Path.GetFullPath(urlAnterior);
                if (!rutaCompleta.StartsWith(carpeta, StringComparison.OrdinalIgnoreCase)) return;

                if (File.Exists(rutaCompleta))
                    File.Delete(rutaCompleta);
            }
            catch
            {
                //Si no se puede liberar la imagen anterior, no interrumpe el guardado
            }
        }

        private bool guardarImagenWeb()
        {
            //URL
            Uri uri = new Uri(txbUrlImagen.Text);
            string urlLimpia = uri.AbsolutePath;

            //Carpeta de destino
            string carpetaDestino = ConfigurationManager.AppSettings["images-folder"] ?? "imágenes";
            string directorioBase = AppDomain.CurrentDomain.BaseDirectory;
            string rutaCompleta = Path.Combine(directorioBase, carpetaDestino);



            if (!Directory.Exists(rutaCompleta)) Directory.CreateDirectory(rutaCompleta);

            //nombre del archivo
            string extension = Path.GetExtension(urlLimpia);
            string nombreArchivo = Helper.limpiarCaracteresEspeciales(txbCodBarras.Text) + Helper.limpiarCaracteresEspeciales(txbNombre.Text) + DateTime.Now.ToString("dd-MM-yy-HH-mm-ss") + extension;


            string rutaDestino = Path.Combine(rutaCompleta, nombreArchivo);

            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls13;
                HttpClientHandler handler = new HttpClientHandler();
                handler.AllowAutoRedirect = true;
                handler.UseCookies = true;

                using (HttpClient cliente = new HttpClient(handler))
                {
                    byte[] imagenBytes = cliente.GetByteArrayAsync(uri).ConfigureAwait(false).GetAwaiter().GetResult();

                    File.WriteAllBytes(rutaDestino, imagenBytes);
                    producto.UrlImagen = rutaDestino;
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo descargar la imagen: " + ex.ToString());
                return false;
            }

        }
        private bool validarTodosTxb()
        {
            if (!Helper.validarTxbNumericos(txbCodBarras))
                return false;
            if (!Helper.validarNomDesc(txbNombre))
                return false;
            if (!Helper.validarNomDesc(txbDescripcion))
                return false;
            if (!Helper.validarTxbNumericos(txbPrecioMayorista, false))
                return false;
            if (!Helper.validarTxbNumericos(txbPrecioKiosco, false))
                return false;
            if (!Helper.validarTxbNumericos(txbStock, false))
            {
                txbStock.Text = "0";
                return false;
            }
            if (!Helper.validarTxbNumericos(txbStockMinimo))
            {
                txbStockMinimo.Text = "0";
                return false;
            }

            return true;
        }

        private void txbUrlImagen_TextChanged(object sender, EventArgs e)
        {
            Helper.cargarImg(pbxAlta, txbUrlImagen.Text);
        }
        private void txbCodBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.soloNumerosKeyPress(e);
            if (txbCodBarras.Text.Length >= 13 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '\r')
                txbNombre.Focus();
        }
        private void txbDescripcion_Enter(object sender, EventArgs e)
        {
            if (txbDescripcion.Text.Equals("Peso, cant. unidades, sabor, etc..."))
                txbDescripcion.Text = "";
            txbDescripcion.ForeColor = System.Drawing.Color.Black;
        }
        private void txbPrecioKiosco_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.soloDecimal(e, txbPrecioKiosco);
        }
        private void txbPrecioMayorista_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.soloDecimal(e, txbPrecioMayorista);
        }
        private void txbStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.soloDecimal(e,txbStock);
        }
        private void txbStockMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.soloNumerosKeyPress(e);
        }

    }
}
