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
    public class GestorAula : servicio, IDisposable
    {

        public GestorAula() : base("", "")
        {

        }
        public void Dispose()
        {

        }

        //Metodo para Insertar Aula
        public string InsertarAula(string Aula_descripcion, string Aula_estado)
        {
            Aula nuevoAula = new Aula(Aula_descripcion, Aula_estado);
            using (ServicioAula elAula = new ServicioAula())
            {
                return elAula.InsertarAula(nuevoAula);
            }
        }

        //Metodo para Modificar Aula
        public string ModificarAula(int Aula_id, string Aula_descripcion, string Aula_estado)
        {
            Aula nuevoAula = new Aula(Aula_id, Aula_descripcion, Aula_estado);
            using (ServicioAula elAula = new ServicioAula())
            {
                return elAula.ModificarAula(nuevoAula);
            }
        }

        public DataSet ConsultarAula(int Aula_id)
        {
            using (ServicioAula elAula = new ServicioAula())
            {
                return elAula.ConsultarAula(Aula_id);
            }
        }

        public DataTable ListarAula()
        {
            using (ServicioAula elAula = new ServicioAula())
            {
                return elAula.ListarAula();
            }
        }

        public string InactivarAula(int Aula_id)
        {
            using (ServicioAula elAula = new ServicioAula())
            {
                return elAula.InactivarAula(Aula_id);
            }
        }
    }

}

