using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Classes
{
    class Overwrite
    {
        private Board board;

        public void Save(Board newBoard, bool Mode) //true if Defense, false if Offense
        {
            try
            {
                board = newBoard;
                int[] row1 = new int[10];
                int[] row2 = new int[10];
                int[] row3 = new int[10];
                int[] row4 = new int[10];
                int[] row5 = new int[10];
                int[] row6 = new int[10];
                int[] row7 = new int[10];
                int[] row8 = new int[10];
                int[] row9 = new int[10];
                int[] row10 = new int[10];
                for (int i = 0; i < 10; i++)
                {
                    row1[i] = board.Value(0, i);
                    row2[i] = board.Value(1, i);
                    row3[i] = board.Value(2, i);
                    row4[i] = board.Value(3, i);
                    row5[i] = board.Value(4, i);
                    row6[i] = board.Value(5, i);
                    row7[i] = board.Value(6, i);
                    row8[i] = board.Value(7, i);
                    row9[i] = board.Value(8, i);
                    row10[i] = board.Value(9, i);
                }

                String sqlQuery = "";
                sqlQuery += "INSERT INTO ";
                if (Mode)
                    sqlQuery += " DEFENSEEXPERIENCE ";
                else
                    sqlQuery += " OFFENSEEXPERIENCE"
                Conexion conexion = new Conexion();

            }
            catch (Exception)
            {

            }

        }
        private void SaveToSql(Board newBoard)
        {

        }
    }
}
