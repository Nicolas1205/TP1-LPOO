using System;
using System.Collections.Generic;
using System.Data;
using ClaseBase;
using Microsoft.Data.SqlClient;

namespace Views.services
{
    public class CategoriaService
    {
        public static void insertCategoria(Categoria categoria)
        {
            string query = "INSERT INTO dbo.Categoria (Cat_ID, Cat_Nombre, Cat_Descripcion) VALUES(@ID, @Nombre, @Descripcion);";
            using (SqlConnection conn = new(Views.Form1.ConnectionString))
            {
                SqlCommand cmd = new(query, conn);
                cmd.Parameters.Add("@ID", SqlDbType.Int);
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar);
                cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar);
                cmd.Parameters["@ID"].Value = categoria.Cat_ID;
                cmd.Parameters["@Nombre"].Value = categoria.Cat_Nombre;
                cmd.Parameters["@Descripcion"].Value = categoria.Cat_Descripcion;

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public static void deleteCategoria(Categoria categoria)
        {
            string query = "DELETE FROM dbo.Categoria WHERE Cat_ID = @ID";
            using (SqlConnection conn = new(Views.Form1.ConnectionString))
            {
                SqlCommand cmd = new(query, conn);
                cmd.Parameters.Add("@ID", SqlDbType.Int);
                cmd.Parameters["@ID"].Value = categoria.Cat_ID;

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public static Categoria getCategoriaById(int id)
        {
            string query = "SELECT * FROM dbo.Categoria WHERE Cat_ID = @ID";
            Categoria categoria = new();
            using (SqlConnection conn = new(Views.Form1.ConnectionString))
            {
                SqlCommand cmd = new(query, conn);
                cmd.Parameters.Add("@ID", SqlDbType.Int);
                cmd.Parameters["@ID"].Value = id;

                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            categoria.Cat_ID = Convert.ToInt32(reader["Cat_ID"]);
                            categoria.Cat_Nombre = reader["Cat_Nombre"].ToString();
                            categoria.Cat_Descripcion = reader["Cat_Descripcion"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return categoria;
        }

        public static List<Categoria> getAllCategorias()
        {
            string query = "SELECT * FROM dbo.Categoria";
            List<Categoria> categorias = new();
            using (SqlConnection conn = new(Views.Form1.ConnectionString))
            {
                SqlCommand cmd = new(query, conn);

                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Categoria categoria = new();
                            categoria.Cat_ID = Convert.ToInt32(reader["Cat_ID"]);
                            categoria.Cat_Nombre = reader["Cat_Nombre"].ToString();
                            categoria.Cat_Descripcion = reader["Cat_Descripcion"].ToString();
                            categorias.Add(categoria);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return categorias;
        }

        public static void updateCategoria(Categoria categoria)
        {
            string query = "UPDATE dbo.Categoria SET Cat_Nombre = @Nombre, Cat_Descripcion = @Descripcion WHERE Cat_ID = @ID";
            using (SqlConnection conn = new(Views.Form1.ConnectionString))
            {
                SqlCommand cmd = new(query, conn);
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar);
                cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar);
                cmd.Parameters.Add("@ID", SqlDbType.Int);
                cmd.Parameters["@Nombre"].Value = categoria.Cat_Nombre;
                cmd.Parameters["@Descripcion"].Value = categoria.Cat_Descripcion;
                cmd.Parameters["@ID"].Value = categoria.Cat_ID;

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
