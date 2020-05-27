using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A7___ManejoArreglos
{
    class ControlArreglo
    {
        public char[] Letras { get; set; }
        public char[] Vocales { get; set; }
        public char[] Consonantes { get; set; }
        public ControlArreglo()
        {

        }
        public char GetVocalInicial()
        {
            Vocales = new char[GetTotalVocales()];
            int j = 0;
            for (int i = 0; i < Letras.Length; i++)
            {
                if (Letras[i] == 'a' || Letras[i] == 'e' || Letras[i] == 'i' || Letras[i] == 'o' || Letras[i] == 'u')
                {
                    Vocales[j] = Letras[i];
                    j++;
                }
            }
            return Vocales[0];
        }
        public char GetConsonanteInicial()
        {
            Consonantes = new char[Letras.Length - GetTotalVocales()];
            int j = 0;
            for (int i = 0; i < Letras.Length; i++)
            {
                if (Letras[i] == 'a' || Letras[i] == 'e' || Letras[i] == 'i' || Letras[i] == 'o' || Letras[i] == 'u' && Letras[i] > 96 && Letras[i] < 123)
                {
                    Consonantes[j] = Letras[i];
                    j++;
                }
            }
            return Consonantes[0];
        }
        public int GetTotalVocales()
        {
            int j = 0;
            for (int i = 0; i < Letras.Length; i++)
            {
                if (Letras[i] == 'a' || Letras[i] == 'e' || Letras[i] == 'i' || Letras[i] == 'o' || Letras[i] == 'u')
                {
                    j++;
                }
            }
            return j;
        }
    }
}
