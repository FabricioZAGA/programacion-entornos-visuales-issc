using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5___CONVERSORES
{
    class Program
    {
        static void Main(string[] args)
        {
            ConversorObjeto objConversor1 = new ConversorObjeto();
            ConversorObjeto objConversor2 = new ConversorObjeto();
            objConversor1.Cifra = 128;
            objConversor1.ConvertirBinario();
            objConversor2.Cifra = 105263;
            objConversor2.ConvertirHexadecimal();
            Console.WriteLine(objConversor1.Binario);
            Console.WriteLine(objConversor2.Hexadecimal);
            Console.ReadKey();
        }
    }
}
