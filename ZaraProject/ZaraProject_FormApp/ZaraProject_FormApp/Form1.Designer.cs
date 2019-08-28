namespace ZaraProject_FormApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnConn = new System.Windows.Forms.Button();
            this.btnDisc = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBoxFan = new System.Windows.Forms.PictureBox();
            this.pictureBoxLamp = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFanON = new System.Windows.Forms.Button();
            this.btnFanOFF = new System.Windows.Forms.Button();
            this.btnLampON = new System.Windows.Forms.Button();
            this.btnLampOFF = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextSensorValue = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.relay_1_panel = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.relay_2_panel = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.relay_3_panel = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.relay_4_panel = new System.Windows.Forms.Panel();
            this.pictureBoxBlinds = new System.Windows.Forms.PictureBox();
            this.timerFan = new System.Windows.Forms.Timer(this.components);
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnSConOFF = new System.Windows.Forms.Button();
            this.btnSConON = new System.Windows.Forms.Button();
            this.trackBarBlinds = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.richTextVoiceCommands = new System.Windows.Forms.RichTextBox();
            this.timerSensor = new System.Windows.Forms.Timer(this.components);
            this.zara = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLamp)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlinds)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlinds)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(219, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // btnConn
            // 
            this.btnConn.Location = new System.Drawing.Point(12, 39);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(109, 23);
            this.btnConn.TabIndex = 1;
            this.btnConn.Text = "Connect";
            this.btnConn.UseVisualStyleBackColor = true;
            this.btnConn.Click += new System.EventHandler(this.btnConn_Click);
            // 
            // btnDisc
            // 
            this.btnDisc.Location = new System.Drawing.Point(122, 39);
            this.btnDisc.Name = "btnDisc";
            this.btnDisc.Size = new System.Drawing.Size(109, 23);
            this.btnDisc.TabIndex = 2;
            this.btnDisc.Text = "Disconnect";
            this.btnDisc.UseVisualStyleBackColor = true;
            this.btnDisc.Click += new System.EventHandler(this.btnDisc_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(377, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(112, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Speech Rec: OFF";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBoxFan
            // 
            this.pictureBoxFan.BackColor = System.Drawing.Color.White;
            this.pictureBoxFan.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFan.Image")));
            this.pictureBoxFan.Location = new System.Drawing.Point(12, 190);
            this.pictureBoxFan.Name = "pictureBoxFan";
            this.pictureBoxFan.Size = new System.Drawing.Size(129, 129);
            this.pictureBoxFan.TabIndex = 8;
            this.pictureBoxFan.TabStop = false;
            // 
            // pictureBoxLamp
            // 
            this.pictureBoxLamp.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLamp.Image")));
            this.pictureBoxLamp.Location = new System.Drawing.Point(12, 338);
            this.pictureBoxLamp.Name = "pictureBoxLamp";
            this.pictureBoxLamp.Size = new System.Drawing.Size(129, 141);
            this.pictureBoxLamp.TabIndex = 9;
            this.pictureBoxLamp.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(358, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(13, 13);
            this.panel1.TabIndex = 10;
            // 
            // btnFanON
            // 
            this.btnFanON.Location = new System.Drawing.Point(156, 190);
            this.btnFanON.Name = "btnFanON";
            this.btnFanON.Size = new System.Drawing.Size(75, 64);
            this.btnFanON.TabIndex = 11;
            this.btnFanON.Text = "ON";
            this.btnFanON.UseVisualStyleBackColor = true;
            this.btnFanON.Click += new System.EventHandler(this.btnFanON_Click);
            // 
            // btnFanOFF
            // 
            this.btnFanOFF.Location = new System.Drawing.Point(156, 255);
            this.btnFanOFF.Name = "btnFanOFF";
            this.btnFanOFF.Size = new System.Drawing.Size(75, 64);
            this.btnFanOFF.TabIndex = 12;
            this.btnFanOFF.Text = "OFF";
            this.btnFanOFF.UseVisualStyleBackColor = true;
            this.btnFanOFF.Click += new System.EventHandler(this.btnFanOFF_Click);
            // 
            // btnLampON
            // 
            this.btnLampON.Location = new System.Drawing.Point(156, 338);
            this.btnLampON.Name = "btnLampON";
            this.btnLampON.Size = new System.Drawing.Size(75, 70);
            this.btnLampON.TabIndex = 13;
            this.btnLampON.Text = "ON";
            this.btnLampON.UseVisualStyleBackColor = true;
            this.btnLampON.Click += new System.EventHandler(this.btnLampON_Click);
            // 
            // btnLampOFF
            // 
            this.btnLampOFF.Location = new System.Drawing.Point(156, 409);
            this.btnLampOFF.Name = "btnLampOFF";
            this.btnLampOFF.Size = new System.Drawing.Size(75, 70);
            this.btnLampOFF.TabIndex = 14;
            this.btnLampOFF.Text = "OFF";
            this.btnLampOFF.UseVisualStyleBackColor = true;
            this.btnLampOFF.Click += new System.EventHandler(this.btnLampOFF_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextSensorValue);
            this.groupBox1.Location = new System.Drawing.Point(277, 338);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 289);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sensor Values:";
            // 
            // richTextSensorValue
            // 
            this.richTextSensorValue.Location = new System.Drawing.Point(6, 19);
            this.richTextSensorValue.Name = "richTextSensorValue";
            this.richTextSensorValue.Size = new System.Drawing.Size(200, 264);
            this.richTextSensorValue.TabIndex = 0;
            this.richTextSensorValue.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.relay_1_panel);
            this.groupBox2.Location = new System.Drawing.Point(12, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(70, 70);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Relay-1:";
            // 
            // relay_1_panel
            // 
            this.relay_1_panel.BackColor = System.Drawing.Color.Red;
            this.relay_1_panel.Location = new System.Drawing.Point(6, 14);
            this.relay_1_panel.Name = "relay_1_panel";
            this.relay_1_panel.Size = new System.Drawing.Size(58, 50);
            this.relay_1_panel.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.relay_2_panel);
            this.groupBox3.Location = new System.Drawing.Point(88, 89);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(70, 70);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Relay-2:";
            // 
            // relay_2_panel
            // 
            this.relay_2_panel.BackColor = System.Drawing.Color.Red;
            this.relay_2_panel.Location = new System.Drawing.Point(6, 14);
            this.relay_2_panel.Name = "relay_2_panel";
            this.relay_2_panel.Size = new System.Drawing.Size(58, 50);
            this.relay_2_panel.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.relay_3_panel);
            this.groupBox4.Location = new System.Drawing.Point(164, 89);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(70, 70);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Relay-3:";
            // 
            // relay_3_panel
            // 
            this.relay_3_panel.BackColor = System.Drawing.Color.Red;
            this.relay_3_panel.Location = new System.Drawing.Point(6, 14);
            this.relay_3_panel.Name = "relay_3_panel";
            this.relay_3_panel.Size = new System.Drawing.Size(58, 50);
            this.relay_3_panel.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.relay_4_panel);
            this.groupBox5.Location = new System.Drawing.Point(240, 89);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(70, 70);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Relay-4:";
            // 
            // relay_4_panel
            // 
            this.relay_4_panel.BackColor = System.Drawing.Color.Red;
            this.relay_4_panel.Location = new System.Drawing.Point(6, 14);
            this.relay_4_panel.Name = "relay_4_panel";
            this.relay_4_panel.Size = new System.Drawing.Size(58, 50);
            this.relay_4_panel.TabIndex = 0;
            // 
            // pictureBoxBlinds
            // 
            this.pictureBoxBlinds.BackColor = System.Drawing.Color.White;
            this.pictureBoxBlinds.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBlinds.Image")));
            this.pictureBoxBlinds.Location = new System.Drawing.Point(12, 498);
            this.pictureBoxBlinds.Name = "pictureBoxBlinds";
            this.pictureBoxBlinds.Size = new System.Drawing.Size(129, 129);
            this.pictureBoxBlinds.TabIndex = 20;
            this.pictureBoxBlinds.TabStop = false;
            // 
            // timerFan
            // 
            this.timerFan.Interval = 300;
            this.timerFan.Tick += new System.EventHandler(this.timerFan_Tick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnSConOFF);
            this.groupBox6.Controls.Add(this.btnSConON);
            this.groupBox6.Location = new System.Drawing.Point(358, 89);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(131, 70);
            this.groupBox6.TabIndex = 23;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Sensor Control:";
            // 
            // btnSConOFF
            // 
            this.btnSConOFF.Location = new System.Drawing.Point(67, 19);
            this.btnSConOFF.Name = "btnSConOFF";
            this.btnSConOFF.Size = new System.Drawing.Size(55, 40);
            this.btnSConOFF.TabIndex = 25;
            this.btnSConOFF.Text = "OFF";
            this.btnSConOFF.UseVisualStyleBackColor = true;
            this.btnSConOFF.Click += new System.EventHandler(this.btnSConOFF_Click);
            // 
            // btnSConON
            // 
            this.btnSConON.Location = new System.Drawing.Point(6, 19);
            this.btnSConON.Name = "btnSConON";
            this.btnSConON.Size = new System.Drawing.Size(55, 40);
            this.btnSConON.TabIndex = 24;
            this.btnSConON.Text = "ON";
            this.btnSConON.UseVisualStyleBackColor = true;
            this.btnSConON.Click += new System.EventHandler(this.btnSConON_Click);
            // 
            // trackBarBlinds
            // 
            this.trackBarBlinds.LargeChange = 60;
            this.trackBarBlinds.Location = new System.Drawing.Point(183, 498);
            this.trackBarBlinds.Maximum = 180;
            this.trackBarBlinds.Name = "trackBarBlinds";
            this.trackBarBlinds.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarBlinds.Size = new System.Drawing.Size(45, 129);
            this.trackBarBlinds.SmallChange = 60;
            this.trackBarBlinds.TabIndex = 24;
            this.trackBarBlinds.TickFrequency = 60;
            this.trackBarBlinds.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarBlinds.Scroll += new System.EventHandler(this.trackBarBlinds_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 608);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 573);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "60";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 539);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "120";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 505);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "180";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 505);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "180";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 539);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "120";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(158, 573);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "60";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(164, 608);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "0";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.richTextVoiceCommands);
            this.groupBox7.Location = new System.Drawing.Point(277, 190);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(212, 142);
            this.groupBox7.TabIndex = 16;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Commands:";
            // 
            // richTextVoiceCommands
            // 
            this.richTextVoiceCommands.Location = new System.Drawing.Point(6, 19);
            this.richTextVoiceCommands.Name = "richTextVoiceCommands";
            this.richTextVoiceCommands.Size = new System.Drawing.Size(200, 117);
            this.richTextVoiceCommands.TabIndex = 0;
            this.richTextVoiceCommands.Text = "";
            // 
            // timerSensor
            // 
            this.timerSensor.Interval = 999;
            this.timerSensor.Tick += new System.EventHandler(this.timerSensor_Tick);
            // 
            // zara
            // 
            this.zara.Enabled = true;
            this.zara.Interval = 10;
            this.zara.Tick += new System.EventHandler(this.zara_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 639);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarBlinds);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.pictureBoxBlinds);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLampOFF);
            this.Controls.Add(this.btnLampON);
            this.Controls.Add(this.btnFanOFF);
            this.Controls.Add(this.btnFanON);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxLamp);
            this.Controls.Add(this.pictureBoxFan);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnDisc);
            this.Controls.Add(this.btnConn);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Home Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Leave += new System.EventHandler(this.Form1_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLamp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlinds)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlinds)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnConn;
        private System.Windows.Forms.Button btnDisc;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBoxFan;
        private System.Windows.Forms.PictureBox pictureBoxLamp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFanON;
        private System.Windows.Forms.Button btnFanOFF;
        private System.Windows.Forms.Button btnLampON;
        private System.Windows.Forms.Button btnLampOFF;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel relay_1_panel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel relay_2_panel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel relay_3_panel;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Panel relay_4_panel;
        private System.Windows.Forms.PictureBox pictureBoxBlinds;
        private System.Windows.Forms.Timer timerFan;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnSConOFF;
        private System.Windows.Forms.Button btnSConON;
        private System.Windows.Forms.TrackBar trackBarBlinds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Timer timerSensor;
        private System.Windows.Forms.RichTextBox richTextSensorValue;
        private System.Windows.Forms.RichTextBox richTextVoiceCommands;
        private System.Windows.Forms.Timer zara;
    }
}

