using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZGAF_02.Model;
namespace ZGAF_02.Controller
{
    public class ControllerProducto
    {
        public List<ModelProducto> Productos = new List<ModelProducto>();
        public void AgregarProducto(ModelProducto producto)
        {
            Productos.Add(producto);
        }

        public List<ModelProducto> GetAll()
        {
            return Productos;
        }
        //public ModelProducto[] Productos { set; get; }

        //public ModelProducto[] BuscarNombre(string nombre)
        //{
        //    ModelProducto[] nombresProducto = null;
        //    int p = 0;
        //    int k = 0;
        //    for (int i = 0; i < Productos.Length; i++)
        //    {
        //        if (Productos[i].Nombre.Equals(nombre))
        //        {
        //            p++;
        //        }
        //    }
        //    if (p > 0)
        //    {
        //        nombresProducto = new ModelProducto[p];
        //        for (int i = 0; i < Productos.Length; i++)
        //        {
        //            if (Productos[i].Nombre.Equals(nombre))
        //            {
        //                nombresProducto[k] = Productos[i];
        //                k++;
        //            }
        //        }
        //    }
        //    return nombresProducto;
        //}
        //public ModelProducto[] BuscarMarca(string marca)
        //{

        //    int p = 0;
        //    int k = 0;
        //    ModelProducto[] marcaProducto = null;

        //    for (int i = 0; i < Productos.Length; i++)
        //    {
        //        if (Productos[i].Marca.Equals(marca))
        //        {
        //            p++;
        //        }
        //    }

        //    if (p > 0)
        //    {
        //        marcaProducto = new ModelProducto[p];
        //        for (int i = 0; i < Productos.Length; i++)
        //        {
        //            if (Productos[i].Marca.Equals(marca))
        //            {
        //                marcaProducto[k] = Productos[i];
        //                k++;
        //            }
        //        }
        //    }
        //    return marcaProducto;
        //}
        //public ModelProducto[] BuscarYear(int year)
        //{
        //    int p = 0;
        //    int k = 0;
        //    ModelProducto[] yearProducto = null;

        //    for (int i = 0; i < Productos.Length; i++)
        //    {
        //        if (Productos[i].FechaLlegada.Year.ToString().Equals(year.ToString()))
        //        {
        //            p++;
        //        }
        //    }

        //    if (p > 0)
        //    {
        //        yearProducto = new ModelProducto[p];
        //        for (int i = 0; i < Productos.Length; i++)
        //        {
        //            if (Productos[i].FechaLlegada.Year.ToString().Equals(year.ToString()))
        //            {
        //                yearProducto[k] = Productos[i];
        //                k++;
        //            }
        //        }
        //    }
        //    return yearProducto;
        //}
        //public ModelProducto[] BuscarCodigo(string codigo)
        //{
        //    int p = 0;
        //    int k = 0;
        //    ModelProducto[] codigoProducto = null;

        //    for (int i = 0; i < Productos.Length; i++)
        //    {
        //        if (Productos[i].Codigo.Equals(codigo))
        //        {
        //            p++;
        //        }
        //    }

        //    if (p > 0)
        //    {
        //        codigoProducto = new ModelProducto[p];
        //        for (int i = 0; i < Productos.Length; i++)
        //        {
        //            if (Productos[i].Codigo.Equals(codigo))
        //            {
        //                codigoProducto[k] = Productos[i];
        //                k++;
        //            }
        //        }
        //    }
        //    return codigoProducto;
        //}
    }
}
