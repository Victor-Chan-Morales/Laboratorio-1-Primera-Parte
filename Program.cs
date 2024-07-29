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
                    Console.WriteLine("Desaea aplicar un descuento?S/N");
                    string respuesta=Console.ReadLine();
                    if (respuesta == "S")
                    {
                        Descuento(total);
                    }
                    else if (respuesta == "N")
                    {
                        Console.WriteLine("No se aplicará descuento");
                    }
                    else
                    {
                        Console.WriteLine("No es una entrada válida, por lo que no se aplicará descueto");
                    }
                    MostarResultado("El total a pagar es W"+total);
                    Console.ReadKey();

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
            precio = double.Parse(Console.ReadLine());
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
            return total - (total * descuento/100);
        }
        static void MostarResultado(string Mensaje)
        {
            Console.Clear();
            Console.WriteLine(Mensaje);
        }
    }
}
