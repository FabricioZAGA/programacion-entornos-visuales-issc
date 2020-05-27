using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZGAF_07.Model
{
    public class Ciudadano 
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int Sexo { get; set; }
        public int Colonia { get; set; }
        public int CodigoPostal { get; set; }
    }
}
