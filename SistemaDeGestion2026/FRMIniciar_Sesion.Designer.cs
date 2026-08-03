namespace SistemaDeGestion2026
{
    partial class FRMIniciar_Sesion
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
            this.TXTNombreLogin = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.GPPanelPrincipal = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.BTNPassword = new DevComponents.DotNetBar.ButtonX();
            this.TXTPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.BTNCancelar = new DevComponents.DotNetBar.ButtonX();
            this.BTNIngresar = new DevComponents.DotNetBar.ButtonX();
            this.GPPanelPrincipal.SuspendLayout();
            this.SuspendLayout();
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
            this.TXTNombreLogin.DisabledBackColor = System.Drawing.Color.White;
            this.TXTNombreLogin.ForeColor = System.Drawing.Color.Black;
            this.TXTNombreLogin.Location = new System.Drawing.Point(9, 3);
            this.TXTNombreLogin.Name = "TXTNombreLogin";
            this.TXTNombreLogin.PreventEnterBeep = true;
            this.TXTNombreLogin.Size = new System.Drawing.Size(233, 26);
            this.TXTNombreLogin.TabIndex = 0;
            this.TXTNombreLogin.WatermarkText = "Login ";
            // 
            // GPPanelPrincipal
            // 
            this.GPPanelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.GPPanelPrincipal.CanvasColor = System.Drawing.SystemColors.Control;
            this.GPPanelPrincipal.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.GPPanelPrincipal.Controls.Add(this.BTNPassword);
            this.GPPanelPrincipal.Controls.Add(this.TXTPassword);
            this.GPPanelPrincipal.Controls.Add(this.TXTNombreLogin);
            this.GPPanelPrincipal.Controls.Add(this.BTNCancelar);
            this.GPPanelPrincipal.Controls.Add(this.BTNIngresar);
            this.GPPanelPrincipal.DisabledBackColor = System.Drawing.Color.Empty;
            this.GPPanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GPPanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.GPPanelPrincipal.Name = "GPPanelPrincipal";
            this.GPPanelPrincipal.Size = new System.Drawing.Size(256, 145);
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
            this.GPPanelPrincipal.TabIndex = 0;
            this.GPPanelPrincipal.Text = "Usuario";
            // 
            // BTNPassword
            // 
            this.BTNPassword.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNPassword.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNPassword.Image = global::SistemaDeGestion2026.Properties.Resources.ic_mostrar_password;
            this.BTNPassword.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.BTNPassword.Location = new System.Drawing.Point(216, 35);
            this.BTNPassword.Name = "BTNPassword";
            this.BTNPassword.Size = new System.Drawing.Size(25, 26);
            this.BTNPassword.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNPassword.TabIndex = 18;
            this.BTNPassword.Click += new System.EventHandler(this.BTNPassword_Click);
            // 
            // TXTPassword
            // 
            this.TXTPassword.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TXTPassword.Border.Class = "TextBoxBorder";
            this.TXTPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTPassword.DisabledBackColor = System.Drawing.Color.White;
            this.TXTPassword.ForeColor = System.Drawing.Color.Black;
            this.TXTPassword.Location = new System.Drawing.Point(9, 35);
            this.TXTPassword.Name = "TXTPassword";
            this.TXTPassword.PasswordChar = '*';
            this.TXTPassword.PreventEnterBeep = true;
            this.TXTPassword.Size = new System.Drawing.Size(201, 26);
            this.TXTPassword.TabIndex = 1;
            this.TXTPassword.WatermarkText = "Password";
            // 
            // BTNCancelar
            // 
            this.BTNCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTNCancelar.Image = global::SistemaDeGestion2026.Properties.Resources.ic_salir_app;
            this.BTNCancelar.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTNCancelar.Location = new System.Drawing.Point(124, 67);
            this.BTNCancelar.Name = "BTNCancelar";
            this.BTNCancelar.Size = new System.Drawing.Size(118, 39);
            this.BTNCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNCancelar.TabIndex = 3;
            this.BTNCancelar.Text = "&Cancelar";
            this.BTNCancelar.Click += new System.EventHandler(this.BTNCancelar_Click);
            // 
            // BTNIngresar
            // 
            this.BTNIngresar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNIngresar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNIngresar.Image = global::SistemaDeGestion2026.Properties.Resources.ic_ingresar;
            this.BTNIngresar.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTNIngresar.Location = new System.Drawing.Point(9, 67);
            this.BTNIngresar.Name = "BTNIngresar";
            this.BTNIngresar.Size = new System.Drawing.Size(109, 39);
            this.BTNIngresar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNIngresar.TabIndex = 2;
            this.BTNIngresar.Text = "&Ingresar";
            this.BTNIngresar.Click += new System.EventHandler(this.BTNIngresar_Click);
            // 
            // FRMIniciar_Sesion
            // 
            this.AcceptButton = this.BTNIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTNCancelar;
            this.ClientSize = new System.Drawing.Size(256, 145);
            this.Controls.Add(this.GPPanelPrincipal);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMIniciar_Sesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión";
            this.GPPanelPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX BTNIngresar;
        private DevComponents.DotNetBar.ButtonX BTNCancelar;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTNombreLogin;
        private DevComponents.DotNetBar.Controls.GroupPanel GPPanelPrincipal;
        private DevComponents.DotNetBar.ButtonX BTNPassword;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTPassword;
    }
}