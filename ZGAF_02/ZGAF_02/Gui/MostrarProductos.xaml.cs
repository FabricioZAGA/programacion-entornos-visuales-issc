﻿using System;
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

namespace ZGAF_02.Gui
{
    /// <summary>
    /// Lógica de interacción para MostrarProductos.xaml
    /// </summary>
    public partial class MostrarProductos : Window
    {
        public MostrarProductos()
        {
            InitializeComponent();

        }
        public void MostrarDatos(ControllerProducto cem)
        {

            dtgProductos.ItemsSource = cem.GetAll();
        }
        private void BtnCerrar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Close();
            main.Show();
        }
    }
}
