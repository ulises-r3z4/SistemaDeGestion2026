using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eithan_System
{
    public static class MetodosGenerales
    {
        #region Funciones de Imágenes a texto
        public static Image ConvertBase64StringToImage(string imageBase64String)
        {
            var imageBytes = Convert.FromBase64String(imageBase64String);
            var imageStream = new MemoryStream(imageBytes, 0, imageBytes.Length);
            imageStream.Write(imageBytes, 0, imageBytes.Length);
            var image = Image.FromStream(imageStream, true);
            return image;
        }

        public static string ConvertImageToBase64String(Image image)
        {
            var imageStream = new MemoryStream();
            image.Save(imageStream, ImageFormat.Png);
            imageStream.Position = 0;
            var imageBytes = imageStream.ToArray();
            return Convert.ToBase64String(imageBytes);
        }
        #endregion

        #region Numero a literal
        private static readonly string[] unidades = {
        "", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve"
    };

        private static readonly string[] especiales = {
        "diez", "once", "doce", "trece", "catorce", "quince",
        "dieciséis", "diecisiete", "dieciocho", "diecinueve"
    };

        private static readonly string[] decenas = {
        "", "", "veinte", "treinta", "cuarenta", "cincuenta",
        "sesenta", "setenta", "ochenta", "noventa"
    };

        private static readonly string[] centenas = {
        "", "ciento", "doscientos", "trescientos", "cuatrocientos", "quinientos",
        "seiscientos", "setecientos", "ochocientos", "novecientos"
    };

        public static string ConvertirNumeroALetras(double numero)
        {
            // Separar parte entera y decimal
            long parteEntera = (long)Math.Floor(Math.Abs(numero));
            int parteDecimal = (int)Math.Round((Math.Abs(numero) - parteEntera) * 100);

            StringBuilder resultado = new StringBuilder();

            // Manejar números negativos
            if (numero < 0)
            {
                resultado.Append("menos ");
            }

            // Convertir parte entera
            if (parteEntera == 0)
            {
                resultado.Append("cero");
            }
            else
            {
                resultado.Append(ConvertirEntero(parteEntera));
            }

            // Agregar parte decimal
            resultado.Append($" {parteDecimal:00}/100");

            return resultado.ToString();
        }

        private static string ConvertirEntero(long numero)
        {
            if (numero == 0) return "";

            if (numero < 10)
            {
                return unidades[numero];
            }
            else if (numero < 20)
            {
                return especiales[numero - 10];
            }
            else if (numero < 100)
            {
                int decena = (int)(numero / 10);
                int unidad = (int)(numero % 10);

                if (decena == 2 && unidad > 0)
                {
                    return "veinti" + unidades[unidad];
                }
                else if (unidad == 0)
                {
                    return decenas[decena];
                }
                else
                {
                    return decenas[decena] + " y " + unidades[unidad];
                }
            }
            else if (numero < 1000)
            {
                int centena = (int)(numero / 100);
                int resto = (int)(numero % 100);

                string resultado = "";

                if (numero == 100)
                {
                    resultado = "cien";
                }
                else
                {
                    resultado = centenas[centena];
                    if (resto > 0)
                    {
                        resultado += " " + ConvertirEntero(resto);
                    }
                }

                return resultado;
            }
            else if (numero < 1000000)
            {
                long miles = numero / 1000;
                long resto = numero % 1000;

                string resultado = "";

                if (miles == 1)
                {
                    resultado = "mil";
                }
                else
                {
                    resultado = ConvertirEntero(miles) + " mil";
                }

                if (resto > 0)
                {
                    resultado += " " + ConvertirEntero(resto);
                }

                return resultado;
            }
            else if (numero < 1000000000)
            {
                long millones = numero / 1000000;
                long resto = numero % 1000000;

                string resultado = "";

                if (millones == 1)
                {
                    resultado = "un millón";
                }
                else
                {
                    resultado = ConvertirEntero(millones) + " millones";
                }

                if (resto > 0)
                {
                    resultado += " " + ConvertirEntero(resto);
                }

                return resultado;
            }
            else
            {
                long miles = numero / 1000000000;
                long resto = numero % 1000000000;

                string resultado = "";

                if (miles == 1)
                {
                    resultado = "mil millones";
                }
                else
                {
                    resultado = ConvertirEntero(miles) + " mil millones";
                }

                if (resto > 0)
                {
                    resultado += " " + ConvertirEntero(resto);
                }

                return resultado;
            }
        }
        #endregion

        #region Validación de Contraseñas
        public static int Puntuar_password(string password)
        {
            int num = 0;

            if (password.Length >= 8)
            {
                num += 1;
            }
            if (password.Any(char.IsLower) || clave.Any(char.IsUpper) )
            {
                num += 1;
            }
            if (password.Any(char.IsDigit))
            {
                num += 1;
            }
            if (password.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                num += 1;
            }
            return num;
        }

        public static void Validar_password(int num, LabelX label)
        {
            
            switch (num)
            {
                case 1:
                    label.Text = "Seguridad de la contraseña: BAJA";
                    label.ForeColor = ColorTranslator.FromHtml("#D32F2F");
                    label.BackColor = ColorTranslator.FromHtml("#FFEBEE");
                    label.BackgroundStyle.BorderColor = ColorTranslator.FromHtml("#D32F2F");
                    break;
                case 2:
                    label.Text = "Seguridad de la contraseña: MEDIA";
                    label.ForeColor = ColorTranslator.FromHtml("#E65100");
                    label.BackColor = ColorTranslator.FromHtml("#FFF3E0");
                    label.BackgroundStyle.BorderColor = ColorTranslator.FromHtml("#E65100");
                    break;
                case 3:
                    label.Text = "Seguridad de la contraseña: FUERTE";
                    label.ForeColor = ColorTranslator.FromHtml("#2E7D32");
                    label.BackColor = ColorTranslator.FromHtml("#E8F5E9");
                    label.BackgroundStyle.BorderColor = ColorTranslator.FromHtml("#2E7D32");
                    break;
                case 4:
                    label.Text = "Seguridad de la contraseña: MUY FUERTE :D";
                    label.ForeColor = ColorTranslator.FromHtml("#1565C0");
                    label.BackColor = ColorTranslator.FromHtml("#E3F2FD");
                    label.BackgroundStyle.BorderColor = ColorTranslator.FromHtml("#1565C0");
                    break;
            }
        }

        public static void Confirmar_pasword(string password, string c_password, LabelX label, ButtonX boton)
        {
            if (password == c_password)
            {
                if(clave.Length >= 8)
                {
                    label.Text = "Las contraseñas coinciden ☺";
                    label.ForeColor = ColorTranslator.FromHtml("#2E7D32");
                    label.BackColor = ColorTranslator.FromHtml("#E8F5E9");
                    label.BackgroundStyle.BorderColor = ColorTranslator.FromHtml("#2E7D32");
                    boton.Enabled = true;
                }
                else
                {
                    label.Text = "La contraseña debe tener al menos 8 caracteres";
                    label.ForeColor = ColorTranslator.FromHtml("#D32F2F");
                    label.BackColor = ColorTranslator.FromHtml("#FFEBEE");
                    label.BackgroundStyle.BorderColor = ColorTranslator.FromHtml("#D32F2F");
                    boton.Enabled = false;
                }
            }
            else
            {
                label.Text = "Las contraseñas deben ser iguales ";
                label.ForeColor = ColorTranslator.FromHtml("#D32F2F");
                label.BackColor = ColorTranslator.FromHtml("#FFEBEE");
                label.BackgroundStyle.BorderColor = ColorTranslator.FromHtml("#D32F2F");
                boton.Enabled = false;
            }
        }
        #endregion
    }
}
