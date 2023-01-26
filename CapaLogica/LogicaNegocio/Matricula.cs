using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMatricula.CapaLogica.LogicaNegocio
{
    public class Matricula
    {
        #region ATRIBUTOS
        protected int matricula_id;
        protected int estudiante_id;
        protected int grupo_id;
        protected int curso_id;
        protected int profesor_id;
        protected int horario_id;
        protected int aula_id;
        protected string matricula_comprobante;
        protected string matricula_estado;

        

        #endregion

        #region CONSTRUCTOR
        public Matricula()
        {

        }

        public Matricula(int Pestudiante_id, int Pgrupo_id, int Pcurso_id, int Pprofesor_id,
                         int Phorario_id, int Paula_id, string Pmatricula_comprobante, string Pmatricula_estado)
        {
            Matricula_id = 0;
            Estudiante_id = Pestudiante_id;
            Grupo_id = Pgrupo_id;
            Curso_id = Pcurso_id;
            Profesor_id = Pprofesor_id;
            Horario_id = Phorario_id;
            Aula_id = Paula_id;
            Matricula_comprobante = Pmatricula_comprobante;
            Matricula_estado = Pmatricula_estado;
        }

        public Matricula(int Pmatricula_id, int Pestudiante_id, int Pgrupo_id, int Pcurso_id, int Pprofesor_id,
                         int Phorario_id, int Paula_id, string Pmatricula_comprobante, string Pmatricula_estado)
        {
            Matricula_id = Pmatricula_id;
            Estudiante_id = Pestudiante_id;
            Grupo_id = Pgrupo_id;
            Curso_id = Pcurso_id;
            Profesor_id = Pprofesor_id;
            Horario_id = Phorario_id;
            Aula_id = Paula_id;
            Matricula_comprobante = Pmatricula_comprobante;
            Matricula_estado = Pmatricula_estado;
        }

        #endregion


        #region SET's Y GET's
        public int Matricula_id { get => matricula_id; set => matricula_id = value; }
        public int Estudiante_id { get => estudiante_id; set => estudiante_id = value; }
        public int Grupo_id { get => grupo_id; set => grupo_id = value; }
        public int Curso_id { get => curso_id; set => curso_id = value; }
        public int Profesor_id { get => profesor_id; set => profesor_id = value; }
        public int Horario_id { get => horario_id; set => horario_id = value; }
        public int Aula_id { get => aula_id; set => aula_id = value; }
        public string Matricula_comprobante { get => matricula_comprobante; set => matricula_comprobante = value; }
        public string Matricula_estado { get => matricula_estado; set => matricula_estado = value; }
        #endregion
    }
}
