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
                int nLados;
                double theta, Ap, res, perim, lDist, Radio;
                Console.WriteLine("Numero de Lados");
                nLados = int.Parse(Console.ReadLine());
                while (nLados < 3)      //Verificación de Polígonos
                {
                    Console.WriteLine("Ingrese un numero valido");
                    nLados = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Distancia Lado");
                lDist = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el Radio");
                Radio = double.Parse(Console.ReadLine());
                theta = 360 / (2 * nLados);
                Ap = lDist / (2 * Math.Tan(theta * (Math.PI / 180)));
                if (nLados > 4)         //Fórmula para polígonos mayores de 4 lados
                {
                    
                   
                    res = ((nLados * lDist) * Ap) / 2;
                    
                }
                else                    //Fórmula para polígonos menores de 5 lados
                {

                    if (nLados == 4)    //Fórmula para rectángulo
                    {
                        res = lDist * lDist;
                    }
                    else                //formula para triángulo
                    {
                        res = (lDist * (Ap+Radio)) / 2;
                    }
                    
                }
                perim = nLados * lDist;
                Console.WriteLine("El area es: " + res + " u^2");
                Console.WriteLine("El perímetro es: " + perim + " u"); //Entrega de resultado
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