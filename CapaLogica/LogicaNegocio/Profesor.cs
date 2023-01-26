using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMatricula.CapaLogica.LogicaNegocio
{
    public class Profesor
    {
        #region ATRIBUTOS
        protected int profesor_id;
        protected string profesor_cedula;
        protected string profesor_nombre;
        protected string profesor_primerApellido;
        protected string profesor_segundoApellido;
        protected string profesor_telefono;
        protected string profesor_correoElectronico;
        protected string profesor_direccion;
        protected string profesor_estado;

        
        #endregion

        #region CONSTRUCTOR
        public Profesor()
        {

        }

        public Profesor(string Pprofesor_cedula, string Pprofesor_nombre,
                string Pprofesor_primerApellido, string Pprofesor_segundoApellido, string Pprofesor_telefono,
                string Pprofesor_correoElectronico, string Pprofesor_direccion, string Pprofesor_estado)
        {
            Profesor_cedula = Pprofesor_cedula;
            Profesor_nombre = Pprofesor_nombre;
            Profesor_primerApellido = Pprofesor_primerApellido;
            Profesor_segundoApellido = Pprofesor_segundoApellido;
            Profesor_telefono = Pprofesor_telefono;
            Profesor_correoElectronico = Pprofesor_correoElectronico;
            Profesor_direccion = Pprofesor_direccion;
            Profesor_estado = Pprofesor_estado;
        }

        public Profesor(int Pprofesor_id, string Pprofesor_cedula, string Pprofesor_nombre,
                string Pprofesor_primerApellido, string Pprofesor_segundoApellido, string Pprofesor_telefono,
                string Pprofesor_correoElectronico, string Pprofesor_direccion, string Pprofesor_estado)
        {
            Profesor_id = Pprofesor_id;
            Profesor_cedula = Pprofesor_cedula;
            Profesor_nombre = Pprofesor_nombre;
            Profesor_primerApellido = Pprofesor_primerApellido;
            Profesor_segundoApellido = Pprofesor_segundoApellido;
            Profesor_telefono = Pprofesor_telefono;
            Profesor_correoElectronico = Pprofesor_correoElectronico;
            Profesor_direccion = Pprofesor_direccion;
            Profesor_estado = Pprofesor_estado;
        }
        

        #endregion

        #region SET's Y GET's
        public int Profesor_id { get => profesor_id; set => profesor_id = value; }
        public string Profesor_cedula { get => profesor_cedula; set => profesor_cedula = value; }
        public string Profesor_nombre { get => profesor_nombre; set => profesor_nombre = value; }
        public string Profesor_primerApellido { get => profesor_primerApellido; set => profesor_primerApellido = value; }
        public string Profesor_segundoApellido { get => profesor_segundoApellido; set => profesor_segundoApellido = value; }
        public string Profesor_telefono { get => profesor_telefono; set => profesor_telefono = value; }
        public string Profesor_correoElectronico { get => profesor_correoElectronico; set => profesor_correoElectronico = value; }
        public string Profesor_direccion { get => profesor_direccion; set => profesor_direccion = value; }
        public string Profesor_estado { get => profesor_estado; set => profesor_estado = value; }
        #endregion
    }
}
