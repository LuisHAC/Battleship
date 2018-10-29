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
        //Type puede ser 'O' para el tablero de ofensiva o 'D' para el defensivo (donde se ponen los barcos)
        public Byte Value(int row, int column)
        {
            return matrix[row, column];
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
        public Board()
        {
            matrix = new byte[10, 10];
            type = 'D';
            status = new char[5];
        }

    }
}
