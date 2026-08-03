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
    public partial class FRMPersona_Buscar : DevComponents.DotNetBar.Office2007Form
    {
        #region Variables
        public aperson persona = new aperson();
        private List<aperson> lista_personas = new List<aperson>();
        public bool seleccionadoOk = false;
        #endregion

        #region Constructor
        public FRMPersona_Buscar()
        {
            InitializeComponent();
        }
        #endregion

        #region Métodos
        private void ActualizarGrid()
        {
            DTGLista.Rows.Clear();
            lista_personas.Clear();
            String soloSinUsuario = "papscodper not in (select papscodper from aperson,aususis where papscodper=fauscodper order by papscodper)"; 
            lista_personas = persona.Lista(soloSinUsuario + " and (capsnumcid like '%" + TXTFiltrar.Text + "%' or " +
                                            "capsapepat like '%" + TXTFiltrar.Text + "%' or " +
                                            "capsapemat like '%" + TXTFiltrar.Text + "%' or " +
                                            "capsnomper like '%" + TXTFiltrar.Text + "%') and capsestper=true " + 
                                            "limit " +
                                           IINFilas.Value.ToString()
                                           );
            foreach (aperson a in lista_personas)
            {
                DTGLista.Rows.Add();
                if (a.capsestper)
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
        private void FRMPersona_Buscar_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void BTNFiltrar_Click(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void TXTFiltrar_Enter(object sender, EventArgs e)
        {
            TXTFiltrar.SelectAll();
        }
        #endregion

        private void BTNAgregarPersona_Click(object sender, EventArgs e)
        {
            FRMPersona_Registrar a = new FRMPersona_Registrar();
            a.ShowDialog();
            if (a.actualizar)
            {
                ActualizarGrid();
            }
        }

        private void BTNAceptar_Click(object sender, EventArgs e)
        {
            if (DTGLista.SelectedRows.Count == 1)
            { 
                persona.papscodper = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
                if (persona.ObtenerDatos())
                {
                    seleccionadoOk = true;               
                    this.Close();
                }                
            }
        }

        private void DTGLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DTGLista.SelectedRows.Count == 1)
            {
                persona.papscodper = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
                if (persona.ObtenerDatos())
                {
                    seleccionadoOk = true;
                    this.Close();
                }
            }
        }
    }
}
