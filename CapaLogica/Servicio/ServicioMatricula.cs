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
    public class ServicioMatricula : servicio, IDisposable//para liberar memoria
    {
        private string respuesta;
        private SqlCommand miComando;

        public ServicioMatricula() : base("", "")
        {
            respuesta = "";
            miComando = new SqlCommand();
        }
        public void Dispose()
        {

        }

        //Metodo para el SP InsertarMatricula
        public string InsertarMatricula(Matricula laMatricula)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Insertar Matricula");

            miComando.CommandText = "InsertarMatricula";

            miComando.Parameters.Add("@Estudiante_id", SqlDbType.Int);
            miComando.Parameters["@Estudiante_id"].Value = laMatricula.Estudiante_id;

            miComando.Parameters.Add("@Grupo_id", SqlDbType.Int);
            miComando.Parameters["@Grupo_id"].Value = laMatricula.Grupo_id;

            miComando.Parameters.Add("@Curso_id", SqlDbType.Int);
            miComando.Parameters["@Curso_id"].Value = laMatricula.Curso_id;

            miComando.Parameters.Add("@Profesor_id", SqlDbType.Int);
            miComando.Parameters["@Profesor_id"].Value = laMatricula.Profesor_id;

            miComando.Parameters.Add("@Horario_id", SqlDbType.Int);
            miComando.Parameters["@Horario_id"].Value = laMatricula.Horario_id;

            miComando.Parameters.Add("@Aula_id", SqlDbType.Int);
            miComando.Parameters["@Aula_id"].Value = laMatricula.Aula_id;

            miComando.Parameters.Add("@Matricula_comprobante", SqlDbType.VarChar);
            miComando.Parameters["@Matricula_comprobante"].Value = laMatricula.Matricula_comprobante;

            miComando.Parameters.Add("@Matricula_estado", SqlDbType.VarChar);
            miComando.Parameters["@Matricula_estado"].Value = laMatricula.Matricula_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Insertar Matricula");

            return respuesta;

        }

        //Metodo para el SP ModificarMatricula
        public string ModificarMatricula(Matricula laMatricula)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Modificar Matricula");

            miComando.CommandText = "ModificarMatricula";

            miComando.Parameters.Add("@Matricula_id", SqlDbType.Int);
            miComando.Parameters["@Matricula_id"].Value = laMatricula.Matricula_id;

            miComando.Parameters.Add("@Estudiante_id", SqlDbType.Int);
            miComando.Parameters["@Estudiante_id"].Value = laMatricula.Estudiante_id;

            miComando.Parameters.Add("@Grupo_id", SqlDbType.Int);
            miComando.Parameters["@Grupo_id"].Value = laMatricula.Grupo_id;

            miComando.Parameters.Add("@Curso_id", SqlDbType.Int);
            miComando.Parameters["@Curso_id"].Value = laMatricula.Curso_id;

            miComando.Parameters.Add("@Profesor_id", SqlDbType.Int);
            miComando.Parameters["@Profesor_id"].Value = laMatricula.Profesor_id;

            miComando.Parameters.Add("@Horario_id", SqlDbType.Int);
            miComando.Parameters["@Horario_id"].Value = laMatricula.Horario_id;

            miComando.Parameters.Add("@Aula_id", SqlDbType.Int);
            miComando.Parameters["@Aula_id"].Value = laMatricula.Aula_id;

            miComando.Parameters.Add("@Matricula_comprobante", SqlDbType.VarChar);
            miComando.Parameters["@Matricula_comprobante"].Value = laMatricula.Matricula_comprobante;

            miComando.Parameters.Add("@Matricula_estado", SqlDbType.VarChar);
            miComando.Parameters["@Matricula_estado"].Value = laMatricula.Matricula_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Moificar Matricula");

            return respuesta;

        }

        public DataSet ConsultarMatricula(int Matricula_id)
        {
            miComando.CommandText = "ConsultarMatricula";

            miComando.Parameters.AddWithValue("@Matricula_id", SqlDbType.Int);
            miComando.Parameters["@Matricula_id"].Value = Matricula_id;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        public DataTable ListarMatricula()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor ListarMatricula");

            miComando.CommandText = "ListarMatricula";

            DataSet laMatricula = new DataSet();
            this.abrirConexion();
            laMatricula = this.seleccionarInformacion(miComando);
            DataTable miDataTable = laMatricula.Tables[0];
            this.cerrarConexion();

            return miDataTable;
        }

        public string InactivarMatricula(int Matricula_id)
        {
            miComando = new SqlCommand();

            Console.WriteLine("Gestor InactivarMaticula");

            miComando.CommandText = "InactivarMatricula";

            miComando.Parameters.AddWithValue("@Matricula_id", SqlDbType.Int);
            miComando.Parameters["@Matricula_id"].Value = Matricula_id;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Inactivar Matricula");

            return respuesta;
        }
    }
}
