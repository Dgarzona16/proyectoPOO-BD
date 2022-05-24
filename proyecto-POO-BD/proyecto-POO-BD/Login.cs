using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Data.SqlClient;
using proyecto_POO_BD.Properties;

namespace proyecto_POO_BD
{
    public partial class frmLogin : KryptonForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        //
        //Login
        //
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            CheckAdmin checkAdmin = new CheckAdmin();
            if (checkAdmin.Login(txtUsuario.Text, txtContraseña.Text))
            {
                frmPrincipal principal = new frmPrincipal();
                principal.Show();
                principal.FormClosed += LogOut;
                this.Hide();
            }
            else
            {
                lblError.Text = "Usuario o contraseña incorrectos";
                txtContraseña.Clear();
                txtUsuario.Focus();
            }
        }

        private void LogOut(object sender, EventArgs e)
        {
            txtContraseña.Clear();
            txtUsuario.Clear();
            lblError.Text = "";
            this.Show();
            txtUsuario.Focus();
        }
        //
        //PLACEHOLDER
        //
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Introduzca su Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Introduzca su Usuario";
                txtUsuario.ForeColor = Color.Silver;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Introduzca su Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Introduzca su Contraseña";
                txtContraseña.ForeColor = Color.Silver;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }
    }
}
