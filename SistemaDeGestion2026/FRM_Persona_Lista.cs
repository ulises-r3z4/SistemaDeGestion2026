using CapaRN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eithan_System
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

        private void ActualizarGrid()
        {
            DTG_Lista.Rows.Clear();
            lista_personas.Clear();
          
            lista_personas = persona.Lista("capsnumcid like '%" + TXT_Filtrar.Text + "%' or " +
                                           "capsapepat like '%" + TXT_Filtrar.Text + "%' or " +
                                           "capsapemat like '%" + TXT_Filtrar.Text + "%' or " +
                                           "capsnomper like '%" + TXT_Filtrar.Text + "%' limit " +
                                           IIN_Filas.Value.ToString()
                                           );
            foreach (aperson a in lista_personas)
            {
                DTG_Lista.Rows.Add();

                if (a.capsestper)
                {
                    if (DTG_Lista.Rows.Count % 2 == 0) {
                        DTG_Lista.Rows[DTG_Lista.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                    }
                }
                else {
                    DTG_Lista.Rows[DTG_Lista.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Salmon;
                }

                DTG_Lista[0, DTG_Lista.Rows.Count - 1].Value = a.papscodper;
                DTG_Lista[1, DTG_Lista.Rows.Count - 1].Value = a.capsestper;
                DTG_Lista[2, DTG_Lista.Rows.Count - 1].Value = a.capsnumcid;
                DTG_Lista[3, DTG_Lista.Rows.Count - 1].Value = a.capsapepat;
                DTG_Lista[4, DTG_Lista.Rows.Count - 1].Value = a.capsapemat;
                DTG_Lista[5, DTG_Lista.Rows.Count - 1].Value = a.capsnomper;
                DTG_Lista[6, DTG_Lista.Rows.Count - 1].Value = a.capsfecnac;
                if(a.capssexper)
                {
                    DTG_Lista[7, DTG_Lista.Rows.Count - 1].Value = "M";
                }
                else
                {
                    DTG_Lista[7, DTG_Lista.Rows.Count - 1].Value = "F";
                }
                DTG_Lista[8, DTG_Lista.Rows.Count - 1].Value = a.capsnumcel;
            }

        }
        #region Eventos
        private void BTNNuevo_Click(object sender, EventArgs e)
        {
            FRMPersona_Registrar F1 = new FRMPersona_Registrar();
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
                FRMPersona_Registrar F1 = new FRMPersona_Registrar();
                F1.modificar = true;
                F1.codPerMod = DTG_Lista[0, DTG_Lista.SelectedRows[0].Index].Value.ToString();
                F1.ShowDialog();
                if (F1.actualizar)
                {
                    ActualizarGrid();
                }
            }
        }
        private void BTN_Registrar_Click(object sender, EventArgs e)
        {
            FRMPersona_Registrar a = new FRMPersona_Registrar();
            a.ShowDialog();
        }
        private void TXT_Filtrar_Click(object sender, EventArgs e)
        {
            ActualizarGrid();
        }
        #endregion

        private void FRM_Persona_Lista_Load_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ActualizarGrid();
        }

        private void DTG_Lista_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (DTG_Lista.SelectedRows.Count > 0)
                {
                    FRMPersona_Registrar F1 = new FRMPersona_Registrar();
                    F1.modificar = true;
                    F1.codPerMod = DTG_Lista[0, e.RowIndex].Value.ToString();
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
                FRMPersona_Registrar F1 = new FRMPersona_Registrar();
                F1.modificar = true;
                F1.codPerMod = DTG_Lista[0, DTG_Lista.SelectedRows[0].Index].Value.ToString();
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
                persona.papscodper = DTG_Lista.SelectedRows[0].Cells[0].Value.ToString();
                if (persona.ObtenerDatos()) {
                    persona.capsestper = false;
                    if (persona.Modificar()) {
                        MessageBox.Show("Persona inhabilitada");
                        ActualizarGrid();
                    }
                }
            }
        }

        private void habilitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DTG_Lista.SelectedRows.Count > 0)
            {
                persona.papscodper = DTG_Lista.SelectedRows[0].Cells[0].Value.ToString();
                if (persona.ObtenerDatos())
                {
                    persona.capsestper = true;
                    if (persona.Modificar())
                    {
                        MessageBox.Show("Persona habilitada");
                        ActualizarGrid();
                    }
                }
            }
        }

        private void CMSMenu_Opening(object sender, CancelEventArgs e)
        {
            if (DTG_Lista.SelectedRows.Count > 0)
            {
                persona.papscodper = DTG_Lista.SelectedRows[0].Cells[0].Value.ToString();
                if (persona.ObtenerDatos())
                {
                    if (persona.capsestper)
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
            else {
                e.Cancel = true;
            }
        }

        private void BTN_Buscar_Click(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void TXT_Filtrar_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TXT_Filtrar_Enter(object sender, EventArgs e)
        {
            TXT_Filtrar.SelectAll();
        }
    }
}
