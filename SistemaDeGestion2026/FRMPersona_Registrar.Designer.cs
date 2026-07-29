namespace Eithan_System
{
    partial class FRMPersona_Registrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMPersona_Registrar));
            this.GP_Panel_Persona = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.GP_Fotografia = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.TXT_CI = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TXT_ApellidoPaterno = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TXT_Direccion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TXT_Correo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TXT_Celular = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TXT_Nombres = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TXT_ApellidoMaterno = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.DTI_Nacimiento = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.SWB_Sexo = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.SWB_Estado = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.BLT_Ayuda = new DevComponents.DotNetBar.BalloonTip();
            this.OFDElegirImagen = new System.Windows.Forms.OpenFileDialog();
            this.BTN_Grabar = new DevComponents.DotNetBar.ButtonX();
            this.BTN_Salir = new DevComponents.DotNetBar.ButtonX();
            this.BTN_AbrirFoto = new DevComponents.DotNetBar.ButtonX();
            this.BTN_LimpiarFoto = new DevComponents.DotNetBar.ButtonX();
            this.BTN_CapturarFoto = new DevComponents.DotNetBar.ButtonX();
            this.PCB_Fotografía = new System.Windows.Forms.PictureBox();
            this.PCB_Camara = new System.Windows.Forms.PictureBox();
            this.BTN_Limpiar = new DevComponents.DotNetBar.ButtonX();
            this.GP_Panel_Persona.SuspendLayout();
            this.GP_Fotografia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTI_Nacimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCB_Fotografía)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCB_Camara)).BeginInit();
            this.SuspendLayout();
            // 
            // GP_Panel_Persona
            // 
            this.GP_Panel_Persona.CanvasColor = System.Drawing.SystemColors.Control;
            this.GP_Panel_Persona.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.GP_Panel_Persona.Controls.Add(this.GP_Fotografia);
            this.GP_Panel_Persona.Controls.Add(this.BTN_Salir);
            this.GP_Panel_Persona.Controls.Add(this.BTN_Limpiar);
            this.GP_Panel_Persona.Controls.Add(this.BTN_Grabar);
            this.GP_Panel_Persona.Controls.Add(this.TXT_CI);
            this.GP_Panel_Persona.Controls.Add(this.TXT_ApellidoPaterno);
            this.GP_Panel_Persona.Controls.Add(this.TXT_Direccion);
            this.GP_Panel_Persona.Controls.Add(this.TXT_Correo);
            this.GP_Panel_Persona.Controls.Add(this.TXT_Celular);
            this.GP_Panel_Persona.Controls.Add(this.TXT_Nombres);
            this.GP_Panel_Persona.Controls.Add(this.TXT_ApellidoMaterno);
            this.GP_Panel_Persona.Controls.Add(this.DTI_Nacimiento);
            this.GP_Panel_Persona.Controls.Add(this.SWB_Sexo);
            this.GP_Panel_Persona.Controls.Add(this.SWB_Estado);
            this.GP_Panel_Persona.DisabledBackColor = System.Drawing.Color.Empty;
            this.GP_Panel_Persona.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GP_Panel_Persona.Location = new System.Drawing.Point(0, 0);
            this.GP_Panel_Persona.Name = "GP_Panel_Persona";
            this.GP_Panel_Persona.Size = new System.Drawing.Size(670, 346);
            // 
            // 
            // 
            this.GP_Panel_Persona.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.GP_Panel_Persona.Style.BackColorGradientAngle = 90;
            this.GP_Panel_Persona.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.GP_Panel_Persona.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GP_Panel_Persona.Style.BorderBottomWidth = 1;
            this.GP_Panel_Persona.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.GP_Panel_Persona.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GP_Panel_Persona.Style.BorderLeftWidth = 1;
            this.GP_Panel_Persona.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GP_Panel_Persona.Style.BorderRightWidth = 1;
            this.GP_Panel_Persona.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GP_Panel_Persona.Style.BorderTopWidth = 1;
            this.GP_Panel_Persona.Style.CornerDiameter = 4;
            this.GP_Panel_Persona.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.GP_Panel_Persona.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.GP_Panel_Persona.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.GP_Panel_Persona.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.GP_Panel_Persona.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.GP_Panel_Persona.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.GP_Panel_Persona.TabIndex = 0;
            this.GP_Panel_Persona.Text = "Persona";
            // 
            // GP_Fotografia
            // 
            this.GP_Fotografia.CanvasColor = System.Drawing.SystemColors.Control;
            this.GP_Fotografia.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.GP_Fotografia.Controls.Add(this.BTN_AbrirFoto);
            this.GP_Fotografia.Controls.Add(this.BTN_LimpiarFoto);
            this.GP_Fotografia.Controls.Add(this.BTN_CapturarFoto);
            this.GP_Fotografia.Controls.Add(this.PCB_Fotografía);
            this.GP_Fotografia.Controls.Add(this.PCB_Camara);
            this.GP_Fotografia.DisabledBackColor = System.Drawing.Color.Empty;
            this.GP_Fotografia.Location = new System.Drawing.Point(311, 6);
            this.GP_Fotografia.Name = "GP_Fotografia";
            this.GP_Fotografia.Size = new System.Drawing.Size(345, 256);
            // 
            // 
            // 
            this.GP_Fotografia.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.GP_Fotografia.Style.BackColorGradientAngle = 90;
            this.GP_Fotografia.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.GP_Fotografia.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GP_Fotografia.Style.BorderBottomWidth = 1;
            this.GP_Fotografia.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.GP_Fotografia.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GP_Fotografia.Style.BorderLeftWidth = 1;
            this.GP_Fotografia.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GP_Fotografia.Style.BorderRightWidth = 1;
            this.GP_Fotografia.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GP_Fotografia.Style.BorderTopWidth = 1;
            this.GP_Fotografia.Style.CornerDiameter = 4;
            this.GP_Fotografia.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.GP_Fotografia.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.GP_Fotografia.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.GP_Fotografia.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.GP_Fotografia.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.GP_Fotografia.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.GP_Fotografia.TabIndex = 10;
            this.GP_Fotografia.Text = "Fotografía";
            // 
            // TXT_CI
            // 
            this.BLT_Ayuda.SetBalloonCaption(this.TXT_CI, "Ayuda");
            this.BLT_Ayuda.SetBalloonText(this.TXT_CI, "Numero de Documento de Identidad de la Persona");
            // 
            // 
            // 
            this.TXT_CI.Border.Class = "TextBoxBorder";
            this.TXT_CI.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXT_CI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXT_CI.Location = new System.Drawing.Point(9, 32);
            this.TXT_CI.Name = "TXT_CI";
            this.TXT_CI.PreventEnterBeep = true;
            this.TXT_CI.Size = new System.Drawing.Size(145, 23);
            this.TXT_CI.TabIndex = 2;
            this.TXT_CI.WatermarkText = "CI";
            this.TXT_CI.Enter += new System.EventHandler(this.TXT_CI_Enter);
            this.TXT_CI.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXT_CI_KeyDown);
            // 
            // TXT_ApellidoPaterno
            // 
            this.BLT_Ayuda.SetBalloonCaption(this.TXT_ApellidoPaterno, "Ayuda");
            this.BLT_Ayuda.SetBalloonText(this.TXT_ApellidoPaterno, "Apellido Paterno de la Persona");
            // 
            // 
            // 
            this.TXT_ApellidoPaterno.Border.Class = "TextBoxBorder";
            this.TXT_ApellidoPaterno.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXT_ApellidoPaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXT_ApellidoPaterno.Location = new System.Drawing.Point(9, 61);
            this.TXT_ApellidoPaterno.Name = "TXT_ApellidoPaterno";
            this.TXT_ApellidoPaterno.PreventEnterBeep = true;
            this.TXT_ApellidoPaterno.Size = new System.Drawing.Size(145, 23);
            this.TXT_ApellidoPaterno.TabIndex = 4;
            this.TXT_ApellidoPaterno.WatermarkText = "Apellido Paterno";
            this.TXT_ApellidoPaterno.Enter += new System.EventHandler(this.TXT_CI_Enter);
            this.TXT_ApellidoPaterno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXT_Nombres_KeyDown);
            // 
            // TXT_Direccion
            // 
            this.BLT_Ayuda.SetBalloonCaption(this.TXT_Direccion, "Ayuda");
            this.BLT_Ayuda.SetBalloonText(this.TXT_Direccion, "Direccion de la Vivienda de la Persona");
            // 
            // 
            // 
            this.TXT_Direccion.Border.Class = "TextBoxBorder";
            this.TXT_Direccion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXT_Direccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXT_Direccion.Location = new System.Drawing.Point(9, 148);
            this.TXT_Direccion.Multiline = true;
            this.TXT_Direccion.Name = "TXT_Direccion";
            this.TXT_Direccion.PreventEnterBeep = true;
            this.TXT_Direccion.Size = new System.Drawing.Size(296, 114);
            this.TXT_Direccion.TabIndex = 9;
            this.TXT_Direccion.WatermarkText = "Dirección";
            this.TXT_Direccion.Enter += new System.EventHandler(this.TXT_CI_Enter);
            this.TXT_Direccion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXT_Direccion_KeyDown);
            // 
            // TXT_Correo
            // 
            this.BLT_Ayuda.SetBalloonCaption(this.TXT_Correo, "Ayuda");
            this.BLT_Ayuda.SetBalloonText(this.TXT_Correo, "Correo Electronico de la Persona");
            // 
            // 
            // 
            this.TXT_Correo.Border.Class = "TextBoxBorder";
            this.TXT_Correo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXT_Correo.Location = new System.Drawing.Point(130, 119);
            this.TXT_Correo.Name = "TXT_Correo";
            this.TXT_Correo.PreventEnterBeep = true;
            this.TXT_Correo.Size = new System.Drawing.Size(175, 23);
            this.TXT_Correo.TabIndex = 8;
            this.TXT_Correo.WatermarkText = "Correo Electrónico";
            this.TXT_Correo.Enter += new System.EventHandler(this.TXT_CI_Enter);
            this.TXT_Correo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXT_Correo_KeyDown);
            // 
            // TXT_Celular
            // 
            this.BLT_Ayuda.SetBalloonCaption(this.TXT_Celular, "Ayuda");
            this.BLT_Ayuda.SetBalloonText(this.TXT_Celular, "Numero de Celular de la Persona");
            // 
            // 
            // 
            this.TXT_Celular.Border.Class = "TextBoxBorder";
            this.TXT_Celular.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXT_Celular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXT_Celular.Location = new System.Drawing.Point(9, 119);
            this.TXT_Celular.Name = "TXT_Celular";
            this.TXT_Celular.PreventEnterBeep = true;
            this.TXT_Celular.Size = new System.Drawing.Size(115, 23);
            this.TXT_Celular.TabIndex = 7;
            this.TXT_Celular.WatermarkText = "Celular";
            this.TXT_Celular.Enter += new System.EventHandler(this.TXT_CI_Enter);
            this.TXT_Celular.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXT_Celular_KeyDown);
            // 
            // TXT_Nombres
            // 
            this.BLT_Ayuda.SetBalloonCaption(this.TXT_Nombres, "Ayuda");
            this.BLT_Ayuda.SetBalloonText(this.TXT_Nombres, "Nombre de la Persona");
            // 
            // 
            // 
            this.TXT_Nombres.Border.Class = "TextBoxBorder";
            this.TXT_Nombres.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXT_Nombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXT_Nombres.Location = new System.Drawing.Point(9, 90);
            this.TXT_Nombres.Name = "TXT_Nombres";
            this.TXT_Nombres.PreventEnterBeep = true;
            this.TXT_Nombres.Size = new System.Drawing.Size(296, 23);
            this.TXT_Nombres.TabIndex = 6;
            this.TXT_Nombres.WatermarkText = "Nombres";
            this.TXT_Nombres.Enter += new System.EventHandler(this.TXT_CI_Enter);
            this.TXT_Nombres.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXT_Nombres_KeyDown);
            // 
            // TXT_ApellidoMaterno
            // 
            this.BLT_Ayuda.SetBalloonCaption(this.TXT_ApellidoMaterno, "Ayuda");
            this.BLT_Ayuda.SetBalloonText(this.TXT_ApellidoMaterno, "Apellido Materno de la Persona");
            // 
            // 
            // 
            this.TXT_ApellidoMaterno.Border.Class = "TextBoxBorder";
            this.TXT_ApellidoMaterno.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXT_ApellidoMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXT_ApellidoMaterno.Location = new System.Drawing.Point(160, 61);
            this.TXT_ApellidoMaterno.Name = "TXT_ApellidoMaterno";
            this.TXT_ApellidoMaterno.PreventEnterBeep = true;
            this.TXT_ApellidoMaterno.Size = new System.Drawing.Size(145, 23);
            this.TXT_ApellidoMaterno.TabIndex = 5;
            this.TXT_ApellidoMaterno.WatermarkText = "Apellido Materno";
            this.TXT_ApellidoMaterno.Enter += new System.EventHandler(this.TXT_CI_Enter);
            this.TXT_ApellidoMaterno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXT_Nombres_KeyDown);
            // 
            // DTI_Nacimiento
            // 
            // 
            // 
            // 
            this.DTI_Nacimiento.BackgroundStyle.Class = "DateTimeInputBackground";
            this.DTI_Nacimiento.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.BLT_Ayuda.SetBalloonCaption(this.DTI_Nacimiento, "Ayuda");
            this.BLT_Ayuda.SetBalloonText(this.DTI_Nacimiento, "Fecha de Nacimiento de la Persona");
            this.DTI_Nacimiento.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.DTI_Nacimiento.ButtonDropDown.Visible = true;
            this.DTI_Nacimiento.IsPopupCalendarOpen = false;
            this.DTI_Nacimiento.Location = new System.Drawing.Point(160, 32);
            // 
            // 
            // 
            // 
            // 
            // 
            this.DTI_Nacimiento.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DTI_Nacimiento.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.DTI_Nacimiento.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.DTI_Nacimiento.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.DTI_Nacimiento.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.DTI_Nacimiento.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.DTI_Nacimiento.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.DTI_Nacimiento.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.DTI_Nacimiento.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.DTI_Nacimiento.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DTI_Nacimiento.MonthCalendar.DisplayMonth = new System.DateTime(2026, 5, 1, 0, 0, 0, 0);
            this.DTI_Nacimiento.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.DTI_Nacimiento.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.DTI_Nacimiento.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.DTI_Nacimiento.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.DTI_Nacimiento.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DTI_Nacimiento.MonthCalendar.TodayButtonVisible = true;
            this.DTI_Nacimiento.Name = "DTI_Nacimiento";
            this.DTI_Nacimiento.Size = new System.Drawing.Size(145, 23);
            this.DTI_Nacimiento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.DTI_Nacimiento.TabIndex = 3;
            this.DTI_Nacimiento.WatermarkText = "Nacimiento";
            // 
            // SWB_Sexo
            // 
            // 
            // 
            // 
            this.SWB_Sexo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.BLT_Ayuda.SetBalloonCaption(this.SWB_Sexo, "Ayuda");
            this.BLT_Ayuda.SetBalloonText(this.SWB_Sexo, "Sexo de la Persona");
            this.SWB_Sexo.Location = new System.Drawing.Point(160, 4);
            this.SWB_Sexo.Name = "SWB_Sexo";
            this.SWB_Sexo.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SWB_Sexo.OffText = "Femenino";
            this.SWB_Sexo.OffTextColor = System.Drawing.Color.White;
            this.SWB_Sexo.OnBackColor = System.Drawing.Color.SteelBlue;
            this.SWB_Sexo.OnText = "Masculino";
            this.SWB_Sexo.OnTextColor = System.Drawing.Color.White;
            this.SWB_Sexo.Size = new System.Drawing.Size(145, 22);
            this.SWB_Sexo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SWB_Sexo.TabIndex = 1;
            this.SWB_Sexo.Value = true;
            this.SWB_Sexo.ValueObject = "Y";
            // 
            // SWB_Estado
            // 
            // 
            // 
            // 
            this.SWB_Estado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.BLT_Ayuda.SetBalloonCaption(this.SWB_Estado, "Ayuda");
            this.BLT_Ayuda.SetBalloonText(this.SWB_Estado, "Estado de la Persona");
            this.SWB_Estado.Location = new System.Drawing.Point(9, 3);
            this.SWB_Estado.Name = "SWB_Estado";
            this.SWB_Estado.OffBackColor = System.Drawing.Color.Red;
            this.SWB_Estado.OffText = "Inhabilitado";
            this.SWB_Estado.OffTextColor = System.Drawing.Color.White;
            this.SWB_Estado.OnBackColor = System.Drawing.Color.LimeGreen;
            this.SWB_Estado.OnText = "Habilitado";
            this.SWB_Estado.OnTextColor = System.Drawing.Color.White;
            this.SWB_Estado.Size = new System.Drawing.Size(145, 22);
            this.SWB_Estado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SWB_Estado.TabIndex = 0;
            this.SWB_Estado.Value = true;
            this.SWB_Estado.ValueObject = "Y";
            // 
            // OFDElegirImagen
            // 
            this.OFDElegirImagen.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png";
            this.OFDElegirImagen.Title = "Elegir Fotografía";
            // 
            // BTN_Grabar
            // 
            this.BTN_Grabar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_Grabar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_Grabar.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Grabar.Image")));
            this.BTN_Grabar.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTN_Grabar.Location = new System.Drawing.Point(9, 268);
            this.BTN_Grabar.Name = "BTN_Grabar";
            this.BTN_Grabar.Size = new System.Drawing.Size(82, 44);
            this.BTN_Grabar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_Grabar.TabIndex = 11;
            this.BTN_Grabar.Text = "&Grabar";
            this.BTN_Grabar.Click += new System.EventHandler(this.BTN_Grabar_Click);
            // 
            // BTN_Salir
            // 
            this.BTN_Salir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_Salir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_Salir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Salir.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Salir.Image")));
            this.BTN_Salir.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTN_Salir.Location = new System.Drawing.Point(584, 268);
            this.BTN_Salir.Name = "BTN_Salir";
            this.BTN_Salir.Size = new System.Drawing.Size(72, 44);
            this.BTN_Salir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_Salir.TabIndex = 13;
            this.BTN_Salir.Text = "&Salir";
            this.BTN_Salir.Click += new System.EventHandler(this.BTN_Salir_Click);
            // 
            // BTN_AbrirFoto
            // 
            this.BTN_AbrirFoto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_AbrirFoto.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_AbrirFoto.Image = ((System.Drawing.Image)(resources.GetObject("BTN_AbrirFoto.Image")));
            this.BTN_AbrirFoto.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTN_AbrirFoto.Location = new System.Drawing.Point(239, 191);
            this.BTN_AbrirFoto.Name = "BTN_AbrirFoto";
            this.BTN_AbrirFoto.Size = new System.Drawing.Size(80, 26);
            this.BTN_AbrirFoto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_AbrirFoto.TabIndex = 2;
            this.BTN_AbrirFoto.Text = "&Abrir";
            this.BTN_AbrirFoto.Click += new System.EventHandler(this.BTN_CamaraAbrir_Click);
            // 
            // BTN_LimpiarFoto
            // 
            this.BTN_LimpiarFoto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_LimpiarFoto.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_LimpiarFoto.Image = ((System.Drawing.Image)(resources.GetObject("BTN_LimpiarFoto.Image")));
            this.BTN_LimpiarFoto.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTN_LimpiarFoto.Location = new System.Drawing.Point(122, 191);
            this.BTN_LimpiarFoto.Name = "BTN_LimpiarFoto";
            this.BTN_LimpiarFoto.Size = new System.Drawing.Size(91, 26);
            this.BTN_LimpiarFoto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_LimpiarFoto.TabIndex = 1;
            this.BTN_LimpiarFoto.Text = "L&impiar";
            this.BTN_LimpiarFoto.Click += new System.EventHandler(this.BTN_LimpiarFoto_Click);
            // 
            // BTN_CapturarFoto
            // 
            this.BTN_CapturarFoto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_CapturarFoto.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_CapturarFoto.Image = ((System.Drawing.Image)(resources.GetObject("BTN_CapturarFoto.Image")));
            this.BTN_CapturarFoto.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTN_CapturarFoto.Location = new System.Drawing.Point(11, 191);
            this.BTN_CapturarFoto.Name = "BTN_CapturarFoto";
            this.BTN_CapturarFoto.Size = new System.Drawing.Size(90, 26);
            this.BTN_CapturarFoto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_CapturarFoto.TabIndex = 0;
            this.BTN_CapturarFoto.Text = "C&apturar";
            this.BTN_CapturarFoto.Click += new System.EventHandler(this.BTN_CamaraCapturar_Click);
            // 
            // PCB_Fotografía
            // 
            this.PCB_Fotografía.Image = global::Eithan_System.Properties.Resources.NoImagen1;
            this.PCB_Fotografía.Location = new System.Drawing.Point(170, 15);
            this.PCB_Fotografía.Name = "PCB_Fotografía";
            this.PCB_Fotografía.Size = new System.Drawing.Size(160, 160);
            this.PCB_Fotografía.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PCB_Fotografía.TabIndex = 1;
            this.PCB_Fotografía.TabStop = false;
            // 
            // PCB_Camara
            // 
            this.PCB_Camara.Image = global::Eithan_System.Properties.Resources.NoImagen;
            this.PCB_Camara.Location = new System.Drawing.Point(11, 15);
            this.PCB_Camara.Name = "PCB_Camara";
            this.PCB_Camara.Size = new System.Drawing.Size(160, 160);
            this.PCB_Camara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PCB_Camara.TabIndex = 0;
            this.PCB_Camara.TabStop = false;
            this.PCB_Camara.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.PCB_Camara_LoadCompleted);
            // 
            // BTN_Limpiar
            // 
            this.BTN_Limpiar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_Limpiar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_Limpiar.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Limpiar.Image")));
            this.BTN_Limpiar.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTN_Limpiar.Location = new System.Drawing.Point(224, 268);
            this.BTN_Limpiar.Name = "BTN_Limpiar";
            this.BTN_Limpiar.Size = new System.Drawing.Size(81, 44);
            this.BTN_Limpiar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_Limpiar.TabIndex = 12;
            this.BTN_Limpiar.Text = "&Limpiar";
            // 
            // FRMPersona_Registrar
            // 
            this.AcceptButton = this.BTN_Grabar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_Salir;
            this.ClientSize = new System.Drawing.Size(670, 346);
            this.Controls.Add(this.GP_Panel_Persona);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMPersona_Registrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMPersona_Registrar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRMPersona_Registrar_FormClosing);
            this.Load += new System.EventHandler(this.FRMPersona_Registrar_Load);
            this.GP_Panel_Persona.ResumeLayout(false);
            this.GP_Fotografia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DTI_Nacimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCB_Fotografía)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCB_Camara)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel GP_Panel_Persona;
        private DevComponents.DotNetBar.Controls.SwitchButton SWB_Estado;
        private DevComponents.DotNetBar.Controls.SwitchButton SWB_Sexo;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput DTI_Nacimiento;
        private DevComponents.DotNetBar.Controls.TextBoxX TXT_ApellidoMaterno;
        private DevComponents.DotNetBar.Controls.TextBoxX TXT_Celular;
        private DevComponents.DotNetBar.Controls.TextBoxX TXT_Nombres;
        private DevComponents.DotNetBar.Controls.TextBoxX TXT_Correo;
        private DevComponents.DotNetBar.Controls.TextBoxX TXT_Direccion;
        private DevComponents.DotNetBar.Controls.TextBoxX TXT_ApellidoPaterno;
        private DevComponents.DotNetBar.Controls.TextBoxX TXT_CI;
        private DevComponents.DotNetBar.ButtonX BTN_Grabar;
        private DevComponents.DotNetBar.ButtonX BTN_Salir;
        private DevComponents.DotNetBar.ButtonX BTN_Limpiar;
        private DevComponents.DotNetBar.Controls.GroupPanel GP_Fotografia;
        private DevComponents.DotNetBar.ButtonX BTN_CapturarFoto;
        private System.Windows.Forms.PictureBox PCB_Fotografía;
        private System.Windows.Forms.PictureBox PCB_Camara;
        private DevComponents.DotNetBar.ButtonX BTN_AbrirFoto;
        private DevComponents.DotNetBar.ButtonX BTN_LimpiarFoto;
        private DevComponents.DotNetBar.BalloonTip BLT_Ayuda;
        private System.Windows.Forms.OpenFileDialog OFDElegirImagen;
    }
}