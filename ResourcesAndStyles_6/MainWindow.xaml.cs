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

namespace ResourcesAndStyles_6
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

        private void CalculateBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = double.Parse(TB_1.Text);
                double b = double.Parse(TB_2.Text);

                if (b != 0)
                {
                    lbl_result.Content = "Частное - " + a / b + ", остаток - " + a % b;
                }
                else lbl_result.Content = "Невозможно поделить";
            }
            catch (Exception)
            {
                lbl_result.Content = "Неверные данные";
            }
        }
    }
}
