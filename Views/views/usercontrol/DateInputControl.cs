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

namespace Views.views.usercontrol
{
    public partial class DateInput : UserControl
    {
        public Regex birthday_regex = new Regex(@"^(0[0-9]|[1-3][0-9])\/(0[0-9]|[1][0-2])\/(19|20)\d\d$");
        public bool is_valid_date;
        public DateTime date_input;

        public DateInput()
        {
            this.is_valid_date = false;
            InitializeComponent();
        }

        private void date_input_textbox_TextChanged(object sender, EventArgs e)
        {
            if (birthday_regex.Match(date_input_textbox.Text).Success)
            {
                valid_input_label.Text = "El formato de la fecha es correcto";
                valid_input_label.ForeColor = Color.FromName("green");
                this.date_input = DateTime.Parse(date_input_textbox.Text);
                this.is_valid_date = true;
            }
            else
            {
                valid_input_label.Text = "El formato de la fecha es incorrecto";
                valid_input_label.ForeColor = Color.FromName("red");
                this.is_valid_date = false;
            }
        }
    }
}
