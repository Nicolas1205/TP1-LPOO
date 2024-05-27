using ClaseBase;
using System;
using System.Security.Cryptography.X509Certificates;
using Views.views;
using Microsoft.Data.SqlClient;

namespace Views
{
    public partial class Form1 : Form
    {
        private const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\GISELA\Documents\db.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection conn;

        public Form1()
        {
            Globals.usuarios.Add(new(1, "nicolas", "nicolas", "", 1));
            Globals.usuarios.Add(new(1, "secadora", "secadora", "", 2));
            Globals.usuarios.Add(new(1, "dumb", "dumb", "", 3));
            Globals.roles.Add(new(1, "Operador"));
            Globals.roles.Add(new(2, "Vendedor"));
            Globals.roles.Add(new(3, "Administrador"));

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
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    if (reader[2].ToString() == password_textbox.Text)
                    {
                        var main = new Main();
                        main.Show();
                        this.Hide();
                        return;
                    } else
                    {
                        invalid_credentials_label.Text = "El Nombre de Usuario o Contraseña son incorrectos";
                        invalid_credentials_label.ForeColor = Color.FromName("red");
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }

    public static class Globals
    {
        public static List<Usuario> usuarios = new List<Usuario>();
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