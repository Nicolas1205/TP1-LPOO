using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Views.services;

namespace Views.views
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void searchUserTextbox_TextChanged(object sender, EventArgs e)
        {
            var usuarios = UsuarioService.getUsuariosByName(searchUserTextbox.Text);
            dataGridView1.DataSource = usuarios;
        }
    }
}
