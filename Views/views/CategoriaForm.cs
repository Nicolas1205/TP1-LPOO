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
            // L�gica para agregar categor�a
            Categoria categoria = new Categoria();
            categoria.Nombre = txtNombre.Text;
            CategoriaService.AgregarCategoria(categoria);
            MessageBox.Show("Categor�a agregada correctamente");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // L�gica para actualizar categor�a
            Categoria categoria = new Categoria();
            categoria.Id = int.Parse(txtId.Text);
            categoria.Nombre = txtNombre.Text;
            CategoriaService.ActualizarCategoria(categoria);
            MessageBox.Show("Categor�a actualizada correctamente");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // L�gica para eliminar categor�a
            int categoriaId = int.Parse(txtId.Text);
            CategoriaService.EliminarCategoria(categoriaId);
            MessageBox.Show("Categor�a eliminada correctamente");
        }
    }
}
