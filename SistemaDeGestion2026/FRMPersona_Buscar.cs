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
    public partial class FRMPersona_Buscar : DevComponents.DotNetBar.Office2007Form
    {
        #region Variables
        public aperson persona = new aperson();
        private List<aperson> lista_personas = new List<aperson>();
        public bool seleccionadoOK = false;
        #endregion

        #region Constructor
        public FRMPersona_Buscar()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
        private void ActualizarGrid()
        {
            DTG_Lista.Rows.Clear();
            lista_personas.Clear();
            String solo_sin_usuario = "papscodper not in (select papscodper from aperson,aususis where papscodper=fauscodper order by papscodper)";
            lista_personas = persona.Lista(solo_sin_usuario + " and (capsnumcid like '%" + TXT_Filtrar.Text + "%' or " +
                                           "capsapepat like '%" + TXT_Filtrar.Text + "%' or " +
                                           "capsapemat like '%" + TXT_Filtrar.Text + "%' or " +
                                           "capsnomper like '%" + TXT_Filtrar.Text + "%') and capsestper = true " + 
                                           " limit " +
                                           IIN_Filas.Value.ToString()
                                           );
            foreach (aperson a in lista_personas)
            {
                DTG_Lista.Rows.Add();

                if (a.capsestper)
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

                DTG_Lista[0, DTG_Lista.Rows.Count - 1].Value = a.papscodper;
                DTG_Lista[1, DTG_Lista.Rows.Count - 1].Value = a.capsestper;
                DTG_Lista[2, DTG_Lista.Rows.Count - 1].Value = a.capsnumcid;
                DTG_Lista[3, DTG_Lista.Rows.Count - 1].Value = a.capsapepat;
                DTG_Lista[4, DTG_Lista.Rows.Count - 1].Value = a.capsapemat;
                DTG_Lista[5, DTG_Lista.Rows.Count - 1].Value = a.capsnomper;
                DTG_Lista[6, DTG_Lista.Rows.Count - 1].Value = a.capsfecnac;
                if (a.capssexper)
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
        #endregion

        #region Eventos
        private void BTN_Buscar_Click(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void TXT_Filtrar_TextChanged(object sender, EventArgs e)
        {
            TXT_Filtrar.SelectAll();
        }

        private void FRMPersona_Buscar_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void BTN_AgregarPersona_Click(object sender, EventArgs e)
        {
            FRMPersona_Registrar a = new FRMPersona_Registrar();
            a.ShowDialog();
            if (a.actualizar)
            {
                ActualizarGrid();
            }

        }

        private void BTN_Okey_Click(object sender, EventArgs e)
        {
            if (DTG_Lista.SelectedRows.Count > 0)
            {
                persona.papscodper = DTG_Lista[0, DTG_Lista.SelectedRows[0].Index].Value.ToString();
                if (persona.ObtenerDatos())
                {
                    seleccionadoOK = true;
                    this.Close();
                }
            }
        }

        private void DTG_Lista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DTG_Lista.SelectedRows.Count > 0)
            {
                persona.papscodper = DTG_Lista[0, DTG_Lista.SelectedRows[0].Index].Value.ToString();
                if (persona.ObtenerDatos())
                {
                    seleccionadoOK = true;
                    this.Close();
                }

            }
        }
        #endregion

    }
}
