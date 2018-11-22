﻿using System;
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

        }

        public void Draw(object sender, PaintEventArgs e)
        {
            DoubleBuffered = true;
            int x = (GB_Map.Location.X + 5), y = (GB_Map.Location.Y + 5);
            Rectangle square = new Rectangle(x, y, 10, 10);
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
                    square = new Rectangle(x, y, 10, 10);
                    e.Graphics.DrawRectangle(new Pen(color), square);
                    x += 10;
                }
                y += 10;
                x = (GB_Map.Location.X + 5);
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
            SqlCommand sqlcom = new SqlCommand();
            string Query = "Select SUM(Value1), SUM(Value2), SUM(Value3), SUM(Value3) " +
                ", SUM(Value5), SUM(Value6), SUM(Value7), SUM(Value8) " +
                ", SUM(Value9), SUM(Value10) " +
                " FROM BOARD " +
                "GROUP BY Row1, Row2, Row3, Row4, Row5, Row6, Row7, Row8, Row9, Row10";
            sqlcom.Connection = conexion.oConexion;
            sqlcom.CommandText = Query;
            sqlcom.CommandType = CommandType.Text;
            SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
            DataTable dt = new DataTable();
            conexion.oConexion.Open();
            sda.Fill(dt);
            conexion.oConexion.Close();

        }
    }
}
