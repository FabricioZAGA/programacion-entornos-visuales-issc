using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2.Model
{
   public class Producto
    {
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public int Cantidad { get; set; }
        public Producto(string _Nombre, int _Precio, int _Cantidad) {
            Nombre = _Nombre;
            Precio = _Precio;
            Cantidad = _Cantidad;
        }
        public Producto() { }
    }
}
