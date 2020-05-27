using Parcial2.Controller;
using Parcial2.Db;
using Parcial2.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace Parcial2.Gui
{
    /// <summary>
    /// Lógica de interacción para Almacen.xaml
    /// </summary>
    public partial class Almacen : Window
    {
        public ControllerProducto controllerProducto = new ControllerProducto();
        public Producto producto = null;

        public Almacen()
        {
            InitializeComponent();
            MostrarDatos(controllerProducto);
        }

        

        private void BtnCerrar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }

        public void MostrarDatos(ControllerProducto controllerProducto)
        {
            dtgProductos.ItemsSource = controllerProducto.MostrarProducto();
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            AsignarValores();
            controllerProducto.InsertProducto(producto);
        }

        public void AsignarValores()
        {
            producto = new Producto();
            try
            {

                producto.Nombre = txtNombre.Text;
                producto.Precio = Int32.Parse(txtNombre_Copy.Text);
                producto.Cantidad = Int32.Parse(txtNombre_Copy1.Text);
            }
            catch
            {
                MessageBox.Show("Introduzca Valores Válidos", "¡Error!");
            }

        }
    }
}
