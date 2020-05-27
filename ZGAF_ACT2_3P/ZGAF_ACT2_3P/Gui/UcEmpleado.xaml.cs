using System;
using System.Windows;
using System.Windows.Controls;
using ZGAF_ACT2_3P.Controller;
using ZGAF_ACT2_3P.Model;

namespace ZGAF_ACT2_3P.Gui
{
    /// <summary>
    /// Lógica de interacción para UcEmpleado.xaml
    /// </summary>
    public partial class UcEmpleado : UserControl
    {
        ControllerEmpleado ce = new ControllerEmpleado();
        Empleado empleado = null;
        public UcEmpleado()
        {
            InitializeComponent();
            MostrarDatos(ce);
        }
        public void MostrarDatos(ControllerEmpleado controllerEmpleado)
        {
            dtgEmpleado.ItemsSource = controllerEmpleado.GetEmpleados();
        }



        private void BtnCambiar_Click(object sender, RoutedEventArgs e)
        {
            SetValores();
            ce.UpdateEmpleado(empleado);

        }

        private void BtnActualizar_Copy_Click(object sender, RoutedEventArgs e)
        {
            dtgEmpleado.ItemsSource = null;
            MostrarDatos(ce);
        }

        private void SetValores()
        {
            empleado = new Empleado();
            empleado.Nombre = txtNombre.Text;
            empleado.ApePaterno = txtApPaterno.Text;
            empleado.ApeMaterno = txtApMaterno.Text;
            empleado.IdUsuario = Int32.Parse(txtIdUsuario.Text);
        }

        private void DtgEmpleado_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                Empleado empleado = new Empleado();
                if (dtgEmpleado.SelectedItem != null)
                {
                    empleado = (Empleado)dtgEmpleado.SelectedItem;
                    txtNombre.Text = empleado.Nombre;
                    txtApPaterno.Text = empleado.ApePaterno;
                    txtApMaterno.Text = empleado.ApeMaterno;
                    txtIdEmpleado.Text = empleado.IdEmpleado.ToString();
                    txtIdUsuario.Text = empleado.IdUsuario.ToString();
                }
            }
            catch
            {

            }

        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            SetValores();
            ce.DeleteEmpleado(empleado);
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            SetValores();
            ce.InsertEmpleado(empleado);
        }
    }
}
