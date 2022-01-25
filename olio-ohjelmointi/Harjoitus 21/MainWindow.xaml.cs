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

namespace Harjoitus_21
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

        private void btn_AddToList_Click(object sender, RoutedEventArgs e)
        {
            lb_Lista.Items.Add(input_Tuote.Text);
        }
        private void btn_RemoveFromList_Click(object sender, RoutedEventArgs e)
        {
            lb_Lista.Items.Remove(input_Tuote.Text);
        }

        private void btn_ClearList_Click(object sender, RoutedEventArgs e)
        {
            lb_Lista.Items.Clear();
        }
    }
}
