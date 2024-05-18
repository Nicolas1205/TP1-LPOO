using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseBase
{
    public class Categoria
    {
        // Propiedades con getters y setters automáticos
        public string Cat_ID { get; set; }
        public string Cat_Nombre { get; set; }
        public string Cat_Descripcion { get; set; }

        // Constructor vacío
        public Categoria()
        {
        }

        // Constructor con argumentos
        public Categoria(string catID, string catNombre, string catDescripcion)
        {
            Cat_ID = catID;
            Cat_Nombre = catNombre;
            Cat_Descripcion = catDescripcion;
        }
    }

}
