using Parcial2.Gui;
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

namespace Parcial2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            llenarUusarios();
        }
        public void llenarUusarios()
        {
            string[] usuarios = { "Uno", "Dos", "Tres" };
            cmbUsers.ItemsSource = usuarios;
        }

        private void CmbUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (cmbUsers.SelectedIndex)
            {
                case 0:
                    txtPassword.Text = "1234";
                    break;
                case 1:
                    txtPassword.Text = "2345";
                    break;
                case 2:
                    txtPassword.Text = "3456";
                    break;
            }
        }

        private void BtnBoton_Click(object sender, RoutedEventArgs e)
        {
            switch (cmbUsers.SelectedIndex)
            {
                case 0:
                    Clientes clientes = new Clientes();
                    this.Close();
                    clientes.Show();
                    break;
                case 1:
                    Ventas ventas = new Ventas();
                    this.Close();
                    ventas.Show();
                    break;
                case 2:
                    Almacen almacen = new Almacen();
                    this.Close();
                    almacen.Show();
                    break;
            }
        }
    }
}
