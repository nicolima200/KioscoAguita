using dominio;
using frmPrincipal;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace frmPrincipal
{
    public static class Helper
    {
        private static readonly HttpClient httpClient = new HttpClient();

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
                if (string.IsNullOrWhiteSpace(ruta))
                {
                    AsignarImagen(pbx, Properties.Resources.imagenNoEncontrada);
                    return;
                }

                Image nuevaImagen;

                if (ruta.ToLower().Contains("http"))
                {
                    byte[] data = httpClient.GetByteArrayAsync(ruta).ConfigureAwait(false).GetAwaiter().GetResult();
                    using (MemoryStream ms = new MemoryStream(data))
                    {
                        nuevaImagen = DecodificarImagen(ms);
                    }
                }
                else
                {
                    if (!File.Exists(ruta))
                    {
                        AsignarImagen(pbx, Properties.Resources.imagenNoEncontrada);
                        return;
                    }

                    using (FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read))
                    {
                        nuevaImagen = DecodificarImagen(fs);
                    }
                }

                AsignarImagen(pbx, nuevaImagen);
            }
            catch
            {
                AsignarImagen(pbx, Properties.Resources.imagenNoEncontrada);
            }
        }

        private static Image DecodificarImagen(Stream stream)
        {
            using (SKBitmap bitmap = SKBitmap.Decode(stream))
            {
                if (bitmap == null)
                    throw new InvalidOperationException("No se pudo decodificar la imagen.");

                return ConvertirABitmap(bitmap);
            }
        }

        private static Bitmap ConvertirABitmap(SKBitmap source)
        {
            if (source.ColorType != SKColorType.Bgra8888)
            {
                using (SKBitmap converted = source.Copy(SKColorType.Bgra8888))
                {
                    return CopiarPixeles(converted);
                }
            }

            return CopiarPixeles(source);
        }

        private static Bitmap CopiarPixeles(SKBitmap source)
        {
            int width = source.Width;
            int height = source.Height;
            int srcStride = source.RowBytes;

            Bitmap bmp = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            System.Drawing.Imaging.BitmapData data = bmp.LockBits(
                new Rectangle(0, 0, width, height),
                System.Drawing.Imaging.ImageLockMode.WriteOnly,
                System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            try
            {
                int dstStride = data.Stride;
                int bytesPerRow = Math.Min(srcStride, dstStride);
                byte[] rowBuffer = new byte[bytesPerRow];
                IntPtr srcPtr = source.GetPixels();

                for (int y = 0; y < height; y++)
                {
                    IntPtr srcRow = IntPtr.Add(srcPtr, y * srcStride);
                    IntPtr dstRow = IntPtr.Add(data.Scan0, y * dstStride);
                    System.Runtime.InteropServices.Marshal.Copy(srcRow, rowBuffer, 0, bytesPerRow);
                    System.Runtime.InteropServices.Marshal.Copy(rowBuffer, 0, dstRow, bytesPerRow);
                }
            }
            finally
            {
                bmp.UnlockBits(data);
            }

            return bmp;
        }

        private static void AsignarImagen(PictureBox pbx, Image nuevaImagen)
        {
            Image anterior = pbx.Image;
            pbx.Image = nuevaImagen;

            if (anterior != null && anterior != Properties.Resources.imagenNoEncontrada)
                anterior.Dispose();
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
