using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR
{
    internal class square
    {
        private int a; // сторона

        public square()
        {
            a = 5;
        }

        public square(int a)
        {
            this.a = a;
        }

        public int A 
        { 
            get { return a; } 
            set { a = value; } 
        }

        public virtual double S()
        {
            return a * a;
        }
    }
}

