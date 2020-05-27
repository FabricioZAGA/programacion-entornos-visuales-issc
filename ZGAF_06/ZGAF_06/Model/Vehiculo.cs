using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZGAF_06.Model
{
    public class Vehiculo
    {
        public double Precio { get; set; }
        public string NumSerie { get; set; }
        public string Tipo { get; set; }
        public string Color { get; set; }
        public string Version { get; set; }
        public Categoria _Categoria { set; get; }
    }
}
