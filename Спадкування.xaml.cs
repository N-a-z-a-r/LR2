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
using System.Windows.Shapes;

namespace LR
{
    /// <summary>
    /// Логика взаимодействия для Спадкування.xaml
    /// </summary>
    public partial class Спадкування : Window
    {
        public Спадкування()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // створюємо квадрат
            var square = new square(Convert.ToInt32(a1.Text));

            s1.Content = square.S().ToString();

            // створюємо прямокутник
            var rectangle = new rectangle(Convert.ToInt32(a2.Text), Convert.ToInt32(b2.Text));

            s2.Content = rectangle.S().ToString();
        }
    }
}
