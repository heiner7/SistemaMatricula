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
    public class ServicioGrupo: servicio, IDisposable
    {

        private string respuesta;
        private SqlCommand miComando;

        public ServicioGrupo() : base("", "")
        {
            respuesta = "";
            miComando = new SqlCommand();
        }

        public void Dispose()
        {

        }

        //Metodo para el SP InsertarGrupo
        public string InsertarGrupo(Grupo elGrupo)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Insertar Grupo");

            miComando.CommandText = "InsertarGrupo";

            miComando.Parameters.Add("@Grupo_descripcion", SqlDbType.VarChar);
            miComando.Parameters["@Grupo_descripcion"].Value = elGrupo.Grupo_descripcion;

            miComando.Parameters.Add("@Grupo_estado", SqlDbType.VarChar);
            miComando.Parameters["@Grupo_estado"].Value = elGrupo.Grupo_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Insertar Grupo");

            return respuesta;
        }

        //Metodo para el SP ModificarGrupo
        public string ModificarGrupo(Grupo elGrupo)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Modificar Grupo");

            miComando.CommandText = "ModificarGrupo";

            miComando.Parameters.Add("@Grupo_id", SqlDbType.VarChar);
            miComando.Parameters["@Grupo_id"].Value = elGrupo.Grupo_id;

            miComando.Parameters.Add("@Grupo_descripcion", SqlDbType.VarChar);
            miComando.Parameters["@Grupo_descripcion"].Value = elGrupo.Grupo_descripcion;

            miComando.Parameters.Add("@Grupo_estado", SqlDbType.VarChar);
            miComando.Parameters["@Grupo_estado"].Value = elGrupo.Grupo_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Modificar Grupo");

            return respuesta;
        }

        public DataTable ListarGrupo()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor ListarGrupo");

            miComando.CommandText = "ListarGrupo";

            DataSet elGrupo = new DataSet();
            this.abrirConexion();
            elGrupo = this.seleccionarInformacion(miComando);
            DataTable miDataTable = elGrupo.Tables[0];
            this.cerrarConexion();

            return miDataTable;
        }

        public DataSet ConsultarGrupo(int Grupo_id)
        {
            miComando.CommandText = "ConsultarGrupo";

            miComando.Parameters.AddWithValue("@Grupo_id", SqlDbType.Int);
            miComando.Parameters["@Grupo_id"].Value = Grupo_id;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        public string InactivarGrupo(int Grupo_id)
        {
            miComando = new SqlCommand();

            Console.WriteLine("Gestor InactivarGrupo");

            miComando.CommandText = "InactivarGrupo";

            miComando.Parameters.AddWithValue("@Grupo_id", SqlDbType.Int);
            miComando.Parameters["@Grupo_id"].Value = Grupo_id;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Modificar Grupo");

            return respuesta;
        }

        public string EliminarGrupo(int Grupo_id)
        {
            miComando = new SqlCommand();

            Console.WriteLine("Gestor EliminarGrupo");

            miComando.CommandText = "EliminarGrupo";

            miComando.Parameters.AddWithValue("@Grupo_id", SqlDbType.Int);
            miComando.Parameters["@Grupo_id"].Value = Grupo_id;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Eliminar Grupo");

            return respuesta;
        }
    }
}
