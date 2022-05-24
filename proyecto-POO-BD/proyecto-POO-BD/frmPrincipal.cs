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

namespace proyecto_POO_BD
{
    public partial class frmPrincipal : KryptonForm
    {
        bool eventPill = true;
        bool colectionPill = true;
        bool materialPill = true;
        bool reservePill = true;
        bool userPill = true;

        int mov;
        int movX;
        int movY;

        public frmPrincipal()
        {
            InitializeComponent();
        }
        //
        //Salir
        //
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //
        //Panel de Eventos
        //
        private void tmrEvento_Tick(object sender, EventArgs e)
        {
            if (eventPill)
            {
                pnlEventoContainer.Height += 10;
                if (pnlEventoContainer.Height == pnlEventoContainer.MaximumSize.Height)
                {
                    eventPill = false;
                    tmrEvento.Stop();
                }
                
            }
            else
            {
                pnlEventoContainer.Height -= 10;
                if (pnlEventoContainer.Height == pnlEventoContainer.MinimumSize.Height)
                {
                    eventPill = true;
                    tmrEvento.Stop();
                }
            }
        }
        private void btnEventos_Click(object sender, EventArgs e)
        {
            if (!colectionPill)
            {
                tmrColeccion.Start();
            }
            if (!materialPill)
            {
                tmrMaterial.Start();
            }
            if (!reservePill)
            {
                tmrReserva.Start();
            }
            if (!userPill)
            {
                tmrUser.Start();
            }
            tmrEvento.Start();
        }
        //
        //Panel de colecciones
        //
        private void tmrColeccion_Tick(object sender, EventArgs e)
        {
            if (colectionPill)
            {
                pnlColeccionContainer.Height += 10;
                if (pnlColeccionContainer.Height == pnlColeccionContainer.MaximumSize.Height)
                {
                    colectionPill = false;
                    tmrColeccion.Stop();
                }
            }
            else
            {
                pnlColeccionContainer.Height -= 10;
                if (pnlColeccionContainer.Height == pnlColeccionContainer.MinimumSize.Height)
                {
                    colectionPill = true;
                    tmrColeccion.Stop();
                }
            }
        }
        private void btnColecciones_Click(object sender, EventArgs e)
        {
            if (!eventPill)
            {
                tmrEvento.Start();
            }
            if (!materialPill)
            {
                tmrMaterial.Start();
            }
            if (!reservePill)
            {
                tmrReserva.Start();
            }
            if (!userPill)
            {
                tmrUser.Start();
            }
            tmrColeccion.Start();
        }
        //
        //Panel de Material
        //
        private void tmrMaterial_Tick(object sender, EventArgs e)
        {
            if (materialPill)
            {
                pnlMaterialContainer.Height += 10;
                if (pnlMaterialContainer.Height == pnlMaterialContainer.MaximumSize.Height)
                {
                    materialPill = false;
                    tmrMaterial.Stop();
                }
            }
            else
            {
                pnlMaterialContainer.Height -= 10;
                if (pnlMaterialContainer.Height == pnlMaterialContainer.MinimumSize.Height)
                {
                    materialPill = true;
                    tmrMaterial.Stop();
                }
            }
        }
        private void btnMaterial_Click(object sender, EventArgs e)
        {
            if (!eventPill)
            {
                tmrEvento.Start();
            }
            if (!colectionPill)
            {
                tmrColeccion.Start();
            }
            if (!reservePill)
            {
                tmrReserva.Start();
            }
            if (!userPill)
            {
                tmrUser.Start();
            }
            tmrMaterial.Start();
        }
        //
        //Panel de Reservas
        //
        private void tmrReserva_Tick(object sender, EventArgs e)
        {
            if (reservePill)
            {
                pnlReservaContainer.Height += 10;
                if (pnlReservaContainer.Height == pnlReservaContainer.MaximumSize.Height)
                {
                    reservePill = false;
                    tmrReserva.Stop();
                }
            }
            else
            {
                pnlReservaContainer.Height -= 10;
                if (pnlReservaContainer.Height == pnlReservaContainer.MinimumSize.Height)
                {
                    reservePill = true;
                    tmrReserva.Stop();
                }
            }
        }
        private void btnReserva_Click(object sender, EventArgs e)
        {
            if (!eventPill)
            {
                tmrEvento.Start();
            }
            if (!colectionPill)
            {
                tmrColeccion.Start();
            }
            if (!materialPill)
            {
                tmrMaterial.Start();
            }
            if (!userPill)
            {
                tmrUser.Start();
            }
            tmrReserva.Start();
        }
        //
        //Panel de Usuarios
        //
        private void tmrUser_Tick(object sender, EventArgs e)
        {
            if (userPill)
            {
                pnlUsuarioContainer.Height += 10;
                if (pnlUsuarioContainer.Height == pnlUsuarioContainer.MaximumSize.Height)
                {
                    userPill = false;
                    tmrUser.Stop();
                }
            }
            else
            {
                pnlUsuarioContainer.Height -= 10;
                if (pnlUsuarioContainer.Height == pnlUsuarioContainer.MinimumSize.Height)
                {
                    userPill = true;
                    tmrUser.Stop();
                }
            }
        }
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            if (!eventPill)
            {
                tmrEvento.Start();
            }
            if (!colectionPill)
            {
                tmrColeccion.Start();
            }
            if (!materialPill)
            {
                tmrMaterial.Start();
            }
            if (!reservePill)
            {
                tmrReserva.Start();
            }
            tmrUser.Start();
        }
        //
        //Minimizar
        //
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //
        //Mover
        //
        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }
        private void pnlHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }
        private void pnlHeader_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
        //
        //Cerrar Sesion
        //
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}