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
    /// Lógica de interacción para VistaEmpleados.xaml
    /// </summary>
    public partial class VistaEmpleados : Window
    {
        public ControllerEmpleado controllerEmpleado = new ControllerEmpleado();
        public Empleado empleado = null;
        public VistaEmpleados()
        {
            InitializeComponent();
            MostrarDatos(controllerEmpleado);
        }
        public void AsignarValores()
        {
            empleado = new Empleado();
            try
            {
                empleado.Codigo = Int32.Parse(txtCodigo.Text);
                empleado.Nombre = txtNombre.Text;
                empleado.ApPaterno = txtApPaterno.Text;
                empleado.ApMaterno = txtApMaterno.Text;
                empleado.NombreUsuario = txtNombreUsuario.Text;
                empleado.Contrasenia = txtContrasenia.Text;
                empleado.FechaIngreso = DateTime.Parse(dtFechaIngreso.Text);
            }
            catch
            {
                MessageBox.Show("Introduzca Valores Válidos", "¡Error!");
            }

        }


        public void MostrarDatos(ControllerEmpleado controllerEmpleado)
        {
            dtgEmpleados.ItemsSource = controllerEmpleado.GetAll();
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            AsignarValores();
            controllerEmpleado.AgregarEmpleado(empleado);
            controllerEmpleado.InsertEmpleado(empleado);
            dtgEmpleados.Items.Refresh(); 
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtApPaterno.Text = "";
            txtApMaterno.Text = "";
            txtNombreUsuario.Text = "";
            txtContrasenia.Text = "";
            dtFechaIngreso.Text="";
        }

        private void BtnRegresar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }

        private void BtnBuscar_Click(object sender, RoutedEventArgs e)
        {
            dtgEmpleados.ItemsSource = null;
            dtgEmpleados.ItemsSource = controllerEmpleado.FindApPaterno(txtApPaterno.Text);
        }
    }
}
