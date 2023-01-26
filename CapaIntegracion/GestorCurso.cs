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
    public class GestorCurso : servicio, IDisposable
    {
        public GestorCurso() : base("", "")
        {

        }
        public void Dispose()
        {

        }

        //Metodo para Insertar Curso
        public string InsertarCurso(string Curso_nombre, string Curso_creditos, string Curso_cupo,
                                    string Curso_estado)
        {
            Curso nuevoCurso = new Curso(Curso_nombre, Curso_creditos, Curso_cupo,
                                         Curso_estado);
            using (ServicioCurso elCurso = new ServicioCurso())
            {
                return elCurso.InsertarCurso(nuevoCurso);
            }
        }

        //Metodo para Modificar Curso
        public string ModificarCurso(int Curso_id, string Curso_nombre, string Curso_creditos,
                                         string Curso_cupo, string Curso_estado)
        {
            Curso nuevoCurso = new Curso(Curso_id, Curso_nombre, Curso_creditos, Curso_cupo, Curso_estado);
            using (ServicioCurso elCurso = new ServicioCurso())
            {
                return elCurso.ModificarCurso(nuevoCurso);
            }
        }

        public DataTable ListarCurso()
        {
            using (ServicioCurso elCurso = new ServicioCurso())
            {
                return elCurso.ListarCurso();
            }
        }

        public DataSet ConsultarCurso(int Curso_id)
        {
            using (ServicioCurso elCurso = new ServicioCurso())
            {
                return elCurso.ConsultarCurso(Curso_id);
            }
        }

        public string InactivarCurso(int Curso_id)
        {
            using (ServicioCurso elCurso = new ServicioCurso())
            {
                return elCurso.InactivarCurso(Curso_id);
            }
        }
    }
}
