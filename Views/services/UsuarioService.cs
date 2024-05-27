using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Views.services
{
    public class UsuarioService
    {
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
