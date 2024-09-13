using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioLibreriaWeb.clases
{
    internal class OrdenDeCompra
    {
        public Cliente Cliente { get; set; }
        public List<Libro> Libros { get; set; }
        public OrdenDeCompra(Cliente cliente, List<Libro> libros)
        {
            Cliente = cliente;
            Libros = libros;
        }
        public decimal CalcularTotal()
        {
            decimal total = 0;
            foreach (Libro libro in Libros)
            {
                total += libro.Precio;
            }
            return total;
        }
        public void MostrarDetalles()
        {
            
            foreach (Libro libro in Libros)
            {
                 libro.MostrarDetalles();
            }
        }    
    } 
}
