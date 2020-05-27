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
using ZGAF_06.Controller;
using ZGAF_06.Model;

namespace ZGAF_06.Gui
{
    /// <summary>
    /// Lógica de interacción para VistaClientes.xaml
    /// </summary>
    public partial class VistaClientes : Window
    {
        public ControllerCliente controllerCliente = new ControllerCliente();
        public Cliente cliente = null;
        public VistaClientes()
        {
            InitializeComponent();
            MostrarDatos(controllerCliente);
        }
        public void AsignarValores()
        {
            cliente = new Cliente();
            try
            {
                cliente.NumCuenta = Int32.Parse(txtNumCuenta.Text);
                cliente.Nombre = txtNombre.Text;
                cliente.ApPaterno = txtApPaterno.Text;
                cliente.ApMaterno = txtApMaterno.Text;
                cliente.NombreUsuario = txtNombreUsuario.Text;
                cliente.Contrasenia = txtContrasenia.Text;
                cliente.Email = txtEmail.Text;
            }
            catch
            {
                MessageBox.Show("Introduzca Valores Válidos", "¡Error!");
            }

        }


        public void MostrarDatos(ControllerCliente cliente)
        {
            dtgClientes.ItemsSource = cliente.GetAll();
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            AsignarValores();
            controllerCliente.AgregarCliente(cliente);
            controllerCliente.InsertCliente(cliente);
            dtgClientes.Items.Refresh();
            txtNumCuenta.Text = "";
            txtNombre.Text = "";
            txtApPaterno.Text = "";
            txtApMaterno.Text = "";
            txtNombreUsuario.Text = "";
            txtContrasenia.Text = "";
            txtEmail.Text = "";
        }

        private void BtnRegresar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }

        private void BtnBuscar_Click(object sender, RoutedEventArgs e)
        {
            dtgClientes.ItemsSource = null;
            dtgClientes.ItemsSource = controllerCliente.FindApPaterno(txtApPaterno.Text);
        }
    }
}
