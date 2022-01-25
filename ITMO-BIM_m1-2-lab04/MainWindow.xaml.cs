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

namespace ITMO_BIM_m1_2_lab04
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double A = Convert.ToDouble(sumUSD.Text);
                double B = Convert.ToDouble(USDrate.Text);
                if (A >= 0 && B >= 0)
                {
                    sum1.Foreground = Brushes.Black;
                    sum1.Text = Convert.ToString(A * B);
                }
                else 
                {
                    sum1.Foreground = Brushes.Red;
                    sum1.Text = "Отриц.значение!";
                }
            }
            catch 
            {
                sum1.Foreground = Brushes.Red;
                sum1.Text = "Недопустимый символ!";
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                double A = Convert.ToDouble(sumEUR.Text);
                double B = Convert.ToDouble(EURrate.Text);
                if (A >= 0 && B >= 0)
                {
                    sum2.Foreground = Brushes.Black;
                    sum2.Text = Convert.ToString(A * B);
                }
                else
                {
                    sum2.Foreground = Brushes.Red;
                    sum2.Text = "Отриц.значение!";
                }
            }
            catch
            {
                sum2.Foreground = Brushes.Red;
                sum2.Text = "Недопустимый символ!";
            }
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                double A = Convert.ToDouble(sumUAH.Text);
                double B = Convert.ToDouble(UAHrate.Text);
                if (A >= 0 && B >= 0)
                {
                    sum3.Foreground = Brushes.Black;
                    sum3.Text = Convert.ToString(A * B);
                }
                else
                {
                    sum3.Foreground = Brushes.Red;
                    sum3.Text = "Отриц.значение!";
                }
            }
            catch
            {
                sum3.Foreground = Brushes.Red;
                sum3.Text = "Недопустимый символ!";
            }
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                double A = Convert.ToDouble(sumAMD.Text);
                double B = Convert.ToDouble(AMDrate.Text);
                if (A >= 0 && B >= 0)
                {
                    sum4.Foreground = Brushes.Black;
                    sum4.Text = Convert.ToString(A * B);
                }
                else
                {
                    sum4.Foreground = Brushes.Red;
                    sum4.Text = "Отриц.значение!";
                }
            }
            catch
            {
                sum4.Foreground = Brushes.Red;
                sum4.Text = "Недопустимый символ!";
            }
        }

        private void Button_Click_IN(object sender, RoutedEventArgs e)
        {
            try
            {
                double A = Convert.ToDouble(lenIN.Text);
                if (A >= 0)
                {
                    resIN.Foreground = Brushes.Black;
                    resIN.Text = Convert.ToString(A * 0.0254);
                }
                else
                {
                    resIN.Foreground = Brushes.Red;
                    resIN.Text = "Отриц.значение!";
                }
            }
            catch
            {
                resIN.Foreground = Brushes.Red;
                resIN.Text = "Недопустимый символ!";
            }
        }
        private void Button_Click_ML(object sender, RoutedEventArgs e)
        {
            try
            {
                double A = Convert.ToDouble(lenML.Text);
                if (A >= 0)
                {
                    resML.Foreground = Brushes.Black;
                    resML.Text = Convert.ToString(A * 1609.34);
                }
                else
                {
                    resML.Foreground = Brushes.Red;
                    resML.Text = "Отриц.значение!";
                }
            }
            catch
            {
                resML.Foreground = Brushes.Red;
                resML.Text = "Недопустимый символ!";
            }
        }
        private void Button_Click_FT(object sender, RoutedEventArgs e)
        {
            try
            {
                double A = Convert.ToDouble(lenFT.Text);
                if (A >= 0)
                {
                    resFT.Foreground = Brushes.Black;
                    resFT.Text = Convert.ToString(A * 0.3048);
                }
                else
                {
                    resFT.Foreground = Brushes.Red;
                    resFT.Text = "Отриц.значение!";
                }
            }
            catch
            {
                resFT.Foreground = Brushes.Red;
                resFT.Text = "Недопустимый символ!";
            }
        }
        private void Button_Click_VR(object sender, RoutedEventArgs e)
        {
            try
            {
                double A = Convert.ToDouble(lenVR.Text);
                if (A >= 0)
                {
                    resVR.Foreground = Brushes.Black;
                    resVR.Text = Convert.ToString(A * 1067);
                }
                else
                {
                    resVR.Foreground = Brushes.Red;
                    resVR.Text = "Отриц.значение!";
                }
            }
            catch
            {
                resVR.Foreground = Brushes.Red;
                resVR.Text = "Недопустимый символ!";
            }
        }
    }
}
