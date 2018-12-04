using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Battleship.Classes
{
    class Board
    {

        private int[,] matrix;
        private char type;
        private char[] status;
        private List<Point> ShootingsLogs = new List<Point>();
        //Type puede ser 'O' para el tablero de ofensiva o 'D' para el defensivo (donde se ponen los barcos)
        public int Value(int row, int column)
        {
             return matrix[row, column];
        }

        public void setValue(int row, int column, int value)
        {
            matrix[row, column] = value;
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
            matrix = new int[10, 10];
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
        public string Logs()
        {
            string log = "";
            foreach (Point p in ShootingsLogs)
            {
                switch (p.X)
                {
                    case 0:
                        log += "A";
                        break;
                    case 1:
                        log += "B";
                        break;
                    case 2:
                        log += "C";
                        break;
                    case 3:
                        log += "D";
                        break;
                    case 4:
                        log += "E";
                        break;
                    case 5:
                        log += "F";
                        break;
                    case 6:
                        log += "G";
                        break;
                    case 7:
                        log += "H";
                        break;
                    case 8:
                        log += "I";
                        break;
                    case 9:
                        log += "J";
                        break;
                    default:
                        log += "";
                        break;
                }
                log += p.Y;
            }
            return log;
        }
        public int Shots()
        {
            return ShootingsLogs.Count();
        }

        public void LoadFromDataTable(DataTable board)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matrix[j, i] = int.Parse(board.Rows[i][j].ToString());
                }
            }
        }

    }
}