using ClaseBase;
using System;
using System.Security.Cryptography.X509Certificates;
using Views.views;

namespace Views
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Globals.usuarios.Add(new Usuario(1, "nicolas", "nicolas", "", 1));
            Globals.usuarios.Add(new Usuario(1, "secadora", "secadora", "", 2));
            Globals.usuarios.Add(new Usuario(1, "dumb", "dumb", "", 3));
            Globals.roles.Add(new Rol(1, "Operador"));
            Globals.roles.Add(new Rol(2, "Vendedor"));
            Globals.roles.Add(new Rol(3, "Administrador"));
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            foreach (Usuario usuario in Globals.usuarios)
            {
                if (username_textbox.Text == usuario.Usu_NombreUsuario 
                    && password_textbox.Text == usuario.Usu_Contraseña)
                {
                    Globals.currentUser = usuario;
                    var MenuForm = new Main();
                    MenuForm.Show();
                    this.Hide();
                    return;
                }
            }
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