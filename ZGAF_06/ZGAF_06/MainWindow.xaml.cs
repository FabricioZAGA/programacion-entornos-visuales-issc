using Autos.Gui;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ZGAF_06.Gui;

namespace ZGAF_06
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnEmpleados_Click(object sender, RoutedEventArgs e)
        {
            VistaEmpleados vistaEmpleados = new VistaEmpleados();
            this.Close();
            vistaEmpleados.Show();

        }

        private void BtnAutos_Click(object sender, RoutedEventArgs e)
        {
            Vehiculos vehiculos = new Vehiculos();
            this.Close();
            vehiculos.Show();
        }

        private void BtnClientes_Click(object sender, RoutedEventArgs e)
        {
            VistaClientes vistaClientes = new VistaClientes();
            this.Close();
            vistaClientes.Show();
        }
    }
}
