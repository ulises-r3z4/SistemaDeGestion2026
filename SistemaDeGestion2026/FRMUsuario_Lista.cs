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

namespace SistemaDeGestion2026
{
    public partial class FRMUsuario_Lista : DevComponents.DotNetBar.Office2007Form
    {
        #region Variables
        private lususis lusuario = new lususis();
        private aususis ausuario = new aususis();
        private List<lususis> lista_usuarios = new List<lususis>();
        #endregion

        #region Constructor
        public FRMUsuario_Lista()
        {
            InitializeComponent();
        }
        #endregion

        #region Métodos
        private void ActualizarGrid()
        {
            DTGLista.Rows.Clear();
            lista_usuarios.Clear();
            lista_usuarios = lusuario.Lista("(capsnumcid like '%" + TXTFiltrar.Text + "%' or " +
                                             "capsapepat like '%" + TXTFiltrar.Text + "%' or " +
                                             "capsapemat like '%" + TXTFiltrar.Text + "%' or " +
                                             "capsnomper like '%" + TXTFiltrar.Text + "%') limit " +
                                           IINFilas.Value.ToString()
                                           );
            foreach (lususis a in lista_usuarios)
            {
                DTGLista.Rows.Add();
                if (a.causestusu)
                {
                    if (DTGLista.Rows.Count % 2 == 0)
                    {
                        DTGLista.Rows[DTGLista.Rows.Count - 1].DefaultCellStyle.BackColor = Color.PaleGoldenrod;
                    }
                }
                else
                {
                    DTGLista.Rows[DTGLista.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Salmon;
                }
                DTGLista[0, DTGLista.Rows.Count - 1].Value = a.pauscodusu;
                DTGLista[1, DTGLista.Rows.Count - 1].Value = a.causestusu;
                DTGLista[2, DTGLista.Rows.Count - 1].Value = a.capsnumcid;
                DTGLista[3, DTGLista.Rows.Count - 1].Value = a.capsapepat + " " +
                                                             a.capsapemat + " " +
                                                             a.capsnomper;
                DTGLista[4, DTGLista.Rows.Count - 1].Value = a.causnomlog;                
            }
        }
        #endregion

        #region Eventos
        private void FRMUsuario_Lista_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ActualizarGrid();
        }

        private void BTNRegistrar_Click(object sender, EventArgs e)
        {
            FRMUsuario_Registrar a = new FRMUsuario_Registrar();
            a.ShowDialog();
            if (a.actualizar)
            {
                ActualizarGrid();
            }
        }

        private void BTNReporte_Click(object sender, EventArgs e)
        {

        }

        private void BTNModificar_Click(object sender, EventArgs e)
        {
            if (DTGLista.SelectedRows.Count > 0)
            {
                FRMUsuario_Registrar F1 = new FRMUsuario_Registrar();
                F1.modificar = true;
                F1.codUsuMod = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
                F1.ShowDialog();
                if (F1.actualizar)
                {
                    ActualizarGrid();
                }
            }
        }

        private void DTGLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (DTGLista.SelectedRows.Count > 0)
                {
                    FRMUsuario_Registrar F1 = new FRMUsuario_Registrar();
                    F1.modificar = true;
                    F1.codUsuMod = DTGLista[0, e.RowIndex].Value.ToString();
                    F1.ShowDialog();
                    if (F1.actualizar)
                    {
                        ActualizarGrid();
                    }
                }
            }
        }

        private void BTNFiltrar_Click(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DTGLista.SelectedRows.Count > 0)
            {
                ausuario.pauscodusu = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
                if (ausuario.ObtenerDatos())
                {
                    ausuario.causestusu = false;
                    if (ausuario.Modificar())
                    {
                        MessageBox.Show("Usuario inhabilitado correctamente");
                        ActualizarGrid();
                    }
                }
            }
        }

        private void habilitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DTGLista.SelectedRows.Count > 0)
            {
                ausuario.pauscodusu = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
                if (ausuario.ObtenerDatos())
                {
                    ausuario.causestusu = true;
                    if (ausuario.Modificar())
                    {
                        MessageBox.Show("Usuario habilitado correctamente");
                        ActualizarGrid();
                    }
                }
            }
        }

        private void CMSMenu_Opening(object sender, CancelEventArgs e)
        {
            if (DTGLista.SelectedRows.Count > 0)
            {
                ausuario.pauscodusu = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
                if (ausuario.ObtenerDatos())
                {
                    if (ausuario.causestusu)
                    {
                        CMSMenu.Items[2].Visible = false;
                        CMSMenu.Items[1].Visible = true;

                    }
                    else
                    {
                        CMSMenu.Items[2].Visible = true;
                        CMSMenu.Items[1].Visible = false;
                    }
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void TXTFiltrar_Enter(object sender, EventArgs e)
        {
            TXTFiltrar.SelectAll();
        }

        #endregion
    }
}
