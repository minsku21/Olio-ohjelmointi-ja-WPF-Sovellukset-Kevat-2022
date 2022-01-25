using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Harjoitus_26
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Plus_Click(object sender, RoutedEventArgs e)
        {
            float tulos = float.Parse(txt_Luku.Text) + float.Parse(txt_Luku2.Text);
            tb_Yhteen.Text = tulos.ToString();
        }

        private void btn_Miinus_Click(object sender, RoutedEventArgs e)
        {
            float tulos = float.Parse(txt_Luku.Text) - float.Parse(txt_Luku2.Text);
            tb_Yhteen.Text = tulos.ToString();
        }

        private void bt_Clear_Numbers_Click(object sender, RoutedEventArgs e)
        {
            txt_Luku.Clear();
            txt_Luku2.Clear();
        }

        private void _PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
