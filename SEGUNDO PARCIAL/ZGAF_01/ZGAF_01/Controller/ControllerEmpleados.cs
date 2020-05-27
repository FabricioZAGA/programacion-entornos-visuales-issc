using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZGAF_01.MODEL;

namespace ZGAF_01.CONTROLLER
{
    public class ControllerEmpleados
    {
        public ModelEmpleado[] Empleados = new ModelEmpleado[10];
        int counter = 0;
        public void AgregarEmpleado(ModelEmpleado puto)
        {
            Empleados[counter++] = puto;
        }
    }
}
