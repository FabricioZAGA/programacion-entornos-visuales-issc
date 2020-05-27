using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZGAF_06.Model
{
    public class Adquisicion
    {
        public string NumPedido { get; set; }
        public DateTime Fecha { get; set; }
        public Cliente _Cliente { get; set; }
        public Empleado _Empleado { get; set; }
        public Vehiculo _Vehiculo { get; set; }
    }
}
