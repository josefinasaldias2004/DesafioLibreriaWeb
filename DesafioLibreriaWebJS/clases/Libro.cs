using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioLibreriaWeb.clases
{
    internal class Libro
    {
       
        public string Rubro {  get; set; }
        public string Titulo { get; set; }

        public string Autor {  get; set; }
        public Categoria Categoria { get; set; }
        public decimal Precio { get; set; }
        public int cantidadStock { get; set; }

        public Libro(string rubro, string titulo, string autor, Categoria categoria, decimal precio, int stock)
        {
           Rubro = rubro;
            Titulo = titulo;
            Autor = autor;
            Categoria = categoria;
            Precio = precio;
            cantidadStock = stock;
        }
        public void MostrarDetalles()
        {
            Console.WriteLine($"Titulo: {Titulo}" +
                $"\nAutor: {Autor}" +
                $"\nCategoria: {Categoria.Nombre}" +
                $"\nPrecio: {Precio}" +
                $"\nCantidad de libros: {cantidadStock}");
        }
    }
}
