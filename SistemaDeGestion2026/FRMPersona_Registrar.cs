using AForge.Video;
using AForge.Video.DirectShow;
using CapaRN;
using DevComponents.DotNetBar.Controls;
using SistemaDeGestion2026.Properties;
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
    public partial class FRMPersona_Registrar : DevComponents.DotNetBar.Office2007Form
    {
        #region Variables
        private aperson persona = new aperson();
        private xnumcor correlativo = new xnumcor();
        public bool modificar = false;
        public String codPerMod = "";
        public bool actualizar = false;
        //Variables para la camara
        private FilterInfoCollection CaptureDevice; // list of webcam
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
            persona.capsnumcid = TXTCI.Text;

            if (TXTCI.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el CI de la persona", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTCI.Focus();
                respuesta = false;
            }
            else if (persona.ObtenerDatosCI()&&!modificar)
            {
                MessageBox.Show("Ya existe una persona con ese CI", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTCI.Focus();
                respuesta = false;
            }
            else if (DTINacimiento.Value > DateTime.Now)
            {
                MessageBox.Show("Introduzca FECHA DE NACIMIENTO válida de la persona", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DTINacimiento.Focus();
                respuesta = false;
            }
            else if ((TXTApellidoPaterno.Text.Replace(" ", "") == "") &&
                     (TXTApellidoMaterno.Text.Replace(" ", "") == ""))
            {
                MessageBox.Show("Introduzca uno de los APELLIDOS de la persona", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTApellidoPaterno.Focus();
                respuesta = false;
            }
            else if (TXTNombres.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca los NOMBRES de la persona", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTNombres.Focus();
                respuesta = false;
            }
            else if (TXTCelular.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el CELULAR de la persona", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTCelular.Focus();
                respuesta = false;
            }
            else if (TXTCorreoElectronico.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca un CORREO VÁLIDO de la persona", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTCorreoElectronico.Focus();
                respuesta = false;
            }
            else if (!xgeneral.emailIsValid(TXTCorreoElectronico.Text))
            {
                MessageBox.Show("Introduzca un CORREO VÁLIDO de la persona", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTCorreoElectronico.Focus();
                respuesta = false;
            }
            else if (TXTDireccion.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca la DIRECCIÓN de la persona", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTDireccion.Focus();
                respuesta = false;
            }


            return respuesta;
        }

        private void LimpiarCasillas()
        {
            SWBEstado.Value = true;
            TXTCI.Text = "";      
        }

        private void JalarDatos()
        {
            persona.papscodper = this.codPerMod;
            persona.ObtenerDatos();
            SWBEstado.Value = persona.capsestper;
            TXTCI.Text = persona.capsnumcid;            
            SWBSexo.Value = persona.capssexper;            
            DTINacimiento.Value = persona.capsfecnac;
            TXTApellidoPaterno.Text = persona.capsapepat;
            TXTApellidoMaterno.Text = persona.capsapemat;
            TXTNombres.Text = persona.capsnomper;
            TXTCelular.Text = persona.capsnumcel;
            TXTCorreoElectronico.Text = persona.capscorele;
            TXTDireccion.Text = persona.capsdirper;
            if (persona.capsfotper == "")
            {
                TieneFoto = false;
                PCBFotografia.Image = Resources.NoImagen;
            }
            else
            {
                TieneFoto = true;
                PCBFotografia.Image = MetodosGenerales.ConvertBase64StringToImage(persona.capsfotper);
            }
        }

        #endregion

        #region Eventos
            
        private void BTNSalir_Click(object sender, EventArgs e)
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

        private void TXTCI_Enter(object sender, EventArgs e)
        {
            TextBoxX a = (TextBoxX)sender;
            a.SelectAll();
        }

        private void FRMPersona_Registrar_Load(object sender, EventArgs e)
        {
            IniciarCamara();
            if (this.modificar)
            {
                JalarDatos();
                BTNGrabar.Text = "&Modificar";
                this.Text = "Modificar Persona";
                GPPanelPrincipal.Text = "Modificar Persona";
                TXTCI.Focus();
            }
            else
            {
                LimpiarCasillas();
                BTNGrabar.Text = "&Guardar";
                this.Text = "Registrar Persona";
                GPPanelPrincipal.Text = "Registrar Persona";
                TXTCI.Focus();
            }
        }

        private void TXTCelular_KeyDown(object sender, KeyEventArgs e)
        {
            bool teclaValida = false;

            if ((e.KeyCode >= Keys.NumPad0) && (e.KeyCode <= Keys.NumPad9))
                teclaValida = true;
            else if ((e.KeyCode >= Keys.D0) && (e.KeyCode <= Keys.D9) && !e.Shift)
                teclaValida = true;
            else if 
                ((e.KeyCode == Keys.Back) ||
                (e.KeyCode == Keys.Delete) ||
                (e.KeyCode == Keys.Left) ||
                (e.KeyCode == Keys.Right))
                teclaValida = true;

            if (!teclaValida)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void TXTCI_KeyDown(object sender, KeyEventArgs e)
        {
            bool teclaValida = false;

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

        private void TXTApellidoPaterno_KeyDown(object sender, KeyEventArgs e)
        {
            bool teclaValida = false;

            if ((e.KeyCode >= Keys.A) && (e.KeyCode <= Keys.Z) && (!e.Alt))
                teclaValida = true;
            else if ((e.KeyCode == Keys.Space) ||
                (e.KeyCode == Keys.Back) ||
                (e.KeyCode == Keys.Delete) ||
                (e.KeyCode == Keys.Left) ||
                (e.KeyCode == Keys.Right) ||
                ((e.KeyCode == Keys.Oem4) && !e.Shift))
                teclaValida = true;            
            if (!teclaValida)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void TXTCorreoElectronico_KeyDown(object sender, KeyEventArgs e)
        {
            bool teclaValida = false;

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
                (e.KeyCode == Keys.OemPeriod) ||
                ((e.KeyCode == Keys.OemMinus)&&e.Shift) ||
                (e.KeyCode == Keys.Decimal) ||
                ((e.KeyCode == Keys.Q)&&e.Alt) ||
                ((e.KeyCode == Keys.Oemplus) && !e.Shift&&!e.Alt) ||
                (e.KeyCode == Keys.Add) ||
                ((e.KeyCode == Keys.OemMinus) && !e.Shift))
                teclaValida = true;
            
            if (!teclaValida)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void BTNGrabar_Click(object sender, EventArgs e)
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
                        persona.papscodper = correlativo.pxnctipcor + "-" +                            
                                             correlativo.cxncnumcor.ToString("D12");
                    }
                }
                else
                {
                    persona.papscodper = this.codPerMod;
                }
                persona.capsestper = SWBEstado.Value;
                persona.capssexper = SWBSexo.Value;
                persona.capsnumcid = TXTCI.Text;
                persona.capsfecnac = DTINacimiento.Value;
                persona.capsapepat = TXTApellidoPaterno.Text;
                persona.capsapemat = TXTApellidoMaterno.Text;
                persona.capsnomper = TXTNombres.Text;
                persona.capsnumcel = TXTCelular.Text;
                persona.capscorele = TXTCorreoElectronico.Text;
                persona.capsdirper = TXTDireccion.Text;
                //Fotografia del producto
                if (TieneFoto)
                {
                    persona.capsfotper = MetodosGenerales.ConvertImageToBase64String(PCBFotografia.Image);
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

        private void BTNAbrirFoto_Click(object sender, EventArgs e)
        {
            if (OFDElegirImagen.ShowDialog() == DialogResult.OK)
            {
                PCBFotografia.ImageLocation = OFDElegirImagen.FileName;
                TieneFoto = true;
            }
        }

        #endregion

        #region Metodos para la Cámara
        
        private void DetectarCamaras()
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);//constructor            
            FinalFrame = new VideoCaptureDevice();
        }

        private void IniciarCamara()
        {
            try
            {
                FinalFrame = new VideoCaptureDevice(CaptureDevice[1].MonikerString);// specified web cam and its filter moniker string
                FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);// click button event is fired, 
                FinalFrame.Start();
            }
            catch 
            {
                MessageBox.Show("No se tiene una cámara conectada al equipo",
                    "Error de cámara",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs) // must be void so that it can be accessed everywhere.
                                                                             // New Frame Event Args is an constructor of a class
        {
            PCBCamara.Image = (Bitmap)eventArgs.Frame.Clone();// clone the bitmap
        }

        private void ApagarCamara()
        {
            if (FinalFrame.IsRunning == true) FinalFrame.Stop();
        }

        #endregion

        private void BTNLimpiarFoto_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea borrar la imagen?",
                            "Pregunta",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                TieneFoto = false;
                PCBFotografia.Image = Resources.NoImagen;
            }
        }

        private void BTNCapturarFoto_Click(object sender, EventArgs e)
        {
            PCBFotografia.Image = PCBCamara.Image;
            TieneFoto = true;
        }

        
    }
}
