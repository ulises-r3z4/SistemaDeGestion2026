using CapaRN;
using DevComponents.DotNetBar.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeGestion2026
{
    public partial class FRMModificar_Password : DevComponents.DotNetBar.Office2007Form
    {
        #region Variables
        public aususis usuario = new aususis();
        public aperson persona = new aperson();
        public bool loginExitoso = false;
        public int NivelSeguridad=0;
        #endregion

        #region Constructor
        public FRMModificar_Password()
        {
            InitializeComponent();
        }
        #endregion

        #region Métodos

        private bool VerificarIntegridad()
        {
            bool respuesta = true;

            if (TXTNombreLogin.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el LOGIN del usuario", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTNombreLogin.Focus();
                respuesta = false;
            }
            else if (TXTPassword.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el PASSWORD del usuario", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTPassword.Focus();
                respuesta = false;
            }

            return respuesta;
        }


        #endregion

        private void BTNPassword_Click(object sender, EventArgs e)
        {
            if (TXTPassword.PasswordChar == '*')
            {
                TXTPassword.PasswordChar = '\0';
            }
            else
            {
                TXTPassword.PasswordChar = '*';
            }
        }

        private void BTNConfirmarPassword_Click(object sender, EventArgs e)
        {
            if (TXTConfirmarPassword.PasswordChar == '*')
            {
                TXTConfirmarPassword.PasswordChar = '\0';
            }
            else
            {
                TXTConfirmarPassword.PasswordChar = '*';
            }
        }

        private void TXTPassword_TextChanged(object sender, EventArgs e)
        {
            NivelSeguridad = MetodosGenerales.ValidarPassword(TXTPassword.Text);
            if (NivelSeguridad == 0)
            { 
                LBLMensaje.Text = "Password inadmisible";
                LBLMensaje.BackColor = Color.Salmon;
            }
            else if (NivelSeguridad == 1)
            {
                LBLMensaje.Text = "Seguridad Baja";
                LBLMensaje.BackColor = Color.SandyBrown;
            }
            else if (NivelSeguridad == 2)
            {
                LBLMensaje.Text = "Seguridad Media";
                LBLMensaje.BackColor = Color.LightYellow;
            }
            else if (NivelSeguridad == 3)
            {
                LBLMensaje.Text = "Seguridad Alta";
                LBLMensaje.BackColor = Color.LightGreen;
            }
        }

        private void FRMModificar_Password_Load(object sender, EventArgs e)
        {
            TXTNombreLogin.Text = usuario.causnomlog;
        }

        private void BTNGuardar_Click(object sender, EventArgs e)
        {
            if (TXTPassword.Text == TXTConfirmarPassword.Text)
            {
                if (NivelSeguridad == 3)
                {
                    usuario.causactpas = false;
                    usuario.causpasswo = TXTPassword.Text;
                    if (usuario.Modificar())
                    {
                        MessageBox.Show("Password modificado correctamente", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar el password", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El nivel de seguridad de la contraseña no es suficiente", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TXTPassword.Focus();
                }
            }
            else
            {
                MessageBox.Show("Password no coincide", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTPassword.Focus();
            }
        }

        private void TXTPassword_Enter(object sender, EventArgs e)
        {
            TextBoxX a = (TextBoxX)sender;
            a.SelectAll();
        }
    }
}
