using System;
using System.Collections.Generic;
using System.Text;
//Libreria para acceso a datos
using System.Data.Common; 
//Libreria para acceso a Capa de Acceso a Datos
using CapaAD;

namespace CapaRN
{
	public class aususis {

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
            //Instancia para conexion a PostgreSQL 8.2
            private CLConexionPGSQL Conexion;
		#endregion 

		#region Propiedades
		    public int causnumhu3
            { 
                get{ return this._causnumhu3;}
                set{ this._causnumhu3 = value;}
            } 
		    public int causnumhu4
            { 
                get{ return this._causnumhu4;}
                set{ this._causnumhu4 = value;}
            } 
		    public bool causestusu
            { 
                get{ return this._causestusu;}
                set{ this._causestusu = value;}
            } 
		    public bool causactpas
            { 
                get{ return this._causactpas;}
                set{ this._causactpas = value;}
            } 
		    public int causmashue
            { 
                get{ return this._causmashue;}
                set{ this._causmashue = value;}
            } 
		    public int causnumhu1
            { 
                get{ return this._causnumhu1;}
                set{ this._causnumhu1 = value;}
            } 
		    public int causnumhu2
            { 
                get{ return this._causnumhu2;}
                set{ this._causnumhu2 = value;}
            } 
		    public string pauscodusu
            { 
                get{ return this._pauscodusu;}
                set{ this._pauscodusu = value;}
            } 
		    public string fauscodper
            { 
                get{ return this._fauscodper;}
                set{ this._fauscodper = value;}
            } 
		    public string causnomlog
            { 
                get{ return this._causnomlog;}
                set{ this._causnomlog = value;}
            } 
		    public string causpasswo
            { 
                get{ return this._causpasswo;}
                set{ this._causpasswo = value;}
            } 
		    public string cuascodhu1
            { 
                get{ return this._cuascodhu1;}
                set{ this._cuascodhu1 = value;}
            } 
		    public string causcodhu2
            { 
                get{ return this._causcodhu2;}
                set{ this._causcodhu2 = value;}
            } 
		    public string causcodhu3
            { 
                get{ return this._causcodhu3;}
                set{ this._causcodhu3 = value;}
            } 
		    public string causcodhu4
            { 
                get{ return this._causcodhu4;}
                set{ this._causcodhu4 = value;}
            } 
        #endregion

        #region Constructor
            public aususis()
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
                this.Conexion = new CLConexionPGSQL();            } 
        #endregion

        #region Metodos
            public bool ObtenerDatos() 
            { 
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
                                     "causcodhu4 " + 
                             "from aususis " +
                             "where "+
                                    "pauscodusu = @pauscodusu";

                this.Conexion.PrepararComando(sql);

                this.Conexion.AsignarParametroCadena("@pauscodusu",this._pauscodusu);

                DbDataReader ResultadoConsulta = Conexion.EjecutarConsulta();

                if (ResultadoConsulta.Read())
                {
                    this._causnumhu3=ResultadoConsulta.GetInt32(0);
                    this._causnumhu4=ResultadoConsulta.GetInt32(1);
                    this._causestusu=ResultadoConsulta.GetBoolean(2);
                    this._causactpas=ResultadoConsulta.GetBoolean(3);
                    this._causmashue=ResultadoConsulta.GetInt32(4);
                    this._causnumhu1=ResultadoConsulta.GetInt32(5);
                    this._causnumhu2=ResultadoConsulta.GetInt32(6);
                    this._pauscodusu=ResultadoConsulta.GetString(7);
                    this._fauscodper=ResultadoConsulta.GetString(8);
                    this._causnomlog=ResultadoConsulta.GetString(9);
                    this._causpasswo=ResultadoConsulta.GetString(10);
                    this._cuascodhu1=ResultadoConsulta.GetString(11);
                    this._causcodhu2=ResultadoConsulta.GetString(12);
                    this._causcodhu3=ResultadoConsulta.GetString(13);
                    this._causcodhu4=ResultadoConsulta.GetString(14);
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
                                     "causcodhu4 " + 
                             "from aususis " +
                             "where " +
                                    "pauscodusu = @pauscodusu";
 
                this.Conexion.PrepararComando(sql); 

                this.Conexion.AsignarParametroCadena("@pauscodusu",this._pauscodusu);

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
			        string sql = "insert into aususis (" +
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
                                                       "causcodhu4" +
                                                       ") " +
	                             "values (" + 
                                          "@causnumhu3," +
                                          "@causnumhu4," +
                                          "@causestusu," +
                                          "@causactpas," +
                                          "@causmashue," +
                                          "@causnumhu1," +
                                          "@causnumhu2," +
                                          "@pauscodusu," +
                                          "@fauscodper," +
                                          "@causnomlog," +
                                          "@causpasswo," +
                                          "@cuascodhu1," +
                                          "@causcodhu2," +
                                          "@causcodhu3," +
                                          "@causcodhu4" +
                                                       ")";

                    this.Conexion.PrepararComando(sql);

                    this.Conexion.AsignarParametroEntero("@causnumhu3",this._causnumhu3);
                    this.Conexion.AsignarParametroEntero("@causnumhu4",this._causnumhu4);
                    this.Conexion.AsignarParametroLogico("@causestusu",this._causestusu);
                    this.Conexion.AsignarParametroLogico("@causactpas",this._causactpas);
                    this.Conexion.AsignarParametroEntero("@causmashue",this._causmashue);
                    this.Conexion.AsignarParametroEntero("@causnumhu1",this._causnumhu1);
                    this.Conexion.AsignarParametroEntero("@causnumhu2",this._causnumhu2);
                    this.Conexion.AsignarParametroCadena("@pauscodusu",this._pauscodusu);
                    this.Conexion.AsignarParametroCadena("@fauscodper",this._fauscodper);
                    this.Conexion.AsignarParametroCadena("@causnomlog",this._causnomlog);
                    this.Conexion.AsignarParametroCadena("@causpasswo",this._causpasswo);
                    this.Conexion.AsignarParametroCadena("@cuascodhu1",this._cuascodhu1);
                    this.Conexion.AsignarParametroCadena("@causcodhu2",this._causcodhu2);
                    this.Conexion.AsignarParametroCadena("@causcodhu3",this._causcodhu3);
                    this.Conexion.AsignarParametroCadena("@causcodhu4",this._causcodhu4);

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
			        string sql = "update aususis set " +
                                                     "causnumhu3 = @causnumhu3, " +
                                                     "causnumhu4 = @causnumhu4, " +
                                                     "causestusu = @causestusu, " +
                                                     "causactpas = @causactpas, " +
                                                     "causmashue = @causmashue, " +
                                                     "causnumhu1 = @causnumhu1, " +
                                                     "causnumhu2 = @causnumhu2, " +
                                                     "fauscodper = @fauscodper, " +
                                                     "causnomlog = @causnomlog, " +
                                                     "causpasswo = @causpasswo, " +
                                                     "cuascodhu1 = @cuascodhu1, " +
                                                     "causcodhu2 = @causcodhu2, " +
                                                     "causcodhu3 = @causcodhu3, " +
                                                     "causcodhu4 = @causcodhu4" +
                                 " where " +
                                        "pauscodusu = @pauscodusu";
 
                this.Conexion.PrepararComando(sql); 

                    this.Conexion.AsignarParametroEntero("@causnumhu3",this._causnumhu3);
                    this.Conexion.AsignarParametroEntero("@causnumhu4",this._causnumhu4);
                    this.Conexion.AsignarParametroLogico("@causestusu",this._causestusu);
                    this.Conexion.AsignarParametroLogico("@causactpas",this._causactpas);
                    this.Conexion.AsignarParametroEntero("@causmashue",this._causmashue);
                    this.Conexion.AsignarParametroEntero("@causnumhu1",this._causnumhu1);
                    this.Conexion.AsignarParametroEntero("@causnumhu2",this._causnumhu2);
                    this.Conexion.AsignarParametroCadena("@pauscodusu",this._pauscodusu);
                    this.Conexion.AsignarParametroCadena("@fauscodper",this._fauscodper);
                    this.Conexion.AsignarParametroCadena("@causnomlog",this._causnomlog);
                    this.Conexion.AsignarParametroCadena("@causpasswo",this._causpasswo);
                    this.Conexion.AsignarParametroCadena("@cuascodhu1",this._cuascodhu1);
                    this.Conexion.AsignarParametroCadena("@causcodhu2",this._causcodhu2);
                    this.Conexion.AsignarParametroCadena("@causcodhu3",this._causcodhu3);
                    this.Conexion.AsignarParametroCadena("@causcodhu4",this._causcodhu4);

                    this.Conexion.EjecutarTransaccion();
                    this.Conexion.Desconectar();

                    return true;
                }
            }
            public List<aususis> Lista(string where)
            { 
                List<aususis> ListaResultado = new List<aususis>();
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
                                     "causcodhu4 " + 
                             "from aususis " ;
 
                if (where.Replace(" ", "") != "")
                {
                    sql+= "where " + where;
                }

 
                this.Conexion.PrepararComando(sql); 
                DbDataReader ResultadoConsulta = Conexion.EjecutarConsulta();

                if (ResultadoConsulta!=null)
                {
                    while (ResultadoConsulta.Read())
                    {
                          aususis Auxiliar = new aususis();
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
                          ListaResultado.Add(Auxiliar);
                    }

                }
                this.Conexion.Desconectar();
                return ListaResultado;
            } 
        #endregion 

	}
}

