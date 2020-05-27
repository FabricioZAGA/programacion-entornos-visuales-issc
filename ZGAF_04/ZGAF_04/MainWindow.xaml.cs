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
using ZGAF_04.Controller;
using ZGAF_04.Db;
using ZGAF_04.Model;

namespace ZGAF_04
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnProbar_Click(object sender, RoutedEventArgs e)
        {
            SqlServerConnection connection = new SqlServerConnection();
            connection.Abrir();
        }

        private void BtnInsertar_Click(object sender, RoutedEventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.NombreUsuario = txtUsuario.Text;
            usuario.NombreContrasenia = txtContrasenia.Text;
            ControllerUsuario controllerUsuario = new ControllerUsuario();
            controllerUsuario.InsertUser(usuario);
        }
    }
}
