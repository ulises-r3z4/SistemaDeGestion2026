using CapaAD;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaRN
{
    public class lususis
    {
        #region Campos
        private int _causnumhu3;
        private int _causnumhu4;
        private bool _causestusu;
        private bool _causactpas;
        private int _causmashue;
        private int _causnumhu1;
        private int _causnumhu2;
        private string _pauscodusu;
        private string _fauscodper;
        private string _causnomlog;
        private string _causpasswo;
        private string _cuascodhu1;
        private string _causcodhu2;
        private string _causcodhu3;
        private string _causcodhu4;

        private DateTime _capsfecnac;
        private bool _capssexper;
        private bool _capsestper;
        private string _capsapemat;
        private string _capsnomper;
        private string _capsnumcel;
        private string _capscorele;
        private string _capsdirper;
        private string _papscodper;
        private string _capsfotper;
        private string _capsnumcid;
        private string _capsapepat;
        //Instancia para conexion a PostgreSQL 8.2
        private CLConexionPGSQL Conexion;
        #endregion

        #region Propiedades
        public int causnumhu3
        {
            get { return this._causnumhu3; }
            set { this._causnumhu3 = value; }
        }
        public int causnumhu4
        {
            get { return this._causnumhu4; }
            set { this._causnumhu4 = value; }
        }
        public bool causestusu
        {
            get { return this._causestusu; }
            set { this._causestusu = value; }
        }
        public bool causactpas
        {
            get { return this._causactpas; }
            set { this._causactpas = value; }
        }
        public int causmashue
        {
            get { return this._causmashue; }
            set { this._causmashue = value; }
        }
        public int causnumhu1
        {
            get { return this._causnumhu1; }
            set { this._causnumhu1 = value; }
        }
        public int causnumhu2
        {
            get { return this._causnumhu2; }
            set { this._causnumhu2 = value; }
        }
        public string pauscodusu
        {
            get { return this._pauscodusu; }
            set { this._pauscodusu = value; }
        }
        public string fauscodper
        {
            get { return this._fauscodper; }
            set { this._fauscodper = value; }
        }
        public string causnomlog
        {
            get { return this._causnomlog; }
            set { this._causnomlog = value; }
        }
        public string causpasswo
        {
            get { return this._causpasswo; }
            set { this._causpasswo = value; }
        }
        public string cuascodhu1
        {
            get { return this._cuascodhu1; }
            set { this._cuascodhu1 = value; }
        }
        public string causcodhu2
        {
            get { return this._causcodhu2; }
            set { this._causcodhu2 = value; }
        }
        public string causcodhu3
        {
            get { return this._causcodhu3; }
            set { this._causcodhu3 = value; }
        }
        public string causcodhu4
        {
            get { return this._causcodhu4; }
            set { this._causcodhu4 = value; }
        }
        public DateTime capsfecnac
        {
            get { return this._capsfecnac; }
            set { this._capsfecnac = value; }
        }
        public bool capssexper
        {
            get { return this._capssexper; }
            set { this._capssexper = value; }
        }
        public bool capsestper
        {
            get { return this._capsestper; }
            set { this._capsestper = value; }
        }
        public string capsapemat
        {
            get { return this._capsapemat; }
            set { this._capsapemat = value; }
        }
        public string capsnomper
        {
            get { return this._capsnomper; }
            set { this._capsnomper = value; }
        }
        public string capsnumcel
        {
            get { return this._capsnumcel; }
            set { this._capsnumcel = value; }
        }
        public string capscorele
        {
            get { return this._capscorele; }
            set { this._capscorele = value; }
        }
        public string capsdirper
        {
            get { return this._capsdirper; }
            set { this._capsdirper = value; }
        }
        public string papscodper
        {
            get { return this._papscodper; }
            set { this._papscodper = value; }
        }
        public string capsfotper
        {
            get { return this._capsfotper; }
            set { this._capsfotper = value; }
        }
        public string capsnumcid
        {
            get { return this._capsnumcid; }
            set { this._capsnumcid = value; }
        }
        public string capsapepat
        {
            get { return this._capsapepat; }
            set { this._capsapepat = value; }
        }
        #endregion

        #region Constructor
        public lususis()
        {
            this._causnumhu3 = 0;
            this._causnumhu4 = 0;
            this._causestusu = true;
            this._causactpas = true;
            this._causmashue = 0;
            this._causnumhu1 = 0;
            this._causnumhu2 = 0;
            this._pauscodusu = "";
            this._fauscodper = "";
            this._causnomlog = "";
            this._causpasswo = "";
            this._cuascodhu1 = "";
            this._causcodhu2 = "";
            this._causcodhu3 = "";
            this._causcodhu4 = "";
            this._capsfecnac = DateTime.Now;
            this._capssexper = true;
            this._capsestper = true;
            this._capsapemat = "";
            this._capsnomper = "";
            this._capsnumcel = "";
            this._capscorele = "";
            this._capsdirper = "";
            this._papscodper = "";
            this._capsfotper = "";
            this._capsnumcid = "";
            this._capsapepat = "";
            this.Conexion = new CLConexionPGSQL();
        }
        #endregion

        #region Métodos

        public List<lususis> Lista(string where)
        {
            List<lususis> ListaResultado = new List<lususis>();
            this.Conexion.Conectar();
            string sql = "select " +
                                 "causnumhu3," +
                                 "causnumhu4," +
                                 "causestusu," +
                                 "causactpas," +
                                 "causmashue," +
                                 "causnumhu1," +
                                 "causnumhu2," +
                                 "pauscodusu," +
                                 "fauscodper," +
                                 "causnomlog," +
                                 "causpasswo," +
                                 "cuascodhu1," +
                                 "causcodhu2," +
                                 "causcodhu3," +
                                 "causcodhu4," +
                                 "capsfecnac," +
                                 "capssexper," +
                                 "capsestper," +
                                 "capsapemat," +
                                 "capsnomper," +
                                 "capsnumcel," +
                                 "capscorele," +
                                 "capsdirper," +
                                 "papscodper," +
                                 "capsfotper," +
                                 "capsnumcid," +
                                 "capsapepat " +
                         "from aususis,aperson "+
                         "where papscodper=fauscodper ";

            if (where.Replace(" ", "") != "")
            {
                sql += "and " + where;
            }

            this.Conexion.PrepararComando(sql);
            DbDataReader ResultadoConsulta = Conexion.EjecutarConsulta();

            if (ResultadoConsulta != null)
            {
                while (ResultadoConsulta.Read())
                {
                    lususis Auxiliar = new lususis();
                    Auxiliar.causnumhu3 = ResultadoConsulta.GetInt32(0);
                    Auxiliar.causnumhu4 = ResultadoConsulta.GetInt32(1);
                    Auxiliar.causestusu = ResultadoConsulta.GetBoolean(2);
                    Auxiliar.causactpas = ResultadoConsulta.GetBoolean(3);
                    Auxiliar.causmashue = ResultadoConsulta.GetInt32(4);
                    Auxiliar.causnumhu1 = ResultadoConsulta.GetInt32(5);
                    Auxiliar.causnumhu2 = ResultadoConsulta.GetInt32(6);
                    Auxiliar.pauscodusu = ResultadoConsulta.GetString(7);
                    Auxiliar.fauscodper = ResultadoConsulta.GetString(8);
                    Auxiliar.causnomlog = ResultadoConsulta.GetString(9);
                    Auxiliar.causpasswo = ResultadoConsulta.GetString(10);
                    Auxiliar.cuascodhu1 = ResultadoConsulta.GetString(11);
                    Auxiliar.causcodhu2 = ResultadoConsulta.GetString(12);
                    Auxiliar.causcodhu3 = ResultadoConsulta.GetString(13);
                    Auxiliar.causcodhu4 = ResultadoConsulta.GetString(14);
                    Auxiliar.capsfecnac = ResultadoConsulta.GetDateTime(15);
                    Auxiliar.capssexper = ResultadoConsulta.GetBoolean(16);
                    Auxiliar.capsestper = ResultadoConsulta.GetBoolean(17);
                    Auxiliar.capsapemat = ResultadoConsulta.GetString(18);
                    Auxiliar.capsnomper = ResultadoConsulta.GetString(19);
                    Auxiliar.capsnumcel = ResultadoConsulta.GetString(20);
                    Auxiliar.capscorele = ResultadoConsulta.GetString(21);
                    Auxiliar.capsdirper = ResultadoConsulta.GetString(22);
                    Auxiliar.papscodper = ResultadoConsulta.GetString(23);
                    Auxiliar.capsfotper = ResultadoConsulta.GetString(24);
                    Auxiliar.capsnumcid = ResultadoConsulta.GetString(25);
                    Auxiliar.capsapepat = ResultadoConsulta.GetString(26);
                    ListaResultado.Add(Auxiliar);
                }

            }
            this.Conexion.Desconectar();
            return ListaResultado;
        }

        #endregion
    }
}
