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
        public void deleteAtleta(Int32 Id)
        {
            string query = "DELETE FROM dbo.Atleta WHERE Atl_ID = @Id";
            Atleta atleta = new();
            using (SqlConnection conn = new(Views.Form1.ConnectionString))
            {
                SqlCommand cmd = new(query, conn);
                cmd.Parameters.Add("@Id", SqlDbType.Int);
                cmd.Parameters["@Id"].Value = Id; 
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
        public Atleta getAtletaById(Int32 Id)
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

        public List<Atleta> getAllAtletas()
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

        public void updateAtleta(Atleta atleta)
        {
            string updateAtletaById = "UPDATE dbo.Atleta" +
                "SET Atl_Nombre = @Nombre" +
                "Atl_Apellido = @Apellido" +
                "Atl_DNI = @DNI" +
                "WHERE Atl_ID = @Atl_ID";
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
