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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SivujenVaihto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<Page> Sivut = new List<Page>();
        
        public MainWindow()
        {
            InitializeComponent();

            Sivut.Add(new Page1());
            Sivut.Add(new Page2());
            
            MainFrame.NavigationService.Navigate(Sivut[0]);
        }
        
    }
}
