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
    public class ServicioProfesor: servicio, IDisposable
    {

        private string respuesta;
        private SqlCommand miComando;

        public ServicioProfesor() : base("", "")
        {
            respuesta = "";
            miComando = new SqlCommand();
        }

        public void Dispose()
        {

        }

        //Metodo para el SP InsertarEstudiante
        public string InsertarProfesor(Profesor elProfesor)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Insertar Profesor");

            miComando.CommandText = "InsertarProfesor";

            miComando.Parameters.Add("@Profesor_cedula", SqlDbType.VarChar);
            miComando.Parameters["@Profesor_cedula"].Value = elProfesor.Profesor_cedula;

            miComando.Parameters.Add("@Profesor_nombre", SqlDbType.VarChar);
            miComando.Parameters["@Profesor_nombre"].Value = elProfesor.Profesor_nombre;

            miComando.Parameters.Add("@Profesor_primerApellido", SqlDbType.VarChar);
            miComando.Parameters["@Profesor_primerApellido"].Value = elProfesor.Profesor_primerApellido;

            miComando.Parameters.Add("@Profesor_segundoApellido", SqlDbType.VarChar);
            miComando.Parameters["@Profesor_segundoApellido"].Value = elProfesor.Profesor_segundoApellido;

            miComando.Parameters.Add("@Profesor_telefono", SqlDbType.VarChar);
            miComando.Parameters["@Profesor_telefono"].Value = elProfesor.Profesor_telefono;

            miComando.Parameters.Add("@Profesor_correoElectronico", SqlDbType.VarChar);
            miComando.Parameters["@Profesor_correoElectronico"].Value = elProfesor.Profesor_correoElectronico;

            miComando.Parameters.Add("@Profesor_direccion", SqlDbType.VarChar);
            miComando.Parameters["@Profesor_direccion"].Value = elProfesor.Profesor_direccion;

            miComando.Parameters.Add("@Profesor_estado", SqlDbType.VarChar);
            miComando.Parameters["@Profesor_estado"].Value = elProfesor.Profesor_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Insertar Profesor");

            return respuesta;

        }

        //Metodo para el SP ModificarProfesor
        public string ModificarProfesor(Profesor elProfesor)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Modificar Profesor");

            miComando.CommandText = "ModificarProfesor";

            miComando.Parameters.Add("@Profesor_id", SqlDbType.VarChar);
            miComando.Parameters["@Profesor_id"].Value = elProfesor.Profesor_id;

            miComando.Parameters.Add("@Profesor_cedula", SqlDbType.VarChar);
            miComando.Parameters["@Profesor_cedula"].Value = elProfesor.Profesor_cedula;

            miComando.Parameters.Add("@Profesor_nombre", SqlDbType.VarChar);
            miComando.Parameters["@Profesor_nombre"].Value = elProfesor.Profesor_nombre;

            miComando.Parameters.Add("@Profesor_primerApellido", SqlDbType.VarChar);
            miComando.Parameters["@Profesor_primerApellido"].Value = elProfesor.Profesor_primerApellido;

            miComando.Parameters.Add("@Profesor_segundoApellido", SqlDbType.VarChar);
            miComando.Parameters["@Profesor_segundoApellido"].Value = elProfesor.Profesor_segundoApellido;

            miComando.Parameters.Add("@Profesor_telefono", SqlDbType.VarChar);
            miComando.Parameters["@Profesor_telefono"].Value = elProfesor.Profesor_telefono;

            miComando.Parameters.Add("@Profesor_correoElectronico", SqlDbType.VarChar);
            miComando.Parameters["@Profesor_correoElectronico"].Value = elProfesor.Profesor_correoElectronico;

            miComando.Parameters.Add("@Profesor_direccion", SqlDbType.VarChar);
            miComando.Parameters["@Profesor_direccion"].Value = elProfesor.Profesor_direccion;

            miComando.Parameters.Add("@Profesor_estado", SqlDbType.VarChar);
            miComando.Parameters["@Profesor_estado"].Value = elProfesor.Profesor_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Modificar Profesor");

            return respuesta;

        }

        public DataTable ListarProfesor()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor ListarProfesor");

            miComando.CommandText = "ListarProfesor";

            DataSet elProfesor = new DataSet();
            this.abrirConexion();
            elProfesor = this.seleccionarInformacion(miComando);
            DataTable miDataTable = elProfesor.Tables[0];
            this.cerrarConexion();

            return miDataTable;
        }

        public DataSet ConsultarProfesor(int Profesor_id)
        {
            miComando.CommandText = "ConsultarProfesor";

            miComando.Parameters.AddWithValue("@Profesor_id", SqlDbType.Int);
            miComando.Parameters["@Profesor_id"].Value = Profesor_id;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        public string InactivarProfesor(int Profesor_id)
        {
            miComando = new SqlCommand();

            Console.WriteLine("Gestor InactivarProfesor");

            miComando.CommandText = "InactivarProfesor";

            miComando.Parameters.AddWithValue("@Profesor_id", SqlDbType.Int);
            miComando.Parameters["@Profesor_id"].Value = Profesor_id;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Inactivar Profesor");

            return respuesta;
        }

        public string EliminarProfesor(int Profesor_id)
        {
            miComando = new SqlCommand();

            Console.WriteLine("Gestor EliminarProfesor");

            miComando.CommandText = "EliminarProfesor";

            miComando.Parameters.AddWithValue("@Profesor_id", SqlDbType.Int);
            miComando.Parameters["@Profesor_id"].Value = Profesor_id;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Eliminar Profesor");

            return respuesta;
        }
    }
}
