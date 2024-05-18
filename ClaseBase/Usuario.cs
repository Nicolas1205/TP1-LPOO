using System;

namespace ClaseBase
{
    public class Usuario
    {
        // Propiedades con getters y setters automáticos
        public int Usu_ID { get; set; }
        public string Usu_NombreUsuario { get; set; }
        public string Usu_Contraseña { get; set; }
        public string Usu_ApellidoNombre { get; set; }
        public int Rol_Codigo { get; set; }

        // Constructor vacío
        public Usuario()
        {
        }

        // Constructor con argumentos
        public Usuario(int usuID, string usuNombreUsuario, string usuContraseña, string? usuApellidoNombre, int? rolCodigo)
        {
            Usu_ID = usuID;
            Usu_NombreUsuario = usuNombreUsuario;
            Usu_Contraseña = usuContraseña;
            Usu_ApellidoNombre = usuApellidoNombre;
            Rol_Codigo = rolCodigo.GetValueOrDefault();
        }
    }

}
