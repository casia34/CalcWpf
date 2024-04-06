
using CalcWpf.FuncSMat;
using System;

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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
            
          var FileNames = Directory.GetFiles( Assembly.GetAssembly(typeof(MatsMetod)).Location.Split("bin")[0] + @"Canzoni");
         
        }




        private void AddNumber_Click(object sender, RoutedEventArgs e)
        {
            Button buttonEventGener = (Button)sender;
            if (flagToUseTheSecondVar)
            {
                ValueB.Text += buttonEventGener.Content;
            }
            else
            {
                ValueA.Text += buttonEventGener.Content;
            }

        }

        private void Result_Click(object sender, RoutedEventArgs e)
        {
            if (Operetor.Text == "+")
            {
                ValueA.Text = MatsMetod.somma(decimal.Parse(ValueA.Text), decimal.Parse(ValueB.Text)).ToString();

            }else if (Operetor.Text == "-")
            {
                ValueA.Text = MatsMetod.sottrazione(decimal.Parse(ValueA.Text), decimal.Parse(ValueB.Text)).ToString();

            }
            else if (Operetor.Text == "*")
            {
                ValueA.Text = MatsMetod.Moltiplicazione(decimal.Parse(ValueA.Text), decimal.Parse(ValueB.Text)).ToString();

            }
            else if (Operetor.Text == "/")
            {
                ValueA.Text = MatsMetod.Divisione(decimal.Parse(ValueA.Text), decimal.Parse(ValueB.Text)).ToString();

            }

            ValueB.Text = "";
            Operetor.Text = "";
        }

        private void Piu_Button_Click(object sender, RoutedEventArgs e)
        {

            System.Media.SoundPlayer player = new System.Media.SoundPlayer();

            player.SoundLocation = @"..\\Canzoni\\Daft Punk - One More Time (Official Video).wav";
            player.Play();

            flagToUseTheSecondVar = true;
            Operetor.Text += "+";
        }

        private void Meno_Button_Click(object sender, RoutedEventArgs e)
        {
            flagToUseTheSecondVar = true;
            Operetor.Text += "-";
        }

        private void divso_button_Click(object sender, RoutedEventArgs e)
        {
            flagToUseTheSecondVar = true;
            Operetor.Text += "/";
        }

        private void Moltiplicazione_Button_Click(object sender, RoutedEventArgs e)
        {
            flagToUseTheSecondVar = true;
            Operetor.Text += "*";
        }
    }
}
