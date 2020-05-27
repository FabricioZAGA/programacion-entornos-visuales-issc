using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZGAF_EX_3P.Model
{
    public class Materia : Carrera
    {
        public int Folio { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int HorasSemana { get; set; }
        public int NumSemestre { get; set; }
    }
}
