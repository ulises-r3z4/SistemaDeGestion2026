namespace SistemaDeGestion2026
{
    partial class FRMPersona_Buscar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DTGLista = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EPNFiltrar = new DevComponents.DotNetBar.ExpandablePanel();
            this.TXTFiltrar = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.IINFilas = new DevComponents.Editors.IntegerInput();
            this.BTNAceptar = new DevComponents.DotNetBar.ButtonX();
            this.BTNAgregarPersona = new DevComponents.DotNetBar.ButtonX();
            this.BTNFiltrar = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.DTGLista)).BeginInit();
            this.EPNFiltrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IINFilas)).BeginInit();
            this.SuspendLayout();
            // 
            // DTGLista
            // 
            this.DTGLista.AllowUserToAddRows = false;
            this.DTGLista.AllowUserToDeleteRows = false;
            this.DTGLista.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DTGLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DTGLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.PaleGoldenrod;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DTGLista.DefaultCellStyle = dataGridViewCellStyle13;
            this.DTGLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTGLista.EnableHeadersVisualStyles = false;
            this.DTGLista.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(157)))));
            this.DTGLista.Location = new System.Drawing.Point(0, 73);
            this.DTGLista.MultiSelect = false;
            this.DTGLista.Name = "DTGLista";
            this.DTGLista.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DTGLista.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.DTGLista.RowHeadersWidth = 51;
            this.DTGLista.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.DTGLista.RowTemplate.Height = 24;
            this.DTGLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTGLista.Size = new System.Drawing.Size(712, 312);
            this.DTGLista.TabIndex = 13;
            this.DTGLista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGLista_CellDoubleClick);
            // 
            // Column1
            // 
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle9;
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle10;
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
            this.Column4.HeaderText = "Ape. Pat.";
            this.Column4.MinimumWidth = 120;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 120;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ape. Mat.";
            this.Column5.MinimumWidth = 120;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 120;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Nombres";
            this.Column6.MinimumWidth = 180;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 180;
            // 
            // Column7
            // 
            dataGridViewCellStyle11.Format = "d";
            dataGridViewCellStyle11.NullValue = null;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle11;
            this.Column7.HeaderText = "Fec. Nac. ";
            this.Column7.MinimumWidth = 110;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 110;
            // 
            // Column8
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column8.DefaultCellStyle = dataGridViewCellStyle12;
            this.Column8.HeaderText = "Sexo";
            this.Column8.MinimumWidth = 60;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 60;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Celular";
            this.Column9.MinimumWidth = 80;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 80;
            // 
            // EPNFiltrar
            // 
            this.EPNFiltrar.CanvasColor = System.Drawing.SystemColors.Control;
            this.EPNFiltrar.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.EPNFiltrar.Controls.Add(this.BTNAceptar);
            this.EPNFiltrar.Controls.Add(this.BTNAgregarPersona);
            this.EPNFiltrar.Controls.Add(this.BTNFiltrar);
            this.EPNFiltrar.Controls.Add(this.TXTFiltrar);
            this.EPNFiltrar.Controls.Add(this.IINFilas);
            this.EPNFiltrar.DisabledBackColor = System.Drawing.Color.Empty;
            this.EPNFiltrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.EPNFiltrar.HideControlsWhenCollapsed = true;
            this.EPNFiltrar.Location = new System.Drawing.Point(0, 0);
            this.EPNFiltrar.Name = "EPNFiltrar";
            this.EPNFiltrar.Size = new System.Drawing.Size(712, 73);
            this.EPNFiltrar.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.EPNFiltrar.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.EPNFiltrar.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.EPNFiltrar.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.EPNFiltrar.Style.GradientAngle = 90;
            this.EPNFiltrar.TabIndex = 12;
            this.EPNFiltrar.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.EPNFiltrar.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.EPNFiltrar.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.EPNFiltrar.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.EPNFiltrar.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.EPNFiltrar.TitleStyle.GradientAngle = 90;
            this.EPNFiltrar.TitleText = "Filtrar";
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
            // BTNAceptar
            // 
            this.BTNAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTNAceptar.Image = global::SistemaDeGestion2026.Properties.Resources.ic_ok;
            this.BTNAceptar.ImageFixedSize = new System.Drawing.Size(15, 15);
            this.BTNAceptar.Location = new System.Drawing.Point(361, 41);
            this.BTNAceptar.Name = "BTNAceptar";
            this.BTNAceptar.Size = new System.Drawing.Size(27, 26);
            this.BTNAceptar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNAceptar.TabIndex = 17;
            this.BTNAceptar.Click += new System.EventHandler(this.BTNAceptar_Click);
            // 
            // BTNAgregarPersona
            // 
            this.BTNAgregarPersona.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNAgregarPersona.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNAgregarPersona.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTNAgregarPersona.Image = global::SistemaDeGestion2026.Properties.Resources.ic_agregar;
            this.BTNAgregarPersona.ImageFixedSize = new System.Drawing.Size(15, 15);
            this.BTNAgregarPersona.Location = new System.Drawing.Point(328, 41);
            this.BTNAgregarPersona.Name = "BTNAgregarPersona";
            this.BTNAgregarPersona.Size = new System.Drawing.Size(27, 26);
            this.BTNAgregarPersona.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNAgregarPersona.TabIndex = 16;
            this.BTNAgregarPersona.Click += new System.EventHandler(this.BTNAgregarPersona_Click);
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
            // FRMPersona_Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 385);
            this.Controls.Add(this.DTGLista);
            this.Controls.Add(this.EPNFiltrar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMPersona_Buscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMPersona_Buscar";
            this.Load += new System.EventHandler(this.FRMPersona_Buscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGLista)).EndInit();
            this.EPNFiltrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IINFilas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX DTGLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private DevComponents.DotNetBar.ExpandablePanel EPNFiltrar;
        private DevComponents.DotNetBar.ButtonX BTNFiltrar;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTFiltrar;
        private DevComponents.Editors.IntegerInput IINFilas;
        private DevComponents.DotNetBar.ButtonX BTNAgregarPersona;
        private DevComponents.DotNetBar.ButtonX BTNAceptar;
    }
}