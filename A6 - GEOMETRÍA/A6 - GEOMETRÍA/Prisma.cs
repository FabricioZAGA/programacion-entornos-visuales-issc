using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A6___GEOMETRÍA
{
    public class Prisma : FiguraRegular
    {
        public double Altura { get; set; }

        public Prisma()
        {

        }
        public double GetVolumen()
        {
            return GetArea() * Altura;
        }
        public double GetAreaPrisma()
        {
            return GetPerimetro() * Altura + (2 * GetArea());
        }
    }
}
