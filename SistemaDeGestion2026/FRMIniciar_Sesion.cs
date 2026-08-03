using CapaRN;
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
    public partial class FRMIniciar_Sesion : DevComponents.DotNetBar.Office2007Form
    {
        #region Variables
            public aususis usuario = new aususis();
            public aperson persona = new aperson();
            public bool loginExitoso = false;
            public bool actualizarPassword = false;
        #endregion

        #region Constructor
        public FRMIniciar_Sesion()
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

        #region Eventos
        private void BTNPassword_Click(object sender, EventArgs e)
        {
            if (TXTPassword.PasswordChar=='*')
            {
                TXTPassword.PasswordChar = '\0';
            }
            else
            {
                TXTPassword.PasswordChar = '*';
            }
        }
     
        private void BTNCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void BTNIngresar_Click(object sender, EventArgs e)
        {
            if (VerificarIntegridad())
            { 
                usuario.causnomlog = TXTNombreLogin.Text;
                usuario.ObtenerDatosLogin(false, TXTNombreLogin.Text);
                persona.papscodper = usuario.fauscodper;
                persona.ObtenerDatos();

                if (usuario.causactpas)
                {                                        
                    if (TXTPassword.Text == persona.capsnumcid)
                    {
                        MessageBox.Show("Bienvenido " + persona.capsnomper + " " + 
                                                        persona.capsapepat + " " + 
                                                        persona.capsapemat , 
                                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loginExitoso = true;
                        actualizarPassword = true;
                        this.Close();
                    }
                }
                else
                {
                    if (TXTPassword.Text == usuario.causpasswo)
                    {
                        MessageBox.Show("Bienvenido " + persona.capsnomper + " " +
                                                        persona.capsapepat + " " +
                                                        persona.capsapemat,
                                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loginExitoso = true;
                        actualizarPassword = false;
                        this.Close();
                    }
                }
            }
        }
        #endregion
    }
}
