using ClaseBase;
using System;
using System.Security.Cryptography.X509Certificates;
using Views.views;
using Microsoft.Data.SqlClient;

namespace Views
{
    public partial class Form1 : Form
    {
        public const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\GISELA\code\LPOO\TP1\Views\db.mdf;Integrated Security=True";

        SqlConnection conn;

        public Form1()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string findUserByUsername = String.Format(@"SELECT * FROM dbo.Usuario WHERE Usu_NombreUsuario = '{0}';", username_textbox.Text);
            Usuario user = new Usuario();
            using (SqlConnection conn = new(ConnectionString))
            {
                SqlCommand cmd = new(findUserByUsername, conn);
                conn.Open();
                try
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        if (reader[2].ToString() == password_textbox.Text)
                        {
                            Globals.currentUser.Usu_ID = Int32.Parse(reader[0].ToString());
                            Globals.currentUser.Usu_NombreUsuario = reader[1].ToString();
                            Globals.currentUser.Usu_Contraseña= reader[2].ToString();
                            Globals.currentUser.Usu_ApellidoNombre = reader[3].ToString();
                            Globals.currentUser.Rol_Codigo = Int32.Parse(reader[4].ToString());
                            var main = new Main();
                            main.Show();
                            this.Hide();
                            return;
                        }
                        invalid_credentials_label.Text = "El Nombre de Usuario o Contraseña son incorrectos";
                        invalid_credentials_label.ForeColor = Color.FromName("red");

                    }
                }
                catch (Exception exp)
                {
                    invalid_credentials_label.Text = "El Nombre de Usuario o Contraseña son incorrectos";
                    invalid_credentials_label.ForeColor = Color.FromName("red");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }

    public static class Globals
    {
        public static Usuario currentUser = new Usuario();
        public static List<Rol> roles = new List<Rol>();
        public static List<Atleta> atletas = new List<Atleta>();
        public static List<Evento> eventos = new List<Evento>();
        public static List<Competencia> competencias = new List<Competencia>();
        public static List<Disciplina> disciplinas = new List<Disciplina>();
        // Serial Id
        public static int currentSerialId = 0;
    }
}
