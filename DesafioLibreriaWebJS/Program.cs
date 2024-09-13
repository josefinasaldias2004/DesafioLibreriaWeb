
using DesafioLibreriaWeb.clases;

class Program
{
    static void Main()
    {
        Categoria categoriaFiccion = new Categoria("Ficción", "Libros de ficción variados.");
        Categoria categoriaHistoria = new Categoria("Historia", "Libros de historia mundial.");
        Categoria categoriaManga = new Categoria ("Manga","Comics japoneses" );
        List<Libro> librosDisponibles = new List<Libro>
        {
            new Libro("Ficcion", "1984", "George Orwell", categoriaFiccion, 150.00m, 10),
            new Libro("Historia", "Sapiens", "Yuval Noah Harari", categoriaHistoria, 120.00m, 5),
            new Libro("Ficcion", "El psicoanalista", "John Katzenbach", categoriaFiccion, 100.00m, 3),
            new Libro("Manga", "Berserk","Kentaro Miura",categoriaManga,123.00m, 8),
            new Libro("Manga", "Tomie", "Junji Ito", categoriaManga, 193.00m, 15),
            new Libro("Historia","El arte de la guerra", "Sun Tzu", categoriaHistoria, 130.00m,6) 

        };

        
        Cliente cliente = new Cliente("atarico", "1234");

        cliente.MostrarDetalles();

        if (cliente.ValidarCliente()) {


            Console.WriteLine("Ingrese el rubro de libros que desea ver (Ficción/Historia/Manga):");
            string rubroSeleccionado = Console.ReadLine().Trim();

           
            List<Libro> librosFiltrados = new List<Libro>();
            foreach (var libro in librosDisponibles)
            {
                if (libro.Rubro.ToLower() == rubroSeleccionado.ToLower())
                {
                    librosFiltrados.Add(libro);
                }
            }

            if (librosFiltrados.Count == 0)
            {
                Console.WriteLine("No hay libros disponibles en este rubro.");
                return;
            }

       
            Console.WriteLine($"\nLibros disponibles en el rubro '{rubroSeleccionado}':");
            foreach (var libro in librosFiltrados)
            {
                libro.MostrarDetalles();
            }

            
            OrdenDeCompra carrito = new OrdenDeCompra(cliente, new List<Libro>());


            bool seguirComprando = true;
            while (seguirComprando)
            {
                Console.WriteLine("Ingrese el título del libro que desea comprar:");
                string tituloSeleccionado = Console.ReadLine();


                Libro libroSeleccionado = null;
                foreach (var libro in librosFiltrados)
                {
                    if (libro.Titulo.ToLower() == tituloSeleccionado.ToLower())
                    {
                        libroSeleccionado = libro;
                        break;
                    }
                }

                if (libroSeleccionado != null)
                {
                    Console.WriteLine("Ingrese la cantidad que desea comprar:");
                    int cantidad = int.Parse(Console.ReadLine());

                    if (libroSeleccionado.cantidadStock >= cantidad)
                    {
                        libroSeleccionado.cantidadStock -= cantidad;  
                        carrito.Libros.Add(libroSeleccionado);
                        Console.WriteLine($"Has agregado {cantidad} de {libroSeleccionado.Titulo} al carrito.");
                    }
                    else
                    {
                        Console.WriteLine("No hay suficiente stock para la cantidad solicitada.");
                    }
                }
                else
                {
                    Console.WriteLine("Libro no encontrado.");
                }

                Console.WriteLine("¿Desea seguir comprando? (S/N)");
                seguirComprando = Console.ReadLine().ToUpper() == "S";
            }

          
            Console.WriteLine("Resumen de la compra:");
            carrito.MostrarDetalles();

          
            Console.WriteLine($"El total a pagar es: {carrito.CalcularTotal()}");

         
            TarjetaCredito tarjeta = new TarjetaCredito("1111-2222-3333-4444", "12/34", "123");

            tarjeta.MostrarDetallesTarjeta();
          
            if (tarjeta.VerificarTarjeta(tarjeta))
            {
                Console.WriteLine("Pago aprobado. Compra finalizada.");
            }
            else
            {
                Console.WriteLine("Pago rechazado.");
            }
        }
    }
}