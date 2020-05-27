using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                
namespace A6___GEOMETRÍA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Prismas (1) o Pirámides (2)");
            int res = Int32.Parse(Console.ReadLine());
            while (res != 1 && res != 2)
            {
                Console.WriteLine("¿Prismas (1) o Pirámides (2)");
                res = Int32.Parse(Console.ReadLine());
            }
            if (res == 1) //Prismas
            {
                Prisma prisma = new Prisma();
                Console.WriteLine("Nombre Figura");
                prisma.Nombre = Console.ReadLine();
                Console.WriteLine("NumLados");
                prisma.NumLados = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Longitud del Lado");
                prisma.LongLado = Double.Parse(Console.ReadLine());
                Console.WriteLine("Longitud del Radio");
                prisma.Radio = Double.Parse(Console.ReadLine());
                Console.WriteLine("Altura");
                prisma.Altura = Double.Parse(Console.ReadLine());
                Console.WriteLine("Area " + prisma.Nombre + ":  " + prisma.GetArea());
                Console.WriteLine("Perimetro " + prisma.Nombre + ":  " + prisma.GetPerimetro());
                Console.WriteLine("Volumen " + prisma.Nombre + ":  " + prisma.GetVolumen());
                Console.WriteLine("Area de Prisma " + prisma.Nombre + ":  " + prisma.GetAreaPrisma());
                Console.ReadKey();
            }
            else if(res == 2) //Piramides
            {
                Piramide piramide = new Piramide();
                Console.WriteLine("Nombre Figura");
                piramide.Nombre = Console.ReadLine();
                Console.WriteLine("NumLados");
                piramide.NumLados = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Longitud del Lado");
                piramide.LongLado = Double.Parse(Console.ReadLine());
                Console.WriteLine("Longitud del Radio");
                piramide.Radio = Double.Parse(Console.ReadLine());
                Console.WriteLine("Altura");
                piramide.Altura = Double.Parse(Console.ReadLine());
                Console.WriteLine("Area " + piramide.Nombre + ":  " + piramide.GetArea());
                Console.WriteLine("Perimetro " + piramide.Nombre + ":  " + piramide.GetPerimetro());
                Console.WriteLine("Volumen " + piramide.Nombre + ":  " + piramide.GetVolumen());
                Console.WriteLine("Area de Piramide " + piramide.Nombre + ":  "+ piramide.GetAreaPiramide());
                Console.ReadKey();
            }
        }
    }
}
