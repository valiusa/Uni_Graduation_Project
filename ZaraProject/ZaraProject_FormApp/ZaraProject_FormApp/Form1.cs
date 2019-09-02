using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO.Ports;
using System.Speech.Recognition;
using System.IO;

namespace ZaraProject_FormApp
{
    public partial class Form1 : Form
    {
        private List<string> ports;
        private SerialPort myPort;
        private SpeechRecognitionEngine engine;
        private string path = Path.GetDirectoryName(Application.ExecutablePath);
        private byte count = 0;
        private string[] sensorsData = new string[2];
        private double lightSensorValue = 0.00;
        private int gasSensorValue = 0;
        private bool zaraOnOFF = false;
        private string zaraOnOffCommand = "";
        private bool sensorControlState = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            zara.Start();

            btnDisc.Enabled = false;
            btnLampON.Enabled = false;
            btnLampOFF.Enabled = false;
            btnFanON.Enabled = false;
            btnFanOFF.Enabled = false;
            btnSConON.Enabled = false;
            btnSConOFF.Enabled = false;
            trackBarBlinds.Enabled = false;
            checkBox1.Enabled = false;

            ports = SerialPort.GetPortNames().ToList();

            foreach (var port in ports)
            {
                comboBox1.Items.Add(port);
            }
        }

        private void Form1_Leave(object sender, EventArgs e)
        {
            if (myPort.IsOpen)
            {
                myPort.Close();
                engine.Dispose();
                timerFan.Stop();
                timerSensor.Stop();
                zara.Stop();
            }
        }

        private void btnConn_Click(object sender, EventArgs e)
        {
            try
            {
                myPort = new SerialPort();

                myPort.PortName = comboBox1.Items[comboBox1.SelectedIndex].ToString();
                myPort.BaudRate = 115200;
                myPort.Open();

                btnConn.Enabled = false;
                btnDisc.Enabled = true;

                btnLampON.Enabled = true;
                btnSConON.Enabled = true;
                btnFanON.Enabled = true;
                trackBarBlinds.Enabled = true;
                checkBox1.Enabled = true;

                MessageBox.Show("Connected", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (IOException)
            {
                MessageBox.Show("The current port is unavailable or does not exist!\nPlease choose onother one!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please choose a device to connect!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDisc_Click(object sender, EventArgs e)
        {
            if (!sensorControlState)
            {
                if (myPort.IsOpen)
                {
                    myPort.Close();

                    btnDisc.Enabled = false;
                    btnConn.Enabled = true;

                    btnLampON.Enabled = false;
                    btnLampOFF.Enabled = false;
                    btnSConON.Enabled = false;
                    btnSConOFF.Enabled = false;
                    btnFanON.Enabled = false;
                    btnFanOFF.Enabled = false;
                    trackBarBlinds.Enabled = false;
                    checkBox1.Enabled = false;
                }                

                MessageBox.Show("Disconnected", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Turn off the sensor control module!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState.ToString() == "Checked")
            {
                checkBox1.Text = "Speech Rec: ON";
                panel1.BackColor = Color.Green;

                engine = new SpeechRecognitionEngine(); // Sets the recognition engine
                engine.SetInputToDefaultAudioDevice();

                Grammar g = MyGrammer();

                engine.LoadGrammar(g);
                engine.RecognizeAsync(RecognizeMode.Multiple);
                engine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(engine_SpeechRecognized);
            }
            else
            {
                checkBox1.Text = "Speech Rec: OFF";
                panel1.BackColor = Color.Red;
                zaraOnOFF = false;
                engine.Dispose(); // Dispose the recognition engine
            }
        }

        private void engine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            richTextVoiceCommands.Text += e.Result.Text + Environment.NewLine;
            zaraOnOffCommand = e.Result.Text;

            if (zaraOnOFF == true)
            {
                string[] comm = e.Result.Text.Split(' ');

                SendCommandToController(comm);                

                SetFanState(e.Result.Text);
                SetLightState(e.Result.Text);
            }
        }

        private void SendCommandToController(string[] _comm)
        {
            if (_comm.Length < 3)
            {
                myPort.WriteLine(_comm[0] + _comm[1]);
            }
            else
            {
                myPort.WriteLine(_comm[0] + _comm[1] + _comm[2]);
            }
        }

        private void SetLightState(string _command)
        {
            if (_command == "turn on light")
            {
                btnLampON.Enabled = false;
                btnLampOFF.Enabled = true;

                pictureBoxLamp.Image = Image.FromFile($"{path}/IMG/LampON.png");

                relay_1_panel.BackColor = Color.Green;
            }
            if (_command == "turn off light")
            {
                btnLampON.Enabled = true;
                btnLampOFF.Enabled = false;

                pictureBoxLamp.Image = Image.FromFile($"{path}/IMG/LampOFF.png");

                relay_1_panel.BackColor = Color.Red;
            }
        }

        private void SetFanState(string _command)
        {
            if (_command == "turn on fan")
            {
                relay_3_panel.BackColor = Color.Green;

                btnFanON.Enabled = false;
                btnFanOFF.Enabled = true;

                timerFan.Start();
            }
            if (_command == "turn off fan")
            {
                relay_3_panel.BackColor = Color.Red;

                btnFanON.Enabled = true;
                btnFanOFF.Enabled = false;

                timerFan.Stop();
            }
        }

        // Creates a garmmer of commands that the speech engine can use
        private Grammar MyGrammer()
        {
            string[] commands = new string[] { "zara", "light", "fan", "blinds" };
            string[] actions = new string[] { "turn on", "turn off", "open", "close", "lower", "raise" };

            GrammarBuilder gb = new GrammarBuilder(new Choices(actions));
            gb.Append(new Choices(commands));

            Grammar g = new Grammar(gb);
            return g;
        }

        private void trackBarBlinds_Scroll(object sender, EventArgs e)
        {
            myPort.WriteLine($"move{trackBarBlinds.Value}deg");

            AnimateBlindsPictureBox(trackBarBlinds.Value);            
        }

        private void AnimateBlindsPictureBox(int value)
        {
            if (value == 0)
            {
                pictureBoxBlinds.Image = Image.FromFile($"{path}/IMG/Blinds_0.png");
            }
            if (value == 60)
            {
                pictureBoxBlinds.Image = Image.FromFile($"{path}/IMG/Blinds_60.png");
            }
            if (value == 120)
            {
                pictureBoxBlinds.Image = Image.FromFile($"{path}/IMG/Blinds_120.png");
            }
            if (value == 180)
            {
                pictureBoxBlinds.Image = Image.FromFile($"{path}/IMG/Blinds_180.png");
            }
        }

        private void btnFanON_Click(object sender, EventArgs e)
        {
            relay_3_panel.BackColor = Color.Green;

            timerFan.Enabled = true;
            btnFanON.Enabled = false;
            btnFanOFF.Enabled = true;

            myPort.Write("turnonfan");
        }

        private void btnFanOFF_Click(object sender, EventArgs e)
        {
            relay_3_panel.BackColor = Color.Red;

            timerFan.Enabled = false;
            btnFanON.Enabled = true; ;
            btnFanOFF.Enabled = false;

            myPort.Write("turnofffan");
        }

        private void timerFan_Tick(object sender, EventArgs e)
        {
            if (count == 0)
            {
                pictureBoxFan.Image = Image.FromFile($"{path}/IMG/Fan.png");
            }            
            else
            {
                pictureBoxFan.Image = Image.FromFile($"{path}/IMG/Fan{count}.png");
            }

            if (count == 3)
            {
                count = 0;
            }

            count++;
        }

        private void btnSConON_Click(object sender, EventArgs e)
        {
            timerSensor.Start();

            checkBox1.Enabled = false;
            btnFanON.Enabled = false;
            btnFanOFF.Enabled = false;
            btnLampON.Enabled = false;
            btnLampOFF.Enabled = false;
            trackBarBlinds.Enabled = false;
            btnSConON.Enabled = false;
            btnSConOFF.Enabled = true;
            sensorControlState = true;
        }

        private void btnSConOFF_Click(object sender, EventArgs e)
        {
            checkBox1.Enabled = true;
            btnFanON.Enabled = true;
            btnLampON.Enabled = true;
            trackBarBlinds.Enabled = true;
            btnSConON.Enabled = true;
            btnSConOFF.Enabled = false;
            sensorControlState = false;

            timerSensor.Stop();
            richTextSensorValue.Clear();
        }

        private void timerSensor_Tick(object sender, EventArgs e)
        {
            sensorsData = myPort.ReadExisting().ToString().Split('/');

            CheckSensorsDataLenght(sensorsData);
        }

        private void CheckSensorsDataLenght(string[] _sensorsData)
        {
            if (_sensorsData.Length == 2)
            {
                GetLightLevelDataAndSetLightAndBlinds(_sensorsData);
                GetGasLevelDataAndSetFanState(_sensorsData);
            }
        }

        private void GetGasLevelDataAndSetFanState(string[] _sensorsData)
        {
            if (int.TryParse(_sensorsData[1], out gasSensorValue))
            {
                if (gasSensorValue > 1000)
                {
                    relay_3_panel.BackColor = Color.Green;                    
                    timerFan.Enabled = true;

                    myPort.Write("turnonfan");
                }
                else
                {                    
                    relay_3_panel.BackColor = Color.Red;                    
                    timerFan.Enabled = false;

                    myPort.Write("turnofffan");
                }
                richTextSensorValue.Text += "Gas Level --> " + gasSensorValue + Environment.NewLine;
            }
        }
        // -------------------------------------------------------
        private void GetLightLevelDataAndSetLightAndBlinds(string[] _sensorsData)
        {
            if (double.TryParse(_sensorsData[0], out lightSensorValue))
            {
                if (lightSensorValue < 100.00)
                {
                    pictureBoxLamp.Image = Image.FromFile($"{path}/IMG/LampON.png");
                    relay_1_panel.BackColor = Color.Green;

                    myPort.Write("turnonlight");
                }
                if (lightSensorValue > 100)
                {
                    pictureBoxLamp.Image = Image.FromFile($"{path}/IMG/LampOFF.png");
                    relay_1_panel.BackColor = Color.Red;

                    myPort.Write("turnofflight");
                }
                if (lightSensorValue > 500)
                {
                    myPort.Write("raiseblinds");
                    pictureBoxBlinds.Image = Image.FromFile($"{path}/IMG/Blinds_180.png");
                }
                if (lightSensorValue < 500)
                {
                    myPort.Write("lowerblinds");
                    pictureBoxBlinds.Image = Image.FromFile($"{path}/IMG/Blinds_0.png");
                }

                richTextSensorValue.Text += "Light Level --> " + lightSensorValue + Environment.NewLine;
            }
        }

        private void btnLampON_Click(object sender, EventArgs e)
        {
            pictureBoxLamp.Image = Image.FromFile($"{path}/IMG/LampON.png");

            btnLampON.Enabled = false;
            btnLampOFF.Enabled = true;

            relay_1_panel.BackColor = Color.Green;
            myPort.Write("turnonlight");
        }

        private void btnLampOFF_Click(object sender, EventArgs e)
        {
            pictureBoxLamp.Image = Image.FromFile($"{path}/IMG/LampOFF.png");

            btnLampON.Enabled = true;
            btnLampOFF.Enabled = false;

            relay_1_panel.BackColor = Color.Red;
            myPort.Write("turnofflight");
        }

        private void zara_Tick(object sender, EventArgs e)
        {
            if (zaraOnOffCommand == "turn on zara")
            {
                zaraOnOFF = true;
            }
            if (zaraOnOffCommand == "turn off zara")
            {
                zaraOnOFF = false;
            }
        }
    }
}
