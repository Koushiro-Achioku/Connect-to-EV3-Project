using System;
using System.IO.Ports;
using System.Timers;

using AppKit;
using Foundation;

namespace ConnecttoEV3forMac
{
    public partial class ViewController : NSViewController
    {
        public static SerialPort port;

        public static Timer aTimer;

        public string data = "            ";
        public bool writed;

        public bool connected = false;

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

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
            port = new SerialPort(); // インスタンス化

            port.PortName = "/dev/tty.MindstormsEV3-SerialPor"; // 通信するポート名
            port.Parity = Parity.None; // パリティ
            port.DataBits = 8; // 送信するデータのビット数 通常は8
            port.BaudRate = 115200; // baud rate
            port.StopBits = StopBits.One; // ストップビットの数
            port.DtrEnable = false; // DTRを用いるか
            port.RtsEnable = false; // RTSを用いるか

            SetTimer();

            Btn_Image_1.Image = NSImage.ImageNamed("none.png");
            Btn_Image_2.Image = NSImage.ImageNamed("none.png");
            Btn_Image_3.Image = NSImage.ImageNamed("none.png");
            Btn_Image_4.Image = NSImage.ImageNamed("none.png");
            Btn_Image_A.Image = NSImage.ImageNamed("none.png");
            Btn_Image_B.Image = NSImage.ImageNamed("none.png");
            Btn_Image_C.Image = NSImage.ImageNamed("none.png");
            Btn_Image_D.Image = NSImage.ImageNamed("none.png");
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

        private void SetTimer()
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(100);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += new ElapsedEventHandler(MyClock);
            aTimer.AutoReset = true;
            aTimer.Enabled = false;
        }

        public void MyClock(object sender, ElapsedEventArgs e)
        {
            this.BeginInvokeOnMainThread((Action)(() => { Check(); }));
            throw new NotImplementedException();
        }

        public void Check()
        {
            if (port.IsOpen == true)
            {
                data = port.ReadLine();
                Console.Write(data);
            }
            Format();
        }

        public int[] motor_zero = new int[4] { 0, 0, 0, 0 };
        public int[] sensor_zero = new int[4] { 0, 0, 0, 0 };

        void Format()
        {
            string[,] get_value = new string[3, 8];
            bool[] next_write = new bool[8] { true, true, true, true, true, true, true, true };

            try
            {
                if (data.Length >= 40)
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
                    if ((get_value[0, 0] == "0") && (get_value[1, 0] == "0") && (get_value[2, 0] == "0") && (sensor_zero[0] < 3))
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
                    if ((get_value[0, 4] == "0") && (motor_zero[0] < 15))
                    {
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
                        Label_1_R.StringValue = get_value[0, 0];
                        Label_1_G.StringValue = get_value[1, 0];
                        Label_1_B.StringValue = get_value[2, 0];
                        sensor_zero[0] = 0;
                    }
                    //Port2書き込み
                    if (next_write[1] == true)
                    {
                        Label_2_R.StringValue = get_value[0, 1];
                        Label_2_G.StringValue = get_value[1, 1];
                        Label_2_B.StringValue = get_value[2, 1];
                        sensor_zero[1] = 0;
                    }
                    //Port3書き込み
                    if (next_write[2] == true)
                    {
                        Label_3_R.StringValue = get_value[0, 1];
                        Label_3_G.StringValue = get_value[1, 1];
                        Label_3_B.StringValue = get_value[2, 1];
                        sensor_zero[2] = 0;
                    }
                    //Port4書き込み
                    if (next_write[3] == true)
                    {
                        Label_4_R.StringValue = get_value[0, 1];
                        Label_4_G.StringValue = get_value[1, 1];
                        Label_4_B.StringValue = get_value[2, 1];
                        sensor_zero[3] = 0;
                    }

                    if (next_write[4] == true)
                    {
                        Label_A_Value.StringValue = get_value[0, 4];
                        motor_zero[0] = 0;
                    }
                    if (next_write[5] == true)
                    {
                        Label_B_Value.StringValue = get_value[0, 5];
                        motor_zero[1] = 0;
                    }
                    if (next_write[6] == true)
                    {
                        Label_C_Value.StringValue = get_value[0, 6];
                        motor_zero[2] = 0;
                    }
                    if (next_write[7] == true)
                    {
                        Label_D_Value.StringValue = get_value[0, 7];
                        motor_zero[3] = 0;
                    }
                }
            }
            catch
            {
                Console.Write("Error1");
            }
        }

        partial void Btn_Connect_Pushed(NSObject sender)
        {
            if (connected == false)
            {
                port.PortName = TextField_portname.StringValue;

                try
                {
                    port.Open(); // ポートをオープン
                    Btn_Connect.Title = "Disconnect";
                    connected = true;
                }
                catch (Exception)
                { // 例外が起きたらとりあえず握り潰してプログラム終了
                  // ポートオープンに失敗した場合
                    Console.WriteLine($"Fail: Port open of {port.PortName}. Application stops.");
                    Environment.Exit(1); // 終了コード1を発行して終了
                }
            }
            else
            {
                if (port.IsOpen == true)
                {
                    port.Close();
                    Btn_Connect.Title = "Connect";
                    connected = false;
                }
            }
        }

        partial void Btn_Start_Pushed(NSObject sender)
        {
            if (port.IsOpen == true)
            {
                port.WriteLine("1");
                port.DiscardInBuffer();
                port.DiscardOutBuffer();
                aTimer.Enabled = true;
            }
        }

        partial void Btn_End_Pushed(NSObject sender)
        {
            if (port.IsOpen == true)
            {
                port.WriteLine("9999");
                aTimer.Enabled = false;
            }
        }

        partial void ComboBox_1_Selected(NSObject sender)
        {
            switch (ComboBox_1.StringValue)
            {
                case "NONE":
                    Stepper_1.MaxValue = 0;
                    Btn_Image_1.Image = NSImage.ImageNamed("none.png");
                    port1[1] = '0';
                    port1[2] = '0';
                    Label_mode_1.StringValue = "none";
                    Btn_Reset_1.Enabled = false;
                    break;
                case "ULTRA SONIC":
                    Stepper_1.MaxValue = 1;
                    Btn_Image_1.Image = NSImage.ImageNamed("Ultrasonic.png");
                    port1[1] = '1';
                    port1[2] = '0';
                    Label_mode_1.StringValue = "距離測定";
                    Btn_Reset_1.Enabled = false;
                    break;
                case "GYRO":
                    Stepper_1.MaxValue = 1;
                    Btn_Image_1.Image = NSImage.ImageNamed("Gyro.png");
                    port1[1] = '2';
                    port1[2] = '0';
                    Label_mode_1.StringValue = "角位置";
                    Btn_Reset_1.Enabled = true;
                    break;
                case "TOUCH":
                    Stepper_1.MaxValue = 0;
                    Btn_Image_1.Image = NSImage.ImageNamed("Touch.png");
                    port1[1] = '3';
                    port1[2] = '0';
                    Label_mode_1.StringValue = "状態(押・離)";
                    Btn_Reset_1.Enabled = false;
                    break;
                case "COLOR":
                    Stepper_1.MaxValue = 3;
                    Btn_Image_1.Image = NSImage.ImageNamed("Color.png");
                    port1[1] = '4';
                    port1[2] = '0';
                    Label_mode_1.StringValue = "反射光";
                    Btn_Reset_1.Enabled = false;
                    break;
                case "HT COLOR":
                    Stepper_1.MaxValue = 1;
                    Btn_Image_1.Image = NSImage.ImageNamed("HTColor.png");
                    port1[1] = '5';
                    port1[2] = '0';
                    Label_mode_1.StringValue = "カラー";
                    Btn_Reset_1.Enabled = false;
                    break;
            }
            Stepper_1.IntValue = 0;
            string s = new string(port1);
            if (port.IsOpen == true) { port.Write(s); }
        }

        partial void Stepper_1_Pushed(NSObject sender)
        {
            switch (ComboBox_1.StringValue)
            {
                case "NONE":
                    break;
                case "ULTRA SONIC":
                    if (Stepper_1.IntValue == 0)
                    {
                        port1[2] = '0';
                        Label_mode_1.StringValue = "距離測定";
                    }
                    else
                    {
                        port1[2] = '1';
                        Label_mode_1.StringValue = "超音波信号";
                    }
                    break;
                case "GYRO":
                    if (Stepper_1.IntValue == 0)
                    {
                        port1[2] = '0';
                        Label_mode_1.StringValue = "角位置";
                    }
                    else
                    {
                        port1[2] = '1';
                        Label_mode_1.StringValue = "角速度";
                    }
                    break;
                case "TOUCH":
                    port1[2] = '0';
                    Label_mode_1.StringValue = "状態(押・離)";
                    break;
                case "COLOR":
                    if (Stepper_1.IntValue == 0)
                    {
                        port1[2] = '0';
                        Label_mode_1.StringValue = "反射光";
                    }
                    else if (Stepper_1.IntValue == 1)
                    {
                        port1[2] = '1';
                        Label_mode_1.StringValue = "周辺光";
                    }
                    else if (Stepper_1.IntValue == 2)
                    {
                        port1[2] = '2';
                        Label_mode_1.StringValue = "カラー";
                    }
                    else if (Stepper_1.IntValue == 3)
                    {
                        port1[2] = '3';
                        Label_mode_1.StringValue = "RGB";
                    }
                    break;
                case "HT COLOR":
                    if (Stepper_1.IntValue == 0)
                    {
                        port1[2] = '0';
                        Label_mode_1.StringValue = "カラー";
                    }
                    else
                    {
                        port1[2] = '1';
                        Label_mode_1.StringValue = "RGB";
                    }
                    break;
            }
            string s = new string(port1);
            if (port.IsOpen == true) { port.Write(s); }
        }

    }
}
