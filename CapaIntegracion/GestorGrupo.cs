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
    public class GestorGrupo: servicio, IDisposable
    {

        public GestorGrupo() : base("", "")
        {

        }
        public void Dispose()
        {

        }

        //Metodo para Insertar Estudiante
        public string InsertarGrupo(string Grupo_descripcion,
                                    string Grupo_estado)
        {
            Grupo nuevoGrupo = new Grupo( Grupo_descripcion, Grupo_estado);
            using (ServicioGrupo elGrupo= new ServicioGrupo())
            {
                return elGrupo.InsertarGrupo(nuevoGrupo);
            }
        }

        public string ModificarGrupo(int Grupo_id, string Grupo_descripcion,
                                    string Grupo_estado)
        {
            Grupo nuevoGrupo = new Grupo(Grupo_id, Grupo_descripcion, Grupo_estado);
            using (ServicioGrupo elGrupo = new ServicioGrupo())
            {
                return elGrupo.ModificarGrupo(nuevoGrupo);
            }
        }

        public DataSet ConsultarGrupo(int Grupo_id)
        {
            using (ServicioGrupo elGrupo = new ServicioGrupo())
            {
                return elGrupo.ConsultarGrupo(Grupo_id);
            }
        }

        public DataTable ListarGrupo()
        {
            using (ServicioGrupo elGrupo = new ServicioGrupo())
            {
                return elGrupo.ListarGrupo();
            }
        }

        public string InactivarGrupo(int Grupo_id)
        {
            using (ServicioGrupo elGrupo = new ServicioGrupo())
            {
                return elGrupo.InactivarGrupo(Grupo_id);
            }
        }

        public string EliminarGrupo(int Grupo_id)
        {
            using (ServicioGrupo elGrupo = new ServicioGrupo())
            {
                return elGrupo.EliminarGrupo(Grupo_id);
            }
        }
    }
}
