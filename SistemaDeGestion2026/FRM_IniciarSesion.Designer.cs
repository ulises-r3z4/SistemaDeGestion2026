namespace Eithan_System
{
    partial class FRM_IniciarSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_IniciarSesion));
            this.GP_Panel_Usuario = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.BTNPassword = new DevComponents.DotNetBar.ButtonX();
            this.TXT_Password = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TXT_Login = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.BTN_Cancelar = new DevComponents.DotNetBar.ButtonX();
            this.BTN_Ingresar = new DevComponents.DotNetBar.ButtonX();
            this.GP_Panel_Usuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // GP_Panel_Usuario
            // 
            this.GP_Panel_Usuario.CanvasColor = System.Drawing.SystemColors.Control;
            this.GP_Panel_Usuario.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.GP_Panel_Usuario.Controls.Add(this.BTNPassword);
            this.GP_Panel_Usuario.Controls.Add(this.TXT_Password);
            this.GP_Panel_Usuario.Controls.Add(this.TXT_Login);
            this.GP_Panel_Usuario.Controls.Add(this.BTN_Cancelar);
            this.GP_Panel_Usuario.Controls.Add(this.BTN_Ingresar);
            this.GP_Panel_Usuario.DisabledBackColor = System.Drawing.Color.Empty;
            this.GP_Panel_Usuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GP_Panel_Usuario.Location = new System.Drawing.Point(0, 0);
            this.GP_Panel_Usuario.Name = "GP_Panel_Usuario";
            this.GP_Panel_Usuario.Size = new System.Drawing.Size(218, 174);
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
            this.GP_Panel_Usuario.TabIndex = 2;
            this.GP_Panel_Usuario.Text = "Usuario";
            // 
            // BTNPassword
            // 
            this.BTNPassword.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNPassword.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNPassword.Image = ((System.Drawing.Image)(resources.GetObject("BTNPassword.Image")));
            this.BTNPassword.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.BTNPassword.Location = new System.Drawing.Point(175, 38);
            this.BTNPassword.Name = "BTNPassword";
            this.BTNPassword.Size = new System.Drawing.Size(28, 23);
            this.BTNPassword.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNPassword.TabIndex = 18;
            this.BTNPassword.Click += new System.EventHandler(this.BTNPassword_Click);
            // 
            // TXT_Password
            // 
            // 
            // 
            // 
            this.TXT_Password.Border.Class = "TextBoxBorder";
            this.TXT_Password.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXT_Password.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXT_Password.Location = new System.Drawing.Point(9, 38);
            this.TXT_Password.Name = "TXT_Password";
            this.TXT_Password.PasswordChar = '*';
            this.TXT_Password.PreventEnterBeep = true;
            this.TXT_Password.Size = new System.Drawing.Size(160, 23);
            this.TXT_Password.TabIndex = 17;
            this.TXT_Password.WatermarkText = "Password";
            this.TXT_Password.TextChanged += new System.EventHandler(this.TXT_Password_TextChanged);
            // 
            // TXT_Login
            // 
            // 
            // 
            // 
            this.TXT_Login.Border.Class = "TextBoxBorder";
            this.TXT_Login.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXT_Login.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXT_Login.Location = new System.Drawing.Point(9, 6);
            this.TXT_Login.Name = "TXT_Login";
            this.TXT_Login.PreventEnterBeep = true;
            this.TXT_Login.Size = new System.Drawing.Size(194, 23);
            this.TXT_Login.TabIndex = 16;
            this.TXT_Login.WatermarkText = "Login";
            // 
            // BTN_Cancelar
            // 
            this.BTN_Cancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_Cancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Cancelar.Image")));
            this.BTN_Cancelar.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.BTN_Cancelar.Location = new System.Drawing.Point(108, 75);
            this.BTN_Cancelar.Name = "BTN_Cancelar";
            this.BTN_Cancelar.Size = new System.Drawing.Size(95, 42);
            this.BTN_Cancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_Cancelar.TabIndex = 13;
            this.BTN_Cancelar.Text = "&Cancelar";
            this.BTN_Cancelar.Click += new System.EventHandler(this.BTN_Cancelar_Click);
            // 
            // BTN_Ingresar
            // 
            this.BTN_Ingresar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_Ingresar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_Ingresar.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Ingresar.Image")));
            this.BTN_Ingresar.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.BTN_Ingresar.Location = new System.Drawing.Point(9, 75);
            this.BTN_Ingresar.Name = "BTN_Ingresar";
            this.BTN_Ingresar.Size = new System.Drawing.Size(93, 42);
            this.BTN_Ingresar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_Ingresar.TabIndex = 11;
            this.BTN_Ingresar.Text = "&Ingresar";
            // 
            // FRM_IniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 174);
            this.Controls.Add(this.GP_Panel_Usuario);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_IniciarSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_IniciarSesion";
            this.Load += new System.EventHandler(this.FRM_IniciarSesion_Load);
            this.GP_Panel_Usuario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel GP_Panel_Usuario;
        private DevComponents.DotNetBar.Controls.TextBoxX TXT_Login;
        private DevComponents.DotNetBar.ButtonX BTN_Cancelar;
        private DevComponents.DotNetBar.ButtonX BTN_Ingresar;
        private DevComponents.DotNetBar.Controls.TextBoxX TXT_Password;
        private DevComponents.DotNetBar.ButtonX BTNPassword;
    }
}