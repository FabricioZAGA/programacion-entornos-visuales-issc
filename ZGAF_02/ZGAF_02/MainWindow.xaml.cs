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
using ZGAF_02.Gui;

namespace ZGAF_02
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

        private void BtnOptionAdd_Click(object sender, RoutedEventArgs e)
        {
            AgregarProductos agregarProductos = new AgregarProductos();
            this.Close();
            agregarProductos.Show();
        }

        private void BtnOptionShow_Click(object sender, RoutedEventArgs e)
        {
            MostrarProductos mostrarProductos = new MostrarProductos();
            this.Close();
            mostrarProductos.Show();
        }
    }
}
