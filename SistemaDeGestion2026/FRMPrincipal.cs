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
    public partial class FRMPrincipal : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public FRMPrincipal()
        {
            InitializeComponent();
        }

        private void FRMPrincipal_Load(object sender, EventArgs e)
        {
            FRMSplash banner = new FRMSplash();
            banner.ShowDialog();
            this.Opacity = 1;
        }

        private void BTNPersonas_Click(object sender, EventArgs e)
        {
            foreach (Form s in this.MdiChildren)
            {
                s.Close();
            }
            FRMPersona_Lista a = new FRMPersona_Lista();
            a.MdiParent = this;
            a.Show();
        }
    }
}
