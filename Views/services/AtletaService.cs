using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClaseBase;
using Microsoft.Data.SqlClient;

namespace Views.services
{
    public class AtletaService
    {
        public static void insertAtleta(Atleta atleta)
        {
            string query = "INSERT INTO dbo.Atleta (Atl_ID, Atl_DNI, Atl_Apellido, Atl_Nombre) VALUES(@ID, @DNI, @Apellido, @Nombre);";
            using (SqlConnection conn = new(Views.Form1.ConnectionString))
            {
                SqlCommand cmd = new(query, conn);
                cmd.Parameters.Add("@ID", SqlDbType.Int);
                cmd.Parameters.Add("@DNI", SqlDbType.VarChar);
                cmd.Parameters.Add("@Apellido", SqlDbType.VarChar);
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar);
                cmd.Parameters["@ID"].Value = atleta.Atl_ID; 
                cmd.Parameters["@DNI"].Value = atleta.Atl_DNI; 
                cmd.Parameters["@Apellido"].Value = atleta.Atl_Apellido; 
                cmd.Parameters["@Nombre"].Value = atleta.Atl_Nombre; 
                try
                {
                    conn.Open();
                    Int32 rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine("RowsAffected: {0}", rowsAffected);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public static void deleteAtleta(Atleta atleta)
        {
            string query = "DELETE FROM dbo.Atleta WHERE Atl_ID = @Id";
            using (SqlConnection conn = new(Views.Form1.ConnectionString))
            {
                SqlCommand cmd = new(query, conn);
                cmd.Parameters.Add("@Id", SqlDbType.Int);
                cmd.Parameters["@Id"].Value = atleta.Atl_ID; 
                try
                {
                    conn.Open();
                    Int32 rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine("RowsAffected: {0}", rowsAffected);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }
        public static Atleta getAtletaById(Int32 Id)
        {
            string query = "SELECT * FROM dbo.Atleta WHERE Atl_ID = @Id";
            Atleta atleta = new();
            using (SqlConnection conn = new(Views.Form1.ConnectionString))
            {
                SqlCommand cmd = new(query, conn);
                conn.Open();
                try
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        atleta.Atl_ID = Int32.Parse(reader[0].ToString());
                        atleta.Atl_DNI = reader[1].ToString();
                        atleta.Atl_Nombre = reader[2].ToString();
                        atleta.Atl_Apellido = reader[3].ToString();
                    }
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp.Message);
                }
            }
            return atleta;
        }

        public static List<Atleta> getAllAtletas()
        {
            string getAllAtletasQuery = "SELECT * FROM dbo.Atleta";
            List<Atleta> atletas = new();
            using (SqlConnection conn = new(Views.Form1.ConnectionString))
            {
                SqlCommand cmd = new(getAllAtletasQuery, conn);
                conn.Open();
                try
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            Atleta atleta = new();
                            atleta.Atl_ID = Int32.Parse(reader[0].ToString());
                            atleta.Atl_DNI = reader[1].ToString();
                            atleta.Atl_Nombre = reader[2].ToString();
                            atleta.Atl_Apellido = reader[3].ToString();
                            atletas.Add(atleta);
                        }
                    }
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp.Message);
                }
            }
            return atletas;
        }

        public static void updateAtleta(Atleta atleta)
        {
            string updateAtletaById = "UPDATE dbo.Atleta" +
                " SET Atl_Nombre = @Nombre" +
                " Atl_Apellido = @Apellido" +
                " Atl_DNI = @DNI" +
                " WHERE Atl_ID = @Atl_ID";
            using (SqlConnection conn = new(Views.Form1.ConnectionString))
            {
                SqlCommand cmd = new(updateAtletaById, conn);
                cmd.Parameters.Add("@Nombre", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@Apellido", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@DNI", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@Atl_ID", System.Data.SqlDbType.Int);
                cmd.Parameters["@Nombre"].Value = atleta.Atl_Nombre;
                cmd.Parameters["@Apellido"].Value = atleta.Atl_Apellido;
                cmd.Parameters["@DNI"].Value = atleta.Atl_DNI;
                cmd.Parameters["@Atl_ID"].Value = atleta.Atl_ID;

                try
                {
                    conn.Open();
                    Int32 rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine("RowsAffected: {0}", rowsAffected);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
