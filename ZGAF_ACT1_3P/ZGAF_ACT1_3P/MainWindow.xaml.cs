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
using ZGAF_ACT1_3P.Controller;
using ZGAF_ACT1_3P.Gui;
using ZGAF_ACT1_3P.Model;

namespace ZGAF_ACT1_3P
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Usuario usuario = null;
        ControllerUsuario controllerUsuario = new ControllerUsuario();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnRegistro_Click(object sender, RoutedEventArgs e)
        {
            VentanaRegistro ventanaRegistro = new VentanaRegistro();
            this.Close();
            ventanaRegistro.Show();
        }

        private void BtnLogIn_Click(object sender, RoutedEventArgs e)
        {
            AsignarValores();
            bool login = controllerUsuario.LogIngUsuario(usuario);
            if(login)
            {
                VentanaPrincipal ventanaPrincipal = new VentanaPrincipal();
                this.Close();
                ventanaPrincipal.Show();

            }
            else
            {
                txtContraseniaUsuario.Password = "";
                txtNombreUsuario.Text = "";
            }
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
