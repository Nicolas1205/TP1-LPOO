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
    public partial class AtletasManagmentForm : Form
    {
        public AtletasManagmentForm()
        {
            InitializeComponent();
        }

        private void register_atleta_btn_Click(object sender, EventArgs e)
        {
            var atletaForm = new AtletaForm();
            atletaForm.Show();
        }

        private void AtletasManagmentForm_Load(object sender, EventArgs e)
        {

            List<Atleta> atletas = AtletaService.getAllAtletas();
            BindingSource bindingSource = new();
            bindingSource.DataSource = atletas;

            atletas_listview.View = View.Details;
            atletas_listview.Columns.Add("ID");
            atletas_listview.Columns.Add("DNI");
            atletas_listview.Columns.Add("Nombre");
            atletas_listview.Columns.Add("Apellido");


            foreach(var atleta in atletas)
            {
                string[] items = { atleta.Atl_ID.ToString(), atleta.Atl_DNI,
                                   atleta.Atl_Nombre, atleta.Atl_Apellido};
                atletas_listview.Items.Add(new ListViewItem(items));
            }
            atletas_listview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

        }

        private void delete_atleta_btn_Click(object sender, EventArgs e)
        {
            var deleteAtletaForm = new DeleteAtletaForm();
            deleteAtletaForm.Show();
        }

        private void update_atleta_btn_Click(object sender, EventArgs e)
        {
            var updateAtletaForm = new UpdateAtletaForm();
            updateAtletaForm.Show();
        }

    }
}
