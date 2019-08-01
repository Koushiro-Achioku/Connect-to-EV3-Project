using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Threading;

namespace Connect_to_EV3
{
    public partial class Form1 : Form
    {
        Form2 Form_setting = new Form2();
        Form3 Form_setting2 = new Form3();

        //public string data="            ";
        public string data;
        public bool writed;
        public bool connected = false;
        public string COM_Port = "COM40";

        public int please_port = 0;

        public char[] port1 = new char[4] { '1', '0', '0', '0' };
        public char[] port2 = new char[4] { '2', '0', '0', '0' };
        public char[] port3 = new char[4] { '3', '0', '0', '0' };
        public char[] port4 = new char[4] { '4', '0', '0', '0' };
        public char[] portA = new char[4] { '5', '0', '0', '0' };
        public char[] portB = new char[4] { '6', '0', '0', '0' };
        public char[] portC = new char[4] { '7', '0', '0', '0' };
        public char[] portD = new char[4] { '8', '0', '0', '0' };

        public char[] read_value = new char[12] { '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0' };
        public char[] read_X = new char[4];
        public string value_X;

        public bool started = false;

        public bool record = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_COM.SelectedItem = Properties.Settings.Default.COM_port;
            comboBox_P1.SelectedItem = "NONE";
            comboBox_P2.SelectedItem = "NONE";
            comboBox_P3.SelectedItem = "NONE";
            comboBox_P4.SelectedItem = "NONE";
            comboBox_PA.SelectedItem = "NONE";
            comboBox_PB.SelectedItem = "NONE";
            comboBox_PC.SelectedItem = "NONE";
            comboBox_PD.SelectedItem = "NONE";

            label_P1.Width = 168;
            label_P1.Location = new Point(174, 107);
            label_P1.Font = new Font(label_P1.Font.FontFamily, 26);
            label_P1.ForeColor = Color.Black;
            label_P2.Width = 168;
            label_P2.Location = new Point(174, 209);
            label_P2.Font = new Font(label_P2.Font.FontFamily, 26);
            label_P2.ForeColor = Color.Black;
            label_P3.Width = 168;
            label_P3.Location = new Point(174, 311);
            label_P3.Font = new Font(label_P3.Font.FontFamily, 26);
            label_P3.ForeColor = Color.Black;
            label_P4.Width = 168;
            label_P4.Location = new Point(174, 413);
            label_P4.Font = new Font(label_P4.Font.FontFamily, 26);
            label_P4.ForeColor = Color.Black;

            btn_end.Enabled = false;
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (connected == false)
            {
                try
                {
                    serialPort1.BaudRate = 115200;
                    serialPort1.Parity = Parity.None;
                    serialPort1.DataBits = 8;
                    serialPort1.StopBits = StopBits.One;
                    serialPort1.Handshake = Handshake.None;
                    serialPort1.PortName = COM_Port;
                    serialPort1.Encoding = Encoding.UTF8;
                    serialPort1.Open();
                    timer1.Start();

                    if (serialPort1.IsOpen == true)
                    {
                        connected = true;
                        btn_connect.BackColor = Color.GreenYellow;
                    }
                }
                catch
                {
                    MessageBox.Show("正しいCOMポートを選択してください。", "COMポートエラー"
                        ,MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                serialPort1.Close();
                connected = false;
                btn_connect.BackColor = Color.Red;
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write("1");
                started = true;
                btn_end.Enabled = true;
                btn_start.Enabled = false;
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            data = serialPort1.ReadExisting();
            writed = true;
        }
        
        public int[] motor_zero = new int[4] { 0, 0, 0, 0 };
        public int[] sensor_zero = new int[4] { 0, 0, 0, 0 };

        public void Format()
        {
            string[,] get_value = new string[3,8];
            bool[] next_write = new bool[8] { true, true, true, true, true, true, true, true };
            if (data.Length>=40)
            {
                //read_value = data.ToCharArray();
                int i = 0;
                //Port1
                while (data[i] != '1')
                {
                    i++;
                }
                i++;
                while (data[i] != ',')
                {
                    get_value[0, 0] += data[i];
                    i++;
                }
                i++;
                while (data[i] != ',')
                {
                    get_value[1, 0] += data[i];
                    i++;
                }
                i++;
                while (data[i] != '#')
                {
                    get_value[2, 0] += data[i];
                    i++;
                }
                if((get_value[0, 0] == "0") && (get_value[1, 0] == "0") && (get_value[2, 0] == "0") && (sensor_zero[0]<3))
                {
                    next_write[0] = false;
                    sensor_zero[0]++;
                }
                i++;
                //Port2
                while (data[i] != '2')
                {
                    i++;
                }
                i++;
                while (data[i] != ',')
                {
                    get_value[0, 1] += data[i];
                    i++;
                }
                i++;
                while (data[i] != ',')
                {
                    get_value[1, 1] += data[i];
                    i++;
                }
                i++;
                while (data[i] != '#')
                {
                    get_value[2, 1] += data[i];
                    i++;
                }
                if ((get_value[0, 1] == "0") && (get_value[1, 1] == "0") && (get_value[2, 1] == "0") && (sensor_zero[1] < 3))
                {
                    next_write[1] = false;
                    sensor_zero[1]++;
                }
                i++;
                //Port3
                while (data[i] != '3')
                {
                    i++;
                }
                i++;
                while (data[i] != ',')
                {
                    get_value[0, 2] += data[i];
                    i++;
                }
                i++;
                while (data[i] != ',')
                {
                    get_value[1, 2] += data[i];
                    i++;
                }
                i++;
                while (data[i] != '#')
                {
                    get_value[2, 2] += data[i];
                    i++;
                }
                if ((get_value[0, 2] == "0") && (get_value[1, 2] == "0") && (get_value[2, 2] == "0") && (sensor_zero[2] < 3))
                {
                    next_write[2] = false;
                    sensor_zero[2]++;
                }
                i++;
                //Port4
                while (data[i] != '4')
                {
                    i++;
                }
                i++;
                while (data[i] != ',')
                {
                    get_value[0, 3] += data[i];
                    i++;
                }
                i++;
                while (data[i] != ',')
                {
                    get_value[1, 3] += data[i];
                    i++;
                }
                i++;
                while (data[i] != '#')
                {
                    get_value[2, 3] += data[i];
                    i++;
                }
                if ((get_value[0, 3] == "0") && (get_value[1, 3] == "0") && (get_value[2, 3] == "0") && (sensor_zero[3] < 3))
                {
                    next_write[3] = false;
                    sensor_zero[3]++;
                }
                i++;
                //PortA
                while (data[i] != '5')
                {
                    i++;
                }
                i++;
                while (data[i] != '#')
                {
                    get_value[0, 4] += data[i];
                    i++;
                }
                if ((get_value[0, 4] == "0") && (motor_zero[0] < 15)){
                    next_write[4] = false;
                    motor_zero[0]++;
                }
                i++;
                //PortB
                while (data[i] != '6')
                {
                    i++;
                }
                i++;
                while (data[i] != '#')
                {
                    get_value[0, 5] += data[i];
                    i++;
                }
                if ((get_value[0, 5] == "0") && (motor_zero[1] < 15))
                {
                    next_write[5] = false;
                    motor_zero[1]++;
                }
                i++;
                //PortC
                while (data[i] != '7')
                {
                    i++;
                }
                i++;
                while (data[i] != '#')
                {
                    get_value[0, 6] += data[i];
                    i++;
                }
                if ((get_value[0, 6] == "0") && (motor_zero[2] < 15))
                {
                    next_write[6] = false;
                    motor_zero[2]++;
                }
                i++;
                //PortD
                while (data[i] != '8')
                {
                    i++;
                }
                i++;
                while (data[i] != '#')
                {
                    get_value[0, 7] += data[i];
                    i++;
                }
                if ((get_value[0, 7] == "0") && (motor_zero[3] < 15))
                {
                    next_write[7] = false;
                    motor_zero[3]++;
                }

                //Port1書き込み
                if (next_write[0] == true)
                {
                    label_P1.Text = get_value[0, 0];
                    label_P1_2.Text = get_value[1, 0];
                    label_P1_3.Text = get_value[2, 0];
                    sensor_zero[0] = 0;
                }
                //Port2書き込み
                if (next_write[1] == true)
                {
                    label_P2.Text = get_value[0, 1];
                    label_P2_2.Text = get_value[1, 1];
                    label_P2_3.Text = get_value[2, 1];
                    sensor_zero[1] = 0;
                }
                //Port3書き込み
                if (next_write[2] == true)
                {
                    label_P3.Text = get_value[0, 2];
                    label_P3_2.Text = get_value[1, 2];
                    label_P3_3.Text = get_value[2, 2];
                    sensor_zero[2] = 0;
                }
                //Port4書き込み
                if (next_write[3] == true)
                {
                    label_P4.Text = get_value[0, 3];
                    label_P4_2.Text = get_value[1, 3];
                    label_P4_3.Text = get_value[2, 3];
                    sensor_zero[3] = 0;
                }

                if (next_write[4] == true)
                {
                    label_PA.Text = get_value[0, 4];
                    motor_zero[0] = 0;
                }
                if (next_write[5] == true)
                {
                    label_PB.Text = get_value[0, 5];
                    motor_zero[1] = 0;
                }
                if (next_write[6] == true)
                {
                    label_PC.Text = get_value[0, 6];
                    motor_zero[2] = 0;
                }
                if (next_write[7] == true)
                {
                    label_PD.Text = get_value[0, 7];
                    motor_zero[3] = 0;
                }

                textBox1.Text += get_value[0, 0];
                textBox1.Text += (",");
                textBox1.Text += get_value[1, 0];
                textBox1.Text += (",");
                textBox1.Text += get_value[2, 0];
                textBox1.Text += (",");
                textBox1.Text += get_value[0, 1];
                textBox1.Text += (",");
                textBox1.Text += get_value[1, 1];
                textBox1.Text += (",");
                textBox1.Text += get_value[2, 1];
                textBox1.Text += (",");
                textBox1.Text += get_value[0, 2];
                textBox1.Text += (",");
                textBox1.Text += get_value[1, 2];
                textBox1.Text += (",");
                textBox1.Text += get_value[2, 2];
                textBox1.Text += (",");
                textBox1.Text += get_value[0, 3];
                textBox1.Text += (",");
                textBox1.Text += get_value[1, 3];
                textBox1.Text += (",");
                textBox1.Text += get_value[2, 3];
                textBox1.Text += (",");

                textBox1.Text += get_value[0, 4];
                textBox1.Text += (",");
                textBox1.Text += get_value[0, 5];
                textBox1.Text += (",");
                textBox1.Text += get_value[0, 6];
                textBox1.Text += (",");
                textBox1.Text += get_value[0, 7];
                textBox1.Text += ("\r\n");

                string writing = 
                      get_value[0, 0] + "," + get_value[1, 0] + "," + get_value[2, 0] + ","
                    + get_value[0, 1] + "," + get_value[1, 1] + "," + get_value[2, 1] + ","
                    + get_value[0, 2] + "," + get_value[1, 2] + "," + get_value[2, 2] + ","
                    + get_value[0, 3] + "," + get_value[1, 3] + "," + get_value[2, 3] + ","
                    + get_value[0, 4] + "," + get_value[0, 5] + "," + get_value[0, 6] + "," + get_value[0, 7];

                if (record == true)
                {            
                    System.IO.StreamWriter sw = new System.IO.StreamWriter(
                    label_Pass.Text, true,
                    System.Text.Encoding.GetEncoding("shift_jis"));
                    sw.WriteLine(writing);
                    sw.Close();
                }
            }
        }

        public int write_times = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {        
            if (writed == true)
            {
                writed = false;
                write_times++;

                Format();

                if (checkBox1.Checked == true)
                {
                    textBox1.Focus();
                    textBox1.SelectionStart = textBox1.Text.Length;
                    textBox1.ScrollToCaret();
                }

                if (Properties.Settings.Default.light_mode == true)
                {
                    if (write_times > 10)
                    {
                        textBox1.Text = "";
                        write_times = 0;
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            serialPort1.Write(textBox2.Text);
        }

        private void comboBox_COM_SelectedIndexChanged(object sender, EventArgs e)
        {
            COM_Port = comboBox_COM.SelectedItem.ToString();
        }

        private void comboBox_P1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_P1.Width = 168;
            label_P1.Location = new Point(174, 107);
            label_P1.Font = new Font(label_P1.Font.FontFamily, 26);
            label_P1.ForeColor = Color.Black;

            switch (comboBox_P1.SelectedItem)
            {
                case "NONE":
                    numericUpDown_P1m.Maximum = 0;
                    pictureBox_P1.Image = Properties.Resources.none;
                    port1[1] = '0';
                    port1[2] = '0';
                    label_P1m.Text = "NONE";
                    btn_P1_reset.Enabled = false;
                    break;
                case "ULTRA SONIC":
                    numericUpDown_P1m.Maximum = 1;
                    pictureBox_P1.Image = Properties.Resources.Ultrasonic;
                    port1[1] = '1';
                    port1[2] = '0';
                    label_P1m.Text = "距離測定";
                    btn_P1_reset.Enabled = false;
                    break;
                case "GYRO":
                    numericUpDown_P1m.Maximum = 1;
                    pictureBox_P1.Image = Properties.Resources.Gyro;
                    port1[1] = '2';
                    port1[2] = '0';
                    label_P1m.Text = "角位置";
                    btn_P1_reset.Enabled = true;
                    break;
                case "TOUCH":
                    numericUpDown_P1m.Maximum = 0;
                    pictureBox_P1.Image = Properties.Resources.Touch;
                    port1[1] = '3';
                    port1[2] = '0';
                    label_P1m.Text = "状態(押・離)";
                    btn_P1_reset.Enabled = false;
                    break;
                case "COLOR":
                    numericUpDown_P1m.Maximum = 3;
                    pictureBox_P1.Image = Properties.Resources.Color;
                    port1[1] = '4';
                    port1[2] = '0';
                    label_P1m.Text = "反射光";
                    btn_P1_reset.Enabled = false;
                    break;
                case "HT COLOR":
                    numericUpDown_P1m.Maximum = 1;
                    pictureBox_P1.Image = Properties.Resources.HTColor;
                    port1[1] = '5';
                    port1[2] = '0';
                    label_P1m.Text = "カラー";
                    btn_P1_reset.Enabled = false;
                    break;
            }

            numericUpDown_P1m.Value = 0;
            string s = new string(port1);
            if (serialPort1.IsOpen == true) { serialPort1.Write(s); }
        }

        private void numericUpDown_P1m_ValueChanged(object sender, EventArgs e)
        {
            label_P1.Width = 168;
            label_P1.Location = new Point(174, 107);
            label_P1.Font = new Font(label_P1.Font.FontFamily, 26);
            label_P1.ForeColor = Color.Black;

            switch (comboBox_P1.SelectedItem)
            {
                case "NONE":
                    break;
                case "ULTRA SONIC":
                    if (numericUpDown_P1m.Value == 0)
                    {
                        port1[2] = '0';
                        label_P1m.Text = "距離測定";
                    }
                    else
                    {
                        port1[2] = '1';
                        label_P1m.Text = "超音波信号";
                    }
                    break;
                case "GYRO":
                    if (numericUpDown_P1m.Value == 0)
                    {
                        port1[2] = '0';
                        label_P1m.Text = "角位置";
                    }
                    else
                    {
                        port1[2] = '1';
                        label_P1m.Text = "角速度";
                    }
                    break;
                case "TOUCH":
                    port1[2] = '0';
                    label_P1m.Text = "状態(押・離)";
                    break;
                case "COLOR":
                    if (numericUpDown_P1m.Value == 0)
                    {
                        port1[2] = '0';
                        label_P1m.Text = "反射光";
                    }
                    else if (numericUpDown_P1m.Value == 1)
                    {
                        port1[2] = '1';
                        label_P1m.Text = "周辺光";
                    }
                    else if (numericUpDown_P1m.Value == 2)
                    {
                        port1[2] = '2';
                        label_P1m.Text = "カラー";
                    }
                    else if (numericUpDown_P1m.Value == 3)
                    {
                        port1[2] = '3';
                        label_P1m.Text = "RGB";

                        label_P1.Width = 52;
                        label_P1.Location = new Point(174, 107);
                        label_P1.Font = new Font(label_P1.Font.FontFamily, 12);
                        label_P1.Font = new Font(label_P1.Font, FontStyle.Bold);
                        label_P1.ForeColor = Color.Red;
                    }
                    break;
                case "HT COLOR":
                    if (numericUpDown_P1m.Value == 0)
                    {
                        port1[2] = '0';
                        label_P1m.Text = "カラー";
                    }
                    else
                    {
                        port1[2] = '1';
                        label_P1m.Text = "RGB";

                        label_P1.Width = 52;
                        label_P1.Location = new Point(174, 107);
                        label_P1.Font = new Font(label_P1.Font.FontFamily, 12);
                        label_P1.Font = new Font(label_P1.Font, FontStyle.Bold);
                        label_P1.ForeColor = Color.Red;
                    }
                    break;
            }
            string s = new string(port1);
            if (serialPort1.IsOpen == true) { serialPort1.Write(s); }
        }

        private void comboBox_P2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_P2.Width = 168;
            label_P2.Location = new Point(174, 209);
            label_P2.Font = new Font(label_P2.Font.FontFamily, 26);
            label_P2.ForeColor = Color.Black;

            switch (comboBox_P2.SelectedItem)
            {
                case "NONE":
                    numericUpDown_P2m.Maximum = 0;
                    pictureBox_P2.Image = Properties.Resources.none;
                    port2[1] = '0';
                    port2[2] = '0';
                    label_P2m.Text = "NONE";
                    btn_P2_reset.Enabled = false;
                    break;
                case "ULTRA SONIC":
                    numericUpDown_P2m.Maximum = 1;
                    pictureBox_P2.Image = Properties.Resources.Ultrasonic;
                    port2[1] = '1';
                    port2[2] = '0';
                    label_P2m.Text = "距離測定";
                    btn_P2_reset.Enabled = false;
                    break;
                case "GYRO":
                    numericUpDown_P2m.Maximum = 1;
                    pictureBox_P2.Image = Properties.Resources.Gyro;
                    port2[1] = '2';
                    port2[2] = '0';
                    label_P2m.Text = "角位置";
                    btn_P2_reset.Enabled = true;
                    break;
                case "TOUCH":
                    numericUpDown_P2m.Maximum = 0;
                    pictureBox_P2.Image = Properties.Resources.Touch;
                    port2[1] = '3';
                    port2[2] = '0';
                    label_P2m.Text = "状態(押・離)";
                    btn_P2_reset.Enabled = false;
                    break;
                case "COLOR":
                    numericUpDown_P2m.Maximum = 3;
                    pictureBox_P2.Image = Properties.Resources.Color;
                    port2[1] = '4';
                    port2[2] = '0';
                    label_P2m.Text = "反射光";
                    btn_P2_reset.Enabled = false;
                    break;
                case "HT COLOR":
                    numericUpDown_P2m.Maximum = 1;
                    pictureBox_P2.Image = Properties.Resources.HTColor;
                    port2[1] = '5';
                    port2[2] = '0';
                    label_P2m.Text = "カラー";
                    btn_P2_reset.Enabled = false;
                    break;
            }
            numericUpDown_P2m.Value = 0;
            string s = new string(port2);
            if (serialPort1.IsOpen == true) { serialPort1.Write(s); }
        }

        private void numericUpDown_P2m_ValueChanged(object sender, EventArgs e)
        {
            label_P2.Width = 168;
            label_P2.Location = new Point(174, 209);
            label_P2.Font = new Font(label_P2.Font.FontFamily, 26);
            label_P2.ForeColor = Color.Black;

            switch (comboBox_P2.SelectedItem)
            {
                case "NONE":
                    break;
                case "ULTRA SONIC":
                    if (numericUpDown_P2m.Value == 0)
                    {
                        port2[2] = '0';
                        label_P2m.Text = "距離測定";
                    }
                    else
                    {
                        port2[2] = '1';
                        label_P2m.Text = "超音波信号";
                    }
                    break;
                case "GYRO":
                    if (numericUpDown_P2m.Value == 0)
                    {
                        port2[2] = '0';
                        label_P2m.Text = "角位置";
                    }
                    else
                    {
                        port2[2] = '1';
                        label_P2m.Text = "角速度";
                    }
                    break;
                case "TOUCH":
                    port2[2] = '0';
                    label_P2m.Text = "状態(押・離)";
                    break;
                case "COLOR":
                    if (numericUpDown_P2m.Value == 0)
                    {
                        port2[2] = '0';
                        label_P2m.Text = "反射光";
                    }
                    else if (numericUpDown_P2m.Value == 1)
                    {
                        port2[2] = '1';
                        label_P2m.Text = "周辺光";
                    }
                    else if (numericUpDown_P2m.Value == 2)
                    {
                        port2[2] = '2';
                        label_P2m.Text = "カラー";
                    }
                    else if (numericUpDown_P2m.Value == 3)
                    {
                        port2[2] = '3';
                        label_P2m.Text = "RGB";

                        label_P2.Width = 52;
                        label_P2.Location = new Point(174, 209);
                        label_P2.Font = new Font(label_P2.Font.FontFamily, 12);
                        label_P2.Font = new Font(label_P2.Font, FontStyle.Bold);
                        label_P2.ForeColor = Color.Red;
                    }
                    break;
                case "HT COLOR":
                    if (numericUpDown_P2m.Value == 0)
                    {
                        port2[2] = '0';
                        label_P2m.Text = "カラー";
                    }
                    else
                    {
                        port2[2] = '1';
                        label_P2m.Text = "RGB";

                        label_P2.Width = 52;
                        label_P2.Location = new Point(174, 209);
                        label_P2.Font = new Font(label_P2.Font.FontFamily, 12);
                        label_P2.Font = new Font(label_P2.Font, FontStyle.Bold);
                        label_P2.ForeColor = Color.Red;
                    }
                    break;
            }
            string s = new string(port2);
            if (serialPort1.IsOpen == true) { serialPort1.Write(s); }
        }

        private void comboBox_P3_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_P3.Width = 168;
            label_P3.Location = new Point(174, 311);
            label_P3.Font = new Font(label_P3.Font.FontFamily, 26);
            label_P3.ForeColor = Color.Black;

            switch (comboBox_P3.SelectedItem)
            {
                case "NONE":
                    numericUpDown_P3m.Maximum = 0;
                    pictureBox_P3.Image = Properties.Resources.none;
                    port3[1] = '0';
                    port3[2] = '0';
                    label_P3m.Text = "NONE";
                    btn_P3_reset.Enabled = false;
                    break;
                case "ULTRA SONIC":
                    numericUpDown_P3m.Maximum = 1;
                    pictureBox_P3.Image = Properties.Resources.Ultrasonic;
                    port3[1] = '1';
                    port3[2] = '0';
                    label_P3m.Text = "距離測定";
                    btn_P3_reset.Enabled = false;
                    break;
                case "GYRO":
                    numericUpDown_P3m.Maximum = 1;
                    pictureBox_P3.Image = Properties.Resources.Gyro;
                    port3[1] = '2';
                    port3[2] = '0';
                    label_P3m.Text = "角位置";
                    btn_P3_reset.Enabled = true;
                    break;
                case "TOUCH":
                    numericUpDown_P3m.Maximum = 0;
                    pictureBox_P3.Image = Properties.Resources.Touch;
                    port3[1] = '3';
                    port3[2] = '0';
                    label_P3m.Text = "状態(押・離)";
                    btn_P3_reset.Enabled = false;
                    break;
                case "COLOR":
                    numericUpDown_P3m.Maximum = 3;
                    pictureBox_P3.Image = Properties.Resources.Color;
                    port3[1] = '4';
                    port3[2] = '0';
                    label_P3m.Text = "反射光";
                    btn_P3_reset.Enabled = false;
                    break;
                case "HT COLOR":
                    numericUpDown_P3m.Maximum = 1;
                    pictureBox_P3.Image = Properties.Resources.HTColor;
                    port3[1] = '5';
                    port3[2] = '0';
                    label_P3m.Text = "カラー";
                    btn_P3_reset.Enabled = false;
                    break;
            }
            numericUpDown_P3m.Value = 0;
            string s = new string(port3);
            if (serialPort1.IsOpen == true) { serialPort1.Write(s); }
        }

        private void numericUpDown_P3m_ValueChanged(object sender, EventArgs e)
        {
            label_P3.Width = 168;
            label_P3.Location = new Point(174, 311);
            label_P3.Font = new Font(label_P3.Font.FontFamily, 26);
            label_P3.ForeColor = Color.Black;

            switch (comboBox_P3.SelectedItem)
            {
                case "NONE":
                    break;
                case "ULTRA SONIC":
                    if (numericUpDown_P3m.Value == 0)
                    {
                        port3[2] = '0';
                        label_P3m.Text = "距離測定";
                    }
                    else
                    {
                        port3[2] = '1';
                        label_P3m.Text = "超音波信号";
                    }
                    break;
                case "GYRO":
                    if (numericUpDown_P3m.Value == 0)
                    {
                        port3[2] = '0';
                        label_P3m.Text = "角位置";
                    }
                    else
                    {
                        port3[2] = '1';
                        label_P3m.Text = "角速度";
                    }
                    break;
                case "TOUCH":
                    port3[2] = '0';
                    label_P3m.Text = "状態(押・離)";
                    break;
                case "COLOR":
                    if (numericUpDown_P3m.Value == 0)
                    {
                        port3[2] = '0';
                        label_P3m.Text = "反射光";
                    }
                    else if (numericUpDown_P3m.Value == 1)
                    {
                        port3[2] = '1';
                        label_P3m.Text = "周辺光";
                    }
                    else if (numericUpDown_P3m.Value == 2)
                    {
                        port3[2] = '2';
                        label_P3m.Text = "カラー";
                    }
                    else if (numericUpDown_P3m.Value == 3)
                    {
                        port3[2] = '3';
                        label_P3m.Text = "RGB";

                        label_P3.Width = 52;
                        label_P3.Location = new Point(174, 311);
                        label_P3.Font = new Font(label_P3.Font.FontFamily, 12);
                        label_P3.Font = new Font(label_P3.Font, FontStyle.Bold);
                        label_P3.ForeColor = Color.Red;
                    }
                    break;
                case "HT COLOR":
                    if (numericUpDown_P3m.Value == 0)
                    {
                        port3[2] = '0';
                        label_P3m.Text = "カラー";
                    }
                    else
                    {
                        port3[2] = '1';
                        label_P3m.Text = "RGB";

                        label_P3.Width = 52;
                        label_P3.Location = new Point(174, 311);
                        label_P3.Font = new Font(label_P3.Font.FontFamily, 12);
                        label_P3.Font = new Font(label_P3.Font, FontStyle.Bold);
                        label_P3.ForeColor = Color.Red;
                    }
                    break;
            }
            string s = new string(port3);
            if (serialPort1.IsOpen == true) { serialPort1.Write(s); }
        }

        private void comboBox_P4_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_P4.Width = 168;
            label_P4.Location = new Point(174, 413);
            label_P4.Font = new Font(label_P4.Font.FontFamily, 26);
            label_P4.ForeColor = Color.Black;

            switch (comboBox_P4.SelectedItem)
            {
                case "NONE":
                    numericUpDown_P4m.Maximum = 0;
                    pictureBox_P4.Image = Properties.Resources.none;
                    port4[1] = '0';
                    port4[2] = '0';
                    label_P4m.Text = "NONE";
                    btn_P4_reset.Enabled = false;
                    break;
                case "ULTRA SONIC":
                    numericUpDown_P4m.Maximum = 1;
                    pictureBox_P4.Image = Properties.Resources.Ultrasonic;
                    port4[1] = '1';
                    port4[2] = '0';
                    label_P4m.Text = "距離測定";
                    btn_P4_reset.Enabled = false;
                    break;
                case "GYRO":
                    numericUpDown_P4m.Maximum = 1;
                    pictureBox_P4.Image = Properties.Resources.Gyro;
                    port4[1] = '2';
                    port4[2] = '0';
                    label_P4m.Text = "角位置";
                    btn_P4_reset.Enabled = true;
                    break;
                case "TOUCH":
                    numericUpDown_P4m.Maximum = 0;
                    pictureBox_P4.Image = Properties.Resources.Touch;
                    port4[1] = '3';
                    port4[2] = '0';
                    label_P4m.Text = "状態(押・離)";
                    btn_P4_reset.Enabled = false;
                    break;
                case "COLOR":
                    numericUpDown_P4m.Maximum = 3;
                    pictureBox_P4.Image = Properties.Resources.Color;
                    port4[1] = '4';
                    port4[2] = '0';
                    label_P4m.Text = "反射光";
                    btn_P4_reset.Enabled = false;
                    break;
                case "HT COLOR":
                    numericUpDown_P4m.Maximum = 1;
                    pictureBox_P4.Image = Properties.Resources.HTColor;
                    port4[1] = '5';
                    port4[2] = '0';
                    label_P4m.Text = "カラー";
                    btn_P4_reset.Enabled = false;
                    break;
            }
            numericUpDown_P4m.Value = 0;
            string s = new string(port4);
            if (serialPort1.IsOpen == true) { serialPort1.Write(s); }
        }

        private void numericUpDown_P4m_ValueChanged(object sender, EventArgs e)
        {
            label_P4.Width = 168;
            label_P4.Location = new Point(174, 413);
            label_P4.Font = new Font(label_P4.Font.FontFamily, 26);
            label_P4.ForeColor = Color.Black;

            switch (comboBox_P4.SelectedItem)
            {
                case "NONE":
                    break;
                case "ULTRA SONIC":
                    if (numericUpDown_P4m.Value == 0)
                    {
                        port4[2] = '0';
                        label_P4m.Text = "距離測定";
                    }
                    else
                    {
                        port4[2] = '1';
                        label_P4m.Text = "超音波信号";
                    }
                    break;
                case "GYRO":
                    if (numericUpDown_P4m.Value == 0)
                    {
                        port4[2] = '0';
                        label_P4m.Text = "角位置";
                    }
                    else
                    {
                        port4[2] = '1';
                        label_P4m.Text = "角速度";
                    }
                    break;
                case "TOUCH":
                    port4[2] = '0';
                    label_P4m.Text = "状態(押・離)";
                    break;
                case "COLOR":
                    if (numericUpDown_P4m.Value == 0)
                    {
                        port4[2] = '0';
                        label_P4m.Text = "反射光";
                    }
                    else if (numericUpDown_P4m.Value == 1)
                    {
                        port4[2] = '1';
                        label_P4m.Text = "周辺光";
                    }
                    else if (numericUpDown_P4m.Value == 2)
                    {
                        port4[2] = '2';
                        label_P4m.Text = "カラー";
                    }
                    else if (numericUpDown_P4m.Value == 3)
                    {
                        port4[2] = '3';
                        label_P4m.Text = "RGB";

                        label_P4.Width = 52;
                        label_P4.Location = new Point(174, 413);
                        label_P4.Font = new Font(label_P4.Font.FontFamily, 12);
                        label_P4.Font = new Font(label_P4.Font, FontStyle.Bold);
                        label_P4.ForeColor = Color.Red;
                    }
                    break;
                case "HT COLOR":
                    if (numericUpDown_P4m.Value == 0)
                    {
                        port4[2] = '0';
                        label_P4m.Text = "カラー";
                    }
                    else
                    {
                        port4[2] = '1';
                        label_P4m.Text = "RGB";

                        label_P4.Width = 52;
                        label_P4.Location = new Point(174, 413);
                        label_P4.Font = new Font(label_P4.Font.FontFamily, 12);
                        label_P4.Font = new Font(label_P4.Font, FontStyle.Bold);
                        label_P4.ForeColor = Color.Red;
                    }
                    break;
            }
            string s = new string(port4);
            if (serialPort1.IsOpen == true) { serialPort1.Write(s); }
        }

        private void comboBox_PA_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_PA.SelectedItem)
            {
                case "NONE":
                    numericUpDown_PAm.Maximum = 0;
                    pictureBox_PA.Image = Properties.Resources.none;
                    portA[1] = '0';
                    portA[2] = '0';
                    label_PAm.Text = "NONE";
                    btn_PA_reset.Enabled = false;
                    break;
                case "L motor":
                    numericUpDown_PAm.Maximum = 1;
                    pictureBox_PA.Image = Properties.Resources.Lmotor;
                    portA[1] = '6';
                    portA[2] = '0';
                    label_PAm.Text = "角位置";
                    btn_PA_reset.Enabled = true;
                    break;
                case "M motor":
                    numericUpDown_PAm.Maximum = 1;
                    pictureBox_PA.Image = Properties.Resources.Mmotor;
                    portA[1] = '7';
                    portA[2] = '0';
                    label_PAm.Text = "角位置";
                    btn_PA_reset.Enabled = true;
                    break;
            }
            numericUpDown_PAm.Value = 0;
            string s = new string(portA);
            if (serialPort1.IsOpen == true) { serialPort1.Write(s); }
        }

        private void numericUpDown_PAm_ValueChanged(object sender, EventArgs e)
        {
            switch (comboBox_PA.SelectedItem)
            {
                case "NONE":
                    break;
                case "L motor":
                    if (numericUpDown_PAm.Value == 0)
                    {
                        portA[2] = '0';
                        label_PAm.Text = "角位置";
                    }
                    else
                    {
                        portA[2] = '1';
                        label_PAm.Text = "パワー";
                    }
                    break;
                case "M motor":
                    if (numericUpDown_PAm.Value == 0)
                    {
                        portA[2] = '0';
                        label_PAm.Text = "角位置";
                    }
                    else
                    {
                        portA[2] = '1';
                        label_PAm.Text = "パワー";
                    }
                    break;
            }
            string s = new string(portA);
            if (serialPort1.IsOpen == true) { serialPort1.Write(s); }
        }

        private void comboBox_PB_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_PB.SelectedItem)
            {
                case "NONE":
                    numericUpDown_PBm.Maximum = 0;
                    pictureBox_PB.Image = Properties.Resources.none;
                    portB[1] = '0';
                    portB[2] = '0';
                    label_PBm.Text = "NONE";
                    btn_PB_reset.Enabled = false;
                    break;
                case "L motor":
                    numericUpDown_PBm.Maximum = 1;
                    pictureBox_PB.Image = Properties.Resources.Lmotor;
                    portB[1] = '6';
                    portB[2] = '0';
                    label_PBm.Text = "角位置";
                    btn_PB_reset.Enabled = true;
                    break;
                case "M motor":
                    numericUpDown_PBm.Maximum = 1;
                    pictureBox_PB.Image = Properties.Resources.Mmotor;
                    portB[1] = '7';
                    portB[2] = '0';
                    label_PBm.Text = "角位置";
                    btn_PB_reset.Enabled = true;
                    break;
            }
            numericUpDown_PBm.Value = 0;
            string s = new string(portB);
            if (serialPort1.IsOpen == true) { serialPort1.Write(s); }
        }

        private void numericUpDown_PBm_ValueChanged(object sender, EventArgs e)
        {
            switch (comboBox_PB.SelectedItem)
            {
                case "NONE":
                    break;
                case "L motor":
                    if (numericUpDown_PBm.Value == 0)
                    {
                        portB[2] = '0';
                        label_PBm.Text = "角位置";
                    }
                    else
                    {
                        portB[2] = '1';
                        label_PBm.Text = "パワー";
                    }
                    break;
                case "M motor":
                    if (numericUpDown_PBm.Value == 0)
                    {
                        portB[2] = '0';
                        label_PBm.Text = "角位置";
                    }
                    else
                    {
                        portB[2] = '1';
                        label_PBm.Text = "パワー";
                    }
                    break;
            }
            string s = new string(portB);
            if (serialPort1.IsOpen == true) { serialPort1.Write(s); }
        }

        private void comboBox_PC_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_PC.SelectedItem)
            {
                case "NONE":
                    numericUpDown_PCm.Maximum = 0;
                    pictureBox_PC.Image = Properties.Resources.none;
                    portC[1] = '0';
                    portC[2] = '0';
                    label_PCm.Text = "NONE";
                    btn_PC_reset.Enabled = false;
                    break;
                case "L motor":
                    numericUpDown_PCm.Maximum = 1;
                    pictureBox_PC.Image = Properties.Resources.Lmotor;
                    portC[1] = '6';
                    portC[2] = '0';
                    label_PCm.Text = "角位置";
                    btn_PC_reset.Enabled = true;
                    break;
                case "M motor":
                    numericUpDown_PCm.Maximum = 1;
                    pictureBox_PC.Image = Properties.Resources.Mmotor;
                    portC[1] = '7';
                    portC[2] = '0';
                    label_PCm.Text = "角位置";
                    btn_PC_reset.Enabled = true;
                    break;
            }
            numericUpDown_PCm.Value = 0;
            string s = new string(portC);
            if (serialPort1.IsOpen == true) { serialPort1.Write(s); }
        }

        private void numericUpDown_PCm_ValueChanged(object sender, EventArgs e)
        {
            switch (comboBox_PC.SelectedItem)
            {
                case "NONE":
                    break;
                case "L motor":
                    if (numericUpDown_PCm.Value == 0)
                    {
                        portC[2] = '0';
                        label_PCm.Text = "角位置";
                    }
                    else
                    {
                        portC[2] = '1';
                        label_PCm.Text = "パワー";
                    }
                    break;
                case "M motor":
                    if (numericUpDown_PBm.Value == 0)
                    {
                        portC[2] = '0';
                        label_PCm.Text = "角位置";
                    }
                    else
                    {
                        portC[2] = '1';
                        label_PCm.Text = "パワー";
                    }
                    break;
            }
            string s = new string(portC);
            if (serialPort1.IsOpen == true) { serialPort1.Write(s); }
        }

        private void comboBox_PD_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_PD.SelectedItem)
            {
                case "NONE":
                    numericUpDown_PDm.Maximum = 0;
                    pictureBox_PD.Image = Properties.Resources.none;
                    portD[1] = '0';
                    portD[2] = '0';
                    label_PDm.Text = "NONE";
                    btn_PD_reset.Enabled = false;
                    break;
                case "L motor":
                    numericUpDown_PDm.Maximum = 1;
                    pictureBox_PD.Image = Properties.Resources.Lmotor;
                    portD[1] = '6';
                    portD[2] = '0';
                    label_PDm.Text = "角位置";
                    btn_PD_reset.Enabled = true;
                    break;
                case "M motor":
                    numericUpDown_PDm.Maximum = 1;
                    pictureBox_PD.Image = Properties.Resources.Mmotor;
                    portD[1] = '7';
                    portD[2] = '0';
                    label_PDm.Text = "角位置";
                    btn_PD_reset.Enabled = true;
                    break;
            }
            numericUpDown_PDm.Value = 0;
            string s = new string(portD);
            if (serialPort1.IsOpen == true) { serialPort1.Write(s); }
        }

        private void numericUpDown_PDm_ValueChanged(object sender, EventArgs e)
        {
            switch (comboBox_PD.SelectedItem)
            {
                case "NONE":
                    break;
                case "L motor":
                    if (numericUpDown_PDm.Value == 0)
                    {
                        portD[2] = '0';
                        label_PDm.Text = "角位置";
                    }
                    else
                    {
                        portD[2] = '1';
                        label_PDm.Text = "パワー";
                    }
                    break;
                case "M motor":
                    if (numericUpDown_PDm.Value == 0)
                    {
                        portD[2] = '0';
                        label_PDm.Text = "角位置";
                    }
                    else
                    {
                        portD[2] = '1';
                        label_PDm.Text = "パワー";
                    }
                    break;
            }
            string s = new string(portD);
            if (serialPort1.IsOpen == true) { serialPort1.Write(s); }
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connected == false)
            {
                serialPort1.BaudRate = 115200;
                serialPort1.Parity = Parity.None;
                serialPort1.DataBits = 8;
                serialPort1.StopBits = StopBits.One;
                serialPort1.Handshake = Handshake.None;
                serialPort1.PortName = COM_Port;
                serialPort1.Encoding = Encoding.UTF8;
                serialPort1.Open();
                timer1.Start();

                if (serialPort1.IsOpen == true)
                {
                    connected = true;
                    btn_connect.BackColor = Color.GreenYellow;
                }
            }
            else
            {
                serialPort1.Close();
                connected = false;
                btn_connect.BackColor = Color.Red;
            }
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write("1");
                started = true;
                btn_end.Enabled = true;
                btn_start.Enabled = false;
            }
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("アプリを終了します。よろしいですか？",
            "確認",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Exclamation,
            MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                //「はい」が選択された時
                this.Close();
                Application.Exit();
            }
            else if (result == DialogResult.No)
            {
                //「いいえ」が選択された時
            }
            else if (result == DialogResult.Cancel)
            {
                //「キャンセル」が選択された時
            }
        }

        private void btn_P1_reset_Click(object sender, EventArgs e)
        {
            char[] reset1 = new char[4] { 'R', '1', '0', '0' };
            switch (comboBox_P1.SelectedItem)
            {
                case "NONE":
                    break;
                case "ULTRA SONIC":
                    break;
                case "GYRO":
                    reset1[2] = 'G';
                    string s = new string(reset1);
                    if (serialPort1.IsOpen == true) { serialPort1.Write(s); }
                    break;
                case "TOUCH":
                    break;
                case "COLOR":
                    break;
                case "HT COLOR":
                    break;
            }
        }

        private void btn_P2_reset_Click(object sender, EventArgs e)
        {
            char[] reset2 = new char[4] { 'R', '2', '0', '0' };
            switch (comboBox_P2.SelectedItem)
            {
                case "NONE":
                    break;
                case "ULTRA SONIC":
                    break;
                case "GYRO":
                    reset2[2] = 'G';
                    string s = new string(reset2);
                    if (serialPort1.IsOpen == true) { serialPort1.Write(s); }
                    break;
                case "TOUCH":
                    break;
                case "COLOR":
                    break;
                case "HT COLOR":
                    break;
            }
        }

        private void btn_P3_reset_Click(object sender, EventArgs e)
        {
            char[] reset3 = new char[4] { 'R', '3', '0', '0' };
            switch (comboBox_P3.SelectedItem)
            {
                case "NONE":
                    break;
                case "ULTRA SONIC":
                    break;
                case "GYRO":
                    reset3[2] = 'G';
                    string s = new string(reset3);
                    if (serialPort1.IsOpen == true) { serialPort1.Write(s); }
                    break;
                case "TOUCH":
                    break;
                case "COLOR":
                    break;
                case "HT COLOR":
                    break;
            }
        }

        private void btn_P4_reset_Click(object sender, EventArgs e)
        {
            char[] reset4 = new char[4] { 'R', '4', '0', '0' };
            switch (comboBox_P4.SelectedItem)
            {
                case "NONE":
                    break;
                case "ULTRA SONIC":
                    break;
                case "GYRO":
                    reset4[2] = 'G';
                    string s = new string(reset4);
                    if (serialPort1.IsOpen == true) { serialPort1.Write(s); }
                    break;
                case "TOUCH":
                    break;
                case "COLOR":
                    break;
                case "HT COLOR":
                    break;
            }
        }

        private void btn_PA_reset_Click(object sender, EventArgs e)
        {
            char[] resetA = new char[4] { 'R', 'A', '0', '0' };
            switch (comboBox_PA.SelectedItem)
            {
                case "NONE":
                    break;
                case "L motor":
                    resetA[2] = 'L';
                    string sL = new string(resetA);
                    if (serialPort1.IsOpen == true) { serialPort1.Write(sL); }
                    break;
                case "M motor":
                    resetA[2] = 'M';
                    string sM = new string(resetA);
                    if (serialPort1.IsOpen == true) { serialPort1.Write(sM); }
                    break;
            }
        }

        private void btn_PB_reset_Click(object sender, EventArgs e)
        {
            char[] resetB = new char[4] { 'R', 'B', '0', '0' };
            switch (comboBox_PB.SelectedItem)
            {
                case "NONE":
                    break;
                case "L motor":
                    resetB[2] = 'L';
                    string sL = new string(resetB);
                    if (serialPort1.IsOpen == true) { serialPort1.Write(sL); }
                    break;
                case "M motor":
                    resetB[2] = 'M';
                    string sM = new string(resetB);
                    if (serialPort1.IsOpen == true) { serialPort1.Write(sM); }
                    break;
            }
        }

        private void btn_PC_reset_Click(object sender, EventArgs e)
        {
            char[] resetC = new char[4] { 'R', 'C', '0', '0' };
            switch (comboBox_PC.SelectedItem)
            {
                case "NONE":
                    break;
                case "L motor":
                    resetC[2] = 'L';
                    string sL = new string(resetC);
                    if (serialPort1.IsOpen == true) { serialPort1.Write(sL); }
                    break;
                case "M motor":
                    resetC[2] = 'M';
                    string sM = new string(resetC);
                    if (serialPort1.IsOpen == true) { serialPort1.Write(sM); }
                    break;
            }
        }

        private void btn_PD_reset_Click(object sender, EventArgs e)
        {
            char[] resetD = new char[4] { 'R', 'D', '0', '0' };
            string s = new string(resetD);
            switch (comboBox_PD.SelectedItem)
            {
                case "NONE":
                    break;
                case "L motor":
                    resetD[2] = 'L';
                    string sL = new string(resetD);
                    if (serialPort1.IsOpen == true) { serialPort1.Write(sL); }
                    break;
                case "M motor":
                    resetD[2] = 'M';
                    string sM = new string(resetD);
                    if (serialPort1.IsOpen == true) { serialPort1.Write(sM); }
                    break;
            }
        }

        private void リセットToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void 送信ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serialPort1.Write(textBox2.Text);
        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write("9999");
                started = false;
                btn_end.Enabled = false;
                btn_start.Enabled = true;
            }
        }

        private void endToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write("9999");
                started = false;
                btn_end.Enabled = false;
                btn_start.Enabled = true;
            }
        }

        private void sendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serialPort1.Write(textBox2.Text);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 環境設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_setting.Show();
        }

        private void btn_record_Click(object sender, EventArgs e)
        {
            if (record == false)
            {
                DialogResult ret;
                System.IO.FileStream FS;

                this.saveFileDialog1.RestoreDirectory = true;
                this.saveFileDialog1.OverwritePrompt = true;
                this.saveFileDialog1.Filter = "csv(*.csv)|*.csv";

                ret = this.saveFileDialog1.ShowDialog();
                if (ret == DialogResult.Cancel)
                {
                    return;
                }


                FS = (System.IO.FileStream)this.saveFileDialog1.OpenFile();

                FS.Close();

                label_Pass.Text = saveFileDialog1.FileName;


                string myPath = this.saveFileDialog1.FileName;

                System.IO.StreamWriter sw = new System.IO.StreamWriter(
                    saveFileDialog1.FileName, false,
                    System.Text.Encoding.GetEncoding("shift_jis"));
                sw.WriteLine("Port1_1,Port1_2,Port1_3,Port2_1,Port2_2,Port2_3,Port3_1,Port3_2,Port3_3,Port4_1,Port4_2,Port4_3,PortA,PortB,PortC,PortD");
                sw.WriteLine(comboBox_P1.SelectedItem.ToString() +", , ,"+
                    comboBox_P2.SelectedItem.ToString() + ", , ," +
                    comboBox_P3.SelectedItem.ToString() + ", , ," +
                    comboBox_P4.SelectedItem.ToString() + ", , ," +
                    comboBox_PA.SelectedItem.ToString() + "," +
                    comboBox_PB.SelectedItem.ToString() + "," +
                    comboBox_PC.SelectedItem.ToString() + "," +
                    comboBox_PD.SelectedItem.ToString());
                sw.WriteLine(label_P1m.Text + ", , ," +
                    label_P2m.Text + ", , ," +
                    label_P3m.Text + ", , ," +
                    label_P4m.Text + ", , ," +
                    label_PAm.Text + "," +
                    label_PBm.Text + "," +
                    label_PCm.Text + "," +
                    label_PDm.Text);
                sw.Close();

                record = true;
                btn_record.BackColor = Color.Red;
            }
            else
            {
                record = false;
                btn_record.BackColor = Color.Gainsboro;
            }
        }

        private void radioControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_setting2.Show();
        }
    }
}
