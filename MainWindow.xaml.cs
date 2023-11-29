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

namespace LR
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // Оголошую три об'єкти класу
            Square square1, square2, square3;

            try
            {
                // Отримуємо значення з текстового поля
                int a = int.Parse(Text_box_1.Text);
                int b = int.Parse(Text_box_2.Text);
                int c = int.Parse(Text_box_3.Text);

                // Створюємо об'єкти класу Square
                square1 = new Square(a);
                square2 = new Square(b, c);
                square3 = new Square();

                // Виводимо результати обчислень
                labelSide1.Content = square1.Side;
                labelPerimeter1.Content = square1.Perimeter;
                labelArea1.Content = square1.Area;

                labelSide2.Content = square2.Side;
                labelPerimeter2.Content = square2.Perimeter;
                labelArea2.Content = square2.Area;

                labelSide3.Content = square3.Side;
                labelPerimeter3.Content = square3.Perimeter;
                labelArea3.Content = square3.Area;
            }
            catch
            {
                MessageBox.Show("Помилка при введенні данних");
            };
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            // показати вікно спадкування
            var СпадкуванняWindow = new Спадкування();
            СпадкуванняWindow.Show();
        }
    }
}