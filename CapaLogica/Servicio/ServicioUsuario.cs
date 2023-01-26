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
    public class ServicioUsuario : servicio, IDisposable
    {
        private string respuesta;
        private SqlCommand miComando;

        public ServicioUsuario() : base("", "")
        {
            respuesta = "";
            miComando = new SqlCommand();
        }

        public void Dispose()
        {

        }

        //Metodo para el SP InsertarUsuario
        public string InsertarUsuario(Usuario elUsuario)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Insertar Usuario");

            miComando.CommandText = "InsertarUsuario";

            miComando.Parameters.Add("@Usuario_nombre", SqlDbType.VarChar);
            miComando.Parameters["@Usuario_nombre"].Value = elUsuario.Usuario_nombre;

            miComando.Parameters.Add("@Usuario_contrasenna", SqlDbType.VarChar);
            miComando.Parameters["@Usuario_contrasenna"].Value = elUsuario.Usuario_contrasenna;

            miComando.Parameters.Add("@Usuario_estado", SqlDbType.VarChar);
            miComando.Parameters["@Usuario_estado"].Value = elUsuario.Usuario_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Insertar Usuario");

            return respuesta;

        }

        //Metodo para el SP ModificarProfesor
        public string ModificarUsuario(Usuario elUsuario)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Insertar Usuario");

            miComando.CommandText = "ModificarUsuario";

            miComando.Parameters.Add("@Usuario_id", SqlDbType.VarChar);
            miComando.Parameters["@Usuario_id"].Value = elUsuario.Usuario_id;

            miComando.Parameters.Add("@Usuario_nombre", SqlDbType.VarChar);
            miComando.Parameters["@Usuario_nombre"].Value = elUsuario.Usuario_nombre;

            miComando.Parameters.Add("@Usuario_contrasenna", SqlDbType.VarChar);
            miComando.Parameters["@Usuario_contrasenna"].Value = elUsuario.Usuario_contrasenna;

            miComando.Parameters.Add("@Usuario_estado", SqlDbType.VarChar);
            miComando.Parameters["@Usuario_estado"].Value = elUsuario.Usuario_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Insertar Usuario");

            return respuesta;

        }

        public DataTable ListarUsuario()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor ListarUsuario");

            miComando.CommandText = "ListarUsuario";

            DataSet elUsuario = new DataSet();
            this.abrirConexion();
            elUsuario = this.seleccionarInformacion(miComando);
            DataTable miDataTable = elUsuario.Tables[0];
            this.cerrarConexion();

            return miDataTable;
        }

        public DataSet ConsultarUsuario(int Usuario_id)
        {
            miComando.CommandText = "ConsultarUsuario";

            miComando.Parameters.AddWithValue("@Usuario_id", SqlDbType.Int);
            miComando.Parameters["@Usuario_id"].Value = Usuario_id;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        public string InactivarUsuario(int Usuario_id)
        {
            miComando = new SqlCommand();

            Console.WriteLine("Gestor InactivarUsuario");

            miComando.CommandText = "InactivarUsuario";

            miComando.Parameters.AddWithValue("@Usuario_id", SqlDbType.Int);
            miComando.Parameters["@Usuario_id"].Value = Usuario_id;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Inactivar Usuario");

            return respuesta;
        }

    }
}

