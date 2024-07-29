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

        static void Main(string[] args)
        {
        }
        static void SolicitarDatos()
        {
            Console.Clear();
            Console.Write("Ingrese el nombre del producto: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese el precio del producto: Q");
            precio = double.Parse(nombre);
        }
        static double CalcularTotal(double precio)
        {
            return total=+precio;
        }
        static double Descuento(double total, double porcentaje)
        {
            Console.Clear();
            Console.Write("Ingrese el descuento a aplicar (use unicamente valores enteros sin el simbolo de porcentaje): ");
            double descuento=
            return total - total * descuento;
        }
    }
}
