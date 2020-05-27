using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string yn;
            do
            {
                int nLados, lDist, b, h;
                double theta, Ap, res;
                Console.WriteLine("Numero de Lados");
                nLados = int.Parse(Console.ReadLine());
                while (nLados < 3)      //Verificación de Polígonos
                {
                    Console.WriteLine("Ingrese un numero valido");
                    nLados = int.Parse(Console.ReadLine());
                }
                if (nLados > 4)         //Fórmula para polígonos mayores de 4 lados
                {
                    Console.WriteLine("Distancia Lado");
                    lDist = int.Parse(Console.ReadLine());
                    theta = 360 / (2 * nLados);
                    Ap = lDist / (2 * Math.Tan(theta * (Math.PI / 180)));
                    res = ((nLados * lDist) * Ap) / 2;
                }
                else                    //Fórmula para polígonos menores de 5 lados
                {
                    Console.WriteLine("Ingrese la Base");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la Altura");
                    h = int.Parse(Console.ReadLine());
                    if (nLados == 4)    //Fórmula para rectángulo
                    {
                        res = b * h;
                    }
                    else                //formula para triángulo
                    {
                        res = (b * h) / 2;
                    }
                }
                Console.WriteLine("El resultado es: " + res + " u^2"); //Entrega de resultado
                do //Verificación caracter
                {
                    Console.WriteLine("Desea realizar otro calculo? Y/N");
                    yn = Console.ReadLine();
                } while (yn != "y" && yn != "n" && yn != "Y" && yn != "N");

            } while (yn == "y");
            Console.WriteLine("Presione una tecla para finalizar");
            Console.ReadKey();
        }
    }
}

