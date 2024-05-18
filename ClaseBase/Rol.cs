using System;

namespace ClaseBase
{
    public class Rol
    {
        // Propiedades con getters y setters automáticos
        public int Rol_Codigo { get; set; }
        public string Rol_Descripcion { get; set; }

        // Constructor vacío
        public Rol()
        {
        }

        // Constructor con argumentos
        public Rol(int rolCodigo, string rolDescripcion)
        {
            Rol_Codigo = rolCodigo;
            Rol_Descripcion = rolDescripcion;
        }
    }
}
