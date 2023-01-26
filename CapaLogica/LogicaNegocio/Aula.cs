using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMatricula.CapaLogica.LogicaNegocio
{
    public class Aula
    {
        #region ATRIBUTOS
        protected int aula_id;
        protected string aula_descripcion;
        protected string aula_estado;

        
        #endregion

        #region CONSTRUCTOR
        public Aula()
        {

        }
        public Aula(string Paula_descripcion, string Paula_estado)
        {
            Aula_id = 0;
            Aula_descripcion = Paula_descripcion;
            Aula_estado = Paula_estado;
        }

        public Aula(int Paula_id, string Paula_descripcion, string Paula_estado)
        {
            Aula_id = Paula_id;
            Aula_descripcion = Paula_descripcion;
            Aula_estado = Paula_estado;
        }

        #endregion

        #region SET's Y GET's
        public int Aula_id { get => aula_id; set => aula_id = value; }
        public string Aula_descripcion { get => aula_descripcion; set => aula_descripcion = value; }
        public string Aula_estado { get => aula_estado; set => aula_estado = value; }
        #endregion
    }
}
