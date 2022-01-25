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

namespace Harjoitus_20
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Opiskelija> Opiskelijat = new List<Opiskelija>();
        
        public MainWindow()
        {
            InitializeComponent();
            dg_Opiskelijat.ItemsSource = Opiskelijat;
        }

        private void btn_LisääOpiskelija_Click(object sender, RoutedEventArgs e)
        {
            string etunimi = tb_Etunimi.Text;
            string sukunimi = tb_Sukunimi.Text;
            string puhelinnumero = tb_Puhelinnumero.Text;
            string sähköposti = tb_Sähköposti.Text;
            string opiskelijaID = tb_OpiskelijaID.Text;

            Opiskelijat.Add(new Opiskelija(etunimi, sukunimi, puhelinnumero, sähköposti, opiskelijaID));
            dg_Opiskelijat.ItemsSource = Opiskelijat;

            tb_Etunimi.Text = "";
            tb_Sukunimi.Text = "";
            tb_Puhelinnumero.Text = "";
            tb_Sähköposti.Text = "";
            tb_OpiskelijaID.Text = "";
        }

        private void btn_PoistaOpiskelija_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
