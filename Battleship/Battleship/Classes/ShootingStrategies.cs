using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Battleship.Classes
{
    class ShootingStrategies
    {
        private int SpiralTurn = 0;
        
        public Point Spiral()
        {
            //Random RNG = new Random();
            //int option = RNG.Next(1,5);
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

        public Point Quadrants()
        {
            return null;
        }
    }
}
