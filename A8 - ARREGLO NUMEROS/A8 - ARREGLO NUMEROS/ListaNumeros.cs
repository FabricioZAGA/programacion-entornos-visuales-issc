using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A8___ARREGLO_NUMEROS
{
    class ListaNumeros
    {
        public int[] Numeros { set; get; }

        public int GetMax()
        {
            int aux = Numeros[0];
            for (int i = 0; i < Numeros.Length; i++)
            {
                if (Numeros[i] > aux)
                {
                    aux = Numeros[i];
                }
            }
            return aux;
        }
        public int[] Invertir() //devuelve el arreglo Numeros Pero en orden inverso
        {
            int aux;
            for (int i = 0; i < Numeros.Length / 2; i++)
            {
                aux = Numeros[i];
                Numeros[i] = Numeros[Numeros.Length - 1 - i];
                Numeros[Numeros.Length - 1 - i] = aux;
            }
            return Numeros;
        }
        public int GetMin() // Devuelve el numero menor del arreglo Numeros
        {
            int aux = Numeros[0];
            for (int i = 0; i > Numeros.Length; i++)
            {
                if (Numeros[i] > aux)
                {
                    aux = Numeros[i];
                }
            }
            return aux;
        }
        public int[] GetMultiplos(int a) // Devuelve un arreglo de numeros que son m�ltiplo de  la variable "a"
        {
            int j = 0;
            for (int i = 0; i < Numeros.Length; i++)
            {
                if (Numeros[i] % a == 0)
                {
                    j++;
                }
            }
            int [] listaMultiplos = new int[j];
            int k = 0;
            for (int i = 0; i < Numeros.Length; i++)
            {
                if (Numeros[i]%a == 0)
                {
                    listaMultiplos[k] = Numeros[i];
                    k++;
                }
            }
            return listaMultiplos;
        }
    }
}
