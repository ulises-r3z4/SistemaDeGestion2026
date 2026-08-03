namespace SistemaDeGestion2026
{
    partial class FRMUsuario_Lista
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DTGLista = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EPNFiltrar = new DevComponents.DotNetBar.ExpandablePanel();
            this.BTNFiltrar = new DevComponents.DotNetBar.ButtonX();
            this.TXTFiltrar = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.IINFilas = new DevComponents.Editors.IntegerInput();
            this.EPNOpciones = new DevComponents.DotNetBar.ExpandablePanel();
            this.BTNActualizarPassword = new DevComponents.DotNetBar.ButtonX();
            this.BTNReporte = new DevComponents.DotNetBar.ButtonX();
            this.BTNModificar = new DevComponents.DotNetBar.ButtonX();
            this.BTNRegistrar = new DevComponents.DotNetBar.ButtonX();
            this.CMSMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habilitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DTGLista)).BeginInit();
            this.EPNFiltrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IINFilas)).BeginInit();
            this.EPNOpciones.SuspendLayout();
            this.CMSMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // DTGLista
            // 
            this.DTGLista.AllowUserToAddRows = false;
            this.DTGLista.AllowUserToDeleteRows = false;
            this.DTGLista.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DTGLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.DTGLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.PaleGoldenrod;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DTGLista.DefaultCellStyle = dataGridViewCellStyle14;
            this.DTGLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTGLista.EnableHeadersVisualStyles = false;
            this.DTGLista.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DTGLista.Location = new System.Drawing.Point(94, 73);
            this.DTGLista.MultiSelect = false;
            this.DTGLista.Name = "DTGLista";
            this.DTGLista.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DTGLista.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.DTGLista.RowHeadersWidth = 51;
            this.DTGLista.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.DTGLista.RowTemplate.Height = 24;
            this.DTGLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTGLista.Size = new System.Drawing.Size(843, 412);
            this.DTGLista.TabIndex = 17;
            this.DTGLista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGLista_CellDoubleClick);
            // 
            // Column1
            // 
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle12;
            this.Column1.HeaderText = "Codigo";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.Checked = true;
            this.Column2.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.Column2.CheckValue = "N";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle13;
            this.Column2.HeaderText = "Est.";
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
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nombre Completo";
            this.Column4.MinimumWidth = 400;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 400;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Login";
            this.Column5.MinimumWidth = 120;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 120;
            // 
            // EPNFiltrar
            // 
            this.EPNFiltrar.CanvasColor = System.Drawing.SystemColors.Control;
            this.EPNFiltrar.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.EPNFiltrar.Controls.Add(this.BTNFiltrar);
            this.EPNFiltrar.Controls.Add(this.TXTFiltrar);
            this.EPNFiltrar.Controls.Add(this.IINFilas);
            this.EPNFiltrar.DisabledBackColor = System.Drawing.Color.Empty;
            this.EPNFiltrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.EPNFiltrar.HideControlsWhenCollapsed = true;
            this.EPNFiltrar.Location = new System.Drawing.Point(94, 0);
            this.EPNFiltrar.Name = "EPNFiltrar";
            this.EPNFiltrar.Size = new System.Drawing.Size(843, 73);
            this.EPNFiltrar.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.EPNFiltrar.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.EPNFiltrar.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.EPNFiltrar.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.EPNFiltrar.Style.GradientAngle = 90;
            this.EPNFiltrar.TabIndex = 16;
            this.EPNFiltrar.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.EPNFiltrar.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.EPNFiltrar.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.EPNFiltrar.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.EPNFiltrar.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.EPNFiltrar.TitleStyle.GradientAngle = 90;
            this.EPNFiltrar.TitleText = "Filtrar";
            // 
            // BTNFiltrar
            // 
            this.BTNFiltrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNFiltrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNFiltrar.Image = global::SistemaDeGestion2026.Properties.Resources.ic_buscar;
            this.BTNFiltrar.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.BTNFiltrar.Location = new System.Drawing.Point(295, 41);
            this.BTNFiltrar.Name = "BTNFiltrar";
            this.BTNFiltrar.Size = new System.Drawing.Size(27, 26);
            this.BTNFiltrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNFiltrar.TabIndex = 6;
            this.BTNFiltrar.Click += new System.EventHandler(this.BTNFiltrar_Click);
            // 
            // TXTFiltrar
            // 
            this.TXTFiltrar.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TXTFiltrar.Border.Class = "TextBoxBorder";
            this.TXTFiltrar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTFiltrar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTFiltrar.DisabledBackColor = System.Drawing.Color.White;
            this.TXTFiltrar.ForeColor = System.Drawing.Color.Black;
            this.TXTFiltrar.Location = new System.Drawing.Point(93, 41);
            this.TXTFiltrar.Name = "TXTFiltrar";
            this.TXTFiltrar.PreventEnterBeep = true;
            this.TXTFiltrar.Size = new System.Drawing.Size(196, 26);
            this.TXTFiltrar.TabIndex = 5;
            this.TXTFiltrar.WatermarkText = "Datos a buscar...";
            this.TXTFiltrar.Enter += new System.EventHandler(this.TXTFiltrar_Enter);
            // 
            // IINFilas
            // 
            // 
            // 
            // 
            this.IINFilas.BackgroundStyle.Class = "DateTimeInputBackground";
            this.IINFilas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.IINFilas.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.IINFilas.Increment = 10;
            this.IINFilas.Location = new System.Drawing.Point(6, 41);
            this.IINFilas.MaxValue = 1000;
            this.IINFilas.MinValue = 0;
            this.IINFilas.Name = "IINFilas";
            this.IINFilas.ShowUpDown = true;
            this.IINFilas.Size = new System.Drawing.Size(80, 26);
            this.IINFilas.TabIndex = 4;
            this.IINFilas.Value = 50;
            // 
            // EPNOpciones
            // 
            this.EPNOpciones.CanvasColor = System.Drawing.SystemColors.Control;
            this.EPNOpciones.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft;
            this.EPNOpciones.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.EPNOpciones.Controls.Add(this.BTNActualizarPassword);
            this.EPNOpciones.Controls.Add(this.BTNReporte);
            this.EPNOpciones.Controls.Add(this.BTNModificar);
            this.EPNOpciones.Controls.Add(this.BTNRegistrar);
            this.EPNOpciones.DisabledBackColor = System.Drawing.Color.Empty;
            this.EPNOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.EPNOpciones.HideControlsWhenCollapsed = true;
            this.EPNOpciones.Location = new System.Drawing.Point(0, 0);
            this.EPNOpciones.Margin = new System.Windows.Forms.Padding(4);
            this.EPNOpciones.Name = "EPNOpciones";
            this.EPNOpciones.Size = new System.Drawing.Size(94, 485);
            this.EPNOpciones.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.EPNOpciones.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.EPNOpciones.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.EPNOpciones.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.EPNOpciones.Style.GradientAngle = 90;
            this.EPNOpciones.TabIndex = 15;
            this.EPNOpciones.TitleHeight = 32;
            this.EPNOpciones.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.EPNOpciones.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.EPNOpciones.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.EPNOpciones.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.EPNOpciones.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.EPNOpciones.TitleStyle.GradientAngle = 90;
            this.EPNOpciones.TitleText = "Menú";
            // 
            // BTNActualizarPassword
            // 
            this.BTNActualizarPassword.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNActualizarPassword.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNActualizarPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTNActualizarPassword.Image = global::SistemaDeGestion2026.Properties.Resources.ic_usuario_cambiar_password;
            this.BTNActualizarPassword.ImageFixedSize = new System.Drawing.Size(60, 60);
            this.BTNActualizarPassword.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTNActualizarPassword.Location = new System.Drawing.Point(0, 365);
            this.BTNActualizarPassword.Name = "BTNActualizarPassword";
            this.BTNActualizarPassword.Size = new System.Drawing.Size(94, 111);
            this.BTNActualizarPassword.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNActualizarPassword.TabIndex = 7;
            this.BTNActualizarPassword.Text = "&Actualizar Password";
            // 
            // BTNReporte
            // 
            this.BTNReporte.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNReporte.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNReporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTNReporte.Image = global::SistemaDeGestion2026.Properties.Resources.ic_usuario_reporte;
            this.BTNReporte.ImageFixedSize = new System.Drawing.Size(60, 60);
            this.BTNReporte.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTNReporte.Location = new System.Drawing.Point(0, 254);
            this.BTNReporte.Name = "BTNReporte";
            this.BTNReporte.Size = new System.Drawing.Size(94, 111);
            this.BTNReporte.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNReporte.TabIndex = 6;
            this.BTNReporte.Text = "&Reporte";
            this.BTNReporte.Click += new System.EventHandler(this.BTNReporte_Click);
            // 
            // BTNModificar
            // 
            this.BTNModificar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNModificar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNModificar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTNModificar.Image = global::SistemaDeGestion2026.Properties.Resources.ic_usuario_modificar;
            this.BTNModificar.ImageFixedSize = new System.Drawing.Size(60, 60);
            this.BTNModificar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTNModificar.Location = new System.Drawing.Point(0, 143);
            this.BTNModificar.Name = "BTNModificar";
            this.BTNModificar.Size = new System.Drawing.Size(94, 111);
            this.BTNModificar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNModificar.TabIndex = 5;
            this.BTNModificar.Text = "&Modificar";
            this.BTNModificar.Click += new System.EventHandler(this.BTNModificar_Click);
            // 
            // BTNRegistrar
            // 
            this.BTNRegistrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNRegistrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNRegistrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTNRegistrar.Image = global::SistemaDeGestion2026.Properties.Resources.ic_usuario_nuevo;
            this.BTNRegistrar.ImageFixedSize = new System.Drawing.Size(60, 60);
            this.BTNRegistrar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTNRegistrar.Location = new System.Drawing.Point(0, 32);
            this.BTNRegistrar.Name = "BTNRegistrar";
            this.BTNRegistrar.Size = new System.Drawing.Size(94, 111);
            this.BTNRegistrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNRegistrar.TabIndex = 4;
            this.BTNRegistrar.Text = "&Registrar";
            this.BTNRegistrar.Click += new System.EventHandler(this.BTNRegistrar_Click);
            // 
            // CMSMenu
            // 
            this.CMSMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CMSMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.habilitarToolStripMenuItem});
            this.CMSMenu.Name = "CMSMenu";
            this.CMSMenu.Size = new System.Drawing.Size(146, 76);
            this.CMSMenu.Opening += new System.ComponentModel.CancelEventHandler(this.CMSMenu_Opening);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.modificarToolStripMenuItem.Text = "&Modificar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.eliminarToolStripMenuItem.Text = "&Inhabilitar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // habilitarToolStripMenuItem
            // 
            this.habilitarToolStripMenuItem.Name = "habilitarToolStripMenuItem";
            this.habilitarToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.habilitarToolStripMenuItem.Text = "&Habilitar";
            this.habilitarToolStripMenuItem.Click += new System.EventHandler(this.habilitarToolStripMenuItem_Click);
            // 
            // FRMUsuario_Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 485);
            this.Controls.Add(this.DTGLista);
            this.Controls.Add(this.EPNFiltrar);
            this.Controls.Add(this.EPNOpciones);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMUsuario_Lista";
            this.Text = "FRMUsuario_Lista";
            this.Load += new System.EventHandler(this.FRMUsuario_Lista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGLista)).EndInit();
            this.EPNFiltrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IINFilas)).EndInit();
            this.EPNOpciones.ResumeLayout(false);
            this.CMSMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX DTGLista;
        private DevComponents.DotNetBar.ExpandablePanel EPNFiltrar;
        private DevComponents.DotNetBar.ButtonX BTNFiltrar;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTFiltrar;
        private DevComponents.Editors.IntegerInput IINFilas;
        private DevComponents.DotNetBar.ExpandablePanel EPNOpciones;
        private DevComponents.DotNetBar.ButtonX BTNReporte;
        private DevComponents.DotNetBar.ButtonX BTNModificar;
        private DevComponents.DotNetBar.ButtonX BTNRegistrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private DevComponents.DotNetBar.ButtonX BTNActualizarPassword;
        private System.Windows.Forms.ContextMenuStrip CMSMenu;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habilitarToolStripMenuItem;
    }
}