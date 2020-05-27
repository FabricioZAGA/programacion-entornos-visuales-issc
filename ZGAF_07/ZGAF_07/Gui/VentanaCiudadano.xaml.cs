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
using ZGAF_07.Controller;
using ZGAF_07.Model;

namespace ZGAF_07.Gui
{
    /// <summary>
    /// Lógica de interacción para VentanaCiudadano.xaml
    /// </summary>
    public partial class VentanaCiudadano : Window
    {
        ControllerCiudadano controllerCiudadano = new ControllerCiudadano();
        Ciudadano ciudadano;

        public VentanaCiudadano()
        {
            InitializeComponent();
            cbSexo.ItemsSource = new string[] { "Femenino", "Masculino", "Otro", "Seleccionar" };
            cbSexo.SelectedIndex = 3;
            cbColonia.ItemsSource = new string[] { "Seleccionar", "Lomas del Sur", "Narvarte", "Villa Linda", "Jerusalen" };
            cbColonia.SelectedIndex = 0;
        }

        private void BtnAddCiudadano_Click(object sender, RoutedEventArgs e)
        {
            AsignarValores();
            controllerCiudadano.InsertCiudadano(ciudadano);
        }

        public void AsignarValores()
        {
            ciudadano = new Ciudadano();
            try
            {

                ciudadano.Nombre = txtNombre.Text;
                ciudadano.ApellidoPaterno = txtApellidoPaterno.Text;
                ciudadano.ApellidoMaterno = txtApellidoMaterno.Text;
                ciudadano.Sexo = cbSexo.SelectedIndex;
                ciudadano.Colonia = cbColonia.SelectedIndex;
                ciudadano.CodigoPostal = Int32.Parse(txtCodigoPostal.Text);
                ciudadano.FechaIngreso = DateTime.Parse(dtFechaIngreso.Text);
            }
            catch
            {
                MessageBox.Show("Introduzca Valores Válidos", "¡Error!");
            }

        }


        private void CbColonia_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (cbColonia.SelectedIndex)
            {
                case 1:
                    txtCodigoPostal.Text = "32312";
                    break;
                case 2:
                    txtCodigoPostal.Text = "34521";
                    break;
                case 3:
                    txtCodigoPostal.Text = "36789";
                    break;
                case 4:
                    txtCodigoPostal.Text = "37804";
                    break;
            }
        }
    }
}
