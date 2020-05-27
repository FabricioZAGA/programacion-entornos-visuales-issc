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
using ZGAF_06;
using ZGAF_06.Controller;
using ZGAF_06.Model;

namespace Autos.Gui
{
    /// <summary>
    /// Lógica de interacción para Vehiculos.xaml
    /// </summary>
    public partial class Vehiculos : Window
    {
        ControllerVehiculo controllerVehiculo = null;
        public Vehiculos()
        {
            InitializeComponent();
            controllerVehiculo = new ControllerVehiculo();
            cmbMarca.ItemsSource = new string[] {"Seleccionar", "VolksWagen", "Honda", "Mazda", "BMW"};
            cmbMarca.SelectedIndex = 0;
        }

        private void CmbMarca_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (cmbMarca.SelectedIndex)
            {
                case 1: cmbModelo.ItemsSource = new String[] { "Selecciona Modelo", "Jetta", "Bora", "Gol", "Up", "Golf"};
                    cmbModelo.SelectedIndex = 0;
                    break;
                case 2:
                    cmbModelo.ItemsSource = new String[] { "Selecciona Modelo", "Civic", "Fit", "Cr-V", "Accord", "Br_V"};
                    cmbModelo.SelectedIndex = 0;
                    break;
                case 3:
                    cmbModelo.ItemsSource = new String[] { "Selecciona Modelo", "Mx-5", "Cx-3", "Mazda 3", "Mazda 6", "Cx-5"};
                    cmbModelo.SelectedIndex = 0;
                    break;
                case 4:
                    cmbModelo.ItemsSource = new String[] { "Selecciona Modelo", "Serie 1", "Serie 2", "Serie 3", "Serie 5", "Serie 8" };
                    cmbModelo.SelectedIndex = 0;
                    break;
            }
            
        }

        private void BtnAddVehiculo_Click(object sender, RoutedEventArgs e)
        {
            Categoria categoria = new Categoria();
            Vehiculo vehiculo = new Vehiculo();
            categoria.Marca = cmbMarca.SelectedItem.ToString();
            categoria.Modelo = cmbModelo.SelectedItem.ToString();
            vehiculo._Categoria = categoria;
            vehiculo.Tipo = txtTipo.Text;
            vehiculo.Precio = Int32.Parse(txtPrecio.Text);
            vehiculo.Version = txtVersion.Text;
            vehiculo.NumSerie = txtNumSerie.Text;
            vehiculo.Color = txtColor.Text;
            controllerVehiculo.AgregarVehiculo(vehiculo);
            controllerVehiculo.InsertVehiculo(vehiculo);
            dtgVehiculos.ItemsSource = controllerVehiculo.GetAll();
            dtgVehiculos.Items.Refresh();
        }

        private void BtnFindVehiculo_Click(object sender, RoutedEventArgs e)
        {
            dtgVehiculos.ItemsSource = null;
            dtgVehiculos.ItemsSource = controllerVehiculo.FindMarca(cmbMarca.SelectedItem.ToString());
        }

        private void BtnFindModeloVehiculo_Click(object sender, RoutedEventArgs e)
        {
            dtgVehiculos.ItemsSource = null;
            dtgVehiculos.ItemsSource = controllerVehiculo.FindModelo(cmbModelo.SelectedItem.ToString());
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }
    }
}