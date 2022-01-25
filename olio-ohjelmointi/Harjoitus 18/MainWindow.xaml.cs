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

namespace Harjoitus_18
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

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            float tulos = float.Parse(txt_Luku.Text) + float.Parse(txt_Luku2.Text);
            tb_Lopputulos.Text = tulos.ToString();
        }

        private void Miinus_Click(object sender, RoutedEventArgs e)
        {
            float tulos = float.Parse(txt_Luku.Text) - float.Parse(txt_Luku2.Text);
            tb_Lopputulos.Text = tulos.ToString();
        }

        private void Jako_Click(object sender, RoutedEventArgs e)
        {
            float tulos = float.Parse(txt_Luku.Text) / float.Parse(txt_Luku2.Text);
            tb_Lopputulos.Text = tulos.ToString();
        }

        private void Kerto_Click(object sender, RoutedEventArgs e)
        {
            float tulos = float.Parse(txt_Luku.Text) * float.Parse(txt_Luku2.Text);
            tb_Lopputulos.Text = tulos.ToString();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_Luku.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txt_Luku.Text = "";
            }
            
            
        }

        private void txt_Luku2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_Luku2.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txt_Luku2.Text = "";
            }
        }
    }
}
