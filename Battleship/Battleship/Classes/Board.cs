using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Classes
{
    class Board
    {

        private Byte[,] matrix;
        private char type;
        private char[] status;
        private List<Point> ShootingsLogs;
        //Type puede ser 'O' para el tablero de ofensiva o 'D' para el defensivo (donde se ponen los barcos)
        public Byte Value(int row, int column)
        {
            return matrix[row, column];
        }
        public bool Repeated(Point point)
        {
            foreach (Point p in ShootingsLogs)
            {
                if (p.X == point.X && p.Y == point.Y)
                {
                    return true;
                }
            }
            return false;
        }
        public char Type
        {
            get { return type; }
            set { type = value; }
        }
        public char[] Status
        {
            get { return status; }
            set { status = value; }
        }
        public Board(bool Defense)
        {
            matrix = new byte[10, 10];
            if (Defense)
                type = 'D';
            else
                type = 'O';
            status = new char[5];
        }
        public int LiveShips()
        {
            int count = 0;
            foreach (char ship in status)
            {
                if (status[ship] == 'S')
                    count++;
            }
            return count;
        }

    }
}