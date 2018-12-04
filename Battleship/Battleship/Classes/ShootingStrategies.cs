using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Battleship.Classes
{
    class ShootingStrategies
    {
        public int SpiralTurn = 0;
        
        public Point Spiral()
        {
            int aux;
            Point point = new Point();
            aux = SpiralTurn % 4;
            switch (SpiralTurn)
            {
                case 1:
                    point.X = SpiralTurn / 4;
                    point.Y = SpiralTurn / 4;
                    break;
                case 2:
                    point.X = SpiralTurn / 4;
                    point.Y = 10 - SpiralTurn / 4;
                    break;
                case 3:
                    point.X = 10 - SpiralTurn / 4;
                    point.Y = 10 - SpiralTurn / 4;
                    break;
                case 4:
                    point.X = 10 - SpiralTurn / 4;
                    point.Y = SpiralTurn / 4;
                    break;
                default:
                    point.X = SpiralTurn / 4;
                    point.Y = SpiralTurn / 4;
                    break;
            }
            SpiralTurn++;
            return point;
        }

        public Point Random()
        {
            Random RNG = new Random();
            Point point = new Point(RNG.Next(1, 11), RNG.Next(1, 11));
            if (!Globals.Offense.Repeated(point))
                return point;
            else
                return Random();
        }


        public Point Quadrantes(Board board, int boardLength, int inicioX, int inicioY)
        {
            Point point = new Point();
            int[] Quadrants = new int[4];
            boardLength = boardLength / 2;

            if (boardLength == 1) //RECURSIVO?!?!?!?! NANI??!!
            {
                point.X = inicioX;
                point.Y = inicioY;
                return point;
            }

            /* Cuatro cuadrantes [0,1,2,3]
             * 
             * //////////////////
             * /        /       /
             * /    0   /   1   /
             * /        /       /
             * //////////////////
             * /        /       /
             * /    2   /   3   /
             * /        /       /
             * //////////////////
             */
            for (int i = inicioY; i < boardLength; i++) //CUADRANTE 0
            {
                for (int x = inicioX; x < boardLength; i++)
                {
                    Quadrants[0] = Quadrants[0] + board.Value(i, x);
                }
            }
            for (int i = inicioY; i < boardLength; i++) //CUADRANTE 1
            {
                for (int x = inicioX + boardLength; x < (boardLength * 2); i++)
                {
                    Quadrants[1] = Quadrants[1] + board.Value(i, x);
                }
            }
            for (int i = inicioY + boardLength; i < (boardLength * 2); i++) //CUADRANTE 2
            {
                for (int x = inicioX; x < boardLength; i++)
                {
                    Quadrants[2] = Quadrants[2] + board.Value(i, x);
                }
            }
            for (int i = inicioY + boardLength; i < (boardLength * 2); i++) //CUADRANTE 3
            {
                for (int x = inicioX + boardLength; x < (boardLength * 2); i++)
                {
                    Quadrants[3] = Quadrants[3] + board.Value(i, x);
                }
            }

            int QNum = Quadrants[0], maxQuadrant = 0;
            for (int i = 0; i < Quadrants.Length; i++) //QUE CUADRANTE TIENE MEJOR PUNTUACION?????????
            {
                if (QNum < Quadrants[i])
                {
                    QNum = Quadrants[i];
                    maxQuadrant = i;
                }
            }

            switch (maxQuadrant)
            {
                case 0:
                    Quadrantes(board, boardLength, 0, 0);//Q0
                    break;
                case 1:
                    Quadrantes(board, boardLength, boardLength, 0);//Q1
                    break;
                case 2:
                    Quadrantes(board, boardLength, 0, boardLength);//Q2
                    break;
                case 3:
                    Quadrantes(board, boardLength, boardLength, boardLength);//Q3
                    break;
                default:
                    break;
            }

            return null;//si llegaste aqui, te pusiste pesado
        }

        public Point Hunt(Point root, char dir)
        {
            Point point = new Point();
            Random RNG = new Random();
            int option = RNG.Next(1, 4);
            point = root;
            if (dir.Equals(null))
            {
                switch (option)
                {
                    case 1:
                        point.X++;
                        break;
                    case 2:
                        point.X--;
                        break;
                    case 3:
                        point.Y++;
                        break;
                    case 4:
                        point.Y--;
                        break;
                }
            }
            else
            {
                switch (dir)
                {
                    case 'R':
                        point.X++;
                        break;
                    case 'L':
                        point.X--;
                        break;
                    case 'U':
                        point.Y++;
                        break;
                    case 'D':
                        point.Y--;
                        break;
                }
            }
            return point;
        }
    }
}
