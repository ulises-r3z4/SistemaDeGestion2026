using System;
using System.Collections.Generic;
using System.Text;
//Libreria para acceso a datos
using System.Data.Common;
//Libreria para acceso a Capa de Acceso a Datos
using CapaAD;

namespace CapaRN
{
    public class xnumcor
    {
        #region Campos
        private int _cxncnumcor;
        private string _pxnctipcor;
        //Instancia para conexion a PostgreSQL 8.2
        private CLConexionPGSQL Conexion;
        #endregion

        #region Propiedades
        public int cxncnumcor
        {
            get { return this._cxncnumcor; }
            set { this._cxncnumcor = value; }
        }
        public string pxnctipcor
        {
            get { return this._pxnctipcor; }
            set { this._pxnctipcor = value; }
        }
        #endregion

        #region Constructor
        public xnumcor()
        {
            this._cxncnumcor = 0;
            this._pxnctipcor = "";
            this.Conexion = new CLConexionPGSQL();
        }
        #endregion

        #region Metodos
        public bool ObtenerDatos()
        {
            this.Conexion.Conectar();
            string sql = "select " +
                                 "cxncnumcor," +
                                 "pxnctipcor " +
                         "from xnumcor " +
                         "where " +
                                "pxnctipcor = @pxnctipcor";

            this.Conexion.PrepararComando(sql);

            this.Conexion.AsignarParametroCadena("@pxnctipcor", this._pxnctipcor);

            DbDataReader ResultadoConsulta = Conexion.EjecutarConsulta();

            

            if (ResultadoConsulta.Read())
            {
                this._cxncnumcor = Convert.ToInt32(ResultadoConsulta.GetInt32(0));
                this._pxnctipcor = ResultadoConsulta.GetString(1);
                this.Conexion.Desconectar();
                return true;
            }
            else
            {
                this.Conexion.Desconectar();
                return false;
            }
        }
        public bool VerificarExistencia()
        {
            this.Conexion.Conectar();
            string sql = "select " +
                                 "cxncnumcor," +
                                 "pxnctipcor " +
                         "from xnumcor " +
                         "where " +
                                "pxnctipcor = @pxnctipcor";

            this.Conexion.PrepararComando(sql);

            this.Conexion.AsignarParametroCadena("@pxnctipcor", this._pxnctipcor);

            DbDataReader ResultadoConsulta = Conexion.EjecutarConsulta();

            

            if (ResultadoConsulta.HasRows)
            {
                this.Conexion.Desconectar();
                return true;
            }
            else
            {
                this.Conexion.Desconectar();
                return false;
            }
        }
        public bool Grabar()
        {
            if (this.VerificarExistencia())
            {
                return false;
            }
            else
            {
                this.Conexion.Conectar();
                string sql = "insert into xnumcor (" +
                                                   "cxncnumcor," +
                                                   "pxnctipcor" +
                                                   ") " +
                             "values (" +
                                      "@cxncnumcor," +
                                      "@pxnctipcor" +
                                                   ")";

                this.Conexion.PrepararComando(sql);

                this.Conexion.AsignarParametroEntero("@cxncnumcor", this._cxncnumcor);
                this.Conexion.AsignarParametroCadena("@pxnctipcor", this._pxnctipcor);

                this.Conexion.EjecutarTransaccion();
                this.Conexion.Desconectar();

                return true;
            }
        }
        public bool Modificar()
        {
            if (!this.VerificarExistencia())
            {
                return false;
            }
            else
            {
                this.Conexion.Conectar();
                string sql = "update xnumcor set " +
                                                 "cxncnumcor = @cxncnumcor" +
                             " where " +
                                    "pxnctipcor = @pxnctipcor";

                this.Conexion.PrepararComando(sql);

                this.Conexion.AsignarParametroEntero("@cxncnumcor", this._cxncnumcor);
                this.Conexion.AsignarParametroCadena("@pxnctipcor", this._pxnctipcor);

                this.Conexion.EjecutarTransaccion();
                this.Conexion.Desconectar();

                return true;
            }
        }
        public List<xnumcor> Lista(string where)
        {
            List<xnumcor> ListaResultado = new List<xnumcor>();
            this.Conexion.Conectar();
            string sql = "select " +
                                 "cxncnumcor," +
                                 "pxnctipcor " +
                         "from xnumcor ";

            if (where.Replace(" ", "") != "")
            {
                sql += "where " + where;
            }


            this.Conexion.PrepararComando(sql);
            DbDataReader ResultadoConsulta = Conexion.EjecutarConsulta();

            if (ResultadoConsulta != null)
            {
                while (ResultadoConsulta.Read())
                {
                    xnumcor Auxiliar = new xnumcor();
                    Auxiliar.cxncnumcor = ResultadoConsulta.GetInt32(0);
                    Auxiliar.pxnctipcor = ResultadoConsulta.GetString(1);
                    ListaResultado.Add(Auxiliar);
                }

            }
            this.Conexion.Desconectar();
            return ListaResultado;
        }
        public bool ObtenerSiguiente()
        {
            bool ban = false;
            if (this.ObtenerDatos())
            {
                this._cxncnumcor += 1;
                if (this.Modificar())
                {
                    ban = true;
                }
            }
            else
            {
                this._cxncnumcor = 1;
                if (this.Grabar())
                {
                    ban = true;
                }
            }
            return ban;
        }

        public bool ObtenerSiguiente(int n)
        {
            bool ban = false;
            if (this.ObtenerDatos())
            {
                this._cxncnumcor += n;
                if (this.Modificar())
                {
                    ban = true;
                }
            }
            else
            {
                this._cxncnumcor = n;
                if (this.Grabar())
                {
                    ban = true;
                }
            }
            return ban;
        }
        #endregion
    }
}

