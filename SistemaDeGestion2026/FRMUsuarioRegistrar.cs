using AForge.Video.DirectShow;
using CapaRN;
using Eithan_System.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eithan_System
{
    public partial class FRMUsuarioRegistrar : DevComponents.DotNetBar.Office2007Form
    {

        #region Variables
        private aususis usuario = new aususis();
        private aperson persona = new aperson();
        public bool personaOK = false;
        private xnumcor correlativo = new xnumcor();
        public bool modificar = false;
        public String codUsuMod = "";
        public bool actualizar = false;
       



        #endregion

        #region Constructor
        public FRMUsuarioRegistrar()
        {
            InitializeComponent();
        }
        #endregion

        #region Métodos
        private bool VerificarIntegridad()
        {
            bool respuesta = true;
            aususis usuario2 = new aususis();
            usuario2.causnomlog = TXT_LoginUsuario.Text;
            aperson persona2 = new aperson();
            persona2.capsnumcid = TXT_CI.Text;

            if (TXT_CI.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el CI de la persona", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXT_CI.Focus();
                respuesta = false;
            }
            else if (TXT_LoginUsuario.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el LOGIN del usuario", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXT_LoginUsuario.Focus();
                respuesta = false;
            }// condicion para retringir LOGIN ajeno al modificar o registrar
            else if (usuario2.ObtenerDatosLogin(modificar, usuario.causnomlog))
            {
                MessageBox.Show("Ya existe una persona con ese LOGIN", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXT_LoginUsuario.Focus();
                respuesta = false;
            }
            else if (TXT_Nombres.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el nombre completo de la persona", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXT_Nombres.Focus();
                respuesta = false;
            }

            return respuesta;
        }
        private void LimpiarCasillas()
        {
            SWB_Estado.Value = true;
            TXT_CI.Text = "";
            TXT_Nombres.Text = "Nombre Completo";
            TXT_LoginUsuario.Text = "";
            TXT_LoginUsuario.Focus();

        }

        private void JalarDatos()
        {
            usuario.pauscodusu = this.codUsuMod;
            usuario.ObtenerDatos();

            persona.papscodper = usuario.fauscodper;
            persona.ObtenerDatos();

            SWB_Estado.Value = usuario.causestusu;
            TXT_CI.Text = persona.capsnumcid;
            TXT_Nombres.Text = persona.capsapepat + " " + persona.capsapemat + " " + persona.capsnomper;
            DPFPHuellas.EnrolledFingerMask = usuario.causmashue;
            TXT_LoginUsuario.Text = usuario.causnomlog;

        }
        #endregion
        private void TXT_Nombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTN_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRMUsuarioRegistrar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cerrar el formulario?",
                               "Pregunta",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
            
        }

        private void TXT_CI_Enter(object sender, EventArgs e)
        {

        }

        private void FRMUsuarioRegistrar_Load(object sender, EventArgs e)
        {
           
            if (this.modificar)
            {
                JalarDatos();
                BTN_Grabar.Text = "&Modificar";
                this.Text = "Modificar Usuario";
                GP_Panel_Usuario.Text = "Modificar Usuario";
                TXT_CI.Focus();
            }
            else
            {
                LimpiarCasillas();
                BTN_Grabar.Text = "&Guardar";
                this.Text = "Registrar Usuario";
                GP_Panel_Usuario.Text = "Registrar Usuario";
                TXT_CI.Focus();
            }
        }

        private void TXT_LoginUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            bool tecla_valida = false;
            //Identificar si es una tecla válida
            if ((e.KeyCode >= Keys.NumPad0) && (e.KeyCode <= Keys.NumPad9))
                tecla_valida = true;
            else if ((e.KeyCode >= Keys.D0) && (e.KeyCode <= Keys.D9) && !e.Shift)
                tecla_valida = true;
            else if((e.KeyCode >= Keys.A) && (e.KeyCode <= Keys.Z)&&(!e.Alt))
                tecla_valida = true;
            else if ((e.KeyCode == Keys.Subtract) ||
                (e.KeyCode == Keys.Back) ||
                (e.KeyCode == Keys.Delete) ||
                (e.KeyCode == Keys.Left) ||
                (e.KeyCode == Keys.Right) ||
                ((e.KeyCode == Keys.OemMinus) && !e.Shift))
                tecla_valida = true;
            if (!tecla_valida)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void BTN_BuscarUsuario_Click(object sender, EventArgs e)
        {
            FRMPersona_Buscar a = new FRMPersona_Buscar();
            a.ShowDialog();
            if (a.seleccionadoOK)
            {
                this.persona = a.persona;
                this.personaOK = true;
                TXT_CI.Text = persona.capsnumcid;
                TXT_Nombres.Text = persona.capsapepat + " " + persona.capsapemat + " " + persona.capsnomper;


            } else {
                this.personaOK = false;
                TXT_CI.Text = "";
                TXT_Nombres.Text = "Nombre Completo";
            }

        }

        private void BTN_Grabar_Click(object sender, EventArgs e)
        {
            if (VerificarIntegridad())
            {
              

                if (!this.modificar)
                {
                    //Generar el correlativo
                    correlativo.pxnctipcor = "aususis";
                    if (correlativo.ObtenerSiguiente())
                    {
                        usuario.pauscodusu = correlativo.pxnctipcor + "-" + correlativo.cxncnumcor.ToString("D12");
                    }
                }
                else
                {
                    usuario.pauscodusu = this.codUsuMod;
                }
                
                usuario.causestusu = SWB_Estado.Value;
                usuario.causnomlog = TXT_LoginUsuario.Text;

                if (!modificar) {
                    usuario.causactpas = false;

                    usuario.causmashue = DPFPHuellas.EnrolledFingerMask;

                    usuario.causmashue = 0;
                    usuario.causnumhu1 = 0;
                    usuario.causcodhu1 = "";
                    usuario.causnumhu2 = 0;
                    usuario.causcodhu2 = "";
                    usuario.causnumhu3 = 0;
                    usuario.causcodhu3 = "";
                    usuario.causnumhu4 = 0;
                    usuario.causcodhu4 = "";

                    usuario.fauscodper = persona.papscodper;

                }
               


                if (!this.modificar)
                {
                    if (usuario.Grabar())
                    {
                        MessageBox.Show("Usuario guardado correctamente!!",
                                        "Mensaje",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        LimpiarCasillas();
                        this.actualizar = true;
                        this.FormClosing -= FRMUsuarioRegistrar_FormClosing;
                     
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuario no se pudo guardar!!",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (usuario.Modificar())
                    {
                        MessageBox.Show("Usuario modificado correctamente!!",
                                        "Mensaje",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        LimpiarCasillas();
                        this.actualizar = true;
                        this.FormClosing -= FRMUsuarioRegistrar_FormClosing;
                     
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuario no se pudo modificar!!",
                                            "Error",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                    }
                }
            }
        }

     

     

        private void DPFPHuellas_OnDelete(object Control, int FingerMask, ref DPFP.Gui.EventHandlerStatus EventHandlerStatus)
        {
            if (usuario.causnumhu1 == FingerMask)
            {
                usuario.causnumhu1 = 0;
                usuario.causcodhu1 = "";
            }
            else if (usuario.causnumhu2 == FingerMask)
            {
                usuario.causnumhu2 = 0;
                usuario.causcodhu2 = "";
            }
            else if (usuario.causnumhu3 == FingerMask)
            {
                usuario.causnumhu3 = 0;
                usuario.causcodhu3 = "";
            }
            else if (usuario.causnumhu4 == FingerMask)
            {
                usuario.causnumhu4 = 0;
                usuario.causcodhu4 = "";
            }
        }

        private void DPFPHuellas_OnEnroll(object Control, int FingerMask, DPFP.Template Template, ref DPFP.Gui.EventHandlerStatus EventHandlerStatus)
        {
            byte[] aux = new byte[1700];
            Template.Serialize(ref aux);
            string cadena = Convert.ToBase64String(aux);

            if (usuario.causnumhu1 == 0)
            {
                usuario.causnumhu1 = FingerMask;
                usuario.causcodhu1 = cadena;
            }
            else if (usuario.causnumhu2 == 0)
            {
                usuario.causnumhu2 = FingerMask;
                usuario.causcodhu2 = cadena;
            }
            else if (usuario.causnumhu3 == 0)
            {
                usuario.causnumhu3 = FingerMask;
                usuario.causcodhu3 = cadena;
            }
            else if (usuario.causnumhu4 == 0)
            {
                usuario.causnumhu4 = FingerMask;
                usuario.causcodhu4 = cadena;
            }
        }

        private void TXT_LoginUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
