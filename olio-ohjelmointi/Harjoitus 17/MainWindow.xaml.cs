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

namespace Harjoitus_17
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        float lämpötila = 20;
        bool keittiövalot = false;
        bool olohuoneenvalot = false;
        bool ovilukossa = true;


        public MainWindow()
        {
            InitializeComponent();

            tb_Lämpötila.Text = "Talon sisälämpötila on " + lämpötila;
            tb_Keittiötila.Text = keittiövalot.ToString();
            tb_OlohuoneTila.Text = olohuoneenvalot.ToString();
            btn_Ovi.Content = ovilukossa.ToString();
        }

        private void btn_Keittiö_Click(object sender, RoutedEventArgs e)
        {
            keittiövalot = !keittiövalot;
            tb_Keittiötila.Text = keittiövalot.ToString();
        }

        private void btn_Olohuone_Click(object sender, RoutedEventArgs e)
        {
            olohuoneenvalot = !olohuoneenvalot;
            tb_OlohuoneTila.Text = olohuoneenvalot.ToString();
        }

        private void btn_Ovi_Click(object sender, RoutedEventArgs e)
        {
            ovilukossa = !ovilukossa;
            btn_Ovi.Content = ovilukossa.ToString();
        }

        private void txt_Termostaatti_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_Termostaatti.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txt_Termostaatti.Text = "";
            }
            else
            {
                if (txt_Termostaatti.Text == "")
                    return;


                lämpötila = int.Parse(txt_Termostaatti.Text);
                tb_Lämpötila.Text = "Talon sisälämpötila on " + lämpötila;
            }
        }
    }
}
