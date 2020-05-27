using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5___CONVERSORES
{
    class Conversor
    {
        public static int Cifra { get; set; }
        public static string Binario { get; set; }
        public static string Hexadecimal { get; set; }
        public static void ConvertirBinario()
        {
            int cosciente = 0;
            int residuo = 0;
            Binario = "";
            while (Cifra != 0)
            {

                cosciente = Cifra / 2;
                residuo = Cifra % 2;
                Binario = residuo + Binario;
                Cifra = cosciente;
            }
        }
        public static void ConvertirHexadecimal()
        {
            int cosciente = 0;
            int residuo = 0;
            Hexadecimal = "";
            while (Cifra != 0)
            {

                cosciente = Cifra / 16;
                residuo = Cifra % 16;
                switch (residuo)
                {
                    case 10:
                        Hexadecimal = "A" + Hexadecimal;
                        break;
                    case 11:
                        Hexadecimal = "B" + Hexadecimal;
                        break;
                    case 12:
                        Hexadecimal = "C" + Hexadecimal;
                        break;
                    case 13:
                        Hexadecimal = "D" + Hexadecimal;
                        break;
                    case 14:
                        Hexadecimal = "E" + Hexadecimal;
                        break;
                    case 15:
                        Hexadecimal = "F" + Hexadecimal;
                        break;
                    default:
                        Hexadecimal = residuo + Hexadecimal;
                        break;
                }
                Cifra = cosciente;
            }
        }
    }
}
