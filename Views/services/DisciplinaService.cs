using System;
using System.Collections.Generic;
using System.Data;
using ClaseBase;
using Microsoft.Data.SqlClient;

namespace Views.services
{
    public class DisciplinaService
    {
        public static void InsertDisciplina(Disciplina disciplina)
        {
            string query = "INSERT INTO dbo.Disciplina (Dis_ID, Dis_Nombre, Dis_Descripcion) VALUES(@ID, @Nombre, @Descripcion);";
            using (SqlConnection conn = new(Views.Form1.ConnectionString))
            {
                SqlCommand cmd = new(query, conn);
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = disciplina.Dis_ID;
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = disciplina.Dis_Nombre;
                cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = disciplina.Dis_Descripcion;

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

        public static void DeleteDisciplina(string id)
        {
            string query = "DELETE FROM dbo.Disciplina WHERE Dis_ID = @ID";
            using (SqlConnection conn = new(Views.Form1.ConnectionString))
            {
                SqlCommand cmd = new(query, conn);
                cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;

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

        public static Disciplina GetDisciplinaById(string id)
        {
            string query = "SELECT * FROM dbo.Disciplina WHERE Dis_ID = @ID";
            Disciplina disciplina = null;
            using (SqlConnection conn = new(Views.Form1.ConnectionString))
            {
                SqlCommand cmd = new(query, conn);
                cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;

                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            disciplina = new Disciplina
                            {
                                Dis_ID = Convert.ToInt32(reader["Dis_ID"]),
                                Dis_Nombre = reader["Dis_Nombre"].ToString(),
                                Dis_Descripcion = reader["Dis_Descripcion"].ToString()
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return disciplina;
        }

        public static List<Disciplina> GetAllDisciplinas()
        {
            string query = "SELECT * FROM dbo.Disciplina";
            List<Disciplina> disciplinas = new();
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
                            Disciplina disciplina = new()
                            {
                                Dis_ID = Convert.ToInt32(reader["Dis_ID"]),
                                Dis_Nombre = reader["Dis_Nombre"].ToString(),
                                Dis_Descripcion = reader["Dis_Descripcion"].ToString()
                            };
                            disciplinas.Add(disciplina);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return disciplinas;
        }

        public static void UpdateDisciplina(Disciplina disciplina)
        {
            string query = "UPDATE dbo.Disciplina SET Dis_Nombre = @Nombre, Dis_Descripcion = @Descripcion WHERE Dis_ID = @ID";
            using (SqlConnection conn = new(Views.Form1.ConnectionString))
            {
                SqlCommand cmd = new(query, conn);
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = disciplina.Dis_Nombre;
                cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = disciplina.Dis_Descripcion;
                cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = disciplina.Dis_ID;

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
