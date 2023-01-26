using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMatricula.CapaLogica.LogicaNegocio
{
    public class Estudiante
    {
        #region ATRIBUTOS
        protected int estudiante_id;
        protected int grupo_id;
        protected string estudiante_cedula;
        protected string estudiante_nombre;
        protected string estudiante_primerApellido;
        protected string estudiante_segundoApellido;
        protected string estudiante_telefono;
        protected string estudiante_correoElectronico;
        protected string estudiante_direccion;
        protected string estudiante_estado;
        
        #endregion

        #region CONSTRUCTOR
        public Estudiante()
        {

        }

        public Estudiante(int Pgrupo_id, string Pestudiante_cedula, string Pestudiante_nombre,
                string Pestudiante_primerApellido, string Pestudiante_segundoApellido, string Pestudiante_telefono,
                string Pestudiante_correoElectronico, string Pestudiante_direccion, string Pestudiante_estado)
        {
            Estudiante_id = 0;
            Grupo_id = Pgrupo_id;
            Estudiante_cedula = Pestudiante_cedula;
            Estudiante_nombre = Pestudiante_nombre;
            Estudiante_primerApellido = Pestudiante_primerApellido;
            Estudiante_segundoApellido = Pestudiante_segundoApellido;
            Estudiante_telefono = Pestudiante_telefono;
            Estudiante_correoElectronico = Pestudiante_correoElectronico;
            Estudiante_direccion = Pestudiante_direccion;
            Estudiante_estado = Pestudiante_estado;
        }

        public Estudiante(int Pestudiante_id, int Pgrupo_id, string Pestudiante_cedula, string Pestudiante_nombre,
                string Pestudiante_primerApellido, string Pestudiante_segundoApellido, string Pestudiante_telefono,
                string Pestudiante_correoElectronico, string Pestudiante_direccion, string Pestudiante_estado)
        {
            Estudiante_id = Pestudiante_id;
            Grupo_id = Pgrupo_id;
            Estudiante_cedula = Pestudiante_cedula;
            Estudiante_nombre = Pestudiante_nombre;
            Estudiante_primerApellido = Pestudiante_primerApellido;
            Estudiante_segundoApellido = Pestudiante_segundoApellido;
            Estudiante_telefono = Pestudiante_telefono;
            Estudiante_correoElectronico = Pestudiante_correoElectronico;
            Estudiante_direccion = Pestudiante_direccion;
            Estudiante_estado = Pestudiante_estado;
        }

        #endregion

        #region SET's Y GET's
        public int Estudiante_id { get => estudiante_id; set => estudiante_id = value; }
        public int Grupo_id { get => grupo_id; set => grupo_id = value; }
        public string Estudiante_cedula { get => estudiante_cedula; set => estudiante_cedula = value; }
        public string Estudiante_nombre { get => estudiante_nombre; set => estudiante_nombre = value; }
        public string Estudiante_primerApellido { get => estudiante_primerApellido; set => estudiante_primerApellido = value; }
        public string Estudiante_segundoApellido { get => estudiante_segundoApellido; set => estudiante_segundoApellido = value; }
        public string Estudiante_telefono { get => estudiante_telefono; set => estudiante_telefono = value; }
        public string Estudiante_correoElectronico { get => estudiante_correoElectronico; set => estudiante_correoElectronico = value; }
        public string Estudiante_direccion { get => estudiante_direccion; set => estudiante_direccion = value; }
        public string Estudiante_estado { get => estudiante_estado; set => estudiante_estado = value; }
        #endregion
    }
}
