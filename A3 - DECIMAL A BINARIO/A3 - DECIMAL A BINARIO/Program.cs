using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3___DECIMAL_A_BINARIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string binario = "";
            Console.WriteLine("Ingrese un numero");
            int numero = int.Parse(Console.ReadLine());
            do
            {
                if (numero % 2 == 0)
                {
                    binario = "0" + binario;
                }
                else
                {
                    binario = "1" + binario;
                }
                numero = (int)numero / 2;
            } while (numero > 0);
            Console.WriteLine("El numero ingresado en binario es: " + binario);
            Console.ReadKey();
        }
    }
}
