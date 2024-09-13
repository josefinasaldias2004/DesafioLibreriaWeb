using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioLibreriaWeb.clases
{
    internal class Rubro
    {
        public string Nombre { get; set; }
        public List<Libro> Libros { get; set; } 
        public Rubro(string nombre, List<Libro> libros) {
            Nombre = nombre; 
            Libros = libros;
        }
        public void MostrarDetalles(string nombreRubro)
        {
            bool validacionSihaylibro = false;
            Console.WriteLine($"¿Cual rubro queres ver?");
            string rubro = Console.ReadLine().Trim().ToLower();
            foreach (Libro libro in Libros)
            {
                bool Libro = nombreRubro.Contains(rubro);
                   
                {
                    libro.MostrarDetalles();
                    validacionSihaylibro = true;
                }
            }
            if (!validacionSihaylibro) {
                Console.WriteLine("No hay libros");
            } 
        }
    }
}
