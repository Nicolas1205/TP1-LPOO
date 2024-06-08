using System;
using System.Windows.Forms;
using ClaseBase;

namespace Views
{
    public partial class CategoriaForm : Form
    {
        public CategoriaForm()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Lógica para agregar categoría
            Categoria categoria = new Categoria();
            categoria.Nombre = txtNombre.Text;
            CategoriaService.AgregarCategoria(categoria);
            MessageBox.Show("Categoría agregada correctamente");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Lógica para actualizar categoría
            Categoria categoria = new Categoria();
            categoria.Id = int.Parse(txtId.Text);
            categoria.Nombre = txtNombre.Text;
            CategoriaService.ActualizarCategoria(categoria);
            MessageBox.Show("Categoría actualizada correctamente");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Lógica para eliminar categoría
            int categoriaId = int.Parse(txtId.Text);
            CategoriaService.EliminarCategoria(categoriaId);
            MessageBox.Show("Categoría eliminada correctamente");
        }
    }
}
