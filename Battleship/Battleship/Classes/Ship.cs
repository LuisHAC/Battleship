using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Classes
{
    class Ship
    {


        #region Variables
        private int size;
        private int x;
        private int y;
        private bool direction;
        #endregion

        #region Get/Sets
        public int Size
        {
            get { return size; }
            set { size = value; }
        }
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
        public bool Direction
        {
            get { return direction; }
            set { direction = value; }
        }

        public void validation()
        {
            if (Direction)
                while ((x + size) > 10)
                    x--;
            else
                while ((y + size) > 10)
                    y--;
        }
        #endregion
    }

}
