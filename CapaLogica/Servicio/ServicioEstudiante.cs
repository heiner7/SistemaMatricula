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
    public class ServicioEstudiante: servicio, IDisposable//para liberar memoria
    {
        private string respuesta;
        private SqlCommand miComando;

        public ServicioEstudiante(string usuario, string contra): base(usuario, contra)
        {
                this.abrirConexion();
                this.cerrarConexion();
        }

        public ServicioEstudiante(): base("","")
        {
            respuesta = "";
            miComando = new SqlCommand();       
        }

        public void Dispose()
        {

        }

        //Metodo para el SP InsertarEstudiante
        public string InsertarEstudiante(Estudiante elEstudiante)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Insertar Estudiante");

            miComando.CommandText = "InsertarEstudiante";

            miComando.Parameters.Add("@Grupo_id", SqlDbType.Int);
            miComando.Parameters["@Grupo_id"].Value = elEstudiante.Grupo_id;

            miComando.Parameters.Add("@Estudiante_cedula", SqlDbType.VarChar);
            miComando.Parameters["@Estudiante_cedula"].Value = elEstudiante.Estudiante_cedula;

            miComando.Parameters.Add("@Estudiante_nombre", SqlDbType.VarChar);
            miComando.Parameters["@Estudiante_nombre"].Value = elEstudiante.Estudiante_nombre;

            miComando.Parameters.Add("@Estudiante_primerApellido", SqlDbType.VarChar);
            miComando.Parameters["@Estudiante_primerApellido"].Value = elEstudiante.Estudiante_primerApellido;

            miComando.Parameters.Add("@Estudiante_segundoApellido", SqlDbType.VarChar);
            miComando.Parameters["@Estudiante_segundoApellido"].Value = elEstudiante.Estudiante_segundoApellido;

            miComando.Parameters.Add("@Estudiante_telefono", SqlDbType.VarChar);
            miComando.Parameters["@Estudiante_telefono"].Value = elEstudiante.Estudiante_telefono;

            miComando.Parameters.Add("@Estudiante_correoElectronico", SqlDbType.VarChar);
            miComando.Parameters["@Estudiante_correoElectronico"].Value = elEstudiante.Estudiante_correoElectronico;

            miComando.Parameters.Add("@Estudiante_direccion", SqlDbType.VarChar);
            miComando.Parameters["@Estudiante_direccion"].Value = elEstudiante.Estudiante_direccion;

            miComando.Parameters.Add("@Estudiante_estado", SqlDbType.VarChar);
            miComando.Parameters["@Estudiante_estado"].Value = elEstudiante.Estudiante_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if(respuesta == "")
            
                respuesta += "Se ha realizado correctamente la transacción";

                Console.WriteLine(respuesta);
                Console.WriteLine("Fin Gestor Insertar Estudiante");

                return respuesta;
            
        }

        //Metodo para el SP ModificarEstudiante
        public string ModificarEstudiante(Estudiante elEstudiante)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Modificar Estudiante");

            miComando.CommandText = "ModificarPersona";

            miComando.Parameters.Add("@Estudiante_id", SqlDbType.Int);
            miComando.Parameters["@Estudiante_id"].Value = elEstudiante.Estudiante_id;

            miComando.Parameters.Add("@Grupo_id", SqlDbType.Int);
            miComando.Parameters["@Grupo_id"].Value = elEstudiante.Grupo_id;

            miComando.Parameters.Add("@Estudiante_cedula", SqlDbType.VarChar);
            miComando.Parameters["@Estudiante_cedula"].Value = elEstudiante.Estudiante_cedula;

            miComando.Parameters.Add("@Estudiante_nombre", SqlDbType.VarChar);
            miComando.Parameters["@Estudiante_nombre"].Value = elEstudiante.Estudiante_nombre;

            miComando.Parameters.Add("@Estudiante_primerApellido", SqlDbType.VarChar);
            miComando.Parameters["@Estudiante_primerApellido"].Value = elEstudiante.Estudiante_primerApellido;

            miComando.Parameters.Add("@Estudiante_segundoApellido", SqlDbType.VarChar);
            miComando.Parameters["@Estudiante_segundoApellido"].Value = elEstudiante.Estudiante_segundoApellido;

            miComando.Parameters.Add("@Estudiante_telefono", SqlDbType.VarChar);
            miComando.Parameters["@Estudiante_telefono"].Value = elEstudiante.Estudiante_telefono;

            miComando.Parameters.Add("@Estudiante_correoElectronico", SqlDbType.VarChar);
            miComando.Parameters["@Estudiante_correoElectronico"].Value = elEstudiante.Estudiante_correoElectronico;

            miComando.Parameters.Add("@Estudiante_direccion", SqlDbType.VarChar);
            miComando.Parameters["@Estudiante_direccion"].Value = elEstudiante.Estudiante_direccion;

            miComando.Parameters.Add("@Estudiante_estado", SqlDbType.VarChar);
            miComando.Parameters["@Estudiante_estado"].Value = elEstudiante.Estudiante_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Modificar Estudiante");

            return respuesta;

        }

        public DataTable ListarEstudiante()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor ListarEstudiantes");

            miComando.CommandText = "ListarEstudiantes";

            DataSet elEstudiante = new DataSet();
            this.abrirConexion();
            elEstudiante = this.seleccionarInformacion(miComando);
            DataTable miDataTable = elEstudiante.Tables[0];
            this.cerrarConexion();

            return miDataTable;
        }

        public DataSet ConsultarEstudiante(int Estudiante_id)
        {
            miComando.CommandText = "ConsultarEstudiante";

            miComando.Parameters.AddWithValue("@Estudiante_id", SqlDbType.Int);
            miComando.Parameters["@Estudiante_id"].Value = Estudiante_id;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        public string InactivarEstudiante(int Estudiante_id)
        {
            miComando = new SqlCommand();

            Console.WriteLine("Gestor InactivarEstudiante");

            miComando.CommandText = "InactivarEstudiante";

            miComando.Parameters.AddWithValue("@Estudiante_id", SqlDbType.Int);
            miComando.Parameters["@Estudiante_id"].Value = Estudiante_id;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Inactivar Estudiante");

            return respuesta;
        }

        public string EliminarEstudiante(int Estudiante_id)
        {
            miComando = new SqlCommand();

            Console.WriteLine("Gestor EliminarEstudiante");

            miComando.CommandText = "EliminarEstudiante";

            miComando.Parameters.AddWithValue("@Estudiante_id", SqlDbType.Int);
            miComando.Parameters["@Estudiante_id"].Value = Estudiante_id;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Eliminar Estudiante");

            return respuesta;
        }
    }
}
