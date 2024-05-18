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
            Globals.currentSerialId += 1;
            new_atleta.Atl_ID = Globals.currentSerialId;
            new_atleta.Atl_Nombre = nombre_textbox.Text;
            new_atleta.Atl_Apellido = apellido_textbox.Text;
            // Parsing the date string
            if (birthday_regex.Match(birthday_textbox.Text).Success)
            {
                new_atleta.Atl_FechaNac = DateTime.Parse(birthday_textbox.Text);

            }
            if (email_regex.Match(email_textbox.Text).Success)
            {
                new_atleta.Atl_Email = email_textbox.Text;
            }

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show("Confirmar la accion", "caption", buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Globals.atletas.Add(new_atleta);
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


        private void AtletaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
