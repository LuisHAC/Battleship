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
        Classes.ShootingStrategies strategy = new Classes.ShootingStrategies();
        Classes.Ship Carrier = new Classes.Ship();
        Classes.Ship Battleship = new Classes.Ship();
        Classes.Ship Cruiser = new Classes.Ship();
        Classes.Ship Destroyer = new Classes.Ship();
        Classes.Ship Submarine = new Classes.Ship();

        public bool ShipsLaunched = false;
        public int atinados = 0;

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
            int x = 16, y = 145, x1 = 20, y1 = 410;
            Rectangle square = new Rectangle(x, y, 20, 20);
            Color color = new Color();
            decimal value = new decimal();
            decimal min = MinValue();
            decimal max = MaxValue();

            if (ShipsLaunched)
            {
                int xCarrier = (Carrier.X * 20) + 20;
                int yCarrier = (Carrier.Y * 20) + 410;
                for (int i = 0; i < Carrier.Size; i++)
                {
                    if (Carrier.Direction)
                    {
                        square = new Rectangle(xCarrier, yCarrier, 20, 20);
                        e.Graphics.FillRectangle(new SolidBrush(Color.Blue), square);
                        xCarrier += 20;
                    }
                    else
                    {
                        square = new Rectangle(xCarrier, yCarrier, 20, 20);
                        e.Graphics.FillRectangle(new SolidBrush(Color.Blue), square);
                        yCarrier += 20;
                    }
                }
                xCarrier = Battleship.X * 20 + 20;
                yCarrier = Battleship.Y * 20 + 410;
                for (int i = 0; i < Battleship.Size; i++)
                {
                    if (Carrier.Direction)
                    {
                        square = new Rectangle(xCarrier, yCarrier, 20, 20);
                        e.Graphics.FillRectangle(new SolidBrush(Color.Blue), square);
                        xCarrier += 20;
                    }
                    else
                    {
                        square = new Rectangle(xCarrier, yCarrier, 20, 20);
                        e.Graphics.FillRectangle(new SolidBrush(Color.Blue), square);
                        yCarrier += 20;
                    }
                }

                xCarrier = Cruiser.X * 20 + 20;
                yCarrier = Cruiser.Y * 20 + 410;
                for (int i = 0; i < Cruiser.Size; i++)
                {
                    if (Cruiser.Direction)
                    {
                        square = new Rectangle(xCarrier, yCarrier, 20, 20);
                        e.Graphics.FillRectangle(new SolidBrush(Color.Blue), square);
                        xCarrier += 20;
                    }
                    else
                    {
                        square = new Rectangle(xCarrier, yCarrier, 20, 20);
                        e.Graphics.FillRectangle(new SolidBrush(Color.Blue), square);
                        yCarrier += 20;
                    }
                }

                xCarrier = Destroyer.X * 20 + 20;
                yCarrier = Destroyer.Y * 20 + 410;
                for (int i = 0; i < Destroyer.Size; i++)
                {
                    if (Destroyer.Direction)
                    {
                        square = new Rectangle(xCarrier, yCarrier, 20, 20);
                        e.Graphics.FillRectangle(new SolidBrush(Color.Blue), square);
                        xCarrier += 20;
                    }
                    else
                    {
                        square = new Rectangle(xCarrier, yCarrier, 20, 20);
                        e.Graphics.FillRectangle(new SolidBrush(Color.Blue), square);
                        yCarrier += 20;
                    }
                }

                xCarrier = Submarine.X * 20 + 20;
                yCarrier = Submarine.Y * 20 + 410;
                for (int i = 0; i < Submarine.Size; i++)
                {
                    if (Submarine.Direction)
                    {
                        square = new Rectangle(xCarrier, yCarrier, 20, 20);
                        e.Graphics.FillRectangle(new SolidBrush(Color.Blue), square);
                        xCarrier += 20;
                    }
                    else
                    {
                        square = new Rectangle(xCarrier, yCarrier, 20, 20);
                        e.Graphics.FillRectangle(new SolidBrush(Color.Blue), square);
                        yCarrier += 20;
                    }
                }

            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {

                    square = new Rectangle(x1, y1, 20, 20);
                    e.Graphics.DrawRectangle(new Pen(Color.Black), square);
                    square = new Rectangle(x, y, 20, 20);
                    e.Graphics.FillRectangle(new SolidBrush(Color.Black), square);
                    e.Graphics.DrawRectangle(new Pen(color), square);
                    value = Classes.Globals.Map.Value(i, j);
                    color = HeatMapColor(value, min, max);
                    square = new Rectangle(x, y, 20, 20);
                    e.Graphics.FillRectangle(new SolidBrush(color), square);
                    e.Graphics.DrawRectangle(new Pen(color), square);
                    x += 20;
                    x1 += 20;
                }
                y1 += 20;
                y += 20;
                x = 16;
                x1 = 20;
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
            //provando Carrier
            for (int aux = 0; aux < Carrier.Size; aux++)
            {
                if (Carrier.Direction)
                {
                    if (x == (Carrier.X + aux) && Carrier.Y == y)
                        return true;
                }
                else
                {
                    if (y == (Carrier.Y + aux) && x == Carrier.X)
                        return true;
                }
            }
            //provando Battleship
            for (int aux = 0; aux < Battleship.Size; aux++)
            {
                if (Battleship.Direction)
                {
                    if (x == (Battleship.X + aux) && Battleship.Y == y)
                        return true;
                }
                else
                {
                    if (y == (Battleship.Y + aux) && x == Battleship.X)
                        return true;
                }
            }
            //provando Cruiser
            for (int aux = 0; aux < Cruiser.Size; aux++)
            {
                if (Cruiser.Direction)
                {
                    if (x == (Cruiser.X + aux) && Cruiser.Y == y)
                        return true;
                }
                else
                {
                    if (y == (Cruiser.Y + aux) && x == Cruiser.X)
                        return true;
                }
            }
            //provando Destroyer
            for (int aux = 0; aux < Destroyer.Size; aux++)
            {
                if (Destroyer.Direction)
                {
                    if (x == (Destroyer.X + aux) && Destroyer.Y == y)
                        return true;
                }
                else
                {
                    if (y == (Destroyer.Y + aux) && x == Destroyer.X)
                        return true;
                }
            }
            //provando Submarine
            for (int aux = 0; aux < Submarine.Size; aux++)
            {
                if (Submarine.Direction)
                {
                    if (x == (Submarine.X + aux) && Submarine.Y == y)
                        return true;
                }
                else
                {
                    if (y == (Submarine.Y + aux) && x == Submarine.X)
                        return true;
                }
            }
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (stratCBox.Text != "")
            {
                button1.Enabled = true;
                stratCBox.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = true;
            }
            else
                MessageBox.Show("Falta seleccionar el tipo de estrategia");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (caCB.Text != "" && caXBox.Text != "" && caYBox.Text != "" && cvCB.Text != "" && cvXBox.Text != "" && cvYbox.Text != "" && ddCB.Text != "" && ddXBox.Text != "" && ddYBox.Text != "" && bbCB.Text != "" && bbXBox.Text != "" && bbYBox.Text != "" && ssCB.Text != "" && ssXBox.Text != "" && ssYBox.Text != "")
            {
                //Carrier
                {
                    Carrier.Size = 5;
                    Carrier.X = Convert.ToInt32(cvXBox.Text);
                    Carrier.Y = Convert.ToInt32(cvYbox.Text);
                    Carrier.Direction = cvCB.Text == "Horizontal" ? true : false;
                    Carrier.validation();
                }
                //Battleship
                {
                    Battleship.Size = 4;
                    Battleship.X = Convert.ToInt32(bbXBox.Text);
                    Battleship.Y = Convert.ToInt32(bbYBox.Text);
                    Battleship.Direction = bbCB.Text == "Horizontal" ? true : false;
                    Battleship.validation();
                }
                //Cruiser
                {
                    Cruiser.Size = 3;
                    Cruiser.X = Convert.ToInt32(caXBox.Text);
                    Cruiser.Y = Convert.ToInt32(caYBox.Text);
                    Cruiser.Direction = caCB.Text == "Horizontal" ? true : false;
                    Cruiser.validation();
                }
                //Destroyer
                {
                    Destroyer.Size = 3;
                    Destroyer.X = Convert.ToInt32(ddXBox.Text);
                    Destroyer.Y = Convert.ToInt32(ddYBox.Text);
                    Destroyer.Direction = ddCB.Text == "Horizontal" ? true : false;
                    Destroyer.validation();
                }
                //Submarine
                {
                    Submarine.Size = 2;
                    Submarine.X = Convert.ToInt32(ssXBox.Text);
                    Submarine.Y = Convert.ToInt32(ssYBox.Text);
                    Submarine.Direction = ssCB.Text == "Horizontal" ? true : false;
                    Submarine.validation();
                }

                fireButton.Enabled = true;
                button1.Enabled = false;
                NextInput();
                ShipsLaunched = true;
                this.Refresh();
            }
            else
                MessageBox.Show("Falta información");
        }

        private void fireButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("acerto el tiro?", "ATENCION", MessageBoxButtons.YesNo);  
                if(dialogResult == DialogResult.Yes)
                {
                    Classes.Globals.Offense.setValue(Convert.ToInt32(xBox.Text), Convert.ToInt32(yBox.Text), 2);
                    dialogResult = DialogResult.No;
                    Classes.Point punto = new Classes.Point();
                    Classes.Point acertado = new Classes.Point(Convert.ToInt32(xBox.Text), Convert.ToInt32(yBox.Text));
                    int x = 1;
                    char c;
                    Classes.Point regreso = new Classes.Point(Convert.ToInt32(xBox.Text), Convert.ToInt32(yBox.Text));
                    while (dialogResult != DialogResult.Yes)
                    {
                        if (x == 1)
                            c = 'R';
                        else if (x == 2)
                            c = 'L';
                        else if (x == 3)
                            c = 'U';
                        else
                            c = 'D';
                        punto = strategy.Hunt(acertado, c);
                        textBox1.Text = punto.X.ToString() + "," + punto.Y.ToString();
                        DialogResult d = MessageBox.Show("acerte?");
                        if (d == DialogResult.Yes)
                            acertado = punto;
                        else if (x == 4)
                        {
                            x = 1;
                            acertado = regreso;
                        }
                        else
                            x++;
                        dialogResult = MessageBox.Show("lo derribe?", "ATENCION", MessageBoxButtons.YesNo);
                    }
                }
                else
                {
                    Classes.Globals.Offense.setValue(Convert.ToInt32(xBox), Convert.ToInt32(yBox), 1);
                }
                NextInput();

            }
            catch
            {
                if (xBox.Text == "" && yBox.Text == "")
                    MessageBox.Show("Falta información");
                else
                    MessageBox.Show("Escribir solo números");
            }
        }

        private void NextInput()
        {
            Classes.Point punto = new Classes.Point();
            switch (stratCBox.SelectedIndex)
            {
                case 0:
                    punto = strategy.Random();
                    break;

                case 1:
                    punto = strategy.Spiral();
                    break;

                case 2:
                    punto = strategy.Quadrantes(Classes.Globals.Offense, 10, 0, 0);
                    break;

            }

            textBox1.Text = punto.X.ToString() + "," + punto.Y.ToString();           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            stratCBox.Enabled = true;
            button3.Enabled = false;
            fireButton.Enabled = false;
            button1.Enabled = false;
        }
    }
}
