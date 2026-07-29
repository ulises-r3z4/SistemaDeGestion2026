namespace Eithan_System
{
    partial class FRMUsuarioRegistrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMUsuarioRegistrar));
            this.GP_Panel_Usuario = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.DPFPHuellas = new DPFP.Gui.Enrollment.EnrollmentControl();
            this.TXT_LoginUsuario = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.BTN_BuscarUsuario = new DevComponents.DotNetBar.ButtonX();
            this.BTN_Salir = new DevComponents.DotNetBar.ButtonX();
            this.BTN_Limpiar = new DevComponents.DotNetBar.ButtonX();
            this.BTN_Grabar = new DevComponents.DotNetBar.ButtonX();
            this.TXT_CI = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TXT_Nombres = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SWB_Estado = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.GP_Panel_Usuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // GP_Panel_Usuario
            // 
            this.GP_Panel_Usuario.CanvasColor = System.Drawing.SystemColors.Control;
            this.GP_Panel_Usuario.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.GP_Panel_Usuario.Controls.Add(this.DPFPHuellas);
            this.GP_Panel_Usuario.Controls.Add(this.TXT_LoginUsuario);
            this.GP_Panel_Usuario.Controls.Add(this.BTN_BuscarUsuario);
            this.GP_Panel_Usuario.Controls.Add(this.BTN_Salir);
            this.GP_Panel_Usuario.Controls.Add(this.BTN_Limpiar);
            this.GP_Panel_Usuario.Controls.Add(this.BTN_Grabar);
            this.GP_Panel_Usuario.Controls.Add(this.TXT_CI);
            this.GP_Panel_Usuario.Controls.Add(this.TXT_Nombres);
            this.GP_Panel_Usuario.Controls.Add(this.SWB_Estado);
            this.GP_Panel_Usuario.DisabledBackColor = System.Drawing.Color.Empty;
            this.GP_Panel_Usuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GP_Panel_Usuario.Location = new System.Drawing.Point(0, 0);
            this.GP_Panel_Usuario.Name = "GP_Panel_Usuario";
            this.GP_Panel_Usuario.Size = new System.Drawing.Size(524, 465);
            // 
            // 
            // 
            this.GP_Panel_Usuario.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.GP_Panel_Usuario.Style.BackColorGradientAngle = 90;
            this.GP_Panel_Usuario.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.GP_Panel_Usuario.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GP_Panel_Usuario.Style.BorderBottomWidth = 1;
            this.GP_Panel_Usuario.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.GP_Panel_Usuario.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GP_Panel_Usuario.Style.BorderLeftWidth = 1;
            this.GP_Panel_Usuario.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GP_Panel_Usuario.Style.BorderRightWidth = 1;
            this.GP_Panel_Usuario.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GP_Panel_Usuario.Style.BorderTopWidth = 1;
            this.GP_Panel_Usuario.Style.CornerDiameter = 4;
            this.GP_Panel_Usuario.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.GP_Panel_Usuario.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.GP_Panel_Usuario.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.GP_Panel_Usuario.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.GP_Panel_Usuario.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.GP_Panel_Usuario.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.GP_Panel_Usuario.TabIndex = 1;
            this.GP_Panel_Usuario.Text = "Usuario";
            // 
            // DPFPHuellas
            // 
            this.DPFPHuellas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DPFPHuellas.EnrolledFingerMask = 0;
            this.DPFPHuellas.Location = new System.Drawing.Point(10, 60);
            this.DPFPHuellas.Margin = new System.Windows.Forms.Padding(4);
            this.DPFPHuellas.MaxEnrollFingerCount = 10;
            this.DPFPHuellas.Name = "DPFPHuellas";
            this.DPFPHuellas.ReaderSerialNumber = "00000000-0000-0000-0000-000000000000";
            this.DPFPHuellas.Size = new System.Drawing.Size(492, 314);
            this.DPFPHuellas.TabIndex = 17;
            this.DPFPHuellas.OnDelete += new DPFP.Gui.Enrollment.EnrollmentControl._OnDelete(this.DPFPHuellas_OnDelete);
            this.DPFPHuellas.OnEnroll += new DPFP.Gui.Enrollment.EnrollmentControl._OnEnroll(this.DPFPHuellas_OnEnroll);
            // 
            // TXT_LoginUsuario
            // 
            // 
            // 
            // 
            this.TXT_LoginUsuario.Border.Class = "TextBoxBorder";
            this.TXT_LoginUsuario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXT_LoginUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXT_LoginUsuario.Location = new System.Drawing.Point(127, 32);
            this.TXT_LoginUsuario.Name = "TXT_LoginUsuario";
            this.TXT_LoginUsuario.PreventEnterBeep = true;
            this.TXT_LoginUsuario.Size = new System.Drawing.Size(295, 23);
            this.TXT_LoginUsuario.TabIndex = 16;
            this.TXT_LoginUsuario.WatermarkText = "Login del Usuario";
            this.TXT_LoginUsuario.TextChanged += new System.EventHandler(this.TXT_LoginUsuario_TextChanged);
            this.TXT_LoginUsuario.Enter += new System.EventHandler(this.TXT_CI_Enter);
            this.TXT_LoginUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXT_LoginUsuario_KeyDown);
            // 
            // BTN_BuscarUsuario
            // 
            this.BTN_BuscarUsuario.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_BuscarUsuario.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_BuscarUsuario.Image = global::Eithan_System.Properties.Resources.icono_buscar;
            this.BTN_BuscarUsuario.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTN_BuscarUsuario.Location = new System.Drawing.Point(428, 3);
            this.BTN_BuscarUsuario.Name = "BTN_BuscarUsuario";
            this.BTN_BuscarUsuario.Size = new System.Drawing.Size(32, 33);
            this.BTN_BuscarUsuario.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_BuscarUsuario.TabIndex = 14;
            this.BTN_BuscarUsuario.Click += new System.EventHandler(this.BTN_BuscarUsuario_Click);
            // 
            // BTN_Salir
            // 
            this.BTN_Salir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_Salir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_Salir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Salir.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Salir.Image")));
            this.BTN_Salir.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTN_Salir.Location = new System.Drawing.Point(374, 381);
            this.BTN_Salir.Name = "BTN_Salir";
            this.BTN_Salir.Size = new System.Drawing.Size(119, 42);
            this.BTN_Salir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_Salir.TabIndex = 13;
            this.BTN_Salir.Text = "&Salir";
            this.BTN_Salir.Click += new System.EventHandler(this.BTN_Salir_Click);
            // 
            // BTN_Limpiar
            // 
            this.BTN_Limpiar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_Limpiar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_Limpiar.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Limpiar.Image")));
            this.BTN_Limpiar.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTN_Limpiar.Location = new System.Drawing.Point(188, 381);
            this.BTN_Limpiar.Name = "BTN_Limpiar";
            this.BTN_Limpiar.Size = new System.Drawing.Size(121, 42);
            this.BTN_Limpiar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_Limpiar.TabIndex = 12;
            this.BTN_Limpiar.Text = "&Limpiar";
            // 
            // BTN_Grabar
            // 
            this.BTN_Grabar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_Grabar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_Grabar.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Grabar.Image")));
            this.BTN_Grabar.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTN_Grabar.Location = new System.Drawing.Point(9, 381);
            this.BTN_Grabar.Name = "BTN_Grabar";
            this.BTN_Grabar.Size = new System.Drawing.Size(118, 42);
            this.BTN_Grabar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_Grabar.TabIndex = 11;
            this.BTN_Grabar.Text = "&Grabar";
            this.BTN_Grabar.Click += new System.EventHandler(this.BTN_Grabar_Click);
            // 
            // TXT_CI
            // 
            // 
            // 
            // 
            this.TXT_CI.Border.Class = "TextBoxBorder";
            this.TXT_CI.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXT_CI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXT_CI.Location = new System.Drawing.Point(127, 2);
            this.TXT_CI.Name = "TXT_CI";
            this.TXT_CI.PreventEnterBeep = true;
            this.TXT_CI.Size = new System.Drawing.Size(121, 23);
            this.TXT_CI.TabIndex = 2;
            this.TXT_CI.WatermarkText = "CI";
            this.TXT_CI.Enter += new System.EventHandler(this.TXT_CI_Enter);
            // 
            // TXT_Nombres
            // 
            // 
            // 
            // 
            this.TXT_Nombres.Border.Class = "TextBoxBorder";
            this.TXT_Nombres.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXT_Nombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXT_Nombres.Location = new System.Drawing.Point(254, 3);
            this.TXT_Nombres.Name = "TXT_Nombres";
            this.TXT_Nombres.PreventEnterBeep = true;
            this.TXT_Nombres.Size = new System.Drawing.Size(168, 23);
            this.TXT_Nombres.TabIndex = 6;
            this.TXT_Nombres.WatermarkText = "Nombre Completo del Usuario";
            this.TXT_Nombres.TextChanged += new System.EventHandler(this.TXT_Nombres_TextChanged);
            // 
            // SWB_Estado
            // 
            // 
            // 
            // 
            this.SWB_Estado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SWB_Estado.Location = new System.Drawing.Point(9, 3);
            this.SWB_Estado.Name = "SWB_Estado";
            this.SWB_Estado.OffBackColor = System.Drawing.Color.Red;
            this.SWB_Estado.OffText = "Inhabilitado";
            this.SWB_Estado.OffTextColor = System.Drawing.Color.White;
            this.SWB_Estado.OnBackColor = System.Drawing.Color.LimeGreen;
            this.SWB_Estado.OnText = "Habilitado";
            this.SWB_Estado.OnTextColor = System.Drawing.Color.White;
            this.SWB_Estado.Size = new System.Drawing.Size(112, 22);
            this.SWB_Estado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SWB_Estado.TabIndex = 0;
            this.SWB_Estado.Value = true;
            this.SWB_Estado.ValueObject = "Y";
            // 
            // FRMUsuarioRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 465);
            this.Controls.Add(this.GP_Panel_Usuario);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMUsuarioRegistrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMUsuarioRegistrar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRMUsuarioRegistrar_FormClosing);
            this.Load += new System.EventHandler(this.FRMUsuarioRegistrar_Load);
            this.GP_Panel_Usuario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel GP_Panel_Usuario;
        private DevComponents.DotNetBar.ButtonX BTN_Salir;
        private DevComponents.DotNetBar.ButtonX BTN_Limpiar;
        private DevComponents.DotNetBar.ButtonX BTN_Grabar;
        private DevComponents.DotNetBar.Controls.TextBoxX TXT_CI;
        private DevComponents.DotNetBar.Controls.TextBoxX TXT_Nombres;
        private DevComponents.DotNetBar.Controls.SwitchButton SWB_Estado;
        private DevComponents.DotNetBar.Controls.TextBoxX TXT_LoginUsuario;
        private DevComponents.DotNetBar.ButtonX BTN_BuscarUsuario;
        private DPFP.Gui.Enrollment.EnrollmentControl DPFPHuellas;
    }
}