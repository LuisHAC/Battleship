﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Battleship.Classes
{
    class Conexion
    {
        public static String Servidor = "(local)"; //Nombre del Servidor
        public static String StringConexion = "Data Source = " + Servidor + ";" +
                                    "Initial Catalog=BATTLESHIP;" + // Catalogo a utilizar
                                    "User Id=sa;" + //Usuario del servidor
                                                    //"Password=DESKTOP-7L99VSP;" +
                                    "Password=LAPTOP-S5O159KO;" + //De Luis
                                    "connect timeout=50"; //Password del usuario

        public SqlConnection oConexion = new SqlConnection(StringConexion);
    }



}
