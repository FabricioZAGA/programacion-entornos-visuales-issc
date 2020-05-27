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
using ZGAF_ACT1_3P.Controller;
using ZGAF_ACT1_3P.Model;

namespace ZGAF_ACT1_3P.Gui
{
    /// <summary>
    /// Lógica de interacción para VentanaRegistro.xaml
    /// </summary>
    public partial class VentanaRegistro : Window
    {
        Usuario usuario = null;
        ControllerUsuario controllerUsuario = new ControllerUsuario();
        public VentanaRegistro()
        {
            InitializeComponent();
        }

        private void BtnVolver_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }

        private void BtnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            AsignarValores();
            controllerUsuario.InsertUsuario(usuario);
            txtContraseniaUsuario.Password = "";
            txtNombreUsuario.Text = "";
        }

        public void AsignarValores()
        {
            try
            {
                usuario = new Usuario();
                usuario.NombreUsuario = txtNombreUsuario.Text;
                usuario.ContraseniaUsuario = txtContraseniaUsuario.Password;
            }
            catch
            {
                MessageBox.Show("Introduzca Valores Válidos", "¡Error!");
            }
        }
    }
}
