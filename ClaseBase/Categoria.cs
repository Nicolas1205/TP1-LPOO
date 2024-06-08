using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseBase
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        private static List<Categoria> categorias = new List<Categoria>();

        public static void AgregarCategoria(Categoria categoria)
        {
            categoria.Id = categorias.Count + 1;
            categorias.Add(categoria);
        }

        public static void ActualizarCategoria(Categoria categoria)
        {
            var existingCategoria = categorias.Find(c => c.Id == categoria.Id);
            if (existingCategoria != null)
            {
                existingCategoria.Nombre = categoria.Nombre;
            }
        }

        public static void EliminarCategoria(int id)
        {
            var categoria = categorias.Find(c => c.Id == id);
            if (categoria != null)
            {
                categorias.Remove(categoria);
            }
        }

        public static List<Categoria> ObtenerCategorias()
        {
            return new List<Categoria>(categorias);
        }
    }
}
