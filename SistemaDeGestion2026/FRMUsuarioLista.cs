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
    public partial class FRMUsuarioLista : DevComponents.DotNetBar.Office2007Form
    {
        #region Variable
        private lususis lusuario = new lususis();
        private aususis ausuario = new aususis();
        private List<lususis> lista_usuarios = new List<lususis>();
        #endregion

        #region Constructor

        public FRMUsuarioLista()
        {
            InitializeComponent();
        }

        #endregion

        #region Metodos

        private void ActualizarGrid()
        {
            DTG_Lista.Rows.Clear();
            lista_usuarios.Clear();
            lista_usuarios = lusuario.Lista("(capsnumcid like '%" + TXT_Filtrar.Text + "%' or " +
                                            "capsapepat like '%" + TXT_Filtrar.Text + "%' or " +
                                            "capsapemat like '%" + TXT_Filtrar.Text + "%' or " +
                                            "capsnomper like '%" + TXT_Filtrar.Text + "%') limit " +
                                           IIN_Filas.Value.ToString()
                                           );
            foreach (lususis a in lista_usuarios)
            {
                DTG_Lista.Rows.Add();

                if (a.causestusu)
                {
                    if (DTG_Lista.Rows.Count % 2 == 0)
                    {
                        DTG_Lista.Rows[DTG_Lista.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                    }
                }
                else
                {
                    DTG_Lista.Rows[DTG_Lista.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Salmon;
                }

                DTG_Lista[0, DTG_Lista.Rows.Count - 1].Value = a.pauscodusu;
                DTG_Lista[1, DTG_Lista.Rows.Count - 1].Value = a.causestusu;
                DTG_Lista[2, DTG_Lista.Rows.Count - 1].Value = a.capsnumcid;
                DTG_Lista[3, DTG_Lista.Rows.Count - 1].Value = a.capsapepat + " " +
                                                               a.capsapemat + " " +
                                                               a.capsnomper;
                DTG_Lista[4, DTG_Lista.Rows.Count - 1].Value = a.causnomlog;
              
                
            }

        }
        #endregion

        #region Eventos

         private void BTN_Registrar_Click(object sender, EventArgs e)
        {
            FRMUsuarioRegistrar F1 = new FRMUsuarioRegistrar();
            F1.modificar = false;
            F1.ShowDialog();
            if (F1.actualizar)
            {
                ActualizarGrid();
            }
        }

        private void BTN_Modificar_Click(object sender, EventArgs e)
        {
            if (DTG_Lista.SelectedRows.Count > 0)
            {
                FRMUsuarioRegistrar F1 = new FRMUsuarioRegistrar();
                F1.modificar = true;
                F1.codUsuMod = DTG_Lista[0, DTG_Lista.SelectedRows[0].Index].Value.ToString();
                F1.ShowDialog();
                if (F1.actualizar)
                {
                    ActualizarGrid();
                }
            }
        }

        private void inhabilitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DTG_Lista.SelectedRows.Count > 0)
            {
                ausuario.pauscodusu = DTG_Lista.SelectedRows[0].Cells[0].Value.ToString();
                if (ausuario.ObtenerDatos())
                {
                    ausuario.causestusu = false;
                    if (ausuario.Modificar())
                    {
                        MessageBox.Show("Persona inhabilitada");
                        ActualizarGrid();
                    }
                }
            }
        }

        private void CMSMenu_Opening(object sender, CancelEventArgs e)
        {
            if (DTG_Lista.SelectedRows.Count > 0)
            {
                ausuario.pauscodusu = DTG_Lista.SelectedRows[0].Cells[0].Value.ToString();
                if (ausuario.ObtenerDatos())
                {
                    if (ausuario.causestusu)
                    {
                        CMSMenu.Items[1].Visible = true;
                        CMSMenu.Items[2].Visible = false;
                    }
                    else
                    {
                        CMSMenu.Items[1].Visible = false;
                        CMSMenu.Items[2].Visible = true;
                    }
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void TXT_Filtrar_Enter(object sender, EventArgs e)
        {

        }

        private void DTG_Lista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (DTG_Lista.SelectedRows.Count > 0)
                {
                    FRMUsuarioRegistrar F1 = new FRMUsuarioRegistrar();
                    F1.modificar = true;
                    F1.codUsuMod = DTG_Lista[0, e.RowIndex].Value.ToString();
                    F1.ShowDialog();
                    if (F1.actualizar)
                    {
                        ActualizarGrid();
                    }
                }
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DTG_Lista.SelectedRows.Count > 0)
            {
                FRMUsuarioRegistrar F1 = new FRMUsuarioRegistrar();
                F1.modificar = true;
                F1.codUsuMod = DTG_Lista[0, DTG_Lista.SelectedRows[0].Index].Value.ToString();
                F1.ShowDialog();
                if (F1.actualizar)
                {
                    ActualizarGrid();
                }
            }
        }

        private void habilitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DTG_Lista.SelectedRows.Count > 0)
            {
                ausuario.pauscodusu = DTG_Lista.SelectedRows[0].Cells[0].Value.ToString();
                if (ausuario.ObtenerDatos())
                {
                    ausuario.causestusu = true;
                    if (ausuario.Modificar())
                    {
                        MessageBox.Show("Persona habilitada");
                        ActualizarGrid();
                    }
                }
            }
        }

        private void FRMUsuarioLista_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ActualizarGrid();
        }

        private void BTN_Buscar_Click(object sender, EventArgs e)//filtrar click
        {
            ActualizarGrid();
        }

        #endregion

    }
}
