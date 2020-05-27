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
using ZGAF_EX_3P.Controller;
using ZGAF_EX_3P.Model;

namespace ZGAF_EX_3P
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ControllerMateria cm = new ControllerMateria();
        public MainWindow()
        {
            InitializeComponent();
            dtgMaterias.ItemsSource = cm.GetMaterias();
        }

        private void DtgMaterias_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dtgMaterias.SelectedItem != null)
            {
                try
                {
                    Materia m = (Materia)dtgMaterias.SelectedItem;
                    txtFolio.Text = m.Folio.ToString();
                    txtNombreM.Text = m.Nombre;
                    txtDescripcion.Text = m.Descripcion;
                    txtHorasSemana.Text = m.HorasSemana.ToString();
                    txtNumSemestre.Text = m.NumSemestre.ToString();
                    txtNombreC.Text = m.Nombre_;
                    txtRegistroSep.Text = m.RegistroSep;
                }
                catch { }
            }
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Materia m = new Materia();
                m.Folio = Int32.Parse(txtFolio.Text);
                m.Nombre = txtNombreM.Text;
                m.Descripcion = txtDescripcion.Text;
                m.HorasSemana = Int32.Parse(txtHorasSemana.Text);
                m.NumSemestre = Int32.Parse(txtNumSemestre.Text);
                m.Nombre_ = txtNombreC.Text;
                m.RegistroSep = txtRegistroSep.Text;
                cm.UpdateMateria(m);
            }
            catch
            {
                MessageBox.Show("Ingrese Valores Válidos", "Error");
            }
        }

        private void BtnRefresh_Click(object sender, RoutedEventArgs e)
        {
            dtgMaterias.ItemsSource = null;
            dtgMaterias.ItemsSource = cm.GetMaterias();
        }
    }
}
