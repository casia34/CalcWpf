
﻿using CalcWpf.FuncSMat;
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

namespace CalcWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool flagToUseTheSecondVar = false;
        enum Current
        {
            Somm,
            Menus,
            Multy,
            Divd
        }

        public MainWindow()
        {
            InitializeComponent();
        }

     

       

        private void NumberOne_Click(object sender, RoutedEventArgs e)
        {
            if (flagToUseTheSecondVar)
            {
                ValueB.Text += "1";
            }
            else
            {
                ValueA.Text += "1";
            }
           
        }

        private void Result_Click(object sender, RoutedEventArgs e)
        {
            ValueA.Text = MatsMetod.somma(int.Parse(ValueA.Text),int.Parse(ValueB.Text)).ToString();
            ValueB.Text = "";
            Operetor.Text = "";
        }

        private void Piu_Button_Click(object sender, RoutedEventArgs e)
        {
            flagToUseTheSecondVar = true;
            Operetor.Text += "+";
        }
    }
}
