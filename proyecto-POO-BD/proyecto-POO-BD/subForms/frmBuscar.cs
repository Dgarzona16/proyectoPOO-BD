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

namespace proyecto_POO_BD.subForms
{
    public partial class frmBuscar : Form
    {
        public frmBuscar(FormTemplate completer)
        {
            InitializeComponent();
            completer.CmbItems.ForEach(x => cmbCatalogo.Items.Add(x));
            cmbCatalogo.Text = cmbCatalogo.Items[0].ToString();
        }
    }
}
