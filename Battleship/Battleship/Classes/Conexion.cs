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
        public static String Servidor = "DESKTOP-0OVR1N1"; //Nombre del Servidor
        public static String StringConexion = "Data Source = " + Servidor + ";" +
                                    "Initial Catalog=BATTLESHIP;" + // Catalogo a utilizar
                                    "Integrated Security=True;"; //Password del usuario

        public SqlConnection oConexion = new SqlConnection(StringConexion);
    }



}
