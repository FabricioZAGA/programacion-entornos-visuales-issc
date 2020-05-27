using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZGAF_06.Model
{
    public class Cliente : Usuario
    {
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public int NumCuenta { get; set; }
    }
}
