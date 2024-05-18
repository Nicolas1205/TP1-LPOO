using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseBase
{
    public class Disciplina
    {
        // Propiedades con getters y setters automáticos
        public string Dis_ID { get; set; }
        public string Dis_Nombre { get; set; }
        public string Dis_Descripcion { get; set; }

        // Constructor vacío
        public Disciplina()
        {
        }

        // Constructor con argumentos
        public Disciplina(string disID, string disNombre, string disDescripcion)
        {
            Dis_ID = disID;
            Dis_Nombre = disNombre;
            Dis_Descripcion = disDescripcion;
        }

        public override string ToString()
        {
            return this.Dis_Nombre; 
        }
    }


}
