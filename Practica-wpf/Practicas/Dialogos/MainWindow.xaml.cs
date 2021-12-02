using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace Dialogos
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

        private void btnSaveDialog_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Text File(*.txt)|*.txt|c# file(*.cs)|*.cs";
            dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (dlg.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                File.WriteAllText(dlg.FileName, txtInfo.Text); 
            }

        }

        private void btnColorDialog_Click(object sender, RoutedEventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
                txtInfo.Foreground = new SolidColorBrush(Color.FromArgb(dlg.Color.A, dlg.Color.R, dlg.Color.G, dlg.Color.B));
        }

        private void btnFontDialog_Click(object sender, RoutedEventArgs e)
        {
            FontDialog dlg = new FontDialog();
            if(dlg.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                txtInfo.FontFamily = new FontFamily(dlg.Font.Name);
                txtInfo.FontSize = dlg.Font.Size * 98.0 / 72.0;
                txtInfo.FontWeight = dlg.Font.Bold ? FontWeights.Bold : FontWeights.Regular;
                txtInfo.FontStyle = dlg.Font.Italic ? FontStyles.Italic : FontStyles.Normal;


            }
        }
    }
}
