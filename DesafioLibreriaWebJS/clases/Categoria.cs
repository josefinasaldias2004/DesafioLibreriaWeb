using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioLibreriaWeb.clases
{
    internal class Categoria
    {
        public string Nombre { get; set; }  
        public string Descripcion { get; set; }

        public Categoria(string nombre, string descripcion) { 
            Nombre = nombre;
            Descripcion = descripcion;
        }

        public void MostrarDetalles() {
            Console.WriteLine($"Categoria: {Nombre}" +
                $"\n-----------------------" +
                $"\n{Descripcion}");
        }


    }
}
