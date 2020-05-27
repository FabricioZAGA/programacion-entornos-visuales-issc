using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A7___ManejoArreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] caracteres = { 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', '(', ')' };
            ControlArreglo controlArreglo = new ControlArreglo();
            controlArreglo.Letras = caracteres;
            Console.WriteLine(controlArreglo.GetVocalInicial());
            Console.WriteLine(controlArreglo.GetConsonanteInicial());
            Console.WriteLine(controlArreglo.GetTotalVocales());
            Console.ReadKey();
        }
    }
}
