using System.Data;
using ClaseBase;
using Microsoft.Data.SqlClient;

namespace Views.services
{
    public class CompetenciaService
    {
        public static void deleteCompetencia(int Com_ID)
        {
            string query = "DELETE FROM dbo.Competencia WHERE Com_ID = @Com_ID";
            using (SqlConnection conn = new(Views.Form1.ConnectionString))
            {
                SqlCommand cmd = new(query, conn);
                cmd.Parameters.Add("@Com_ID", SqlDbType.Int);
                cmd.Parameters["@Com_ID"].Value = Com_ID;
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

        public static void updateCompetencia(Competencia updated_competencia)
        {
            string query = "UPDATE dbo.Competencia " +
                " SET Com_Nombre = @Com_Nombre," +
                " Com_FechaInicio = @Com_FechaInicio," +
                " Com_FechaFin = @Com_FechaFin," +
                " Com_Estado = @Com_Estado," +
                " Cat_ID = @Cat_ID," +
                " Dis_ID = @Dis_ID" +
                " WHERE Com_ID = @Com_ID";
            using (SqlConnection conn = new(Views.Form1.ConnectionString))
            {
                SqlCommand cmd = new(query, conn);
                cmd.Parameters.Add("@Com_ID", SqlDbType.Int);
                cmd.Parameters.Add("@Com_Nombre", SqlDbType.VarChar);
                cmd.Parameters.Add("@Com_FechaInicio", SqlDbType.DateTime);
                cmd.Parameters.Add("@Com_FechaFin", SqlDbType.DateTime);
                cmd.Parameters.Add("@Com_Estado", SqlDbType.VarChar);
                cmd.Parameters.Add("@Cat_ID", SqlDbType.Int);
                cmd.Parameters.Add("@Dis_ID", SqlDbType.Int);
                cmd.Parameters["@Com_ID"].Value = updated_competencia.Com_ID;
                cmd.Parameters["@Com_Nombre"].Value = updated_competencia.Com_Nombre;
                cmd.Parameters["@Com_FechaInicio"].Value = updated_competencia.Com_FechaInicio;
                cmd.Parameters["@Com_FechaFin"].Value = updated_competencia.Com_FechaFin;
                cmd.Parameters["@Com_Estado"].Value = updated_competencia.Com_Estado;
                cmd.Parameters["@Cat_ID"].Value = updated_competencia.Cat_ID;
                cmd.Parameters["@Dis_ID"].Value = updated_competencia.Dis_ID;
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

        
        public static List<Competencia> getAllCompetencias()
        {
            string query = "SELECT * FROM dbo.Competencia;";
            List<Competencia> competencias = new();
            using (SqlConnection conn = new(Views.Form1.ConnectionString))
            {
                SqlCommand cmd = new(query, conn);
                conn.Open();
                try
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            Competencia competencia = new();
                            competencia.Com_ID = Convert.ToInt32(reader["Com_ID"]);
                            competencia.Com_Nombre= reader["Com_Nombre"].ToString();
                            competencia.Com_FechaInicio = DateTime.Parse(reader["Com_FechaInicio"].ToString());
                            competencia.Com_FechaFin = DateTime.Parse(reader["Com_FechaFin"].ToString());
                            competencia.Com_Estado= reader["Com_Estado"].ToString();
                            competencia.Cat_ID = Convert.ToInt32(reader["Cat_ID"]);
                            competencia.Dis_ID = Convert.ToInt32(reader["Dis_ID"]);
                            competencias.Add(competencia);
                        }
                    }
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp.Message);
                }
            }
            return competencias;
        }

        public static void InsertCompetencia(Competencia competencia)
        {
            string query = "INSERT INTO dbo.Competencia (Com_ID, Com_Nombre, Com_FechaInicio, Com_FechaFin, Com_Estado, Cat_ID, Dis_ID) VALUES(@Com_ID, @Com_Nombre, @Com_FechaInicio, @Com_FechaFin, @Com_Estado, @Cat_ID, @Dis_ID);";
            using (SqlConnection conn = new(Views.Form1.ConnectionString))
            {
                SqlCommand cmd = new(query, conn);
                cmd.Parameters.Add("@Com_ID", SqlDbType.Int);
                cmd.Parameters.Add("@Com_Nombre", SqlDbType.VarChar);
                cmd.Parameters.Add("@Com_FechaInicio", SqlDbType.DateTime);
                cmd.Parameters.Add("@Com_FechaFin", SqlDbType.DateTime);
                cmd.Parameters.Add("@Com_Estado", SqlDbType.VarChar);
                cmd.Parameters.Add("@Cat_ID", SqlDbType.Int);
                cmd.Parameters.Add("@Dis_ID", SqlDbType.Int);
                cmd.Parameters["@Com_ID"].Value = competencia.Com_ID;
                cmd.Parameters["@Com_Nombre"].Value = competencia.Com_Nombre;
                cmd.Parameters["@Com_FechaInicio"].Value = competencia.Com_FechaInicio;
                cmd.Parameters["@Com_FechaFin"].Value = competencia.Com_FechaFin;
                cmd.Parameters["@Com_Estado"].Value = competencia.Com_Estado;
                cmd.Parameters["@Cat_ID"].Value = competencia.Cat_ID;
                cmd.Parameters["@Dis_ID"].Value = competencia.Dis_ID;
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
