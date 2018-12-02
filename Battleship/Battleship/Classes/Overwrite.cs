using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Battleship.Classes
{
    class Overwrite
    {
        private Board board;

        public void Save(Board newBoard, bool Mode, int stratID, char PhatW) //true if Defense, false if Offense
        {
            try
            {
                board = newBoard;
                int BoardID = 1;
                Conexion conexion = new Conexion();
                SqlCommand sqlcom = new SqlCommand();
                string smallquery = "Select BoardId from Board Order by Desc";

                sqlcom.Connection = conexion.oConexion;
                sqlcom.CommandText = smallquery;
                sqlcom.CommandType = CommandType.Text;
                SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
                DataTable dt = new DataTable();
                conexion.oConexion.Open();
                sda.Fill(dt);
                conexion.oConexion.Close();
                BoardID = int.Parse(dt.Rows[0]["BoardId"].ToString());
                string sqlQuery1 = "";
                for (int i = 0; i < 10; i++)
                {
                    sqlQuery1 += "INSERT INTO " +
                        "BOARD " +
                        "VALUES (" + i + ", " + getBit(board.Value(i, 0)) + ", " + getBit(board.Value(i, 1)) + ", " + getBit(board.Value(i, 2)) + ", " +
                        "" + getBit(board.Value(i, 3)) + ", " + getBit(board.Value(i, 4)) + ", " + getBit(board.Value(i, 5)) + ", " +
                        "" + getBit(board.Value(i, 6)) + ", " + getBit(board.Value(i, 7)) + ", " + getBit(board.Value(i, 8)) + ", " +
                        "" + getBit(board.Value(i, 9)) + ", " + BoardID + ", " + Mode + ") ";
                }
                dt = new DataTable();
                sqlcom.CommandText = sqlQuery1;
                sda = new SqlDataAdapter(sqlcom);
                conexion.oConexion.Open();
                sda.Fill(dt);
                conexion.oConexion.Close();


                String sqlQuery = "";
                sqlQuery += "INSERT INTO ";
                if (Mode)
                    sqlQuery += " DEFENSEEXPERIENCE ";
                else
                    sqlQuery += " OFFENSEEXPERIENCE ";
                sqlQuery += "VALUES (" + BoardID + ", " + stratID + ", " + board.Shots() + ", null, null, "+board.Logs()+", " +
                    ""+ (5 - board.LiveShips()) +", " + board.Shots() + ", " + PhatW + ")";
                dt = new DataTable();
                sqlcom.CommandText = sqlQuery;
                sda = new SqlDataAdapter(sqlcom);
                conexion.oConexion.Open();
                sda.Fill(dt);
                conexion.oConexion.Close();
            }
            catch (Exception)
            {

            }

        }
        private void SaveToSql(Board newBoard)
        {

        }

        private string getBit(int x)
        {
            switch (x)
            {
                case 0:
                    return "null";
                case 1:
                    return "0";
                case 2:
                    return "1";
                default:
                    return null;
            }
        }

        private 
    }
}
