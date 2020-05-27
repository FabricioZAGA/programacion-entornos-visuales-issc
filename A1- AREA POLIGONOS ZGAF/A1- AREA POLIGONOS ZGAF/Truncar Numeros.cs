using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1__AREA_POLIGONOS_ZGAF
{
    static class Truncar_Numeros
    {
        public static double Truncate(this double value, int decimales)
        {
            double aux_value = Math.Pow(10, decimales);
            return (Math.Truncate(value * aux_value) / aux_value);
        }
    }
}
