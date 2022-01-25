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

namespace Harjoitus_19
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<Page> kerrokset = new List<Page>();

        Hissi hissi = new Hissi();
        
        public MainWindow()
        {
            InitializeComponent();

            kerrokset.Add(new Kerros1());
            kerrokset.Add(new Kerros2());
            kerrokset.Add(new Kerros3());
            kerrokset.Add(new Kerros4());

            VaihdaKerrosta(1);
        }

        void VaihdaKerrosta(int kerros)
        {
            MainFrame.NavigationService.Navigate(kerrokset[kerros - 1]);
            hissi.NykyinenKerros = kerros;
            tb_Kerros.Text = "Kerros " + hissi.NykyinenKerros;
        }
        
        private void btn_Kerros1_Click(object sender, RoutedEventArgs e)
        {
            VaihdaKerrosta(1);
        }

        private void btn_Kerros2_Click(object sender, RoutedEventArgs e)
        {
            VaihdaKerrosta(2);
        }

        private void btn_Kerros3_Click(object sender, RoutedEventArgs e)
        {
            VaihdaKerrosta(3);
        }

        private void btn_Kerros4_Click(object sender, RoutedEventArgs e)
        {
            VaihdaKerrosta(4);
        }
    }
}
