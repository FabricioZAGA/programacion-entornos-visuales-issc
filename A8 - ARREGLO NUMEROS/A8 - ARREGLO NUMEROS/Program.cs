using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A8___ARREGLO_NUMEROS
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaNumeros ln = new ListaNumeros();
            Console.WriteLine("Cantidad del arreglo: ");
            int cantidad = int.Parse(Console.ReadLine());
            int[] datos = new int[cantidad-1];
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Elemento " + (i + 1) + ": ");
                datos[i] = int.Parse(Console.ReadLine());
            }
            //int[] datos = { 5, 12, 8, 9, 21 };
            ln.Numeros = datos;

            Console.WriteLine("Máximo: " + ln.GetMax());
            Console.WriteLine("Mínimo: " + ln.GetMin());
            Console.WriteLine("Invertido: " + string.Join(", ", ln.Invertir()));
            Console.WriteLine("Sacar múltiplos de: ");
            int res = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Multiplos de " + res + ": "+ string.Join(", ", ln.GetMultiplos(res)));
            Console.ReadKey();
        }
    }
}
