using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZGAF_06.Model
{
    public class Categoria
    {
        public int Codigo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public Categoria(int codigo, string marca, string modelo)
        {
            Codigo = codigo;
            Marca = marca;
            Modelo = modelo;
        }
        public Categoria()
        {

        }
    }
}
