using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioLibreriaWeb.clases
{
    internal class TarjetaCredito
    {
        public string NumeroTarjeta { get; set; }

        public string FechaVencimientoTarjeta { get; set; }
        public string CodigoSeguridadTarjeta { get; set; }



        public TarjetaCredito(string numeroTarjeta, string fechaVencimientoTarjeta, string codigoSeguridadTarjeta)
        {
            NumeroTarjeta = numeroTarjeta;
            FechaVencimientoTarjeta = fechaVencimientoTarjeta;
            CodigoSeguridadTarjeta = codigoSeguridadTarjeta;
        }
        public void CrearTarjeta()
        {
            Console.WriteLine("Ingrese el numero de la tarjeta");
            NumeroTarjeta = Console.ReadLine();
            Console.WriteLine("Ingrese la fecha de vencimiento de la tarjeta ");
            FechaVencimientoTarjeta = Console.ReadLine();
            Console.WriteLine("Ingrese el codigo de seguridad de la carpeta");
            CodigoSeguridadTarjeta = Console.ReadLine();

        }


        public bool VerificarTarjeta(TarjetaCredito tarjeta)
        {

            Console.Write("Número de tarjeta: ");
            string numeroTarjetaConfirmacion = Console.ReadLine();

            Console.Write("Fecha de vencimiento (MM/AA): ");
            string fechaVencimientoConfirmacion = Console.ReadLine();

            Console.Write("Código de seguridad: ");
            string codigoSeguridadConfirmacion = Console.ReadLine();

            return tarjeta.NumeroTarjeta == numeroTarjetaConfirmacion &&
                   tarjeta.FechaVencimientoTarjeta == fechaVencimientoConfirmacion &&
                   tarjeta.CodigoSeguridadTarjeta == codigoSeguridadConfirmacion;
        }

        public void MostrarDetallesTarjeta()
        {
            

            Console.WriteLine(  $"\n\n//El numero de tu tarjeta es {NumeroTarjeta}" +
                $"\n //La fecha de vencimiento es{FechaVencimientoTarjeta}" +
                $"\n y el codigo de seguridad: {CodigoSeguridadTarjeta} \n ");

        }
    }
}