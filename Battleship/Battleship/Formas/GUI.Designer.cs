namespace Battleship.Formas
{
    partial class GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stratCBox = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GB_Map = new System.Windows.Forms.GroupBox();
            this.GB_Offence = new System.Windows.Forms.GroupBox();
            this.GB_Defence = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.xBox = new System.Windows.Forms.TextBox();
            this.yBox = new System.Windows.Forms.TextBox();
            this.fireButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cvYbox = new System.Windows.Forms.TextBox();
            this.cvXBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cvCB = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bbCB = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.bbYBox = new System.Windows.Forms.TextBox();
            this.bbXBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.caCB = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.caYBox = new System.Windows.Forms.TextBox();
            this.caXBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.ddCB = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.ddYBox = new System.Windows.Forms.TextBox();
            this.ddXBox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.ssCB = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.ssYBox = new System.Windows.Forms.TextBox();
            this.ssXBox = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.TurnoLabel = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shooting Strategy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(497, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your next input:";
            // 
            // stratCBox
            // 
            this.stratCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stratCBox.FormattingEnabled = true;
            this.stratCBox.Items.AddRange(new object[] {
            "Random",
            "Spiral",
            "Quadrants"});
            this.stratCBox.Location = new System.Drawing.Point(11, 24);
            this.stratCBox.Margin = new System.Windows.Forms.Padding(2);
            this.stratCBox.Name = "stratCBox";
            this.stratCBox.Size = new System.Drawing.Size(168, 21);
            this.stratCBox.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(583, 35);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(55, 20);
            this.textBox1.TabIndex = 3;
            // 
            // GB_Map
            // 
            this.GB_Map.BackColor = System.Drawing.Color.Transparent;
            this.GB_Map.Location = new System.Drawing.Point(500, 118);
            this.GB_Map.Margin = new System.Windows.Forms.Padding(2);
            this.GB_Map.Name = "GB_Map";
            this.GB_Map.Padding = new System.Windows.Forms.Padding(2);
            this.GB_Map.Size = new System.Drawing.Size(225, 244);
            this.GB_Map.TabIndex = 4;
            this.GB_Map.TabStop = false;
            this.GB_Map.Text = "HeatMap";
            // 
            // GB_Offence
            // 
            this.GB_Offence.BackColor = System.Drawing.Color.Transparent;
            this.GB_Offence.Location = new System.Drawing.Point(12, 118);
            this.GB_Offence.Margin = new System.Windows.Forms.Padding(2);
            this.GB_Offence.Name = "GB_Offence";
            this.GB_Offence.Padding = new System.Windows.Forms.Padding(2);
            this.GB_Offence.Size = new System.Drawing.Size(225, 244);
            this.GB_Offence.TabIndex = 5;
            this.GB_Offence.TabStop = false;
            this.GB_Offence.Text = "ShootMap";
            // 
            // GB_Defence
            // 
            this.GB_Defence.BackColor = System.Drawing.Color.Transparent;
            this.GB_Defence.Location = new System.Drawing.Point(12, 366);
            this.GB_Defence.Margin = new System.Windows.Forms.Padding(2);
            this.GB_Defence.Name = "GB_Defence";
            this.GB_Defence.Padding = new System.Windows.Forms.Padding(2);
            this.GB_Defence.Size = new System.Drawing.Size(225, 244);
            this.GB_Defence.TabIndex = 6;
            this.GB_Defence.TabStop = false;
            this.GB_Defence.Text = "PlaceMap";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Next shot?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 149);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Y";
            // 
            // xBox
            // 
            this.xBox.Location = new System.Drawing.Point(251, 165);
            this.xBox.Name = "xBox";
            this.xBox.Size = new System.Drawing.Size(29, 20);
            this.xBox.TabIndex = 10;
            // 
            // yBox
            // 
            this.yBox.Location = new System.Drawing.Point(286, 165);
            this.yBox.Name = "yBox";
            this.yBox.Size = new System.Drawing.Size(29, 20);
            this.yBox.TabIndex = 11;
            // 
            // fireButton
            // 
            this.fireButton.Enabled = false;
            this.fireButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fireButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fireButton.Location = new System.Drawing.Point(251, 192);
            this.fireButton.Name = "fireButton";
            this.fireButton.Size = new System.Drawing.Size(75, 23);
            this.fireButton.TabIndex = 12;
            this.fireButton.Text = "FIRE!!";
            this.fireButton.UseVisualStyleBackColor = true;
            this.fireButton.Click += new System.EventHandler(this.fireButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 382);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ships\' Locations";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(248, 395);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Carrier (5):";
            // 
            // cvYbox
            // 
            this.cvYbox.Location = new System.Drawing.Point(286, 424);
            this.cvYbox.Name = "cvYbox";
            this.cvYbox.Size = new System.Drawing.Size(29, 20);
            this.cvYbox.TabIndex = 18;
            // 
            // cvXBox
            // 
            this.cvXBox.Location = new System.Drawing.Point(251, 424);
            this.cvXBox.Name = "cvXBox";
            this.cvXBox.Size = new System.Drawing.Size(29, 20);
            this.cvXBox.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(283, 408);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Y";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(248, 408);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "X";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(318, 408);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Direction:";
            // 
            // cvCB
            // 
            this.cvCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cvCB.FormattingEnabled = true;
            this.cvCB.Items.AddRange(new object[] {
            "Horizontal",
            "Vertical"});
            this.cvCB.Location = new System.Drawing.Point(322, 425);
            this.cvCB.Name = "cvCB";
            this.cvCB.Size = new System.Drawing.Size(121, 21);
            this.cvCB.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(360, 29);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Enterprise is thinking...";
            this.label11.Visible = false;
            // 
            // bbCB
            // 
            this.bbCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bbCB.FormattingEnabled = true;
            this.bbCB.Items.AddRange(new object[] {
            "Horizontal",
            "Vertical"});
            this.bbCB.Location = new System.Drawing.Point(322, 477);
            this.bbCB.Name = "bbCB";
            this.bbCB.Size = new System.Drawing.Size(121, 21);
            this.bbCB.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(318, 460);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Direction:";
            // 
            // bbYBox
            // 
            this.bbYBox.Location = new System.Drawing.Point(286, 476);
            this.bbYBox.Name = "bbYBox";
            this.bbYBox.Size = new System.Drawing.Size(29, 20);
            this.bbYBox.TabIndex = 26;
            // 
            // bbXBox
            // 
            this.bbXBox.Location = new System.Drawing.Point(251, 476);
            this.bbXBox.Name = "bbXBox";
            this.bbXBox.Size = new System.Drawing.Size(29, 20);
            this.bbXBox.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(283, 460);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Y";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(248, 460);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "X";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(248, 447);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "Battleship (4):";
            // 
            // caCB
            // 
            this.caCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.caCB.FormattingEnabled = true;
            this.caCB.Items.AddRange(new object[] {
            "Horizontal",
            "Vertical"});
            this.caCB.Location = new System.Drawing.Point(322, 529);
            this.caCB.Name = "caCB";
            this.caCB.Size = new System.Drawing.Size(121, 21);
            this.caCB.TabIndex = 35;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(318, 512);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "Direction:";
            // 
            // caYBox
            // 
            this.caYBox.Location = new System.Drawing.Point(286, 528);
            this.caYBox.Name = "caYBox";
            this.caYBox.Size = new System.Drawing.Size(29, 20);
            this.caYBox.TabIndex = 33;
            // 
            // caXBox
            // 
            this.caXBox.Location = new System.Drawing.Point(251, 528);
            this.caXBox.Name = "caXBox";
            this.caXBox.Size = new System.Drawing.Size(29, 20);
            this.caXBox.TabIndex = 32;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(283, 512);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(14, 13);
            this.label17.TabIndex = 31;
            this.label17.Text = "Y";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(248, 512);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(14, 13);
            this.label18.TabIndex = 30;
            this.label18.Text = "X";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(248, 499);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 13);
            this.label19.TabIndex = 29;
            this.label19.Text = "Cruiser (3):";
            // 
            // ddCB
            // 
            this.ddCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddCB.FormattingEnabled = true;
            this.ddCB.Items.AddRange(new object[] {
            "Horizontal",
            "Vertical"});
            this.ddCB.Location = new System.Drawing.Point(322, 581);
            this.ddCB.Name = "ddCB";
            this.ddCB.Size = new System.Drawing.Size(121, 21);
            this.ddCB.TabIndex = 42;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(318, 564);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 13);
            this.label20.TabIndex = 41;
            this.label20.Text = "Direction:";
            // 
            // ddYBox
            // 
            this.ddYBox.Location = new System.Drawing.Point(286, 580);
            this.ddYBox.Name = "ddYBox";
            this.ddYBox.Size = new System.Drawing.Size(29, 20);
            this.ddYBox.TabIndex = 40;
            // 
            // ddXBox
            // 
            this.ddXBox.Location = new System.Drawing.Point(251, 580);
            this.ddXBox.Name = "ddXBox";
            this.ddXBox.Size = new System.Drawing.Size(29, 20);
            this.ddXBox.TabIndex = 39;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(283, 564);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(14, 13);
            this.label21.TabIndex = 38;
            this.label21.Text = "Y";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(248, 564);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(14, 13);
            this.label22.TabIndex = 37;
            this.label22.Text = "X";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(248, 551);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(70, 13);
            this.label23.TabIndex = 36;
            this.label23.Text = "Destroyer (3):";
            // 
            // ssCB
            // 
            this.ssCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ssCB.FormattingEnabled = true;
            this.ssCB.Items.AddRange(new object[] {
            "Horizontal",
            "Vertical"});
            this.ssCB.Location = new System.Drawing.Point(322, 633);
            this.ssCB.Name = "ssCB";
            this.ssCB.Size = new System.Drawing.Size(121, 21);
            this.ssCB.TabIndex = 49;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(318, 616);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(52, 13);
            this.label24.TabIndex = 48;
            this.label24.Text = "Direction:";
            // 
            // ssYBox
            // 
            this.ssYBox.Location = new System.Drawing.Point(286, 632);
            this.ssYBox.Name = "ssYBox";
            this.ssYBox.Size = new System.Drawing.Size(29, 20);
            this.ssYBox.TabIndex = 47;
            // 
            // ssXBox
            // 
            this.ssXBox.Location = new System.Drawing.Point(251, 632);
            this.ssXBox.Name = "ssXBox";
            this.ssXBox.Size = new System.Drawing.Size(29, 20);
            this.ssXBox.TabIndex = 46;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(283, 616);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(14, 13);
            this.label25.TabIndex = 45;
            this.label25.Text = "Y";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(248, 616);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(14, 13);
            this.label26.TabIndex = 44;
            this.label26.Text = "X";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(248, 603);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(75, 13);
            this.label27.TabIndex = 43;
            this.label27.Text = "Submarine (2):";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(251, 660);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 23);
            this.button1.TabIndex = 50;
            this.button1.Text = "LAUNCH BATTLESHIPS!!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(184, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 51;
            this.button2.Text = "Start!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(265, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 52;
            this.button3.Text = "Stop!";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TurnoLabel
            // 
            this.TurnoLabel.AutoSize = true;
            this.TurnoLabel.Location = new System.Drawing.Point(318, 80);
            this.TurnoLabel.Name = "TurnoLabel";
            this.TurnoLabel.Size = new System.Drawing.Size(48, 13);
            this.TurnoLabel.TabIndex = 53;
            this.TurnoLabel.Text = "Maquina";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(266, 80);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(53, 13);
            this.label28.TabIndex = 54;
            this.label28.Text = "Turno de ";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 749);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.TurnoLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ssCB);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.ssYBox);
            this.Controls.Add(this.ssXBox);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.ddCB);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.ddYBox);
            this.Controls.Add(this.ddXBox);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.caCB);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.caYBox);
            this.Controls.Add(this.caXBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.bbCB);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.bbYBox);
            this.Controls.Add(this.bbXBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cvCB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cvYbox);
            this.Controls.Add(this.cvXBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fireButton);
            this.Controls.Add(this.yBox);
            this.Controls.Add(this.xBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GB_Defence);
            this.Controls.Add(this.GB_Offence);
            this.Controls.Add(this.GB_Map);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.stratCBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GUI";
            this.Text = "GUI";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox stratCBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox GB_Map;
        private System.Windows.Forms.GroupBox GB_Offence;
        private System.Windows.Forms.GroupBox GB_Defence;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox xBox;
        private System.Windows.Forms.TextBox yBox;
        private System.Windows.Forms.Button fireButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cvYbox;
        private System.Windows.Forms.TextBox cvXBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cvCB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox bbCB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox bbYBox;
        private System.Windows.Forms.TextBox bbXBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox caYBox;
        private System.Windows.Forms.TextBox caXBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox ddCB;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox ddYBox;
        private System.Windows.Forms.TextBox ddXBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox ssCB;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox ssYBox;
        private System.Windows.Forms.TextBox ssXBox;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox caCB;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label TurnoLabel;
        private System.Windows.Forms.Label label28;
    }
}