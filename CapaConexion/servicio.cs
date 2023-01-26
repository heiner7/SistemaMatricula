using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bibliotecas SQL
using System.Data;
using System.Data.SqlClient;

namespace SistemaMatricula.CapaConexion
{
    public class servicio
    {
        //Hacer la conexion
        private SqlConnection conexion;

        public servicio(string usuario, string contra)
        {

            if(usuario == "") {
                usuario = "sa";
                contra = "una2019";
            }
            conexion = new SqlConnection(@"server = DESKTOP-MAQMOR9\SQLEXPRESS;                                       
                                          database = SistemaMatricula;
                                          " +
                                          "user =" + usuario + ";"+
                                          "password =" + contra +";"+
                                          "connection timeout=30"
                                         );
        }


        protected void abrirConexion()
        {
           conexion.Open();          
        }

        protected void cerrarConexion()
        {
            conexion.Close();
        }

        protected string ejecutaSentencia(string sentencia)
        {
            SqlCommand comando = new SqlCommand(sentencia, conexion);

            try
            {
                this.abrirConexion();
                comando.ExecuteScalar();
            }
            catch (Exception error)
            {
                this.cerrarConexion();
                return error.Message;
            }
            this.cerrarConexion();
            return "";
        }

        protected string ejecutaSentencia(SqlCommand miComando)
        {
            miComando.Connection = conexion;
            miComando.CommandType = CommandType.StoredProcedure;
            miComando.CommandTimeout = 6000;

            try
            {
                this.abrirConexion();
                miComando.ExecuteScalar();
            }
            catch(Exception error)
            {
                this.cerrarConexion();
                return error.Message;
            }
            this.cerrarConexion();
            return "";
        }

        //Solo devuelve un registro de esa persona
        protected DataSet seleccionarInformacion(string sentencia)
        {
            DataSet miDataSet = new DataSet();
            SqlCommand miSqlCommand = conexion.CreateCommand();

            miSqlCommand.CommandText = sentencia;
            SqlDataAdapter miSqlDataAdapter = new SqlDataAdapter();

            miSqlDataAdapter.SelectCommand = miSqlCommand;
            miSqlDataAdapter.Fill(miDataSet);

            return miDataSet;
        }

        protected DataSet seleccionarInformacion(SqlCommand miComando)
        {
            DataSet miDataset = new DataSet();
            SqlDataAdapter miSqlDataAdapter = new SqlDataAdapter();

            miComando.CommandTimeout = 2000;
            miComando.Connection = conexion;

            miComando.CommandType = CommandType.StoredProcedure;
            miSqlDataAdapter.SelectCommand = miComando;
            miSqlDataAdapter.Fill(miDataset);

            return miDataset;
        }
    }
}
