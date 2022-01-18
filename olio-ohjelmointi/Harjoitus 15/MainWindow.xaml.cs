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

namespace Harjoitus_15
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int autot = 0;
        int KuormaAutot = 0;
        
        
        public MainWindow()
        {
            InitializeComponent();
            Auto.Text = autot.ToString();
            KuormaAuto.Text = KuormaAutot.ToString();
        }




        private void Button_kuorma_auto_Click(object sender, RoutedEventArgs e)
        {
            KuormaAutot++;
            KuormaAuto.Text = KuormaAutot.ToString();
        }

        private void Button_auto_Click(object sender, RoutedEventArgs e)
        {
            autot++;
            Auto.Text = autot.ToString();
        }
    }
}
