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
    public class GestorMatricula : servicio, IDisposable
    {
        public GestorMatricula() : base("", "")
        {

        }
        public void Dispose()
        {

        }

        //Metodo para Insertar Matricula
        public string InsertarMatricula(int Estudiante_id, int Grupo_id, int Curso_id, int Profesor_id,
                                        int Horario_id, int Aula_id, string Matricula_comprobante, string Matricula_estado)
        {
            Matricula nuevoMatricula = new Matricula(Estudiante_id, Grupo_id, Curso_id, Profesor_id, Horario_id,
                                                        Aula_id, Matricula_comprobante, Matricula_estado);
            using (ServicioMatricula laMatricula = new ServicioMatricula())
            {
                return laMatricula.InsertarMatricula(nuevoMatricula);
            }
        }

        //Metodo para Modificar Matricula
        public string ModificarMatricula(int Matricula_id, int Estudiante_id, int Grupo_id, int Curso_id, int Profesor_id,
                                        int Horario_id, int Aula_id, string Matricula_comprobante, string Matricula_estado)
        {
            Matricula nuevoMatricula = new Matricula(Matricula_id, Estudiante_id, Grupo_id, Curso_id, Profesor_id, Horario_id,
                                                        Aula_id, Matricula_comprobante, Matricula_estado);
            using (ServicioMatricula laMatricula = new ServicioMatricula())
            {
                return laMatricula.ModificarMatricula(nuevoMatricula);
            }
        }

        public DataSet ConsultarMatricula(int Matricula_id)
        {
            using (ServicioMatricula elMatricula = new ServicioMatricula())
            {
                return elMatricula.ConsultarMatricula(Matricula_id);
            }
        }

        public DataTable ListarMatricula()
        {
            using (ServicioMatricula laMatricula = new ServicioMatricula())
            {
                return laMatricula.ListarMatricula();
            }
        }

        public string InactivarMatricula(int Matricula_id)
        {
            using (ServicioMatricula laMatricula = new ServicioMatricula())
            {
                return laMatricula.InactivarMatricula(Matricula_id);
            }
        }
    }
}
