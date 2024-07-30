using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_1_parte_1
{
    internal class Program
    {
        static List<double> listaPrecio = new List<double>();
        static List<string> listaNombre = new List<string>();
        static double totalProductos = 0;
        static void RegistrarProducto()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("¿Desea registrar un producto? S/N");
                string registrar = Console.ReadLine().ToUpper();
                if (registrar == "S")
                {
                    Console.Write("Nombre del producto: ");
                    string nombreProducto = Console.ReadLine().ToUpper();
                    listaNombre.Add(nombreProducto);
                    Console.Write("Precio del prodcuto: Q ");
                    double precioProducto = double.Parse(Console.ReadLine());
                    listaPrecio.Add(precioProducto);
                    Console.WriteLine("Producto registrado");
                }
                else if (registrar == "N")
                {
                    Console.WriteLine("No se registrará ningún producto...");
                    break;
                }
                else
                {
                    Console.WriteLine("Debe ingresar S o N");

                }
                Console.ReadKey();
            }
        }
        static double CalcularTotal(List<double> Precios)
        {
            double total = 0;
            foreach (double precio in listaPrecio)
            {
                total += precio;
            }
            return total;
        }
        static void MostrarProductos(List<string> ListaNombres, List<double>listaPrecios)
        {
            if (ListaNombres.Count > 0)
            {
                for (int i = 0; i < ListaNombres.Count; i++)
                {
                    Console.WriteLine($"Nombre del producto: {ListaNombres[i]}  Precio del producto: {listaPrecios[i]}");
                }
            }
            else
            {
                Console.WriteLine("No existe ningún producto registrado");
            }
        }
        static double AplicarDescuento(List<double> ListaPrecios)
        {
            while (true)
            {
                Console.Write("Ingrese el descuento a aplciar, usar números enteros del 1 al 100 (0 si no aplica descuento): ");
                double descuento = double.Parse(Console.ReadLine());
                if (descuento > 0)
                {
                    double total = 0;
                    for (int i = 0; i < ListaPrecios.Count; i++)
                    {
                        total += ListaPrecios[i];
                    }
                    return total - total * descuento;
                    break;
                }
                else
                {
                    Console.WriteLine("No es un valor válido");
                }
                Console.ReadKey();
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Bienvenido a ElectroniK");
                    RegistrarProducto();
                    MostrarProductos(listaNombre, listaPrecio);
                    totalProductos=CalcularTotal(listaPrecio);
                    Console.WriteLine("El subtotal es: Q"+totalProductos);
                    totalProductos=AplicarDescuento(listaPrecio);
                    Console.WriteLine("El total es: Q"+totalProductos);
                    Console.WriteLine("Gracias por usar el sistema de registro de ventas...");
                    Console.ReadKey();
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: ha ingresado un caracter inválido, por favor verifique sus entradas");
                    Console.ReadKey();
                }
            }
        }


    }
}
