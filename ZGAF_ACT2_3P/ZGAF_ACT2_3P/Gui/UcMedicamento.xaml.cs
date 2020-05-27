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
    /// Lógica de interacción para UcMedicamento.xaml
    /// </summary>
    public partial class UcMedicamento : UserControl
    {
        ControllerMedicamento cm = new ControllerMedicamento();
        Medicamento medicamento = null;
        public UcMedicamento()
        {
            InitializeComponent();
            MostrarDatos(cm);
        }
        public void MostrarDatos(ControllerMedicamento controllerMedicamento)
        {
            dtgMedicamentos.ItemsSource = controllerMedicamento.GetMedicamentos();
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            SetValores();
            cm.InsertMedicamento(medicamento);
        }

        private void BtnModificar_Click(object sender, RoutedEventArgs e)
        {
            SetValores();

            cm.UpdateMedicamento(medicamento);
            
        }

        private void SetValores()
        {
            medicamento = new Medicamento();
            medicamento.NombreGeneral = txtNG.Text;
            medicamento.FormaFarmaceutica = txtFormaF.Text;
            medicamento.Concentracion = txtConcentracion.Text;
            medicamento.PricipalIndicacion = txtIndicacion.Text;
            medicamento.PrecioUnidad = Int32.Parse(txtPrecioU.Text);
            medicamento.Activo = Int32.Parse(txtActivo.Text);
            medicamento.UnidadesEnvase = Int32.Parse(txtUnidadesE.Text);
            medicamento.UnidadMedida = txtUnidadesMedida.Text;
            medicamento.Categoria = Int32.Parse(txtCategoria.Text);
            try
            {
                medicamento.IdMedicamento = Int32.Parse(txtIdM.Text);
            }
            catch
            {

            }
        }

        private void DtgMedicamentos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                Medicamento medicamento = new Medicamento();
                if (dtgMedicamentos.SelectedItem != null)
                {
                    medicamento = (Medicamento)dtgMedicamentos.SelectedItem;
                    txtIdM.Text = medicamento.IdMedicamento.ToString();
                    txtNG.Text = medicamento.NombreGeneral;
                    txtFormaF.Text = medicamento.FormaFarmaceutica;
                    txtConcentracion.Text = medicamento.Concentracion;
                    txtIndicacion.Text = medicamento.PricipalIndicacion;
                    txtPrecioU.Text = medicamento.PrecioUnidad.ToString();
                    txtActivo.Text = medicamento.Activo.ToString();
                    txtUnidadesE.Text = medicamento.UnidadesEnvase.ToString();
                    txtUnidadesMedida.Text = medicamento.UnidadMedida;
                    txtCategoria.Text = medicamento.Categoria.ToString();
                }
            }
            catch
            {

            }
        }

        private void BtnActualizar_Copy_Click(object sender, RoutedEventArgs e)
        {
            dtgMedicamentos.ItemsSource = null;
            MostrarDatos(cm);
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            SetValores();
            cm.DeleteMedicamento(medicamento);
        }
    }
}
