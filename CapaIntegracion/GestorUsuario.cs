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
    public class GestorUsuario : servicio, IDisposable
    {
        public GestorUsuario():base("","")
        {

        }
        public void Dispose()
        {

        }

        //Metodo para Insertar Usuario
        public string InsertarUsuario(string Usuario_nombre, string Usuario_contrasenna, string Usuario_estado)
        {
            Usuario nuevoUsuario = new Usuario(Usuario_nombre, Usuario_contrasenna, Usuario_estado);
            using (ServicioUsuario laMatricula = new ServicioUsuario())
            {
                return laMatricula.InsertarUsuario(nuevoUsuario);
            }
        }

        //Metodo para Insertar Usuario
        public string ModificarUsuario(int Usuario_id, string Usuario_nombre, string Usuario_contrasenna, string Usuario_estado)
        {
            Usuario nuevoUsuario = new Usuario(Usuario_id, Usuario_nombre, Usuario_contrasenna, Usuario_estado);
            using (ServicioUsuario laMatricula = new ServicioUsuario())
            {
                return laMatricula.ModificarUsuario(nuevoUsuario);
            }
        }

        public DataTable ListarUsuario()
        {
            using (ServicioUsuario elUsuario = new ServicioUsuario())
            {
                return elUsuario.ListarUsuario();
            }
        }

        public DataSet ConsultarUsuario(int Usuario_id)
        {
            using (ServicioUsuario elUsuario = new ServicioUsuario())
            {
                return elUsuario.ConsultarUsuario(Usuario_id);
            }
        }

        public string InactivarUsuario(int Usuario_id)
        {
            using (ServicioUsuario elUsuario = new ServicioUsuario())
            {
                return elUsuario.InactivarUsuario(Usuario_id);
            }
        }
    }
}
