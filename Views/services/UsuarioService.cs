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
            string query = @"SELECT * FROM dbo.Usuario WHERE Usu_NombreUsuario LIKE @SEARCH;";
            List<Usuario> usuarios = new();
            using (SqlConnection conn = new(Views.Form1.ConnectionString))
            {
                SqlCommand cmd = new(query, conn);
                cmd.Parameters.Add("@SEARCH", SqlDbType.VarChar);
                cmd.Parameters["@SEARCH"].Value = "%" + nombre + "%";
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        Usuario usuario = new();
                        usuario.Usu_ID = Convert.ToInt32(reader["Usu_ID"]);
                        usuario.Usu_NombreUsuario = reader["Usu_NombreUsuario"].ToString();
                        usuario.Usu_Contraseña = reader["Usu_Contraseña"].ToString();
                        usuario.Usu_ApellidoNombre = reader["Usu_ApellidoNombre"].ToString();
                        usuario.Rol_Codigo = Convert.ToInt32(reader["Rol_Codigo"]);
                        usuarios.Add(usuario);
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
