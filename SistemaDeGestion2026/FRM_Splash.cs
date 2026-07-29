using System;
using System.Windows.Forms;

namespace Eithan_System
{
    public partial class FRM_Splash : Form
    {
        private bool bandera = false;
        public FRM_Splash()
        {
            InitializeComponent();
        }

        private void FRM_Splash_Load(object sender, EventArgs e)
        {
            TMR_reloj1.Enabled = true;
        }

        private void TMR_reloj1_Tick(object sender, EventArgs e)
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
