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
using ZGAF_07.Controller;
using ZGAF_07.Gui;

namespace ZGAF_07
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

        private void BtnLogIn_Click(object sender, RoutedEventArgs e)
        {
            ControllerUsuario controllerUsuario = new ControllerUsuario();
            if (txtUsuario.Text == controllerUsuario.GetNombreUsuario() && txtContrasenia.Text == controllerUsuario.GetContrasenia())
            {
                VentanaCiudadano ventanaCiudadano = new VentanaCiudadano();
                this.Close();
                ventanaCiudadano.Show();
            }

        }
    }
}
