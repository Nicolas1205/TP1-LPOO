using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClaseBase;
using Views.services;

namespace Views.views
{
    public partial class AtletaForm : Form
    {
        public Regex birthday_regex = new Regex(@"^(0[0-9]|[1-3][0-9])\/(0[0-9]|[1][0-2])\/(19|20)\d\d$");
        public Regex email_regex = new Regex(@"^(.*[a-z]|[A-z])@(.*[a-z]|[A-Z])\.(.*[a-z]|[A-Z])$");
        public AtletaForm()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            var main = new Main();
            main.Show();
            this.Hide();
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            var new_atleta = new Atleta();
            Random rand = new();
            new_atleta.Atl_ID = rand.Next(5, 10000);
            new_atleta.Atl_DNI = dni_textbox.Text;
            new_atleta.Atl_Nombre = nombre_textbox.Text;
            new_atleta.Atl_Apellido = apellido_textbox.Text;
            // Parsing the date string
            //if (birthday_regex.Match(birthday_textbox.Text).Success)
            //{
            //    new_atleta.Atl_FechaNac = DateTime.Parse(birthday_textbox.Text);
            //}
            //if (email_regex.Match(email_textbox.Text).Success)
            //{
            //   new_atleta.Atl_Email = email_textbox.Text;
            //}

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show("Confirmar la accion", "caption", buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Globals.atletas.Add(new_atleta);
                AtletaService.insertAtleta(new_atleta);
                success_label.Text = "Se ha registrado correctamente";
                success_label.ForeColor = Color.FromName("green");
            }
        }

        private void birthday_textbox_TextChanged(object sender, EventArgs e)
        {
            if (birthday_regex.Match(birthday_textbox.Text).Success)
            {
                validbirthday_label.Text = "El formato de la fecha es correcto";
                validbirthday_label.ForeColor = Color.FromName("green");
            }
            else
            {
                validbirthday_label.Text = "El formato de la fecha es incorrecto";
                validbirthday_label.ForeColor = Color.FromName("red");
            }
        }

        private void email_textbox_TextChanged(object sender, EventArgs e)
        {
            if (email_regex.Match(email_textbox.Text).Success)
            {
                validemail_label.Text = "El formato del correo es correcto";
                validemail_label.ForeColor = Color.FromName("green");
            }
            else
            {
                validemail_label.Text = "El formato del correo es incorrecto";
                validemail_label.ForeColor = Color.FromName("red");
            }

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            List<Atleta> atletas = AtletaService.getAllAtletas();

            if (rbtnDNI.Checked)
            {
                atletas = atletas.OrderBy(atleta => atleta.Atl_DNI).ToList();
            }
            else if (rbtnApellido.Checked)
            {
                atletas = atletas.OrderBy(atleta => atleta.Atl_Apellido).ToList();
            }

            lstAtletas.Items.Clear();
            foreach (var atleta in atletas)
            {
                lstAtletas.Items.Add($"ID: {atleta.Atl_ID}, DNI: {atleta.Atl_DNI}, Nombre: {atleta.Atl_Nombre}, Apellido: {atleta.Atl_Apellido}");
            }
        }


        private void AtletaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
