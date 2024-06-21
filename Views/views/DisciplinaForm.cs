using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClaseBase;
using Views.services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Views.views
{
    public partial class DisciplinaForm : Form
    {
        public DisciplinaForm()
        {
            InitializeComponent();
            LoadDisciplinas();
        }

        private void LoadDisciplinas()
        {
            var disciplinas = DisciplinaService.GetAllDisciplinas();
            disciplinaDataGridView.DataSource = disciplinas;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            var main = new Main();
            main.Show();
            this.Hide();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Random rand = new();
            var disciplina = new Disciplina
            {
                Dis_ID = rand.Next(5, 10000),
                Dis_Nombre = nombreTextBox.Text,
                Dis_Descripcion = descripcionTextBox.Text
            };
            DisciplinaService.InsertDisciplina(disciplina);
            LoadDisciplinas();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Random rand = new();
            var disciplina = new Disciplina
            {
                Dis_ID = rand.Next(5, 10000),
                Dis_Nombre = nombreTextBox.Text,
                Dis_Descripcion = descripcionTextBox.Text
            };
            DisciplinaService.UpdateDisciplina(disciplina);
            LoadDisciplinas();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DisciplinaService.DeleteDisciplina(idTextBox.Text);
            LoadDisciplinas();
        }

        private void disciplinaDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = disciplinaDataGridView.Rows[e.RowIndex];
                idTextBox.Text = row.Cells["Dis_ID"].Value.ToString();
                nombreTextBox.Text = row.Cells["Dis_Nombre"].Value.ToString();
                descripcionTextBox.Text = row.Cells["Dis_Descripcion"].Value.ToString();
            }
        }
    }
}