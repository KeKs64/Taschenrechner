using NCalc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Drawing;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Converters;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Expression = NCalc.Expression;
using Color = System.Drawing.Color;

namespace Taschenrechner
{
    /// <summary>
    /// Interaction logic for MainWindow1.xaml
    /// </summary>
    public partial class MainWindow1 : UserControl
    {
        public MainWindow1()
        {
            InitializeComponent();
        }


        string Zahl = "  ";

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            Zahl += "0";
            Ergebnis.Text = Zahl;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Zahl += "1";
            Ergebnis.Text = Zahl;
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Zahl += "2";
            Ergebnis.Text = Zahl;
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            Zahl += "3";
            Ergebnis.Text = Zahl;
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            Zahl += "4";
            Ergebnis.Text = Zahl;
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            Zahl += "5";
            Ergebnis.Text = Zahl;
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            Zahl += "6";
            Ergebnis.Text = Zahl;
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            Zahl += "7";
            Ergebnis.Text = Zahl;
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            Zahl += "8";
            Ergebnis.Text = Zahl;
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            Zahl += "9";
            Ergebnis.Text = Zahl;
        }

        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            Zahl += "+";
            Ergebnis.Text = Zahl;
            if (Zahl[Zahl.Length - 2] == '+')
            {
                Zahl = Zahl.Remove(Zahl.ToString().Length - 1);
            }
            if (Zahl[Zahl.Length - 2] == '-')
            {
                Zahl = Zahl.Remove(Zahl.ToString().Length - 1);
            }
            if (Zahl[Zahl.Length - 2] == '/')
            {
                Zahl = Zahl.Remove(Zahl.ToString().Length - 1);
            }
            if (Zahl[Zahl.Length - 2] == '*')
            {
                Zahl = Zahl.Remove(Zahl.ToString().Length - 1);
            }
        }

        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            Zahl += "-";
            Ergebnis.Text = Zahl;
            if (Zahl[Zahl.Length - 2] == '-')
            {
                Zahl = Zahl.Remove(Zahl.ToString().Length - 1);
            }
            if (Zahl[Zahl.Length - 2] == '/')
            {
                Zahl = Zahl.Remove(Zahl.ToString().Length - 1);
            }
            if (Zahl[Zahl.Length - 2] == '*')
            {
                Zahl = Zahl.Remove(Zahl.ToString().Length - 1);
            }
            if (Zahl[Zahl.Length - 2] == '+')
            {
                Zahl = Zahl.Remove(Zahl.ToString().Length - 1);
            }
        }

        private void ButtonMal_Click(object sender, RoutedEventArgs e)
        {
            Zahl += "*";
            Ergebnis.Text = Zahl;
            if (Zahl[Zahl.Length - 2] == '*')
            {
                Zahl = Zahl.Remove(Zahl.ToString().Length - 1);
            }
            if (Zahl[Zahl.Length - 2] == '/')
            {
                Zahl = Zahl.Remove(Zahl.ToString().Length - 1);
            }
            if (Zahl[Zahl.Length - 2] == '-')
            {
                Zahl = Zahl.Remove(Zahl.ToString().Length - 1);
            }
            if (Zahl[Zahl.Length - 2] == '+')
            {
                Zahl = Zahl.Remove(Zahl.ToString().Length - 1);
            }
        }

        private void ButtonGeteilt_Click(object sender, RoutedEventArgs e)
        {
            Zahl += "/";
            Ergebnis.Text = Zahl;
            if (Zahl[Zahl.Length - 2] == '/')
            {
                Zahl = Zahl.Remove(Zahl.ToString().Length - 1);
            }
            if (Zahl[Zahl.Length - 2] == '*')
            {
                Zahl = Zahl.Remove(Zahl.ToString().Length - 1);
            }
            if (Zahl[Zahl.Length - 2] == '-')
            {
                Zahl = Zahl.Remove(Zahl.ToString().Length - 1);
            }
            if (Zahl[Zahl.Length - 2] == '+')
            {
                Zahl = Zahl.Remove(Zahl.ToString().Length - 1);
            }
        }

        private void ButtonErgebnis_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var result = new Expression(Zahl);
                Ergebnis.Text = result.Evaluate().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            Zahl = "  ";
            Ergebnis.Text = Zahl;
        }

        private void ButtonKomma_Click(object sender, RoutedEventArgs e)
        {
            Zahl += ",";
            Ergebnis.Text = Zahl;
        }


        private void ButtonKlammerAuf_Click(object sender, RoutedEventArgs e)
        {
            Zahl += "(";
            Ergebnis.Text = Zahl;
        }

        private void ButtonKlammerZu_Click(object sender, RoutedEventArgs e)
        {
            Zahl += ")";
            Ergebnis.Text = Zahl;
        }
    }
}
