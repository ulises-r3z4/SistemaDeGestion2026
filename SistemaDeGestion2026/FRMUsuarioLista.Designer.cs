namespace Eithan_System
{
    partial class FRMUsuarioLista
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMUsuarioLista));
            this.DTG_Lista = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Completo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EPN_Filtrar = new DevComponents.DotNetBar.ExpandablePanel();
            this.BTN_Buscar = new DevComponents.DotNetBar.ButtonX();
            this.TXT_Filtrar = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.IIN_Filas = new DevComponents.Editors.IntegerInput();
            this.EPN_Opciones = new DevComponents.DotNetBar.ExpandablePanel();
            this.BTN_Password = new DevComponents.DotNetBar.ButtonX();
            this.BTN_Reporte = new DevComponents.DotNetBar.ButtonX();
            this.BTN_Modificar = new DevComponents.DotNetBar.ButtonX();
            this.BTN_Registrar = new DevComponents.DotNetBar.ButtonX();
            this.CMSMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inhabilitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habilitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_Lista)).BeginInit();
            this.EPN_Filtrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IIN_Filas)).BeginInit();
            this.EPN_Opciones.SuspendLayout();
            this.CMSMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // DTG_Lista
            // 
            this.DTG_Lista.AllowUserToAddRows = false;
            this.DTG_Lista.AllowUserToDeleteRows = false;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DTG_Lista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.DTG_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTG_Lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Nombre_Completo,
            this.Login});
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DTG_Lista.DefaultCellStyle = dataGridViewCellStyle19;
            this.DTG_Lista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTG_Lista.EnableHeadersVisualStyles = false;
            this.DTG_Lista.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DTG_Lista.Location = new System.Drawing.Point(72, 99);
            this.DTG_Lista.MultiSelect = false;
            this.DTG_Lista.Name = "DTG_Lista";
            this.DTG_Lista.ReadOnly = true;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DTG_Lista.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.DTG_Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTG_Lista.Size = new System.Drawing.Size(723, 375);
            this.DTG_Lista.TabIndex = 19;
            this.DTG_Lista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTG_Lista_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.Checked = true;
            this.Column2.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.Column2.CheckValue = null;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle18;
            this.Column2.HeaderText = "Estado";
            this.Column2.MinimumWidth = 60;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 60;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Documento";
            this.Column3.MinimumWidth = 100;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Nombre_Completo
            // 
            this.Nombre_Completo.HeaderText = "Nombre Completo";
            this.Nombre_Completo.MinimumWidth = 200;
            this.Nombre_Completo.Name = "Nombre_Completo";
            this.Nombre_Completo.ReadOnly = true;
            this.Nombre_Completo.Width = 400;
            // 
            // Login
            // 
            this.Login.HeaderText = "Login";
            this.Login.MinimumWidth = 120;
            this.Login.Name = "Login";
            this.Login.ReadOnly = true;
            this.Login.Width = 120;
            // 
            // EPN_Filtrar
            // 
            this.EPN_Filtrar.CanvasColor = System.Drawing.SystemColors.Control;
            this.EPN_Filtrar.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.EPN_Filtrar.Controls.Add(this.BTN_Buscar);
            this.EPN_Filtrar.Controls.Add(this.TXT_Filtrar);
            this.EPN_Filtrar.Controls.Add(this.IIN_Filas);
            this.EPN_Filtrar.DisabledBackColor = System.Drawing.Color.Empty;
            this.EPN_Filtrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.EPN_Filtrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EPN_Filtrar.HideControlsWhenCollapsed = true;
            this.EPN_Filtrar.Location = new System.Drawing.Point(72, 0);
            this.EPN_Filtrar.Name = "EPN_Filtrar";
            this.EPN_Filtrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EPN_Filtrar.Size = new System.Drawing.Size(723, 99);
            this.EPN_Filtrar.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.EPN_Filtrar.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.EPN_Filtrar.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.EPN_Filtrar.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.EPN_Filtrar.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.EPN_Filtrar.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.EPN_Filtrar.Style.GradientAngle = 90;
            this.EPN_Filtrar.TabIndex = 18;
            this.EPN_Filtrar.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.EPN_Filtrar.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.EPN_Filtrar.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.EPN_Filtrar.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.EPN_Filtrar.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.EPN_Filtrar.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.EPN_Filtrar.TitleStyle.GradientAngle = 90;
            this.EPN_Filtrar.TitleStyleMouseOver.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EPN_Filtrar.TitleText = "Filtrar";
            // 
            // BTN_Buscar
            // 
            this.BTN_Buscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_Buscar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_Buscar.Image = global::Eithan_System.Properties.Resources.icono_buscar;
            this.BTN_Buscar.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.BTN_Buscar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTN_Buscar.Location = new System.Drawing.Point(278, 50);
            this.BTN_Buscar.Name = "BTN_Buscar";
            this.BTN_Buscar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Buscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_Buscar.TabIndex = 6;
            this.BTN_Buscar.Click += new System.EventHandler(this.BTN_Buscar_Click);
            // 
            // TXT_Filtrar
            // 
            // 
            // 
            // 
            this.TXT_Filtrar.Border.Class = "TextBoxBorder";
            this.TXT_Filtrar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXT_Filtrar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXT_Filtrar.Location = new System.Drawing.Point(92, 50);
            this.TXT_Filtrar.Name = "TXT_Filtrar";
            this.TXT_Filtrar.PreventEnterBeep = true;
            this.TXT_Filtrar.Size = new System.Drawing.Size(159, 23);
            this.TXT_Filtrar.TabIndex = 5;
            this.TXT_Filtrar.WatermarkText = "Datos a Buscar...";
            this.TXT_Filtrar.Enter += new System.EventHandler(this.TXT_Filtrar_Enter);
            // 
            // IIN_Filas
            // 
            // 
            // 
            // 
            this.IIN_Filas.BackgroundStyle.Class = "DateTimeInputBackground";
            this.IIN_Filas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.IIN_Filas.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.IIN_Filas.Increment = 10;
            this.IIN_Filas.Location = new System.Drawing.Point(6, 50);
            this.IIN_Filas.MaxValue = 1000;
            this.IIN_Filas.MinValue = 0;
            this.IIN_Filas.Name = "IIN_Filas";
            this.IIN_Filas.ShowUpDown = true;
            this.IIN_Filas.Size = new System.Drawing.Size(80, 23);
            this.IIN_Filas.TabIndex = 4;
            this.IIN_Filas.Value = 50;
            // 
            // EPN_Opciones
            // 
            this.EPN_Opciones.CanvasColor = System.Drawing.SystemColors.Control;
            this.EPN_Opciones.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft;
            this.EPN_Opciones.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.EPN_Opciones.Controls.Add(this.BTN_Password);
            this.EPN_Opciones.Controls.Add(this.BTN_Reporte);
            this.EPN_Opciones.Controls.Add(this.BTN_Modificar);
            this.EPN_Opciones.Controls.Add(this.BTN_Registrar);
            this.EPN_Opciones.DisabledBackColor = System.Drawing.Color.Empty;
            this.EPN_Opciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.EPN_Opciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EPN_Opciones.HideControlsWhenCollapsed = true;
            this.EPN_Opciones.Location = new System.Drawing.Point(0, 0);
            this.EPN_Opciones.Name = "EPN_Opciones";
            this.EPN_Opciones.Size = new System.Drawing.Size(72, 474);
            this.EPN_Opciones.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.EPN_Opciones.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.EPN_Opciones.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.EPN_Opciones.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.EPN_Opciones.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.EPN_Opciones.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.EPN_Opciones.Style.GradientAngle = 90;
            this.EPN_Opciones.TabIndex = 17;
            this.EPN_Opciones.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.EPN_Opciones.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.EPN_Opciones.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.EPN_Opciones.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.EPN_Opciones.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.EPN_Opciones.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.EPN_Opciones.TitleStyle.GradientAngle = 90;
            this.EPN_Opciones.TitleStyleMouseDown.BackColor1.Color = System.Drawing.Color.Transparent;
            this.EPN_Opciones.TitleText = "Opciones";
            // 
            // BTN_Password
            // 
            this.BTN_Password.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_Password.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_Password.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Password.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Password.Image")));
            this.BTN_Password.ImageFixedSize = new System.Drawing.Size(60, 60);
            this.BTN_Password.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTN_Password.Location = new System.Drawing.Point(0, 267);
            this.BTN_Password.Name = "BTN_Password";
            this.BTN_Password.Size = new System.Drawing.Size(72, 81);
            this.BTN_Password.TabIndex = 7;
            this.BTN_Password.Text = "&Contraseña";
            // 
            // BTN_Reporte
            // 
            this.BTN_Reporte.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_Reporte.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_Reporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Reporte.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Reporte.Image")));
            this.BTN_Reporte.ImageFixedSize = new System.Drawing.Size(60, 60);
            this.BTN_Reporte.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTN_Reporte.Location = new System.Drawing.Point(0, 186);
            this.BTN_Reporte.Name = "BTN_Reporte";
            this.BTN_Reporte.Size = new System.Drawing.Size(72, 81);
            this.BTN_Reporte.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_Reporte.TabIndex = 6;
            this.BTN_Reporte.Text = "Reporte";
         
            // 
            // BTN_Modificar
            // 
            this.BTN_Modificar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_Modificar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_Modificar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Modificar.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Modificar.Image")));
            this.BTN_Modificar.ImageFixedSize = new System.Drawing.Size(60, 60);
            this.BTN_Modificar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTN_Modificar.Location = new System.Drawing.Point(0, 106);
            this.BTN_Modificar.Name = "BTN_Modificar";
            this.BTN_Modificar.Size = new System.Drawing.Size(72, 80);
            this.BTN_Modificar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_Modificar.TabIndex = 5;
            this.BTN_Modificar.Text = "Modificar ";
            this.BTN_Modificar.Click += new System.EventHandler(this.BTN_Modificar_Click);
            // 
            // BTN_Registrar
            // 
            this.BTN_Registrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_Registrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_Registrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Registrar.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Registrar.Image")));
            this.BTN_Registrar.ImageFixedSize = new System.Drawing.Size(60, 60);
            this.BTN_Registrar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTN_Registrar.Location = new System.Drawing.Point(0, 26);
            this.BTN_Registrar.Name = "BTN_Registrar";
            this.BTN_Registrar.Size = new System.Drawing.Size(72, 80);
            this.BTN_Registrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_Registrar.TabIndex = 4;
            this.BTN_Registrar.Text = "Registrar ";
            this.BTN_Registrar.Click += new System.EventHandler(this.BTN_Registrar_Click);
            // 
            // CMSMenu
            // 
            this.CMSMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarToolStripMenuItem,
            this.inhabilitarToolStripMenuItem,
            this.habilitarToolStripMenuItem});
            this.CMSMenu.Name = "CMSMenu";
            this.CMSMenu.Size = new System.Drawing.Size(128, 70);
            this.CMSMenu.Opening += new System.ComponentModel.CancelEventHandler(this.CMSMenu_Opening);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificarToolStripMenuItem.Text = "&Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // inhabilitarToolStripMenuItem
            // 
            this.inhabilitarToolStripMenuItem.Name = "inhabilitarToolStripMenuItem";
            this.inhabilitarToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.inhabilitarToolStripMenuItem.Text = "&Inhabilitar";
            this.inhabilitarToolStripMenuItem.Click += new System.EventHandler(this.inhabilitarToolStripMenuItem_Click);
            // 
            // habilitarToolStripMenuItem
            // 
            this.habilitarToolStripMenuItem.Name = "habilitarToolStripMenuItem";
            this.habilitarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.habilitarToolStripMenuItem.Text = "&Habilitar";
            this.habilitarToolStripMenuItem.Click += new System.EventHandler(this.habilitarToolStripMenuItem_Click);
            // 
            // FRMUsuarioLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 474);
            this.Controls.Add(this.DTG_Lista);
            this.Controls.Add(this.EPN_Filtrar);
            this.Controls.Add(this.EPN_Opciones);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMUsuarioLista";
            this.Text = "FRMUsuarioLista";
            this.Load += new System.EventHandler(this.FRMUsuarioLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTG_Lista)).EndInit();
            this.EPN_Filtrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IIN_Filas)).EndInit();
            this.EPN_Opciones.ResumeLayout(false);
            this.CMSMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX DTG_Lista;
        private DevComponents.DotNetBar.ExpandablePanel EPN_Filtrar;
        private DevComponents.DotNetBar.ButtonX BTN_Buscar;
        private DevComponents.DotNetBar.Controls.TextBoxX TXT_Filtrar;
        private DevComponents.Editors.IntegerInput IIN_Filas;
        private DevComponents.DotNetBar.ExpandablePanel EPN_Opciones;
        private DevComponents.DotNetBar.ButtonX BTN_Reporte;
        private DevComponents.DotNetBar.ButtonX BTN_Modificar;
        private DevComponents.DotNetBar.ButtonX BTN_Registrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Completo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private DevComponents.DotNetBar.ButtonX BTN_Password;
        private System.Windows.Forms.ContextMenuStrip CMSMenu;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inhabilitarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habilitarToolStripMenuItem;
    }
}