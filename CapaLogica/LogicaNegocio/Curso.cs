using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMatricula.CapaLogica.LogicaNegocio
{
    public class Curso
    {
        #region ATRIBUTOS
        protected int curso_id;
        protected string curso_nombre;
        protected string curso_creditos;
        protected string curso_cupo;
        protected string curso_estado;

        #endregion

        #region CONSTRUCTOR
        public Curso()
        {

        }

        public Curso( string Pcurso_nombre, string Pcurso_creditos, string Pcurso_cupo, string Pcurso_estado)
        {
            Curso_nombre = Pcurso_nombre;
            Curso_creditos = Pcurso_creditos;
            Curso_cupo = Pcurso_cupo;
            Curso_estado = Pcurso_estado;
        }

        public Curso(int Pcurso_id, string Pcurso_nombre, string Pcurso_creditos, string Pcurso_cupo, string Pcurso_estado)
        {
            Curso_id = Pcurso_id;
            Curso_nombre = Pcurso_nombre;
            Curso_creditos = Pcurso_creditos;
            Curso_cupo = Pcurso_cupo;
            Curso_estado = Pcurso_estado;
        }
        #endregion

        #region SET's Y GET's
        public int Curso_id { get => curso_id; set => curso_id = value; }
        public string Curso_nombre { get => curso_nombre; set => curso_nombre = value; }
        public string Curso_creditos { get => curso_creditos; set => curso_creditos = value; }
        public string Curso_cupo { get => curso_cupo; set => curso_cupo = value; }
        public string Curso_estado { get => curso_estado; set => curso_estado = value; }
        #endregion
    }
}
