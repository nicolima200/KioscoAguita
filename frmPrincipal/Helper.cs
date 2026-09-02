using dominio;
using frmPrincipal;
using ImageMagick;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace frmPrincipal
{
    public static class Helper
    {
        public static void soloNumerosKeyPress(KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        //Validacion keypress para solo permitir numeros y una coma decimal
        public static void soloDecimal(KeyPressEventArgs e, TextBox tbx)
        {
            if ((!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (e.KeyChar != ','))
                e.Handled = true;

            //Para que no se ingrese más de una coma decimal
            if ((e.KeyChar == ',') && (tbx.Text.IndexOf(',') > -1))
                e.Handled = true;
        }

        //Validacion para textbox numericos (enteros o decimales)
        public static bool validarTxbNumericos(TextBox textBox, bool enteros=true)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.BackColor = Color.LightCoral;
                MessageBox.Show("El campo " + textBox.Tag + " no puede estar vacío", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox.Focus();
                return false;
            }

            bool esValido;

            // no usar el 'out' del TryParse, ya que puede generar errores con los ceros a la izquierda
            if (enteros)
            {
                esValido = long.TryParse(textBox.Text, out _);
            }
            else
            {
                esValido = double.TryParse(textBox.Text, out _);
            }    
            
            if (!esValido)
            {
                textBox.BackColor = Color.LightCoral;
                MessageBox.Show("El campo " + textBox.Tag + " debe contener un valor numérico válido", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox.Focus();
                return false;
            }

            textBox.BackColor = SystemColors.Window;
            return true;
        }


        public static void cargarImg(PictureBox pbx, string ruta)
        {
            try
            {
                if (ruta != null)
                {
                    //Si contiene http es una imagen en línea
                    if (ruta.ToLower().Contains("http"))
                    {
                        using (WebClient cliente = new WebClient())
                        {
                            byte[] data = cliente.DownloadData(ruta);

                            using (MemoryStream ms = new MemoryStream(data))
                            {
                                //Si la extensión es webp, usa la librería MagickImage para convertirla y poder renderizarla
                                if (ruta.ToLower().EndsWith(".webp"))
                                {
                                    ms.Position = 0;
                                    using (MagickImage image = new MagickImage(ms))
                                    {
                                        pbx.Image = image.ToBitmap();
                                    }
                                }
                                else
                                {
                                    pbx.Image = Image.FromStream(ms);
                                }
                            }
                        }
                    }
                    //Si no tiene http, se lo maneja como un archivo local
                    else
                    {
                        using (FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read))
                        using (MemoryStream ms = new MemoryStream())
                        {
                            fs.CopyTo(ms);
                            ms.Position = 0;
                            string extension = Path.GetExtension(ruta).ToLower();

                            if (extension == ".webp")
                            {
                                using (MagickImage image = new MagickImage(ms))
                                {
                                    pbx.Image = image.ToBitmap();
                                }
                            }
                            else
                            {
                                pbx.Load(ruta);
                            }
                        }
                    }
                }
                else
                {
                    pbx.Image = Properties.Resources.imagenNoEncontrada;
                }
            }
            catch (Exception)
            {
                pbx.Image = Properties.Resources.imagenNoEncontrada;

            }
        }

        public static bool validarNomDesc(TextBox textbox)
        {
            if (textbox.Text.Trim().Length < 3)
            {
                textbox.BackColor = Color.LightCoral;
                MessageBox.Show("El campo '" + textbox.Tag + "' debe tener al menos 3 caracteres", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textbox.Focus();
                return false;
            }
            textbox.BackColor = SystemColors.Window;
            return true;
        }

        public static string limpiarCaracteresEspeciales(string texto)
        {
            //Elimina caracteres especiales de un string
            char[] caracteresEspeciales = { '@', '#', '$', '%', '^', '&', '*', '(', ')', '=', '+', '{', '}', '[', ']', '|', '\\', ':', ';', '"', '\'', '<', '>', ',', '?', '/' };
            foreach (char c in caracteresEspeciales)
            {
                texto = texto.Replace(c.ToString(), "");
            }
            return texto;
        }
    }
}
