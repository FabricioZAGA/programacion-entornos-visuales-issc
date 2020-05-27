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
using ZGAF_02.Controller;
using ZGAF_02.Model;

namespace ZGAF_02.Gui
{
    /// <summary>
    /// Lógica de interacción para AgregarProductos.xaml
    /// </summary>
    public partial class AgregarProductos : Window
    {
        public ControllerProducto cp = new ControllerProducto();
        public ModelProducto x = null;
        public AgregarProductos()
        {
            InitializeComponent();
        }
        public void AsignarValores()
        {
            x = new ModelProducto();
            x.Codigo = txtCodigo.Text;
            x.Nombre = txtNombre.Text;
            x.Marca = txtMarca.Text;
            x.FechaLlegada = DateTime.Parse(txtFecha.Text);
        }

        private void BtnAgregarProducto_Click(object sender, RoutedEventArgs e)
        {
            AsignarValores();
            cp.AgregarProducto(x);
        }

        private void BtnCerrar_Click(object sender, RoutedEventArgs e)
        {
            MostrarProductos mp = new MostrarProductos();
            this.Close();
            mp.MostrarDatos(cp);
            mp.Show();
        }
    }
}
