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
using ZGAF_ACT2_3P.Controller;
using ZGAF_ACT2_3P.Model;

namespace ZGAF_ACT2_3P.Gui
{
    /// <summary>
    /// Lógica de interacción para UcUsuario.xaml
    /// </summary>
    public partial class UcUsuario : UserControl
    {
        ControllerUsuario cu = new ControllerUsuario();
        Usuario usuario = null;
        public UcUsuario()
        {
            InitializeComponent();
            MostrarDatos(cu);
        }
        public void MostrarDatos(ControllerUsuario controllerUsuario)
        {
            dtgUsuarios.ItemsSource = controllerUsuario.GetUsuarios();
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            SetValores();
            cu.InsertUsuario(usuario);
        }

        private void SetValores()
        {
            usuario = new Usuario();
            try
            {
                usuario.IdUsuario = Int32.Parse(txtIdUsuario.Text);
            }
            catch
            {

            }
            
            usuario.Nombre = txtNombre.Text;
            usuario.Contrasenia = txtContrasenia.Text;
            usuario.Rol = txtRol.Text;
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            SetValores();
            cu.UpdateUsuario(usuario);
        }

        private void DtgUsuarios_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario();
                if (dtgUsuarios.SelectedItem != null)
                {
                    usuario = (Usuario)dtgUsuarios.SelectedItem;
                    txtIdUsuario.Text = usuario.IdUsuario.ToString();
                    txtNombre.Text = usuario.Nombre;
                    txtContrasenia.Text = usuario.Contrasenia;
                    txtRol.Text = usuario.Rol;

                }
            }
            catch
            {

            }
        }

        private void BtnActualizar_Copy_Click(object sender, RoutedEventArgs e)
        {
            dtgUsuarios.ItemsSource = null;
            MostrarDatos(cu);
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            SetValores();
            cu.DeleteUsuario(usuario);
        }
    }
}
