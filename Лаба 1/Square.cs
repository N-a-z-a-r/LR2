using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR
{
    public class Square
    {
        //Сторона квадрата
        private double side;

        //Конструктор 1, для введення значень з клавіатури
        public Square(double side)
        {
            this.side = side;
        }

        //Конструктор 2, для генерації числа у заданих межах
        public Square(int a, int b)
        {
            generator(a, b);
        }

        //Конструктор 3, для генерації у межах від 0 до 100
        public Square()
        {
            generator(0, 100);
        }

        private void generator(int a, int b)
        {
            Random r = new Random();
            this.side = r.Next(a, b);
        }

        //Метод для обчислення сторони квадрата.
        public double Side
        {
            get { return side; }
            set { side = value; }
        }

        //Метод для обчислення периметра квадрата.
        public double Perimeter
        {
            get { return 4 * side; }
        }

        //Метод для обчислення площі квадрата.
        public double Area
        {
            get { return side * side; }
        }
    }
}
