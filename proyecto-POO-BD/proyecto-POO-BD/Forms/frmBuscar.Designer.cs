namespace proyecto_POO_BD.Forms
{
    partial class frmBuscar
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
            this.txtBuscador = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cmbCatalogo = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.dtgvResultado = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscador
            // 
            this.txtBuscador.Location = new System.Drawing.Point(12, 24);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(563, 23);
            this.txtBuscador.TabIndex = 0;
            this.txtBuscador.TextChanged += new System.EventHandler(this.txtBuscador_TextChanged);
            // 
            // cmbCatalogo
            // 
            this.cmbCatalogo.DropDownWidth = 167;
            this.cmbCatalogo.Location = new System.Drawing.Point(612, 26);
            this.cmbCatalogo.Name = "cmbCatalogo";
            this.cmbCatalogo.Size = new System.Drawing.Size(167, 23);
            this.cmbCatalogo.StateActive.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.cmbCatalogo.StateActive.ComboBox.Content.Color1 = System.Drawing.Color.White;
            this.cmbCatalogo.StateActive.ComboBox.Content.Font = new System.Drawing.Font("Fira Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCatalogo.StateNormal.ComboBox.Content.Font = new System.Drawing.Font("Fira Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCatalogo.StateNormal.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.cmbCatalogo.StateNormal.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.cmbCatalogo.StateTracking.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.cmbCatalogo.StateTracking.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.cmbCatalogo.StateTracking.Item.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.cmbCatalogo.StateTracking.Item.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.cmbCatalogo.StateTracking.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbCatalogo.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.cmbCatalogo.StateTracking.Item.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.cmbCatalogo.TabIndex = 1;
            // 
            // dtgvResultado
            // 
            this.dtgvResultado.AllowUserToAddRows = false;
            this.dtgvResultado.AllowUserToDeleteRows = false;
            this.dtgvResultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvResultado.Location = new System.Drawing.Point(12, 82);
            this.dtgvResultado.Name = "dtgvResultado";
            this.dtgvResultado.ReadOnly = true;
            this.dtgvResultado.Size = new System.Drawing.Size(801, 392);
            this.dtgvResultado.StateNormal.HeaderRow.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.dtgvResultado.StateNormal.HeaderRow.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.dtgvResultado.TabIndex = 2;
            // 
            // frmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(843, 500);
            this.Controls.Add(this.dtgvResultado);
            this.Controls.Add(this.cmbCatalogo);
            this.Controls.Add(this.txtBuscador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBuscar";
            this.Text = "frmBuscar";
            this.Load += new System.EventHandler(this.frmBuscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtBuscador;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbCatalogo;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dtgvResultado;
    }
}