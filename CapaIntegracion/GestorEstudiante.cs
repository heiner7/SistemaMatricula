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
    public class GestorEstudiante: servicio, IDisposable
    {
        public GestorEstudiante(string usuario, string contra) : base(usuario, contra)
        {
            ServicioEstudiante elEstudiante = new ServicioEstudiante(usuario, contra);
            
        }

        public GestorEstudiante(): base("","")
        {

        }
        public void Dispose()
        {

        }

        //Metodo para Insertar Estudiante
        public string InsertarEstudiante(int Grupo_id, string Estudiante_cedula, string Estudiante_nombre,
                                         string Estudiante_primerApellido, string Estudiante_segundoApellido, 
                                         string Estudiante_telefono, string Estudiante_correoElectronico,
                                         string Estudiante_direccion, string Estudiante_estado)
        {
            Estudiante nuevoEstudiante = new Estudiante(Grupo_id, Estudiante_cedula, Estudiante_nombre,
                                                        Estudiante_primerApellido, Estudiante_segundoApellido,
                                                        Estudiante_telefono, Estudiante_correoElectronico,
                                                        Estudiante_direccion, Estudiante_estado);
            using (ServicioEstudiante elEstudiante = new ServicioEstudiante())
            {
                return elEstudiante.InsertarEstudiante(nuevoEstudiante);
            }
        }

        //Metodo para Modificar Estudiante
        public string ModificarEstudiante(int Estudiante_id, int Grupo_id, string Estudiante_cedula, string Estudiante_nombre,
                                         string Estudiante_primerApellido, string Estudiante_segundoApellido,
                                         string Estudiante_telefono, string Estudiante_correoElectronico,
                                         string Estudiante_direccion, string Estudiante_estado)
        {
            Estudiante nuevoEstudiante = new Estudiante(Estudiante_id, Grupo_id, Estudiante_cedula, Estudiante_nombre,
                                                        Estudiante_primerApellido, Estudiante_segundoApellido,
                                                        Estudiante_telefono, Estudiante_correoElectronico,
                                                        Estudiante_direccion, Estudiante_estado);
            using (ServicioEstudiante elEstudiante = new ServicioEstudiante())
            {
                return elEstudiante.ModificarEstudiante(nuevoEstudiante);
            }
        }

        public DataSet ConsultarEstudiante(int Estudiante_id)
        {
            using (ServicioEstudiante elEstudiante = new ServicioEstudiante())
            {
                return elEstudiante.ConsultarEstudiante(Estudiante_id);
            }
        }

        public DataTable ListarEstudiante()
        {
            using (ServicioEstudiante elEstudiante = new ServicioEstudiante())
            {
                return elEstudiante.ListarEstudiante();
            }
        }

        public string InactivarEstudiante(int Estudiante_id)
        {
            using (ServicioEstudiante elEstudiante = new ServicioEstudiante())
            {
                return elEstudiante.InactivarEstudiante(Estudiante_id);
            }
        }

        public string EliminarEstudiante(int Estudiante_id)
        {
            using (ServicioEstudiante elEstudiante = new ServicioEstudiante())
            {
                return elEstudiante.EliminarEstudiante(Estudiante_id);
            }
        }
    }
}
