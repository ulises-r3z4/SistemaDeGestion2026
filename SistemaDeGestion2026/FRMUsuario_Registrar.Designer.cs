namespace SistemaDeGestion2026
{
    partial class FRMUsuario_Registrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GPPanelPrincipal = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.DPEHuellas = new DPFP.Gui.Enrollment.EnrollmentControl();
            this.TXTNombreLogin = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.BTNBuscarUsuario = new DevComponents.DotNetBar.ButtonX();
            this.BTNSalir = new DevComponents.DotNetBar.ButtonX();
            this.BTNLimpiar = new DevComponents.DotNetBar.ButtonX();
            this.BTNGrabar = new DevComponents.DotNetBar.ButtonX();
            this.TXTCI = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TXTNombres = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SWBEstado = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.GPPanelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // GPPanelPrincipal
            // 
            this.GPPanelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.GPPanelPrincipal.CanvasColor = System.Drawing.SystemColors.Control;
            this.GPPanelPrincipal.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.GPPanelPrincipal.Controls.Add(this.DPEHuellas);
            this.GPPanelPrincipal.Controls.Add(this.TXTNombreLogin);
            this.GPPanelPrincipal.Controls.Add(this.BTNBuscarUsuario);
            this.GPPanelPrincipal.Controls.Add(this.BTNSalir);
            this.GPPanelPrincipal.Controls.Add(this.BTNLimpiar);
            this.GPPanelPrincipal.Controls.Add(this.BTNGrabar);
            this.GPPanelPrincipal.Controls.Add(this.TXTCI);
            this.GPPanelPrincipal.Controls.Add(this.TXTNombres);
            this.GPPanelPrincipal.Controls.Add(this.SWBEstado);
    
            this.GPPanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GPPanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.GPPanelPrincipal.Name = "GPPanelPrincipal";
            this.GPPanelPrincipal.Size = new System.Drawing.Size(520, 485);
            // 
            // 
            // 
            this.GPPanelPrincipal.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.GPPanelPrincipal.Style.BackColorGradientAngle = 90;
            this.GPPanelPrincipal.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.GPPanelPrincipal.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GPPanelPrincipal.Style.BorderBottomWidth = 1;
            this.GPPanelPrincipal.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.GPPanelPrincipal.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GPPanelPrincipal.Style.BorderLeftWidth = 1;
            this.GPPanelPrincipal.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GPPanelPrincipal.Style.BorderRightWidth = 1;
            this.GPPanelPrincipal.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GPPanelPrincipal.Style.BorderTopWidth = 1;
            this.GPPanelPrincipal.Style.CornerDiameter = 4;
            this.GPPanelPrincipal.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.GPPanelPrincipal.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.GPPanelPrincipal.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.GPPanelPrincipal.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.GPPanelPrincipal.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.GPPanelPrincipal.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.GPPanelPrincipal.TabIndex = 1;
            this.GPPanelPrincipal.Text = "Usuario";
            // 
            // DPEHuellas
            // 
            this.DPEHuellas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DPEHuellas.EnrolledFingerMask = 0;
            this.DPEHuellas.Location = new System.Drawing.Point(9, 69);
            this.DPEHuellas.Margin = new System.Windows.Forms.Padding(5);
            this.DPEHuellas.MaxEnrollFingerCount = 10;
            this.DPEHuellas.Name = "DPEHuellas";
            this.DPEHuellas.ReaderSerialNumber = "00000000-0000-0000-0000-000000000000";
            this.DPEHuellas.Size = new System.Drawing.Size(492, 314);
            this.DPEHuellas.TabIndex = 17;
            this.DPEHuellas.OnDelete += new DPFP.Gui.Enrollment.EnrollmentControl._OnDelete(this.DPEHuellas_OnDelete);
            this.DPEHuellas.OnEnroll += new DPFP.Gui.Enrollment.EnrollmentControl._OnEnroll(this.DPEHuellas_OnEnroll);
            // 
            // TXTNombreLogin
            // 
            this.TXTNombreLogin.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TXTNombreLogin.Border.Class = "TextBoxBorder";
            this.TXTNombreLogin.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTNombreLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;

            this.TXTNombreLogin.ForeColor = System.Drawing.Color.Black;
            this.TXTNombreLogin.Location = new System.Drawing.Point(276, 35);
            this.TXTNombreLogin.Name = "TXTNombreLogin";
            this.TXTNombreLogin.PreventEnterBeep = true;
            this.TXTNombreLogin.Size = new System.Drawing.Size(225, 26);
            this.TXTNombreLogin.TabIndex = 16;
            this.TXTNombreLogin.WatermarkText = "Login ";
            this.TXTNombreLogin.Enter += new System.EventHandler(this.TXTCI_Enter);
            this.TXTNombreLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTNombreLogin_KeyDown);
            // 
            // BTNBuscarUsuario
            // 
            this.BTNBuscarUsuario.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNBuscarUsuario.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNBuscarUsuario.Image = global::SistemaDeGestion2026.Properties.Resources.ic_buscar;
            this.BTNBuscarUsuario.ImageFixedSize = new System.Drawing.Size(15, 15);
            this.BTNBuscarUsuario.Location = new System.Drawing.Point(243, 3);
            this.BTNBuscarUsuario.Name = "BTNBuscarUsuario";
            this.BTNBuscarUsuario.Size = new System.Drawing.Size(27, 26);
            this.BTNBuscarUsuario.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNBuscarUsuario.TabIndex = 14;
            this.BTNBuscarUsuario.Click += new System.EventHandler(this.BTNBuscarUsuario_Click);
            // 
            // BTNSalir
            // 
            this.BTNSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTNSalir.Image = global::SistemaDeGestion2026.Properties.Resources.ic_salir;
            this.BTNSalir.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.BTNSalir.Location = new System.Drawing.Point(380, 402);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(121, 51);
            this.BTNSalir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNSalir.TabIndex = 13;
            this.BTNSalir.Text = "&Salir";
            this.BTNSalir.Click += new System.EventHandler(this.BTNSalir_Click);
            // 
            // BTNLimpiar
            // 
            this.BTNLimpiar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNLimpiar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNLimpiar.Image = global::SistemaDeGestion2026.Properties.Resources.ic_limpiar;
            this.BTNLimpiar.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.BTNLimpiar.Location = new System.Drawing.Point(130, 402);
            this.BTNLimpiar.Name = "BTNLimpiar";
            this.BTNLimpiar.Size = new System.Drawing.Size(121, 51);
            this.BTNLimpiar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNLimpiar.TabIndex = 12;
            this.BTNLimpiar.Text = "&Limpiar";
            // 
            // BTNGrabar
            // 
            this.BTNGrabar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNGrabar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNGrabar.Image = global::SistemaDeGestion2026.Properties.Resources.ic_guardar;
            this.BTNGrabar.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.BTNGrabar.Location = new System.Drawing.Point(3, 402);
            this.BTNGrabar.Name = "BTNGrabar";
            this.BTNGrabar.Size = new System.Drawing.Size(121, 51);
            this.BTNGrabar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNGrabar.TabIndex = 11;
            this.BTNGrabar.Text = "&Grabar";
            this.BTNGrabar.Click += new System.EventHandler(this.BTNGrabar_Click);
            // 
            // TXTCI
            // 
            this.TXTCI.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TXTCI.Border.Class = "TextBoxBorder";
            this.TXTCI.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTCI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
        
            this.TXTCI.ForeColor = System.Drawing.Color.Black;
            this.TXTCI.Location = new System.Drawing.Point(150, 3);
            this.TXTCI.Name = "TXTCI";
            this.TXTCI.PreventEnterBeep = true;
            this.TXTCI.Size = new System.Drawing.Size(87, 26);
            this.TXTCI.TabIndex = 0;
            this.TXTCI.WatermarkText = "CI";
            this.TXTCI.Enter += new System.EventHandler(this.TXTCI_Enter);
            // 
            // TXTNombres
            // 
            this.TXTNombres.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TXTNombres.Border.Class = "TextBoxBorder";
            this.TXTNombres.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
       
            this.TXTNombres.ForeColor = System.Drawing.Color.Black;
            this.TXTNombres.Location = new System.Drawing.Point(9, 35);
            this.TXTNombres.Name = "TXTNombres";
            this.TXTNombres.PreventEnterBeep = true;
            this.TXTNombres.Size = new System.Drawing.Size(261, 26);
            this.TXTNombres.TabIndex = 4;
            this.TXTNombres.WatermarkText = "Nombre Completo ";
            // 
            // SWBEstado
            // 
            // 
            // 
            // 
            this.SWBEstado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SWBEstado.Location = new System.Drawing.Point(9, 3);
            this.SWBEstado.Name = "SWBEstado";
            this.SWBEstado.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SWBEstado.OffText = "Inhabilitado";
            this.SWBEstado.OffTextColor = System.Drawing.Color.White;
            this.SWBEstado.OnBackColor = System.Drawing.Color.LimeGreen;
            this.SWBEstado.OnText = "Habilitado";
            this.SWBEstado.OnTextColor = System.Drawing.Color.White;
            this.SWBEstado.Size = new System.Drawing.Size(135, 26);
            this.SWBEstado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SWBEstado.TabIndex = 9;
            this.SWBEstado.Value = true;
            this.SWBEstado.ValueObject = "Y";
            // 
            // FRMUsuario_Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 485);
            this.Controls.Add(this.GPPanelPrincipal);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMUsuario_Registrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMUsuario_Registrar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRMUsuario_Registrar_FormClosing);
            this.Load += new System.EventHandler(this.FRMUsuario_Registrar_Load);
            this.GPPanelPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel GPPanelPrincipal;
        private DevComponents.DotNetBar.ButtonX BTNBuscarUsuario;
        private DevComponents.DotNetBar.ButtonX BTNSalir;
        private DevComponents.DotNetBar.ButtonX BTNLimpiar;
        private DevComponents.DotNetBar.ButtonX BTNGrabar;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTCI;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTNombres;
        private DevComponents.DotNetBar.Controls.SwitchButton SWBEstado;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTNombreLogin;
        private DPFP.Gui.Enrollment.EnrollmentControl DPEHuellas;
    }
}