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
    public partial class CompetenciaForm : Form
    {
        public CompetenciaForm()
        {
            InitializeComponent();
        }

        private void LoadCompetencias()
        {
            var competencias = CompetenciaService.getAllCompetencias();
            dataGridView1.DataSource = competencias;
        }
        private void CompetenciaForm_Load(object sender, EventArgs e)
        {
            var disciplinas = DisciplinaService.GetAllDisciplinas();
            var categorias = CategoriaService.getAllCategorias();
            foreach (var disciplina in disciplinas)
            {
                disciplina_combobox.Items.Add(disciplina);
            }
            foreach (var categoria in categorias)
            {
                categoria_combobox.Items.Add(categoria);
            }
            LoadCompetencias();
        }

        private void registrar_button_Click(object sender, EventArgs e)
        {
            var disciplina = (Disciplina)disciplina_combobox.SelectedItem;
            var categoria = (Categoria)categoria_combobox.SelectedItem;
            Random rand = new();

            var new_competencia = new Competencia
            {
                Com_ID = rand.Next(1, 10000),
                Com_Nombre = nombre_textbox.Text,
                Com_FechaInicio = fecha_inicio_datatimepicker.Value,
                Com_FechaFin = fecha_final_datetimepicker.Value,
                Com_Estado = estado_combobox.SelectedItem.ToString(),
                Cat_ID = categoria.Cat_ID,
                Dis_ID = disciplina.Dis_ID
            };
            CompetenciaService.InsertCompetencia(new_competencia);
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            var main = new Main();
            main.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void update_button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var competencia = (Competencia)selectedRow.DataBoundItem;

                nombre_textbox.Text = competencia.Com_Nombre;

                registrar_button.Text = "Actualizar";
                registrar_button.Click -= registrar_button_Click;
                registrar_button.Click += (s, args) => UpdateCompetencia(competencia.Com_ID);
            }
            else
            {
                MessageBox.Show("Seleccione una categoría para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            LoadCompetencias();

        }

        private void UpdateCompetencia(int id)
        {
            var updated_categoria = new Categoria
            {
                Cat_ID = id,
                Cat_Nombre = nombre_textbox.Text,
            };

            CategoriaService.updateCategoria(updated_categoria);
            LoadCompetencias();

            registrar_button.Text = "Registrar";
            registrar_button.Click += registrar_button_Click;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var competencia = (Competencia)selectedRow.DataBoundItem;

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Confirmar la acción", "Confirmación", buttons);

                if (result == DialogResult.Yes)
                {
                    CompetenciaService.deleteCompetencia(competencia.Com_ID);
                    LoadCompetencias();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una categoría para borrar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
