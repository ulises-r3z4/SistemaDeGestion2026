using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eithan_System
{
    public partial class FRM_Principal : Form
    {
        public FRM_Principal()
        {
            InitializeComponent();
        }

        private void FRM_Principal_Load(object sender, EventArgs e)
        {
            FRM_Splash banner = new FRM_Splash();
            banner.ShowDialog();
            this.Opacity = 1;
        }

        private void BTN_Personas_Click(object sender, EventArgs e)
        {
            foreach ( Form s in this.MdiChildren )
            {
                s.Close();
            }
            FRM_Persona_Lista a = new FRM_Persona_Lista();
            a.MdiParent = this;
            a.Show();
        }

        private void BTN_Usuarios_Click(object sender, EventArgs e)
        {
            foreach (Form s in this.MdiChildren)
            {
                s.Close();
            }
            FRMUsuarioLista a = new FRMUsuarioLista();
            a.MdiParent = this;
            a.Show();
        }

        private void BTNLogin_Click(object sender, EventArgs e)
        {
            FRM_IniciarSesion a = new FRM_IniciarSesion();
            a.ShowDialog();
        }
    }
}
