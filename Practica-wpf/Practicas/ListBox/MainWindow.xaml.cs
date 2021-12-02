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

namespace ListBox
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Departamentos> depts = new List<Departamentos>();

            depts.Add(new Departamentos(){Departamento1 ="Managua", Temperatura1 = 29, Departamento2= "Leon", Temperatura2 = 31});
            depts.Add(new Departamentos() { Departamento1 = "Chinandega", Temperatura1 = 32, Departamento2 = "Masaya", Temperatura2 = 29 });
            depts.Add(new Departamentos() { Departamento1 = "Matagalpa", Temperatura1 = 29, Departamento2 = "Estelí", Temperatura2 = 27 });
            depts.Add(new Departamentos() { Departamento1 = "Jinotega", Temperatura1 = 29, Departamento2 = "Granada", Temperatura2 = 30 });
            depts.Add(new Departamentos() { Departamento1 = "Carazo", Temperatura1 = 27, Departamento2 = "Rivas", Temperatura2 = 28 });

            listaDepts.ItemsSource = depts;

        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            if (listaDepts.SelectedItem != null)
            {
                MessageBox.Show((listaDepts.SelectedItem as Departamentos).Departamento1 = " " +
                    (listaDepts.SelectedItem as Departamentos).Temperatura1 + "C " +
                (listaDepts.SelectedItem as Departamentos).Departamento2 + "C " +
                (listaDepts.SelectedItem as Departamentos).Temperatura2 + "C ");
            }
            else
                MessageBox.Show("Seleccione un departamento");
        }

        public class Departamentos
        {
            public string Departamento1 { get; set; }

            public int Temperatura1 { get; set; }

            public string Departamento2 { get; set; }

            public int Temperatura2 { get; set; }

            public int DiferenciaTmp {
                get {
                    if (Temperatura2 > Temperatura1)
                        return Temperatura2 - Temperatura1;
                    else
                        return Temperatura1 - Temperatura2;
                }
                set { }
            }
        }
    }
}
