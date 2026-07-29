using CapaRN;
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
    public partial class FRM_IniciarSesion : DevComponents.DotNetBar.Office2007Form
    {
        #region Variables
        aususis usuario=new aususis();
        #endregion
        #region Constructor

        public FRM_IniciarSesion()
        {
            InitializeComponent();
        }
        #endregion


        #region Eventos
       
        private void FRM_IniciarSesion_Load(object sender, EventArgs e)
        {

        }

        private void BTNPassword_Click(object sender, EventArgs e)
        {
            if (TXT_Password.PasswordChar=='*') { 
                TXT_Password.PasswordChar = '\0';
            } else {
                TXT_Password.PasswordChar = '*';
            }
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Metodos

        #endregion

        private void TXT_Password_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
