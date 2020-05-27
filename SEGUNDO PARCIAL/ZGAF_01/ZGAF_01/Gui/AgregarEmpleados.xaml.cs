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
using ZGAF_01.MODEL;
using ZGAF_01.CONTROLLER;

namespace ZGAF_01.GUI
{
    /// <summary>
    /// Lógica de interacción para AgregarEmpleados.xaml
    /// </summary>
    public partial class AgregarEmpleados : Window
    {
        ControllerEmpleados controllerEmpleados = new ControllerEmpleados();
        public AgregarEmpleados()
        {
            InitializeComponent();
        }

        public ModelEmpleado AsignarValores()
        {
            ModelEmpleado empleado = new ModelEmpleado();
            empleado.Codigo = this.txtCodigo.Text;
            empleado.Nombre = this.txtNombre.Text;
            empleado.Paterno = this.txtPaterno.Text;
            empleado.Materno = this.txtMaterno.Text;
            return empleado;
        }

        private void BtnAgregarEmpleado_Click(object sender, RoutedEventArgs e) 
        {
            AsignarValores();
            controllerEmpleados.AgregarEmpleado(AsignarValores());
            MessageBox.Show("Se ha agregado un empleado", "¡Éxito!");
        }
    }
}
