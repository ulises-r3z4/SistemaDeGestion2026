using AForge.Video;
using AForge.Video.DirectShow;
using CapaRN;
using Eithan_System.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eithan_System
{
    public partial class FRMPersona_Registrar : DevComponents.DotNetBar.Office2007Form
    {

        #region Variables
        private aperson persona = new aperson();
        private xnumcor correlativo = new xnumcor();
        public bool modificar = false;
        public String codPerMod = "";
        public bool actualizar = false;

        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
        private bool TieneFoto = false;
       
        #endregion

        #region Constructor
        public FRMPersona_Registrar()
        {
            InitializeComponent();
            DetectarCamaras();
        }
        #endregion

        #region Métodos
        private bool VerificarIntegridad()
        {
            bool respuesta = true;
            aperson persona2 = new aperson();
            persona2.capsnumcid = TXT_CI.Text;

            

            if (TXT_CI.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el CI de la persona", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXT_CI.Focus();
                respuesta = false;
            }
            else if (persona2.ObtenerDatosCI(modificar,persona.capsnumcid)) {
                MessageBox.Show("Ya existe una persona con ese CI", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXT_CI.Focus();
                respuesta = false;
            }
            else if (DTI_Nacimiento.IsEmpty)
            {
                MessageBox.Show("La FECHA DE NACIMIENTO no puede ser vacio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DTI_Nacimiento.Focus();
                respuesta = false;
            }
            else if (DTI_Nacimiento.Value > DateTime.Now)
            {
                MessageBox.Show("La FECHA DE NACIMIENTO no puede ser mayor a la fecha actual", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DTI_Nacimiento.Focus();
                respuesta = false;
            }
            else if ((TXT_ApellidoMaterno.Text.Replace(" ", "") == "") && (TXT_ApellidoPaterno.Text.Replace(" ", "") == ""))
            {
                MessageBox.Show("La persona debe tener al menos un APELLIDO", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXT_ApellidoPaterno.Focus();
                respuesta = false;

            }
            else if (TXT_Nombres.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca los NOMBRES de la persona", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXT_Nombres.Focus();
                respuesta = false;
            }
            else if (TXT_Celular.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el NUMERO DE CELULAR de la persona", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXT_Celular.Focus();
                respuesta = false;
            }
            else if (TXT_Correo.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca un CORREO ELECTRONICO de la persona", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXT_Correo.Focus();
                respuesta = false;
            }
            else if (!xgeneral.emailsValid(TXT_Correo.Text))
            {
                MessageBox.Show("Introduzca un CORREO ELECTRONICO VALIDO de la persona", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXT_Correo.Focus();
                respuesta = false;
            }
            else if (TXT_Direccion.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca la DIRECCIÓN de la persona", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXT_Direccion.Focus();
                respuesta = false;
            }
            return respuesta;
        }
        private void LimpiarCasillas()
        {
            SWB_Estado.Value = true;
            TXT_CI.Text = "";
        }

        private void JalarDatos()
        {
            persona.papscodper = this.codPerMod;
            persona.ObtenerDatos();

            SWB_Estado.Value = persona.capsestper;
            TXT_CI.Text = persona.capsnumcid;
            SWB_Sexo.Value = persona.capssexper;
            DTI_Nacimiento.Value = persona.capsfecnac;
            TXT_ApellidoPaterno.Text = persona.capsapepat;
            TXT_ApellidoMaterno.Text = persona.capsapemat;
            TXT_Nombres.Text = persona.capsnomper;
            TXT_Celular.Text = persona.capsnumcel;
            TXT_Correo.Text = persona.capscorele;
            TXT_Direccion.Text = persona.capsdirper;



            if (persona.capsfotper == "")
            {
                TieneFoto = false;
                PCB_Fotografía.Image = Resources.NoImagen;
            }
            else
            {
                TieneFoto = true;
                PCB_Fotografía.Image = MetodosGenerales.ConvertBase64StringToImage(persona.capsfotper);
            }

        }
        #endregion

        #region Eventos

        private void BTN_Salir_Click(object sender, EventArgs e)
        {
            
            this.Close();

        }
        private void FRMPersona_Registrar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cerrar el formulario?",
                                "Pregunta",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                ApagarCamara();
            }

        }

        

        private void TXT_CI_Enter(object sender, EventArgs e)
        {
            TextBox a = (TextBox)sender;
            a.SelectAll();
        }

        private void FRMPersona_Registrar_Load(object sender, EventArgs e)
        {
            IniciarCamara();
            if (this.modificar)
            {
                JalarDatos();
                BTN_Grabar.Text = "&Modificar";
                this.Text = "Modificar Persona";
                GP_Panel_Persona.Text = "Modificar Persona";
                TXT_CI.Focus();
            }
            else
            {
                LimpiarCasillas();
                BTN_Grabar.Text = "&Guardar";
                this.Text = "Registrar Persona";
                GP_Panel_Persona.Text = "Registrar Persona";
                TXT_CI.Focus();
            }
        }

        private void TXT_Celular_KeyDown(object sender, KeyEventArgs e)
        {
            bool tecla_valida = false;
            //Identificar si es una tecla válida
            if ((e.KeyCode >= Keys.NumPad0) && (e.KeyCode <= Keys.NumPad9))
                tecla_valida = true;
            else if ((e.KeyCode >= Keys.D0) && (e.KeyCode <= Keys.D9) && !e.Shift)
                tecla_valida = true;
            else if ((e.KeyCode == Keys.Back) ||
                (e.KeyCode == Keys.Delete) ||
                (e.KeyCode == Keys.Left) ||
                (e.KeyCode == Keys.Right) )
                tecla_valida = true;
            if (!tecla_valida)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void TXT_CI_KeyDown(object sender, KeyEventArgs e)
        {
            bool tecla_valida = false;
            //Identificar si es una tecla válida
            if ((e.KeyCode >= Keys.NumPad0) && (e.KeyCode <= Keys.NumPad9))
                tecla_valida = true;
            else if ((e.KeyCode >= Keys.D0) && (e.KeyCode <= Keys.D9) && !e.Shift)
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
        private void TXT_Direccion_KeyDown(object sender, KeyEventArgs e)
        {
            bool tecla_valida = true;
            if (!tecla_valida)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void TXT_Correo_KeyDown(object sender, KeyEventArgs e)
        {
            bool tecla_valida = false;
            if (e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z)
                tecla_valida = true;
            else if ((e.KeyCode >= Keys.NumPad0) && (e.KeyCode <= Keys.NumPad9))
                tecla_valida = true;
            else if ((e.KeyCode >= Keys.D0) && (e.KeyCode <= Keys.D9) && (!e.Shift || (e.Shift && e.KeyCode == Keys.D2)))
                tecla_valida = true;
            else if ((e.KeyCode == Keys.Back) ||
                     (e.KeyCode == Keys.Delete) ||
                     (e.KeyCode == Keys.Left) ||
                     (e.KeyCode == Keys.Right) ||
                     (e.KeyCode == Keys.Add) ||
                     (e.KeyCode == Keys.OemPeriod) ||
                     (e.KeyCode == Keys.Decimal) ||
                     (e.KeyCode == Keys.OemMinus) ||
                     (e.KeyCode == Keys.Subtract) )
            {
                tecla_valida = true;
            }
            else if (e.Control && e.Alt && (e.KeyCode == Keys.Q || e.KeyCode == Keys.D2))
                tecla_valida = true;
            if (!tecla_valida)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void TXT_Nombres_KeyDown(object sender, KeyEventArgs e)
        {
            bool tecla_valida = false;
            //Identificar si es una tecla válida
            if ((e.KeyCode >= Keys.A) && (e.KeyCode <= Keys.Z) && (!e.Alt))
                tecla_valida = true;
            else if ((e.KeyCode == Keys.Subtract) ||
                (e.KeyCode == Keys.Back) ||
                (e.KeyCode == Keys.Delete) ||
                (e.KeyCode == Keys.Left) ||
                (e.KeyCode == Keys.Right) ||
                ((e.KeyCode == Keys.OemMinus) && !e.Shift) ||
                ((e.KeyCode == Keys.Oem4) && !e.Shift))
                tecla_valida = true;
            if (!tecla_valida)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void BTN_Grabar_Click(object sender, EventArgs e)
        {
            if (VerificarIntegridad())
            {
                persona = new aperson();

                if (!this.modificar)
                {
                    //Generar el correlativo
                    correlativo.pxnctipcor = "aperson";
                    if (correlativo.ObtenerSiguiente())
                    {
                        persona.papscodper = correlativo.pxnctipcor+"-"+correlativo.cxncnumcor.ToString("D12");
                    }
                }
                else
                {
                    persona.papscodper = this.codPerMod;
                }

                persona.capsestper = SWB_Estado.Value;
                persona.capssexper = SWB_Sexo.Value;
                persona.capsfecnac = DTI_Nacimiento.Value;
                persona.capsnumcid = TXT_CI.Text;
                persona.capsapepat = TXT_ApellidoPaterno.Text;
                persona.capsapemat = TXT_ApellidoMaterno.Text;
                persona.capsnomper = TXT_Nombres.Text;
                persona.capsnumcel = TXT_Celular.Text;
                persona.capscorele = TXT_Correo.Text;
                persona.capsdirper = TXT_Direccion.Text;
                


                //Fotografia del producto
                if (TieneFoto)
                {
                    persona.capsfotper = MetodosGenerales.ConvertImageToBase64String(PCB_Fotografía.Image);
                }
                else
                {
                    persona.capsfotper = "";
                }




                if (!this.modificar)
                {
                    if (persona.Grabar())
                    {
                        MessageBox.Show("Persona guardada correctamente!!",
                                        "Mensaje",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        LimpiarCasillas();
                        this.actualizar = true;
                        this.FormClosing -= FRMPersona_Registrar_FormClosing;
                        ApagarCamara();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Persona no se pudo guardar!!",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (persona.Modificar())
                    {
                        MessageBox.Show("Persona modificada correctamente!!",
                                        "Mensaje",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        LimpiarCasillas();
                        this.actualizar = true;
                        this.FormClosing -= FRMPersona_Registrar_FormClosing;
                        ApagarCamara();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Persona no se pudo modificar!!",
                                            "Error",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void TXTCI_KeyDown(object sender, KeyEventArgs e)
        {
            bool teclaValida = false;
            //Identificar si es una tecla válida
            if ((e.KeyCode >= Keys.NumPad0) && (e.KeyCode <= Keys.NumPad9))
                teclaValida = true;
            else if ((e.KeyCode >= Keys.D0) && (e.KeyCode <= Keys.D9) && !e.Shift)
                teclaValida = true;
            else if ((e.KeyCode >= Keys.A) && (e.KeyCode <= Keys.Z) && (!e.Alt))
                teclaValida = true;
            else if ((e.KeyCode == Keys.Subtract) ||
                (e.KeyCode == Keys.Back) ||
                (e.KeyCode == Keys.Delete) ||
                (e.KeyCode == Keys.Left) ||
                (e.KeyCode == Keys.Right) ||
                ((e.KeyCode == Keys.OemMinus) && !e.Shift))
                teclaValida = true;

            if (!teclaValida)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void TXTApellidoPaterno_KeyDown(object sender, KeyEventArgs e){
            bool teclaValida = false;
            //Identificar si es una tecla válida            
            if ((e.KeyCode >= Keys.A) && (e.KeyCode <= Keys.Z) && (!e.Alt))
                teclaValida = true;
            else if ((e.KeyCode == Keys.Subtract) ||
                (e.KeyCode == Keys.Back) ||
                (e.KeyCode == Keys.Delete) ||
                (e.KeyCode == Keys.Left) ||
                (e.KeyCode == Keys.Right) ||
                (e.KeyCode == Keys.Space) ||
                ((e.KeyCode == Keys.OemMinus) && !e.Shift))
                teclaValida = true;
            if (!teclaValida)
            {
                e.SuppressKeyPress = true;
            }
        }


        private void BTN_LimpiarFoto_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea borrar la imagen?",
                           "Pregunta",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                TieneFoto = false;
                PCB_Fotografía.Image = Resources.NoImagen;
            }
        }
        #endregion

        #region Metodo para la Cámara
        private void DetectarCamaras()
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);//constructor            
            FinalFrame = new VideoCaptureDevice();
        }

        private void IniciarCamara()
        {
            try
            {
                FinalFrame = new VideoCaptureDevice(CaptureDevice[0].MonikerString);// specified web cam and its filter moniker string
                FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);// click button event is fired, 
                FinalFrame.Start();
            }
            catch { 
                MessageBox.Show("No se detectó ninguna cámara web en el sistema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs) // must be void so that it can be accessed everywhere.
                                                                             // New Frame Event Args is an constructor of a class
        {
            PCB_Camara.Image = (Bitmap)eventArgs.Frame.Clone();// clone the bitmap
           
        }

        private void ApagarCamara()
        {
            if (FinalFrame.IsRunning == true) FinalFrame.Stop();
        }

        private void BTN_CamaraCapturar_Click(object sender, EventArgs e)
        {
            PCB_Fotografía.Image = PCB_Camara.Image;
            TieneFoto = true;
        }

        private void BTN_CamaraAbrir_Click(object sender, EventArgs e)
        {
            if (OFDElegirImagen.ShowDialog() == DialogResult.OK)
            {
                PCB_Fotografía.ImageLocation = OFDElegirImagen.FileName;
                TieneFoto = true;
            }
        }
        #endregion

        private void PCB_Camara_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {

        }
    }
}
