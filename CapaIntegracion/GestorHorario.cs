using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Biblioteca SQL
using System.Data;
//Bibliotecas del sistema
using SistemaMatricula.CapaConexion;
using SistemaMatricula.CapaLogica.LogicaNegocio;
using SistemaMatricula.CapaLogica.Servicio;

namespace SistemaMatricula.CapaIntegracion
{
    public class GestorHorario : servicio, IDisposable
    {
        public GestorHorario() : base("", "")
        {

        }
        public void Dispose()
        {

        }

        //Metodo para Insertar Horario
        public string InsertarHorario(string Horario_descripcion,
                                      string Horario_dia, string Horario_horaInicio,
                                      string Horario_horaFinal, string Horario_estado)
        {
            Horario nuevoHorario = new Horario (Horario_descripcion, Horario_dia,
                                                Horario_horaInicio, Horario_horaFinal, Horario_estado);
            using (ServicioHorario elHorario = new ServicioHorario())
            {
                return elHorario.InsertarHorario(nuevoHorario);
            }
        }

        //Metodo para Modificar Horario
        public string ModificarHorario(int Horario_id, string Horario_descripcion,
                                      string Horario_dia, string Horario_horaInicio,
                                      string Horario_horaFinal, string Horario_estado)
        {
            Horario nuevoHorario = new Horario(Horario_id, Horario_descripcion, Horario_dia,
                                                Horario_horaInicio, Horario_horaFinal, Horario_estado);
            using (ServicioHorario elHorario = new ServicioHorario())
            {
                return elHorario.ModificarHorario(nuevoHorario);
            }
        }

        public DataSet ConsultarHorario(int Horario_id)
        {
            using (ServicioHorario elHorario = new ServicioHorario())
            {
                return elHorario.ConsultarHorario(Horario_id);
            }
        }

        public DataTable ListarHorario()
        {
            using (ServicioHorario elHorario = new ServicioHorario())
            {
                return elHorario.ListarHorario();
            }
        }

        public string InactivarHorario(int Horario_id)
        {
            using (ServicioHorario elHorario = new ServicioHorario())
            {
                return elHorario.InactivarHorario(Horario_id);
            }
        }
    }
}
