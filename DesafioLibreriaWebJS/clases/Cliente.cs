using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioLibreriaWeb.clases
{
    internal class Cliente
        {
            public string Nombre { get; set; }
            public string Contraseña { get; set; }

            public Cliente(string nombre, string contraseña)
            {
                Nombre = nombre;
                Contraseña = contraseña;
            }

            public string nombre
            {

                get { return Nombre; }
                set
                {
                    Nombre = value;
                }
            }

            public string contraseña
            {
                get { return Contraseña; }
                set { Contraseña = value; }
            }

            public void MostrarDetalles()
            {
                Console.WriteLine($"//El nombre de tu cuenta es de {Nombre}" +
                    $"\n //La contraseña de tu cuenta es de {Contraseña}");
            }
            public void CrearUsuario(string NombreUsuario, string ContraseñaUsuario)
            {
                nombre = NombreUsuario;
                contraseña = ContraseñaUsuario;
            }

        public bool ValidarCliente()
        {
            bool validarIngreso = false;
            while (!validarIngreso)
            {
                Console.WriteLine("Ingresa un usuario: (Las mayusculas y los caracteres especiales cuentan)");
                string NombreUsuario = Console.ReadLine().Trim();
                Console.WriteLine("Ingrese una contraseña: ");
                string ContraseniaUsuario = Console.ReadLine().Trim();
                if (NombreUsuario == Nombre && ContraseniaUsuario == Contraseña)
                {
                    validarIngreso = true;
                }
                else
                {
                    Console.WriteLine("No ingresaste bien el usuario o contraseña");
                }
            }

            if (validarIngreso)
            {
                return true;
            }

            return false;
        }

    }


    
}
