using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClaseBase;
using Views.services;

namespace Views.views
{
    public partial class DeleteAtletaForm : Form
    {
        public DeleteAtletaForm()
        {
            InitializeComponent();
        }

        private void DeleteAtletaForm_Load(object sender, EventArgs e)
        {
            List<Atleta> atletas = AtletaService.getAllAtletas();
            foreach (var atleta in atletas)
            {
                atleta_combobox.Items.Add(atleta);
            }

        }

        private void delete_atleta_btn_Click(object sender, EventArgs e)
        {
            var selected_atleta = (Atleta)atleta_combobox.SelectedItem;
            AtletaService.deleteAtleta(selected_atleta);
            this.Close();
        }
    }
}
