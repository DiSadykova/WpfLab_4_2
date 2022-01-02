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

namespace WpfLab_4_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //Обработка событий кнопок во вкладке "Валюты"
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDouble = rateDollar * sumDollar;
            resSum.Text = resDouble.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEuro1 = Convert.ToDouble(rateEuro.Text);
            double sumEuro1 = Convert.ToDouble(sumEuro.Text);
            double resDouble = rateEuro1 * sumEuro1;
            resSumEuro.Text = resDouble.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateGriv1 = Convert.ToDouble(rateGriv.Text);
            double sumGriv1 = Convert.ToDouble(sumGriv.Text);
            double resDouble = rateGriv1 * sumGriv1;
            resSumGriv.Text = resDouble.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateArDram1 = Convert.ToDouble(rateArDram.Text);
            double sumArDram1 = Convert.ToDouble(sumArDram.Text);
            double resDouble = rateArDram1 * sumArDram1;
            resSumArDram.Text = resDouble.ToString();
        }


        //Обработка событий кнопок во вкладке "Расстояния"
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double valIn1= Convert.ToDouble(valIn.Text);
            const double inInMeters=0.0254;
            double resDouble = valIn1 * inInMeters;
            resInchesInMeters.Text = resDouble.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double valFoot1 = Convert.ToDouble(valFoot.Text);
            const double ftInMeters = 0.3048;
            double resDouble = valFoot1 * ftInMeters;
            resFootsInMeters.Text = resDouble.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double valMile1 = Convert.ToDouble(valMile.Text);
            const double miInMeters = 1609.344;
            double resDouble = valMile1 * miInMeters;
            resMiliesInMeters.Text = resDouble.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double valVerst1 = Convert.ToDouble(valVerst.Text);
            const double verstInMeters = 1066.8;
            double resDouble = valVerst1 *verstInMeters;
            resVerstsInMeters.Text = resDouble.ToString();
        }
    }
}
