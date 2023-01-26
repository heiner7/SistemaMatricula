using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMatricula.CapaLogica.LogicaNegocio
{
    public class Horario
    {
        #region ATRIBUTOS
        protected int horario_id;
        protected string horario_descripcion;
        protected string horario_dia;
        protected string horario_horaInicio;
        protected string horario_horaFinal;
        protected string horario_estado;

        #endregion

        #region CONSTRUCTOR
        public Horario()
        {

        }

        public Horario (string Phorario_descripcion, string Phorario_dia, string Phorario_horaInicio, string Phorario_horaFinal, string Phorario_estado)
        {
            Horario_id = 0;
            Horario_descripcion = Phorario_descripcion;
            Horario_dia = Phorario_dia;
            Horario_horaInicio = Phorario_horaInicio;
            Horario_horaFinal = Phorario_horaFinal;
            Horario_estado = Phorario_estado;
        }

        public Horario(int Phorario_id, string Phorario_descripcion, string Phorario_dia, string Phorario_horaInicio, string Phorario_horaFinal, string Phorario_estado)
        {
            Horario_id = Phorario_id;
            Horario_descripcion = Phorario_descripcion;
            Horario_dia = Phorario_dia;
            Horario_horaInicio = Phorario_horaInicio;
            Horario_horaFinal = Phorario_horaFinal;
            Horario_estado = Phorario_estado;
        }

        #endregion

        #region SET's Y GET's
        public int Horario_id { get => horario_id; set => horario_id = value; }
        public string Horario_descripcion { get => horario_descripcion; set => horario_descripcion = value; }
        public string Horario_dia { get => horario_dia; set => horario_dia = value; }
        public string Horario_horaInicio { get => horario_horaInicio; set => horario_horaInicio = value; }
        public string Horario_horaFinal { get => horario_horaFinal; set => horario_horaFinal = value; }
        public string Horario_estado { get => horario_estado; set => horario_estado = value; }
        #endregion
    }
}
