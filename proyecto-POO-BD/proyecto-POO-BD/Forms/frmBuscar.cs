using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyecto_POO_BD.Properties;

namespace proyecto_POO_BD.Forms
{
    public partial class frmBuscar : Form
    {
        private FormTemplate consultor;
        public frmBuscar(FormTemplate completer)
        {
            InitializeComponent();
            completer.CmbItems.ForEach(x => cmbCatalogo.Items.Add(x));
            cmbCatalogo.Text = cmbCatalogo.Items[0].ToString();
            consultor = completer;
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            dtgvResultado.DataSource = consultor.consulta.consult(txtBuscador.Text, cmbCatalogo.Text);
        }
    }
}
