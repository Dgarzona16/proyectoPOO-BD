namespace proyecto_POO_BD.subForms
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
            ((System.ComponentModel.ISupportInitialize)(this.cmbCatalogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscador
            // 
            this.txtBuscador.Location = new System.Drawing.Point(12, 12);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(563, 23);
            this.txtBuscador.TabIndex = 0;
            // 
            // cmbCatalogo
            // 
            this.cmbCatalogo.DropDownWidth = 167;
            this.cmbCatalogo.Location = new System.Drawing.Point(597, 14);
            this.cmbCatalogo.Name = "cmbCatalogo";
            this.cmbCatalogo.Size = new System.Drawing.Size(167, 21);
            this.cmbCatalogo.TabIndex = 1;
            // 
            // frmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(843, 500);
            this.Controls.Add(this.cmbCatalogo);
            this.Controls.Add(this.txtBuscador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBuscar";
            this.Text = "frmBuscar";
            ((System.ComponentModel.ISupportInitialize)(this.cmbCatalogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtBuscador;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbCatalogo;
    }
}