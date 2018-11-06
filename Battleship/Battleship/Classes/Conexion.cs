using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Classes
{
    class Conexion
    {
        public static String Server = "";
        public static String ConectionString = "Data Source=" + Server + ";" +
                                            "Initial Catalog=ESCOLAR;" +
                                            "User Id=RolandoA;" +
                                            "Password=5425;connect timeout=50";
    }   
}
