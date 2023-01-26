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
    public class ServicioHorario : servicio, IDisposable//para liberar memoria
    {
        private string respuesta;
        private SqlCommand miComando;

        public ServicioHorario() : base("", "")
        {
            respuesta = "";
            miComando = new SqlCommand();
        }

        public void Dispose()
        {

        }

        //Metodo para el SP InsertarHorario
        public string InsertarHorario(Horario elHorario)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Insertar Horario");

            miComando.CommandText = "InsertarHorario";

            miComando.Parameters.Add("@Horario_descripcion", SqlDbType.VarChar);
            miComando.Parameters["@Horario_descripcion"].Value = elHorario.Horario_descripcion;

            miComando.Parameters.Add("@Horario_dia", SqlDbType.VarChar);
            miComando.Parameters["@Horario_dia"].Value = elHorario.Horario_dia;

            miComando.Parameters.Add("@Horario_horaInicio", SqlDbType.VarChar);
            miComando.Parameters["@Horario_horaInicio"].Value = elHorario.Horario_horaInicio;

            miComando.Parameters.Add("@Horario_horaFinal", SqlDbType.VarChar);
            miComando.Parameters["@Horario_horaFinal"].Value = elHorario.Horario_horaFinal;

            miComando.Parameters.Add("@Horario_estado", SqlDbType.VarChar);
            miComando.Parameters["@Horario_estado"].Value = elHorario.Horario_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Insertar Horario");

            return respuesta;

        }

        //Metodo para el SP InsertarHorario
        public string ModificarHorario(Horario elHorario)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Modificar Horario");

            miComando.CommandText = "ModificarHorario";

            miComando.Parameters.Add("@Horario_id", SqlDbType.Int);
            miComando.Parameters["@Horario_id"].Value = elHorario.Horario_id;

            miComando.Parameters.Add("@Horario_descripcion", SqlDbType.VarChar);
            miComando.Parameters["@Horario_descripcion"].Value = elHorario.Horario_descripcion;

            miComando.Parameters.Add("@Horario_dia", SqlDbType.VarChar);
            miComando.Parameters["@Horario_dia"].Value = elHorario.Horario_dia;

            miComando.Parameters.Add("@Horario_horaInicio", SqlDbType.VarChar);
            miComando.Parameters["@Horario_horaInicio"].Value = elHorario.Horario_horaInicio;

            miComando.Parameters.Add("@Horario_horaFinal", SqlDbType.VarChar);
            miComando.Parameters["@Horario_horaFinal"].Value = elHorario.Horario_horaFinal;

            miComando.Parameters.Add("@Horario_estado", SqlDbType.VarChar);
            miComando.Parameters["@Horario_estado"].Value = elHorario.Horario_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Modificar Horario");

            return respuesta;

        }

        public DataTable ListarHorario()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor ListarHorario");

            miComando.CommandText = "ListarHorario";

            DataSet elHorario = new DataSet();
            this.abrirConexion();
            elHorario = this.seleccionarInformacion(miComando);
            DataTable miDataTable = elHorario.Tables[0];
            this.cerrarConexion();

            return miDataTable;
        }

        public DataSet ConsultarHorario(int Horario_id)
        {
            miComando.CommandText = "ConsultarHorario";

            miComando.Parameters.AddWithValue("@Horario_id", SqlDbType.Int);
            miComando.Parameters["@Horario_id"].Value = Horario_id;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        public string InactivarHorario(int Horario_id)
        {
            miComando = new SqlCommand();

            Console.WriteLine("Gestor InactivarHorario");

            miComando.CommandText = "InactivarHorario";

            miComando.Parameters.AddWithValue("@Horario_id", SqlDbType.Int);
            miComando.Parameters["@Horario_id"].Value = Horario_id;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Inactivar Horario");

            return respuesta;
        }
    }
}
