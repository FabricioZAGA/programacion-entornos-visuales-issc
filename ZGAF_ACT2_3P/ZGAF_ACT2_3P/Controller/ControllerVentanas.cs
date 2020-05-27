using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using ZGAF_ACT2_3P.Gui;

namespace ZGAF_ACT2_3P.Controller
{
    public class ControllerVentanas
    {
        public void StackWindows(Grid grid, UserControl userControl)
        {
            if (grid.Children.Count != 0)
            {
                grid.Children.Clear();
            }
            grid.Children.Add(userControl);

        }


    }
}
