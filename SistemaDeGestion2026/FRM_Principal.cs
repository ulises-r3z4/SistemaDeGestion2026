using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeGestion2026
{
    public partial class FRM_Principal : DevComponents.DotNetBar.Office2007Form
    {
        public FRM_Principal()
        {
            InitializeComponent();
        }

        private void FRMPrincipal_Load(object sender, EventArgs e)
        {
            FRM_Splash banner = new FRM_Splash();
            banner.ShowDialog();
            this.Opacity = 1;
        }

        private void BTNPersonas_Click(object sender, EventArgs e)
        {
            foreach (Form s in this.MdiChildren)
            {
                s.Close();
            }
            FRM_Persona_Lista a = new FRM_Persona_Lista();
            a.MdiParent = this;
            a.Show();
        }
    }
}
