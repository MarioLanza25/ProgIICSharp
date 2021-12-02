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

namespace DataGridView
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Telefono> telefonos = new List<Telefono>();

            telefonos.Add(new Telefono("S21 plus", "Samsung", 720.2f));
            telefonos.Add(new Telefono("S21 ", "Samsung", 650));
            telefonos.Add(new Telefono("P40 pro", "Huawei", 620));
            telefonos.Add(new Telefono("Mi 11 pro", "Xiaomi", 700.5f));

            dgvProductos.ItemsSource = telefonos;


        }

        private void btnSeleccionar_Click(object sender, RoutedEventArgs e)
        {
            Telefono telefono = (Telefono)dgvProductos.SelectedItem;

            string msj = string.Format("El modelo {0} de la marca {1} tiene como precio ${2}", 
                telefono.Nombre, telefono.Marca, telefono.Precio);

            MessageBox.Show(msj, "Producto seleccionado");
        }
    }
}
