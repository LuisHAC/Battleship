using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Battleship.Classes
{
    class Conexion
    {
        public static String Servidor = "LAPTOP-S5O159KO"; //Nombre del Servidor
        public static String StringConexion = "Data Source = " + Servidor + ";" +
                                    "Initial Catalog=BATTLESHIP;" + // Catalogo a utilizar
                                    "User Id=sa;" + //Usuario del servidor
                                    "Password=LAPTOP-S5O159KO;connect timeout=50"; //Password del usuario

        public static SqlConnection oConexion = new SqlConnection(StringConexion);
    }



}
