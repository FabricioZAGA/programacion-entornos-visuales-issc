using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ZGAF_ACT2_3P.Controller;

namespace ZGAF_ACT2_3P.Gui
{
    /// <summary>
    /// Lógica de interacción para Principal.xaml
    /// </summary>
    public partial class Principal : Window
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void BtnCompras_Click(object sender, RoutedEventArgs e)
        {
            ControllerVentanas controllerVentana = new ControllerVentanas();
            controllerVentana.StackWindows(grdPrincipal, new UcCategoria());
        }

        private void BtnMedicamentos_Click(object sender, RoutedEventArgs e)
        {
            ControllerVentanas controllerVentana = new ControllerVentanas();
            controllerVentana.StackWindows(grdPrincipal, new UcMedicamento());
        }

        private void BtnEmpleados_Click(object sender, RoutedEventArgs e)
        {
            ControllerVentanas controllerVentana = new ControllerVentanas();
            controllerVentana.StackWindows(grdPrincipal, new UcEmpleado());
        }

        private void BtnUsuarios_Click(object sender, RoutedEventArgs e)
        {
            ControllerVentanas controllerVentana = new ControllerVentanas();
            controllerVentana.StackWindows(grdPrincipal, new UcUsuario());
        }
    }
}
