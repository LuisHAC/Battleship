using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Classes
{
    class Globals
    {
        public static Board Offense = new Board(false);
        public static Board Defense = new Board(true);
        public static Board Map = new Board(false);
         
    }
}
