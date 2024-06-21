using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using ClaseBase;

namespace Views.services
{
    public class UsuarioService
    {
        public static List<Usuario> getUsuariosByName(string nombre)
        {
            string query = "SELECT * FRMO dbo.Usuario WHERE Usu_NombreUsuario LIKE '%@nombre%'";
            List<Usuario> usuarios = new();
            using (SqlConnection conn = new(Views.Form1.ConnectionString))
            {
                SqlCommand cmd = new(query, conn);
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar);
                cmd.Parameters["@nombre"].Value = nombre;
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        Usuario usuario = new();
                        usuario.Usu_ID = (int)reader[0];
                        usuario.Usu_NombreUsuario = reader[1].ToString();
                        usuario.Usu_Contraseña = reader[2].ToString();
                        usuario.Usu_ApellidoNombre = reader[3].ToString();
                        usuario.Rol_Codigo = (int)reader[4];
                    }
                }
                
            }
            return usuarios;
        }
        public static string getUserRol()
        {
            string query = "SELECT Rol_Descripcion FROM dbo.Rol WHERE Rol_Codigo = @Id";
            using (SqlConnection conn = new(Views.Form1.ConnectionString))
            {
                SqlCommand cmd = new(query, conn);
                cmd.Parameters.Add("@Id", SqlDbType.Int);
                cmd.Parameters["@Id"].Value = Globals.currentUser.Rol_Codigo;
                conn.Open();
                try
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        return reader[0].ToString();
                    }
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp.Message);
                }
            }
            return null;
        }
    }
}
