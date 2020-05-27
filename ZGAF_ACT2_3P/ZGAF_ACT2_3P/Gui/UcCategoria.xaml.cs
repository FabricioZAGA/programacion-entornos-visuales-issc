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
    /// Lógica de interacción para UcCategoria.xaml
    /// </summary>
    public partial class UcCategoria : UserControl
    {
        ControllerCategoria cc = new ControllerCategoria();
        public UcCategoria()
        {
            InitializeComponent();
            MostrarDatos(cc);
        }

        public void MostrarDatos(ControllerCategoria controllerCategoria)
        {
            dtgCategoria.ItemsSource = controllerCategoria.GetCategorias();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            Categoria categoria = new Categoria();
            categoria.Proveedor = txtProovedores.Text;
            cc.InsertCategoria(categoria);
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Categoria categoria = new Categoria();
            categoria.Proveedor = txtProovedores.Text;
            categoria.IdCategoria = Int32.Parse(txtIdCategoria.Text);
            cc.UpdateCategoria(categoria);
        }

        private void BtnActualizar_Copy_Click(object sender, RoutedEventArgs e)
        {
            dtgCategoria.ItemsSource = null;
            MostrarDatos(cc);
        }

        private void DtgCategoria_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                Categoria categoria = new Categoria();
                if (dtgCategoria.SelectedItem != null)
                {
                    categoria = (Categoria)dtgCategoria.SelectedItem;
                    txtIdCategoria.Text = categoria.IdCategoria.ToString();
                    txtProovedores.Text = categoria.Proveedor;

                }
            }
            catch
            {

            }
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            Categoria categoria = new Categoria();
            categoria.Proveedor = txtProovedores.Text;
            categoria.IdCategoria = Int32.Parse(txtIdCategoria.Text);
            cc.DeleteCategoria(categoria);
        }
    }
}
