using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bibliotecas SQL
using System.Data;
using System.Data.SqlClient;
//Bibliotecas del sistema
using SistemaMatricula.CapaConexion;
using SistemaMatricula.CapaLogica.LogicaNegocio;

namespace SistemaMatricula.CapaLogica.Servicio
{
    public class ServicioAula : servicio, IDisposable//para liberar memoria
    {

        private string respuesta;
        private SqlCommand miComando;

        public ServicioAula(): base("","")
        {
            respuesta = "";
            miComando = new SqlCommand();
        }

        public void Dispose()
        {

        }


        //Metodo para el SP InsertarAula
        public string InsertarAula(Aula elAula)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Insertar Aula");

            miComando.CommandText = "InsertarAula";

            miComando.Parameters.Add("@Aula_descripcion", SqlDbType.VarChar);
            miComando.Parameters["@Aula_descripcion"].Value = elAula.Aula_descripcion;

            miComando.Parameters.Add("@Aula_estado", SqlDbType.VarChar);
            miComando.Parameters["@Aula_estado"].Value = elAula.Aula_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Insertar Aula");

            return respuesta;

        }

        //Metodo para el SP ModificarAula
        public string ModificarAula(Aula elAula)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Modificar Aula");

            miComando.CommandText = "ModificarAula";

            miComando.Parameters.Add("@Aula_id", SqlDbType.Int);
            miComando.Parameters["@Aula_id"].Value = elAula.Aula_id;

            miComando.Parameters.Add("@Aula_descripcion", SqlDbType.VarChar);
            miComando.Parameters["@Aula_descripcion"].Value = elAula.Aula_descripcion;

            miComando.Parameters.Add("@Aula_estado", SqlDbType.VarChar);
            miComando.Parameters["@Aula_estado"].Value = elAula.Aula_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Modificar Aula");

            return respuesta;

        }

        public DataTable ListarAula()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor ListarAula");

            miComando.CommandText = "ListarAula";

            DataSet elAula = new DataSet();
            this.abrirConexion();
            elAula = this.seleccionarInformacion(miComando);
            DataTable miDataTable = elAula.Tables[0];
            this.cerrarConexion();

            return miDataTable;
        }

        public DataSet ConsultarAula(int Aula_id)
        {
            miComando.CommandText = "ConsultarAula";

            miComando.Parameters.AddWithValue("@Aula_id", SqlDbType.Int);
            miComando.Parameters["@Aula_id"].Value = Aula_id;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        public string InactivarAula(int Aula_id)
        {
            miComando = new SqlCommand();

            Console.WriteLine("Gestor InactivarAula");

            miComando.CommandText = "InactivarAula";

            miComando.Parameters.AddWithValue("@Aula_id", SqlDbType.Int);
            miComando.Parameters["@Aula_id"].Value = Aula_id;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Inactivar Aula");

            return respuesta;
        }
    }

}

