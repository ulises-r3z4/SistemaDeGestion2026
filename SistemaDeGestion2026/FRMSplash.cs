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
    public partial class FRMSplash : Form
    {        
        private bool bandera=false;
        public FRMSplash()
        {
            InitializeComponent();
        }

        private void FRMSplash_Load(object sender, EventArgs e)
        {
            TMRReloj.Enabled = true;
        }

        private void TMRReloj_Tick(object sender, EventArgs e)
        {
            if (!bandera && this.Opacity < 1)
            {            
                this.Opacity += 0.05;
            }
            if (this.Opacity == 1)
            {
                bandera = true;
            }
            if (bandera && this.Opacity > 0)
            {
                this.Opacity -= 0.05;
            }
            if (bandera && this.Opacity == 0)
            {
                this.Close();
            }
        }
    }
}
