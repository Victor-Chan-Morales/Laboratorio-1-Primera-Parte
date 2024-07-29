using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_1_parte_1
{
    internal class Program
    {
        static double precio = 0, total=0;
        static string nombre = "";
        static double resultado= 0;

        static void Main(string[] args)
        {
            do
            {
                try
                {
                    SolicitarDatos();
                    CalcularTotal(precio);
                    Console.WriteLine("Desaea aplicar un descuento?");
                    string respuesta=Console.ReadLine

                }
                catch (FormatException)
                {
                    Console.WriteLine("No es una entrada válida, intente de nuevo.");
                }
            }while (true);
        }
        static void SolicitarDatos()
        {
            Console.Clear();
            Console.Write("Ingrese el nombre del producto: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese el precio del producto: Q");
            precio = double.Parse(nombre);
        }
        static double CalcularTotal(double precio)
        {
            return total=+precio;
        }
        static double Descuento(double total)
        {
            Console.Clear();
            Console.Write("Ingrese el descuento a aplicar (use unicamente valores enteros sin el simbolo de porcentaje): ");
            double descuento=double.Parse(Console.ReadLine());
            return total - total * descuento;
        }
        static void MostarResultado(string Mensaje)
        {
            Console.Clear();
            Console.WriteLine(Mensaje);
        }
    }
}
