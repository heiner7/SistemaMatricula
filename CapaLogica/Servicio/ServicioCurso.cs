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
    public class ServicioCurso : servicio, IDisposable
    {
        private string respuesta;
        private SqlCommand miComando;

        public ServicioCurso() : base("", "")
        {
            respuesta = "";
            miComando = new SqlCommand();
        }

        public void Dispose()
        {

        }

        //Metodo para el SP InsertarCurso
        public string InsertarCurso(Curso elCurso)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Insertar Curso");

            miComando.CommandText = "InsertarCurso";

            miComando.Parameters.Add("@Curso_nombre", SqlDbType.VarChar);
            miComando.Parameters["@Curso_nombre"].Value = elCurso.Curso_nombre;

            miComando.Parameters.Add("@Curso_creditos", SqlDbType.VarChar);
            miComando.Parameters["@Curso_creditos"].Value = elCurso.Curso_creditos;

            miComando.Parameters.Add("@Curso_cupo", SqlDbType.VarChar);
            miComando.Parameters["@Curso_cupo"].Value = elCurso.Curso_cupo;

            miComando.Parameters.Add("@Curso_estado", SqlDbType.VarChar);
            miComando.Parameters["@Curso_estado"].Value = elCurso.Curso_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Insertar Curso");

            return respuesta;

        }

        //Metodo para el SP ModificarModificar
        public string ModificarCurso(Curso elCurso)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Modificar Curso");

            miComando.CommandText = "ModificarCurso";//Metodo para el SP ModificarCurso

            miComando.Parameters.Add("@Curso_id", SqlDbType.Int);
            miComando.Parameters["@Curso_id"].Value = elCurso.Curso_id;

            miComando.Parameters.Add("@Curso_nombre", SqlDbType.VarChar);
            miComando.Parameters["@Curso_nombre"].Value = elCurso.Curso_nombre;

            miComando.Parameters.Add("@Curso_creditos", SqlDbType.VarChar);
            miComando.Parameters["@Curso_creditos"].Value = elCurso.Curso_creditos;

            miComando.Parameters.Add("@Curso_cupo", SqlDbType.VarChar);
            miComando.Parameters["@Curso_cupo"].Value = elCurso.Curso_cupo;

            miComando.Parameters.Add("@Curso_estado", SqlDbType.VarChar);
            miComando.Parameters["@Curso_estado"].Value = elCurso.Curso_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Modificar Curso");

            return respuesta;
        }

        public DataTable ListarCurso()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor ListarCursos");

            miComando.CommandText = "ListarCurso";

            DataSet elCurso = new DataSet();
            this.abrirConexion();
            elCurso = this.seleccionarInformacion(miComando);
            DataTable miDataTable = elCurso.Tables[0];
            this.cerrarConexion();

            return miDataTable;
        }

        public DataSet ConsultarCurso(int Curso_id)
        {
            miComando.CommandText = "ConsultarCurso";

            miComando.Parameters.AddWithValue("@Curso_id", SqlDbType.Int);
            miComando.Parameters["@Curso_id"].Value = Curso_id;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        public string InactivarCurso(int Curso_id)
        {
            miComando = new SqlCommand();

            Console.WriteLine("Gestor InactivarCurso");

            miComando.CommandText = "InactivarCurso";

            miComando.Parameters.AddWithValue("@Curso_id", SqlDbType.Int);
            miComando.Parameters["@Curso_id"].Value = Curso_id;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor InactivarCurso Estudiante");

            return respuesta;
        }
    }
}
