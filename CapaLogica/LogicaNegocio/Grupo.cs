using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMatricula.CapaLogica.LogicaNegocio
{
    public class Grupo
    {
        #region ATRIBUTOS
        protected int grupo_id;
        protected string grupo_descripcion;
        protected string grupo_estado;

        public Grupo()
        {

        }

        public Grupo( string Pgrupo_descripcion, string Pgrupo_estado)
        {
            
            Grupo_descripcion = Pgrupo_descripcion;
            Grupo_estado = Pgrupo_estado;
        }
        public Grupo(int Pgrupo_id, string Pgrupo_descripcion, string Pgrupo_estado)
        {
            Grupo_id = Pgrupo_id;
            Grupo_descripcion = Pgrupo_descripcion;
            Grupo_estado = Pgrupo_estado;
        }
        #endregion

        #region SET's Y GET's
        public int Grupo_id { get => grupo_id; set => grupo_id = value; }
        public string Grupo_descripcion { get => grupo_descripcion; set => grupo_descripcion = value; }
        public string Grupo_estado { get => grupo_estado; set => grupo_estado = value; }
        #endregion
    }
}
