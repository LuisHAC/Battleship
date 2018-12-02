using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Battleship.Formas
{
    public partial class GUI : Form
    {

        public GUI()
        {
            InitializeComponent();
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            HeatUp();
            Paint += new PaintEventHandler(Draw);
        }

        public void Draw(object sender, PaintEventArgs e)
        {
            DoubleBuffered = true;
            int x = 100, y = 100;
            Rectangle square = new Rectangle(x, y, 30, 30);
            Color color = new Color();
            decimal value = new decimal();
            decimal min = MinValue();
            decimal max = MaxValue();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    value = Classes.Globals.Map.Value(i, j);
                    color = HeatMapColor(value, min, max);
                    square = new Rectangle(x, y, 30, 30);
                    e.Graphics.FillRectangle(new SolidBrush(color), square);
                    e.Graphics.DrawRectangle(new Pen(color), square);
                    x += 30;
                }
                y += 30;
                x = 100;
            }

        }
        public Color HeatMapColor(decimal value, decimal min, decimal max)
        {
            decimal val = (value - min) / (max - min);
            int r = Convert.ToByte(255 * val);
            int g = Convert.ToByte(255 * (1 - val));
            int b = 0;

            return Color.FromArgb(255, r, g, b);
        }
        public Color shootColor(int value)
        {
            if (value == 0)
                return Color.Aqua;
            else if (value == 1)
                return Color.Crimson;
            else return Color.Navy;
        }

        public Color placeColor(int value, int x, int y)
        {
            if (checkShips(x, y))
                return Color.Black;
            else if (value == 0)
                return Color.Aqua;
            else if (value == 1)
                return Color.Crimson;
            else return Color.Navy;
        }

        private int MaxValue()
        {
            int max = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (Classes.Globals.Map.Value(i, j) > max)
                    {
                        max = Classes.Globals.Map.Value(i, j);
                    }
                }
            }
            return max;
        }

        private int MinValue()
        {
            int min = int.MaxValue;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (Classes.Globals.Map.Value(i, j) < min)
                    {
                        min = Classes.Globals.Map.Value(i, j);
                        if (min == 0)
                            return min;
                    }
                }
            }
            return min;
        }

        private void HeatUp()
        {
            var conexion = new Classes.Conexion();
            DataTable dt = new DataTable();
            SqlCommand sqlcom = new SqlCommand();
            string Query = "Select SUM(CASE(VALUE1) WHEN 1 THEN 2 WHEN 0 THEN 1 ELSE 0 END) AS 'Row1', " +
        "SUM(CASE(VALUE2) WHEN 1 THEN 2 WHEN 0 THEN 1 ELSE 0 END) AS 'Row2', " +
        "SUM(CASE(VALUE3) WHEN 1 THEN 2 WHEN 0 THEN 1 ELSE 0 END) AS 'Row3', " +
        "SUM(CASE(VALUE4) WHEN 1 THEN 2 WHEN 0 THEN 1 ELSE 0 END) AS 'Row4', " +
        "SUM(CASE(VALUE5) WHEN 1 THEN 2 WHEN 0 THEN 1 ELSE 0 END) AS 'Row5', " +
        "SUM(CASE(VALUE6) WHEN 1 THEN 2 WHEN 0 THEN 1 ELSE 0 END) AS 'Row6', " +
        "SUM(CASE(VALUE7) WHEN 1 THEN 2 WHEN 0 THEN 1 ELSE 0 END) AS 'Row7', " +
        "SUM(CASE(VALUE8) WHEN 1 THEN 2 WHEN 0 THEN 1 ELSE 0 END) AS 'Row8', " +
        "SUM(CASE(VALUE9) WHEN 1 THEN 2 WHEN 0 THEN 1 ELSE 0 END) AS 'Row9', " +
        "SUM(CASE(VALUE10) WHEN 1 THEN 2 WHEN 0 THEN 1 ELSE 0 END) AS 'Row10' " +
        "FROM BOARD  " +
        "GROUP BY RowNo";

            try
            {
                sqlcom.Connection = conexion.oConexion;
                conexion.oConexion.Open();
                
                sqlcom.CommandText = Query;
                sqlcom.CommandType = CommandType.Text;
                SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
                sda.Fill(dt);
            }
            catch(Exception e)
            {
                MessageBox.Show("Error de conexion u.u");
            }
            finally
            {
                conexion.oConexion.Close();
            }

            Classes.Globals.Map.LoadFromDataTable(dt);
            
        }

        private void RiseUp()// mostrara posicion de las naves seleccionadas y donde ha disparado la pc.  merge with HeatUp?
        {
        }

        private bool checkShips(int x, int y)// checar si en esta posicion esta un barco.  
        {
            if ()
            {
                return true;
            }
            else
                return false;
        }
    }
}
