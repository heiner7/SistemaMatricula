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
    public class GestorProfesor: servicio, IDisposable
    {

        public GestorProfesor():base("","")
        {

        }
        public void Dispose()
        {

        }

        //Metodo para Insertar Estudiante
        public string InsertarProfesor(string Profesor_cedula, string Profesor_nombre,
                                         string Profesor_primerApellido, string Profesor_segundoApellido,
                                         string Profesor_telefono, string Profesor_correoElectronico,
                                         string Profesor_direccion, string Profesor_estado)
        {
            Profesor nuevoProfesor = new Profesor(Profesor_cedula, Profesor_nombre,
                                                        Profesor_primerApellido, Profesor_segundoApellido,
                                                        Profesor_telefono, Profesor_correoElectronico,
                                                        Profesor_direccion, Profesor_estado);
            using (ServicioProfesor elProfesor = new ServicioProfesor())
            {
                return elProfesor.InsertarProfesor(nuevoProfesor);
            }
        }

        //Metodo para Modificar Profesor
        public string ModificarProfesor(int Profesor_id, string Profesor_cedula, string Profesor_nombre,
                                         string Profesor_primerApellido, string Profesor_segundoApellido,
                                         string Profesor_telefono, string Profesor_correoElectronico,
                                         string Profesor_direccion, string Profesor_estado)
        {
            Profesor nuevoProfesor = new Profesor(Profesor_id, Profesor_cedula, Profesor_nombre,
                                                        Profesor_primerApellido, Profesor_segundoApellido,
                                                        Profesor_telefono, Profesor_correoElectronico,
                                                        Profesor_direccion, Profesor_estado);
            using (ServicioProfesor elProfesor = new ServicioProfesor())
            {
                return elProfesor.ModificarProfesor(nuevoProfesor);
            }
        }

        public DataSet ConsultarProfesor(int Profesor_id)
        {
            using (ServicioProfesor elProfesor = new ServicioProfesor())
            {
                return elProfesor.ConsultarProfesor(Profesor_id);
            }
        }

        public DataTable ListarProfesor()
        {
            using (ServicioProfesor elProfesor = new ServicioProfesor())
            {
                return elProfesor.ListarProfesor();
            }
        }

        public string InactivarProfesor(int Profesor_id)
        {
            using (ServicioProfesor elProfesor = new ServicioProfesor())
            {
                return elProfesor.InactivarProfesor(Profesor_id);
            }
        }

        public string EliminarProfesor(int Profesor_id)
        {
            using (ServicioProfesor elProfesor = new ServicioProfesor())
            {
                return elProfesor.EliminarProfesor(Profesor_id);
            }
        }
    }
}
