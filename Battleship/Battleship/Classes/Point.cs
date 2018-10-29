using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Classes
{
    class Point
    {
        private int x;
        private int y;
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public Point()
        {
            x = 0;
            y = 0;
        }
        public Point(int a, int b)
        {
            x = a;
            y = b;
        }
    }
}
