using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZGAF_06.Model
{
    public class Empleado : Usuario
    {
        public int Codigo { get; set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaIngreso { get; set; }
    }
}
