﻿namespace vts_odu
{
    partial class ShipAddForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.shipmmsi = new System.Windows.Forms.TextBox();
            this.shiptype = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.shipname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.shipcourse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.shipheading = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.shiptypename = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.psl = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.maxspeed = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.shiplength = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.shipwidth = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.scs = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.wcs = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.shipPictureBox = new System.Windows.Forms.PictureBox();
            this.label21 = new System.Windows.Forms.Label();
            this.openFileDialog_ship = new System.Windows.Forms.OpenFileDialog();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.kzsgd = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.m_leftEngineSpeed = new System.Windows.Forms.TrackBar();
            this.m_rightEngineSpeed = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.shipmodel = new System.Windows.Forms.ComboBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shipPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_leftEngineSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_rightEngineSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(44, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "船舶MMSI:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(456, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "确  定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(653, 411);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "取  消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // shipmmsi
            // 
            this.shipmmsi.Enabled = false;
            this.shipmmsi.Location = new System.Drawing.Point(121, 29);
            this.shipmmsi.Name = "shipmmsi";
            this.shipmmsi.Size = new System.Drawing.Size(139, 21);
            this.shipmmsi.TabIndex = 3;
            // 
            // shiptype
            // 
            this.shiptype.FormattingEnabled = true;
            this.shiptype.Location = new System.Drawing.Point(548, 29);
            this.shiptype.Name = "shiptype";
            this.shiptype.Size = new System.Drawing.Size(139, 20);
            this.shiptype.TabIndex = 4;
            this.shiptype.SelectionChangeCommitted += new System.EventHandler(this.shiptype_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(461, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "船舶类型：";
            // 
            // shipname
            // 
            this.shipname.Location = new System.Drawing.Point(121, 70);
            this.shipname.Name = "shipname";
            this.shipname.Size = new System.Drawing.Size(139, 21);
            this.shipname.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(44, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "船舶名称:";
            // 
            // shipcourse
            // 
            this.shipcourse.Location = new System.Drawing.Point(121, 115);
            this.shipcourse.Name = "shipcourse";
            this.shipcourse.Size = new System.Drawing.Size(139, 21);
            this.shipcourse.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(44, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "航向:";
            // 
            // shipheading
            // 
            this.shipheading.Location = new System.Drawing.Point(121, 161);
            this.shipheading.Name = "shipheading";
            this.shipheading.Size = new System.Drawing.Size(139, 21);
            this.shipheading.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(44, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "船首向:";
            // 
            // shiptypename
            // 
            this.shiptypename.Enabled = false;
            this.shiptypename.Location = new System.Drawing.Point(548, 70);
            this.shiptypename.Name = "shiptypename";
            this.shiptypename.Size = new System.Drawing.Size(139, 21);
            this.shiptypename.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(461, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 14);
            this.label9.TabIndex = 15;
            this.label9.Text = "类型名称:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(693, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 14);
            this.label10.TabIndex = 20;
            this.label10.Text = "吨(t)";
            // 
            // psl
            // 
            this.psl.Enabled = false;
            this.psl.Location = new System.Drawing.Point(548, 115);
            this.psl.Name = "psl";
            this.psl.Size = new System.Drawing.Size(139, 21);
            this.psl.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(461, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 14);
            this.label11.TabIndex = 18;
            this.label11.Text = "排水量:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(693, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 14);
            this.label12.TabIndex = 23;
            this.label12.Text = "knot";
            // 
            // maxspeed
            // 
            this.maxspeed.Enabled = false;
            this.maxspeed.Location = new System.Drawing.Point(548, 161);
            this.maxspeed.Name = "maxspeed";
            this.maxspeed.Size = new System.Drawing.Size(139, 21);
            this.maxspeed.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(461, 164);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 14);
            this.label13.TabIndex = 21;
            this.label13.Text = "最大航速:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(693, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 14);
            this.label8.TabIndex = 26;
            this.label8.Text = "米(m)";
            // 
            // shiplength
            // 
            this.shiplength.Enabled = false;
            this.shiplength.Location = new System.Drawing.Point(548, 200);
            this.shiplength.Name = "shiplength";
            this.shiplength.Size = new System.Drawing.Size(139, 21);
            this.shiplength.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(461, 203);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 14);
            this.label14.TabIndex = 24;
            this.label14.Text = "船长:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(693, 239);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 14);
            this.label15.TabIndex = 29;
            this.label15.Text = "米(m)";
            // 
            // shipwidth
            // 
            this.shipwidth.Enabled = false;
            this.shipwidth.Location = new System.Drawing.Point(548, 236);
            this.shipwidth.Name = "shipwidth";
            this.shipwidth.Size = new System.Drawing.Size(139, 21);
            this.shipwidth.TabIndex = 28;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(461, 239);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 14);
            this.label16.TabIndex = 27;
            this.label16.Text = "船宽:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(693, 279);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 14);
            this.label17.TabIndex = 32;
            this.label17.Text = "米(m)";
            // 
            // scs
            // 
            this.scs.Enabled = false;
            this.scs.Location = new System.Drawing.Point(548, 276);
            this.scs.Name = "scs";
            this.scs.Size = new System.Drawing.Size(139, 21);
            this.scs.TabIndex = 31;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(461, 279);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 14);
            this.label18.TabIndex = 30;
            this.label18.Text = "船首吃水:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(693, 320);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 14);
            this.label19.TabIndex = 35;
            this.label19.Text = "米(m)";
            // 
            // wcs
            // 
            this.wcs.Enabled = false;
            this.wcs.Location = new System.Drawing.Point(548, 317);
            this.wcs.Name = "wcs";
            this.wcs.Size = new System.Drawing.Size(139, 21);
            this.wcs.TabIndex = 34;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(461, 320);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(70, 14);
            this.label20.TabIndex = 33;
            this.label20.Text = "船尾吃水:";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(121, 425);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 30);
            this.button3.TabIndex = 36;
            this.button3.Text = "选择船舶图片";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // shipPictureBox
            // 
            this.shipPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.shipPictureBox.BackgroundImage = global::vts_odu.Properties.Resources.ship;
            this.shipPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.shipPictureBox.Location = new System.Drawing.Point(121, 358);
            this.shipPictureBox.Name = "shipPictureBox";
            this.shipPictureBox.Size = new System.Drawing.Size(121, 61);
            this.shipPictureBox.TabIndex = 37;
            this.shipPictureBox.TabStop = false;
            this.shipPictureBox.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label21.Location = new System.Drawing.Point(30, 384);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(70, 14);
            this.label21.TabIndex = 38;
            this.label21.Text = "船舶实图:";
            this.label21.Visible = false;
            // 
            // openFileDialog_ship
            // 
            this.openFileDialog_ship.FileName = "openFileDialog1";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label22.ForeColor = System.Drawing.Color.Red;
            this.label22.Location = new System.Drawing.Point(278, 30);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(152, 16);
            this.label22.TabIndex = 39;
            this.label22.Text = "船舶MMSI只能为数字";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label23.Location = new System.Drawing.Point(693, 361);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(42, 14);
            this.label23.TabIndex = 42;
            this.label23.Text = "米(m)";
            // 
            // kzsgd
            // 
            this.kzsgd.Enabled = false;
            this.kzsgd.Location = new System.Drawing.Point(548, 358);
            this.kzsgd.Name = "kzsgd";
            this.kzsgd.Size = new System.Drawing.Size(139, 21);
            this.kzsgd.TabIndex = 41;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label24.Location = new System.Drawing.Point(461, 361);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(84, 14);
            this.label24.TabIndex = 40;
            this.label24.Text = "控制室高度:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label25.Location = new System.Drawing.Point(16, 211);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(84, 14);
            this.label25.TabIndex = 43;
            this.label25.Text = "左车钟档位:";
            // 
            // m_leftEngineSpeed
            // 
            this.m_leftEngineSpeed.Location = new System.Drawing.Point(121, 209);
            this.m_leftEngineSpeed.Maximum = 5;
            this.m_leftEngineSpeed.Name = "m_leftEngineSpeed";
            this.m_leftEngineSpeed.Size = new System.Drawing.Size(139, 45);
            this.m_leftEngineSpeed.TabIndex = 44;
            this.m_leftEngineSpeed.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // m_rightEngineSpeed
            // 
            this.m_rightEngineSpeed.Location = new System.Drawing.Point(121, 260);
            this.m_rightEngineSpeed.Maximum = 5;
            this.m_rightEngineSpeed.Name = "m_rightEngineSpeed";
            this.m_rightEngineSpeed.Size = new System.Drawing.Size(139, 45);
            this.m_rightEngineSpeed.TabIndex = 46;
            this.m_rightEngineSpeed.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(16, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 14);
            this.label6.TabIndex = 45;
            this.label6.Text = "右车钟档位:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(127, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 16);
            this.label7.TabIndex = 47;
            this.label7.Text = "0";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label26.ForeColor = System.Drawing.Color.Red;
            this.label26.Location = new System.Drawing.Point(150, 191);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(16, 16);
            this.label26.TabIndex = 48;
            this.label26.Text = "1";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label27.ForeColor = System.Drawing.Color.Red;
            this.label27.Location = new System.Drawing.Point(173, 191);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(16, 16);
            this.label27.TabIndex = 49;
            this.label27.Text = "2";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label28.ForeColor = System.Drawing.Color.Red;
            this.label28.Location = new System.Drawing.Point(195, 191);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(16, 16);
            this.label28.TabIndex = 50;
            this.label28.Text = "3";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label29.ForeColor = System.Drawing.Color.Red;
            this.label29.Location = new System.Drawing.Point(217, 191);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(16, 16);
            this.label29.TabIndex = 51;
            this.label29.Text = "4";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label30.ForeColor = System.Drawing.Color.Red;
            this.label30.Location = new System.Drawing.Point(239, 191);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(16, 16);
            this.label30.TabIndex = 52;
            this.label30.Text = "5";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label31.ForeColor = System.Drawing.Color.Red;
            this.label31.Location = new System.Drawing.Point(239, 243);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(16, 16);
            this.label31.TabIndex = 58;
            this.label31.Text = "5";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label32.ForeColor = System.Drawing.Color.Red;
            this.label32.Location = new System.Drawing.Point(217, 243);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(16, 16);
            this.label32.TabIndex = 57;
            this.label32.Text = "4";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label33.ForeColor = System.Drawing.Color.Red;
            this.label33.Location = new System.Drawing.Point(195, 243);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(16, 16);
            this.label33.TabIndex = 56;
            this.label33.Text = "3";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label34.ForeColor = System.Drawing.Color.Red;
            this.label34.Location = new System.Drawing.Point(173, 243);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(16, 16);
            this.label34.TabIndex = 55;
            this.label34.Text = "2";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label35.ForeColor = System.Drawing.Color.Red;
            this.label35.Location = new System.Drawing.Point(150, 243);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(16, 16);
            this.label35.TabIndex = 54;
            this.label35.Text = "1";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label36.ForeColor = System.Drawing.Color.Red;
            this.label36.Location = new System.Drawing.Point(127, 243);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(16, 16);
            this.label36.TabIndex = 53;
            this.label36.Text = "0";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label37.ForeColor = System.Drawing.Color.Red;
            this.label37.Location = new System.Drawing.Point(278, 220);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(120, 16);
            this.label37.TabIndex = 59;
            this.label37.Text = "左车钟暂未启用";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label38.Location = new System.Drawing.Point(30, 315);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(70, 14);
            this.label38.TabIndex = 61;
            this.label38.Text = "船舶模型:";
            // 
            // shipmodel
            // 
            this.shipmodel.FormattingEnabled = true;
            this.shipmodel.Location = new System.Drawing.Point(121, 314);
            this.shipmodel.Name = "shipmodel";
            this.shipmodel.Size = new System.Drawing.Size(139, 20);
            this.shipmodel.TabIndex = 60;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label39.ForeColor = System.Drawing.Color.Red;
            this.label39.Location = new System.Drawing.Point(278, 114);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(96, 16);
            this.label39.TabIndex = 62;
            this.label39.Text = "(0度-360度)";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label40.ForeColor = System.Drawing.Color.Red;
            this.label40.Location = new System.Drawing.Point(278, 162);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(96, 16);
            this.label40.TabIndex = 63;
            this.label40.Text = "(0度-360度)";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label41.ForeColor = System.Drawing.Color.Red;
            this.label41.Location = new System.Drawing.Point(278, 315);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(104, 16);
            this.label41.TabIndex = 64;
            this.label41.Text = "船舶运动模型";
            // 
            // ShipAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 467);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.shipmodel);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.m_rightEngineSpeed);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.m_leftEngineSpeed);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.kzsgd);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.shipPictureBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.wcs);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.scs);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.shipwidth);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.shiplength);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.maxspeed);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.psl);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.shiptypename);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.shipheading);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.shipcourse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.shipname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.shiptype);
            this.Controls.Add(this.shipmmsi);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "ShipAddForm";
            this.Text = "添加船舶";
            this.Load += new System.EventHandler(this.ShipAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shipPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_leftEngineSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_rightEngineSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox shipPictureBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.OpenFileDialog openFileDialog_ship;
        public System.Windows.Forms.TextBox shipmmsi;
        public System.Windows.Forms.ComboBox shiptype;
        public System.Windows.Forms.TextBox shipname;
        public System.Windows.Forms.TextBox shipcourse;
        public System.Windows.Forms.TextBox shipheading;
        public System.Windows.Forms.TextBox shiptypename;
        public System.Windows.Forms.TextBox psl;
        public System.Windows.Forms.TextBox maxspeed;
        public System.Windows.Forms.TextBox shiplength;
        public System.Windows.Forms.TextBox shipwidth;
        public System.Windows.Forms.TextBox scs;
        public System.Windows.Forms.TextBox wcs;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        public System.Windows.Forms.TextBox kzsgd;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TrackBar m_leftEngineSpeed;
        public System.Windows.Forms.TrackBar m_rightEngineSpeed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        public System.Windows.Forms.ComboBox shipmodel;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
    }
}