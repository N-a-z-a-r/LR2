using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR
{
    internal class rectangle : square
    {
        private int b; // різниця між довжинами сторін

        public rectangle()
        {
            b = 5;
        }

        public rectangle(int a, int b)
        {
            this.A = a;
            this.b = b;
        }
        public int B 
        { 
            get { return b; } 
            set { b = value; } 
        }

        public override double S()
        {
            return A * b * 2;
        }
    }
}
