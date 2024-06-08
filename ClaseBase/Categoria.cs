using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseBase
{
    public class Categoria
    {
        public int Cat_ID { get; set; }
        public string Cat_Nombre { get; set; }
        public string Cat_Descripcion { get; set; }

        public Categoria() { }

        public Categoria(int id, string nombre, string descripcion)
        {
            Cat_ID = id;
            Cat_Nombre = nombre;
            Cat_Descripcion = descripcion;
        }

        public override string ToString()
        {
            return this.Cat_Nombre;
        }
    }
}
