﻿using System;
using System.Diagnostics;
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

namespace WPF_Testing
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

        private void Number1_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Number2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Calculate__Click(object sender, RoutedEventArgs e)
        {
            double FirstNumber = Convert.ToDouble(Number1.Text);
            double SecondNumber = Convert.ToDouble(Number2.Text);
            double Answer = FirstNumber + SecondNumber;
            theAnswer.Text = "The answer is: \n" + Answer;
        }

    }
}
