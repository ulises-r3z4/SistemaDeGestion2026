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
    public partial class FRM_Persona_Lista : DevComponents.DotNetBar.Office2007Form
    {
        #region Variables
           private aperson persona = new aperson();
           private List<aperson> lista_personas = new List<aperson>();
        #endregion

        #region Constructor
        public FRM_Persona_Lista()
        {
            InitializeComponent();
        }
        #endregion

        #region Métodos
        private void ActualizarGrid()
        {
            DTGLista.Rows.Clear();
            lista_personas.Clear();
            lista_personas = persona.Lista("capsnumcid like '%" + TXTFiltrar.Text + "%' or " +
                                           "capsapepat like '%" + TXTFiltrar.Text + "%' or " +
                                           "capsapemat like '%" + TXTFiltrar.Text + "%' or " +
                                           "capsnomper like '%" + TXTFiltrar.Text + "%' limit " +
                                           IINFilas.Value.ToString()
                                           );
            foreach (aperson a in lista_personas)
            {
                if (a.capsestper)
                {
                    DTGLista.Rows[DTGLista.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else
                {
                    DTGLista.Rows[DTGLista.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Salmon;
                }
                DTGLista.Rows.Add();
                DTGLista[0, DTGLista.Rows.Count - 1].Value = a.papscodper;
                DTGLista[1, DTGLista.Rows.Count - 1].Value = a.capsestper;
                DTGLista[2, DTGLista.Rows.Count - 1].Value = a.capsnumcid;
                DTGLista[3, DTGLista.Rows.Count - 1].Value = a.capsapepat;
                DTGLista[4, DTGLista.Rows.Count - 1].Value = a.capsapemat;
                DTGLista[5, DTGLista.Rows.Count - 1].Value = a.capsnomper;
                DTGLista[6, DTGLista.Rows.Count - 1].Value = a.capsfecnac;
                if (a.capssexper)
                {
                    DTGLista[7, DTGLista.Rows.Count - 1].Value = "M";
                }
                else
                {
                    DTGLista[7, DTGLista.Rows.Count - 1].Value = "F";
                }

                DTGLista[8, DTGLista.Rows.Count - 1].Value = a.capsnumcel;

            }

        }
        #endregion

        #region Eventos
        private void FRMPersona_Lista_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ActualizarGrid();
        }

        private void BTNRegistrar_Click(object sender, EventArgs e)
        {
            FRM_Persona_Registrar a = new FRM_Persona_Registrar();
            a.ShowDialog();
        }        

        private void BTNReporte_Click(object sender, EventArgs e)
        {

        }

        private void BTNModificar_Click(object sender, EventArgs e)
        {
            if (DTGLista.SelectedRows.Count > 0)
            {
                FRM_Persona_Registrar F1 = new FRM_Persona_Registrar();
                F1.modificar = true;
                F1.codPerMod = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
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
                    FRM_Persona_Registrar F1 = new FRM_Persona_Registrar();
                    F1.modificar = true;
                    F1.codPerMod = DTGLista[0, e.RowIndex].Value.ToString();
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

        #endregion

        private void InhabilitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DTGLista.SelectedRows.Count > 0)
            {
                FRM_Persona_Registrar F1 = new FRM_Persona_Registrar();
                F1.modificar = true;
                F1.codPerMod = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
                F1.ShowDialog();
                if (F1.actualizar)
                {
                    ActualizarGrid();
                }
            }
        }

        private void habilitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DTGLista.SelectedRows.Count > 0)
            {
                persona.papscodper = DTGLista.SelectedRows[0].Cells[0].Value.ToString();
                if (persona.ObtenerDatos()){ 
                    persona.capsestper = false;
                    if (persona.Modificar())
                    {
                        MessageBox.Show("Persona Inhabilitada");
                        ActualizarGrid();
                    }
                }
            }
        }

        private void inhabilitarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (DTGLista.SelectedRows.Count > 0)
            {
                persona.papscodper = DTGLista.SelectedRows[0].Cells[0].Value.ToString();
                if (persona.ObtenerDatos())
                {
                    persona.capsestper = false;
                    if (persona.Modificar())
                    {
                        MessageBox.Show("Persona Inhabilitada");
                        ActualizarGrid();
                    }
                }
            }
        }

        private void CMS_Menu_Opening(object sender, CancelEventArgs e)
        {
            if (DTGLista.SelectedRows.Count > 0)
            {
                persona.papscodper = DTGLista.SelectedRows[0].Cells[0].Value.ToString();
                if (persona.ObtenerDatos())
                {
                    if (persona.capsestper)
                    {
                        CMS_Menu.Items[1].Visible = true;
                        CMS_Menu.Items[2].Visible = false;

                    }
                    else
                    {
                        CMS_Menu.Items[1].Visible = false;
                        CMS_Menu.Items[2].Visible = true;
                    }
                }
            }
        }

        private void TXTFiltrar_Enter(object sender, EventArgs e)
        {
            ActualizarGrid();
        }
    }
}
