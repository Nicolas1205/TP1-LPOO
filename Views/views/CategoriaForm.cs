using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClaseBase;
using Views.services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Views.views
{
    public partial class CategoriaForm : Form
    {
        public CategoriaForm()
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
            Random rand = new();
            var new_categoria = new Categoria
            {
                Cat_ID = rand.Next(5, 10000),
                Cat_Nombre = nombre_textbox.Text,
                Cat_Descripcion = descripcion_textbox.Text
            };

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Confirmar la acción", "Confirmación", buttons);

            if (result == DialogResult.Yes)
            {
                CategoriaService.insertCategoria(new_categoria);
                success_label.Text = "Se ha registrado correctamente";
                success_label.ForeColor = Color.Green;
                LoadCategorias();
            }
        }

        private void CategoriaForm_Load(object sender, EventArgs e)
        {
            LoadCategorias();
        }

        private void LoadCategorias()
        {
            var categorias = CategoriaService.getAllCategorias();
            categoriaDataGridView.DataSource = categorias;
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            if (categoriaDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = categoriaDataGridView.SelectedRows[0];
                var categoria = (Categoria)selectedRow.DataBoundItem;

                nombre_textbox.Text = categoria.Cat_Nombre;
                descripcion_textbox.Text = categoria.Cat_Descripcion;

                register_button.Text = "Actualizar";
                register_button.Click -= register_button_Click;
                register_button.Click += (s, args) => UpdateCategoria(categoria.Cat_ID);
            }
            else
            {
                MessageBox.Show("Seleccione una categoría para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateCategoria(int id)
        {
            var updated_categoria = new Categoria
            {
                Cat_ID = id,
                Cat_Nombre = nombre_textbox.Text,
                Cat_Descripcion = descripcion_textbox.Text
            };

            CategoriaService.updateCategoria(updated_categoria);
            success_label.Text = "Se ha actualizado correctamente";
            success_label.ForeColor = Color.Green;
            LoadCategorias();

            register_button.Text = "Registrar";
            register_button.Click += register_button_Click;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (categoriaDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = categoriaDataGridView.SelectedRows[0];
                var categoria = (Categoria)selectedRow.DataBoundItem;

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Confirmar la acción", "Confirmación", buttons);

                if (result == DialogResult.Yes)
                {
                    CategoriaService.deleteCategoria(categoria);
                    success_label.Text = "Se ha borrado correctamente";
                    success_label.ForeColor = Color.Green;
                    LoadCategorias();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una categoría para borrar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

