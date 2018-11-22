namespace Connect_to_EV3
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBox_COM = new System.Windows.Forms.ComboBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_P1 = new System.Windows.Forms.Label();
            this.numericUpDown_P1m = new System.Windows.Forms.NumericUpDown();
            this.comboBox_P1 = new System.Windows.Forms.ComboBox();
            this.label_P1m = new System.Windows.Forms.Label();
            this.label_P2m = new System.Windows.Forms.Label();
            this.numericUpDown_P2m = new System.Windows.Forms.NumericUpDown();
            this.label_P2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_P2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label_P4m = new System.Windows.Forms.Label();
            this.numericUpDown_P4m = new System.Windows.Forms.NumericUpDown();
            this.label_P4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_P4 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label_P3m = new System.Windows.Forms.Label();
            this.numericUpDown_P3m = new System.Windows.Forms.NumericUpDown();
            this.label_P3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox_P3 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.環境設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.コンソールToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.リセットToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.コマンドToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_PDm = new System.Windows.Forms.Label();
            this.numericUpDown_PDm = new System.Windows.Forms.NumericUpDown();
            this.label_PD = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.comboBox_PD = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label_PCm = new System.Windows.Forms.Label();
            this.numericUpDown_PCm = new System.Windows.Forms.NumericUpDown();
            this.label_PC = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.comboBox_PC = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label_PBm = new System.Windows.Forms.Label();
            this.numericUpDown_PBm = new System.Windows.Forms.NumericUpDown();
            this.label_PB = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.comboBox_PB = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label_PAm = new System.Windows.Forms.Label();
            this.numericUpDown_PAm = new System.Windows.Forms.NumericUpDown();
            this.label_PA = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.comboBox_PA = new System.Windows.Forms.ComboBox();
            this.label36 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label_P1_2 = new System.Windows.Forms.Label();
            this.label_P1_3 = new System.Windows.Forms.Label();
            this.label_P2_3 = new System.Windows.Forms.Label();
            this.label_P2_2 = new System.Windows.Forms.Label();
            this.label_P3_3 = new System.Windows.Forms.Label();
            this.label_P3_2 = new System.Windows.Forms.Label();
            this.label_P4_3 = new System.Windows.Forms.Label();
            this.label_P4_2 = new System.Windows.Forms.Label();
            this.btn_P1_reset = new System.Windows.Forms.Button();
            this.btn_PA_reset = new System.Windows.Forms.Button();
            this.btn_PB_reset = new System.Windows.Forms.Button();
            this.btn_P2_reset = new System.Windows.Forms.Button();
            this.btn_PC_reset = new System.Windows.Forms.Button();
            this.btn_P3_reset = new System.Windows.Forms.Button();
            this.btn_PD_reset = new System.Windows.Forms.Button();
            this.btn_P4_reset = new System.Windows.Forms.Button();
            this.btn_end = new System.Windows.Forms.Button();
            this.pictureBox_PD = new System.Windows.Forms.PictureBox();
            this.pictureBox_P4 = new System.Windows.Forms.PictureBox();
            this.pictureBox_PC = new System.Windows.Forms.PictureBox();
            this.pictureBox_P3 = new System.Windows.Forms.PictureBox();
            this.pictureBox_PB = new System.Windows.Forms.PictureBox();
            this.pictureBox_P2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_PA = new System.Windows.Forms.PictureBox();
            this.pictureBox_P1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_P1m)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_P2m)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_P4m)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_P3m)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PDm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PCm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PBm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PAm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_P4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_P3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_P2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_P1)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // btn_connect
            // 
            this.btn_connect.BackColor = System.Drawing.Color.Red;
            this.btn_connect.ForeColor = System.Drawing.Color.Black;
            this.btn_connect.Location = new System.Drawing.Point(12, 27);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 23);
            this.btn_connect.TabIndex = 0;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = false;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(93, 27);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Location = new System.Drawing.Point(12, 498);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(373, 117);
            this.textBox1.TabIndex = 2;
            this.textBox1.MouseEnter += new System.EventHandler(this.textBox1_MouseEnter);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comboBox_COM
            // 
            this.comboBox_COM.FormattingEnabled = true;
            this.comboBox_COM.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15",
            "COM16",
            "COM17",
            "COM18",
            "COM19",
            "COM20",
            "COM21",
            "COM22",
            "COM23",
            "COM24",
            "COM25",
            "COM40"});
            this.comboBox_COM.Location = new System.Drawing.Point(255, 27);
            this.comboBox_COM.Name = "comboBox_COM";
            this.comboBox_COM.Size = new System.Drawing.Size(121, 20);
            this.comboBox_COM.TabIndex = 3;
            this.comboBox_COM.SelectedIndexChanged += new System.EventHandler(this.comboBox_COM_SelectedIndexChanged);
            // 
            // btn_send
            // 
            this.btn_send.Enabled = false;
            this.btn_send.Location = new System.Drawing.Point(382, 27);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 4;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "sensor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "mode";
            // 
            // label_P1
            // 
            this.label_P1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_P1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_P1.ForeColor = System.Drawing.Color.Red;
            this.label_P1.Location = new System.Drawing.Point(178, 107);
            this.label_P1.Name = "label_P1";
            this.label_P1.Size = new System.Drawing.Size(48, 38);
            this.label_P1.TabIndex = 10;
            this.label_P1.Text = "0";
            this.label_P1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericUpDown_P1m
            // 
            this.numericUpDown_P1m.Location = new System.Drawing.Point(174, 84);
            this.numericUpDown_P1m.Name = "numericUpDown_P1m";
            this.numericUpDown_P1m.Size = new System.Drawing.Size(48, 19);
            this.numericUpDown_P1m.TabIndex = 11;
            this.numericUpDown_P1m.ValueChanged += new System.EventHandler(this.numericUpDown_P1m_ValueChanged);
            // 
            // comboBox_P1
            // 
            this.comboBox_P1.FormattingEnabled = true;
            this.comboBox_P1.Items.AddRange(new object[] {
            "NONE",
            "ULTRA SONIC",
            "GYRO",
            "TOUCH",
            "COLOR",
            "HT COLOR"});
            this.comboBox_P1.Location = new System.Drawing.Point(174, 58);
            this.comboBox_P1.Name = "comboBox_P1";
            this.comboBox_P1.Size = new System.Drawing.Size(164, 20);
            this.comboBox_P1.TabIndex = 6;
            this.comboBox_P1.SelectedIndexChanged += new System.EventHandler(this.comboBox_P1_SelectedIndexChanged);
            // 
            // label_P1m
            // 
            this.label_P1m.AutoSize = true;
            this.label_P1m.Location = new System.Drawing.Point(228, 86);
            this.label_P1m.Name = "label_P1m";
            this.label_P1m.Size = new System.Drawing.Size(36, 12);
            this.label_P1m.TabIndex = 12;
            this.label_P1m.Text = "NONE";
            // 
            // label_P2m
            // 
            this.label_P2m.AutoSize = true;
            this.label_P2m.Location = new System.Drawing.Point(228, 188);
            this.label_P2m.Name = "label_P2m";
            this.label_P2m.Size = new System.Drawing.Size(36, 12);
            this.label_P2m.TabIndex = 19;
            this.label_P2m.Text = "NONE";
            // 
            // numericUpDown_P2m
            // 
            this.numericUpDown_P2m.Location = new System.Drawing.Point(174, 186);
            this.numericUpDown_P2m.Name = "numericUpDown_P2m";
            this.numericUpDown_P2m.Size = new System.Drawing.Size(48, 19);
            this.numericUpDown_P2m.TabIndex = 18;
            this.numericUpDown_P2m.ValueChanged += new System.EventHandler(this.numericUpDown_P2m_ValueChanged);
            // 
            // label_P2
            // 
            this.label_P2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_P2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_P2.ForeColor = System.Drawing.Color.Red;
            this.label_P2.Location = new System.Drawing.Point(178, 209);
            this.label_P2.Name = "label_P2";
            this.label_P2.Size = new System.Drawing.Size(48, 38);
            this.label_P2.TabIndex = 17;
            this.label_P2.Text = "0";
            this.label_P2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "mode";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(129, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "sensor";
            // 
            // comboBox_P2
            // 
            this.comboBox_P2.FormattingEnabled = true;
            this.comboBox_P2.Items.AddRange(new object[] {
            "NONE",
            "ULTRA SONIC",
            "GYRO",
            "TOUCH",
            "COLOR",
            "HT COLOR"});
            this.comboBox_P2.Location = new System.Drawing.Point(174, 160);
            this.comboBox_P2.Name = "comboBox_P2";
            this.comboBox_P2.Size = new System.Drawing.Size(164, 20);
            this.comboBox_P2.TabIndex = 14;
            this.comboBox_P2.SelectedIndexChanged += new System.EventHandler(this.comboBox_P2_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(12, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 26);
            this.label8.TabIndex = 13;
            this.label8.Text = "2";
            // 
            // label_P4m
            // 
            this.label_P4m.AutoSize = true;
            this.label_P4m.Location = new System.Drawing.Point(228, 392);
            this.label_P4m.Name = "label_P4m";
            this.label_P4m.Size = new System.Drawing.Size(36, 12);
            this.label_P4m.TabIndex = 33;
            this.label_P4m.Text = "NONE";
            // 
            // numericUpDown_P4m
            // 
            this.numericUpDown_P4m.Location = new System.Drawing.Point(174, 390);
            this.numericUpDown_P4m.Name = "numericUpDown_P4m";
            this.numericUpDown_P4m.Size = new System.Drawing.Size(48, 19);
            this.numericUpDown_P4m.TabIndex = 32;
            this.numericUpDown_P4m.ValueChanged += new System.EventHandler(this.numericUpDown_P4m_ValueChanged);
            // 
            // label_P4
            // 
            this.label_P4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_P4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_P4.ForeColor = System.Drawing.Color.Red;
            this.label_P4.Location = new System.Drawing.Point(178, 413);
            this.label_P4.Name = "label_P4";
            this.label_P4.Size = new System.Drawing.Size(48, 38);
            this.label_P4.TabIndex = 31;
            this.label_P4.Text = "0";
            this.label_P4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(129, 393);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 12);
            this.label9.TabIndex = 30;
            this.label9.Text = "mode";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(129, 367);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 12);
            this.label10.TabIndex = 29;
            this.label10.Text = "sensor";
            // 
            // comboBox_P4
            // 
            this.comboBox_P4.FormattingEnabled = true;
            this.comboBox_P4.Items.AddRange(new object[] {
            "NONE",
            "ULTRA SONIC",
            "GYRO",
            "TOUCH",
            "COLOR",
            "HT COLOR"});
            this.comboBox_P4.Location = new System.Drawing.Point(174, 364);
            this.comboBox_P4.Name = "comboBox_P4";
            this.comboBox_P4.Size = new System.Drawing.Size(164, 20);
            this.comboBox_P4.TabIndex = 28;
            this.comboBox_P4.SelectedIndexChanged += new System.EventHandler(this.comboBox_P4_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(12, 364);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 26);
            this.label11.TabIndex = 27;
            this.label11.Text = "4";
            // 
            // label_P3m
            // 
            this.label_P3m.AutoSize = true;
            this.label_P3m.Location = new System.Drawing.Point(228, 290);
            this.label_P3m.Name = "label_P3m";
            this.label_P3m.Size = new System.Drawing.Size(36, 12);
            this.label_P3m.TabIndex = 26;
            this.label_P3m.Text = "NONE";
            // 
            // numericUpDown_P3m
            // 
            this.numericUpDown_P3m.Location = new System.Drawing.Point(174, 288);
            this.numericUpDown_P3m.Name = "numericUpDown_P3m";
            this.numericUpDown_P3m.Size = new System.Drawing.Size(48, 19);
            this.numericUpDown_P3m.TabIndex = 25;
            this.numericUpDown_P3m.ValueChanged += new System.EventHandler(this.numericUpDown_P3m_ValueChanged);
            // 
            // label_P3
            // 
            this.label_P3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_P3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_P3.ForeColor = System.Drawing.Color.Red;
            this.label_P3.Location = new System.Drawing.Point(178, 311);
            this.label_P3.Name = "label_P3";
            this.label_P3.Size = new System.Drawing.Size(48, 38);
            this.label_P3.TabIndex = 24;
            this.label_P3.Text = "0";
            this.label_P3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(129, 291);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 12);
            this.label14.TabIndex = 23;
            this.label14.Text = "mode";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(129, 265);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 12);
            this.label15.TabIndex = 22;
            this.label15.Text = "sensor";
            // 
            // comboBox_P3
            // 
            this.comboBox_P3.FormattingEnabled = true;
            this.comboBox_P3.Items.AddRange(new object[] {
            "NONE",
            "ULTRA SONIC",
            "GYRO",
            "TOUCH",
            "COLOR",
            "HT COLOR"});
            this.comboBox_P3.Location = new System.Drawing.Point(174, 262);
            this.comboBox_P3.Name = "comboBox_P3";
            this.comboBox_P3.Size = new System.Drawing.Size(164, 20);
            this.comboBox_P3.TabIndex = 21;
            this.comboBox_P3.SelectedIndexChanged += new System.EventHandler(this.comboBox_P3_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label16.Location = new System.Drawing.Point(12, 262);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 26);
            this.label16.TabIndex = 20;
            this.label16.Text = "3";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.コンソールToolStripMenuItem,
            this.コマンドToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(852, 24);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.startToolStripMenuItem,
            this.endToolStripMenuItem,
            this.環境設定ToolStripMenuItem,
            this.終了ToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // endToolStripMenuItem
            // 
            this.endToolStripMenuItem.Name = "endToolStripMenuItem";
            this.endToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.endToolStripMenuItem.Text = "end";
            this.endToolStripMenuItem.Click += new System.EventHandler(this.endToolStripMenuItem_Click);
            // 
            // 環境設定ToolStripMenuItem
            // 
            this.環境設定ToolStripMenuItem.Name = "環境設定ToolStripMenuItem";
            this.環境設定ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.環境設定ToolStripMenuItem.Text = "環境設定";
            this.環境設定ToolStripMenuItem.Click += new System.EventHandler(this.環境設定ToolStripMenuItem_Click);
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.終了ToolStripMenuItem.Text = "終了";
            this.終了ToolStripMenuItem.Click += new System.EventHandler(this.終了ToolStripMenuItem_Click);
            // 
            // コンソールToolStripMenuItem
            // 
            this.コンソールToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.リセットToolStripMenuItem});
            this.コンソールToolStripMenuItem.Name = "コンソールToolStripMenuItem";
            this.コンソールToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.コンソールToolStripMenuItem.Text = "コンソール";
            // 
            // リセットToolStripMenuItem
            // 
            this.リセットToolStripMenuItem.Name = "リセットToolStripMenuItem";
            this.リセットToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.リセットToolStripMenuItem.Text = "リセット";
            this.リセットToolStripMenuItem.Click += new System.EventHandler(this.リセットToolStripMenuItem_Click);
            // 
            // コマンドToolStripMenuItem
            // 
            this.コマンドToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendToolStripMenuItem});
            this.コマンドToolStripMenuItem.Name = "コマンドToolStripMenuItem";
            this.コマンドToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.コマンドToolStripMenuItem.Text = "コマンド";
            // 
            // sendToolStripMenuItem
            // 
            this.sendToolStripMenuItem.Enabled = false;
            this.sendToolStripMenuItem.Name = "sendToolStripMenuItem";
            this.sendToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sendToolStripMenuItem.Text = "Send";
            this.sendToolStripMenuItem.Click += new System.EventHandler(this.sendToolStripMenuItem_Click);
            // 
            // label_PDm
            // 
            this.label_PDm.AutoSize = true;
            this.label_PDm.Location = new System.Drawing.Point(641, 392);
            this.label_PDm.Name = "label_PDm";
            this.label_PDm.Size = new System.Drawing.Size(36, 12);
            this.label_PDm.TabIndex = 62;
            this.label_PDm.Text = "NONE";
            // 
            // numericUpDown_PDm
            // 
            this.numericUpDown_PDm.Location = new System.Drawing.Point(587, 390);
            this.numericUpDown_PDm.Name = "numericUpDown_PDm";
            this.numericUpDown_PDm.Size = new System.Drawing.Size(48, 19);
            this.numericUpDown_PDm.TabIndex = 61;
            this.numericUpDown_PDm.ValueChanged += new System.EventHandler(this.numericUpDown_PDm_ValueChanged);
            // 
            // label_PD
            // 
            this.label_PD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_PD.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_PD.Location = new System.Drawing.Point(587, 413);
            this.label_PD.Name = "label_PD";
            this.label_PD.Size = new System.Drawing.Size(164, 38);
            this.label_PD.TabIndex = 60;
            this.label_PD.Text = "0";
            this.label_PD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(542, 393);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(32, 12);
            this.label19.TabIndex = 59;
            this.label19.Text = "mode";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(542, 367);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(39, 12);
            this.label20.TabIndex = 58;
            this.label20.Text = "sensor";
            // 
            // comboBox_PD
            // 
            this.comboBox_PD.FormattingEnabled = true;
            this.comboBox_PD.Items.AddRange(new object[] {
            "NONE",
            "L motor",
            "M motor"});
            this.comboBox_PD.Location = new System.Drawing.Point(587, 364);
            this.comboBox_PD.Name = "comboBox_PD";
            this.comboBox_PD.Size = new System.Drawing.Size(164, 20);
            this.comboBox_PD.TabIndex = 57;
            this.comboBox_PD.SelectedIndexChanged += new System.EventHandler(this.comboBox_PD_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label21.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label21.Location = new System.Drawing.Point(425, 364);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(28, 26);
            this.label21.TabIndex = 56;
            this.label21.Text = "D";
            // 
            // label_PCm
            // 
            this.label_PCm.AutoSize = true;
            this.label_PCm.Location = new System.Drawing.Point(641, 290);
            this.label_PCm.Name = "label_PCm";
            this.label_PCm.Size = new System.Drawing.Size(36, 12);
            this.label_PCm.TabIndex = 55;
            this.label_PCm.Text = "NONE";
            // 
            // numericUpDown_PCm
            // 
            this.numericUpDown_PCm.Location = new System.Drawing.Point(587, 288);
            this.numericUpDown_PCm.Name = "numericUpDown_PCm";
            this.numericUpDown_PCm.Size = new System.Drawing.Size(48, 19);
            this.numericUpDown_PCm.TabIndex = 54;
            this.numericUpDown_PCm.ValueChanged += new System.EventHandler(this.numericUpDown_PCm_ValueChanged);
            // 
            // label_PC
            // 
            this.label_PC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_PC.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_PC.Location = new System.Drawing.Point(587, 311);
            this.label_PC.Name = "label_PC";
            this.label_PC.Size = new System.Drawing.Size(164, 38);
            this.label_PC.TabIndex = 53;
            this.label_PC.Text = "0";
            this.label_PC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(542, 291);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(32, 12);
            this.label24.TabIndex = 52;
            this.label24.Text = "mode";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(542, 265);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(39, 12);
            this.label25.TabIndex = 51;
            this.label25.Text = "sensor";
            // 
            // comboBox_PC
            // 
            this.comboBox_PC.FormattingEnabled = true;
            this.comboBox_PC.Items.AddRange(new object[] {
            "NONE",
            "L motor",
            "M motor"});
            this.comboBox_PC.Location = new System.Drawing.Point(587, 262);
            this.comboBox_PC.Name = "comboBox_PC";
            this.comboBox_PC.Size = new System.Drawing.Size(164, 20);
            this.comboBox_PC.TabIndex = 50;
            this.comboBox_PC.SelectedIndexChanged += new System.EventHandler(this.comboBox_PC_SelectedIndexChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label26.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label26.Location = new System.Drawing.Point(425, 262);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(28, 26);
            this.label26.TabIndex = 49;
            this.label26.Text = "C";
            // 
            // label_PBm
            // 
            this.label_PBm.AutoSize = true;
            this.label_PBm.Location = new System.Drawing.Point(641, 188);
            this.label_PBm.Name = "label_PBm";
            this.label_PBm.Size = new System.Drawing.Size(36, 12);
            this.label_PBm.TabIndex = 48;
            this.label_PBm.Text = "NONE";
            // 
            // numericUpDown_PBm
            // 
            this.numericUpDown_PBm.Location = new System.Drawing.Point(587, 186);
            this.numericUpDown_PBm.Name = "numericUpDown_PBm";
            this.numericUpDown_PBm.Size = new System.Drawing.Size(48, 19);
            this.numericUpDown_PBm.TabIndex = 47;
            this.numericUpDown_PBm.ValueChanged += new System.EventHandler(this.numericUpDown_PBm_ValueChanged);
            // 
            // label_PB
            // 
            this.label_PB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_PB.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_PB.Location = new System.Drawing.Point(587, 209);
            this.label_PB.Name = "label_PB";
            this.label_PB.Size = new System.Drawing.Size(164, 38);
            this.label_PB.TabIndex = 46;
            this.label_PB.Text = "0";
            this.label_PB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(542, 189);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(32, 12);
            this.label29.TabIndex = 45;
            this.label29.Text = "mode";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(542, 163);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(39, 12);
            this.label30.TabIndex = 44;
            this.label30.Text = "sensor";
            // 
            // comboBox_PB
            // 
            this.comboBox_PB.FormattingEnabled = true;
            this.comboBox_PB.Items.AddRange(new object[] {
            "NONE",
            "L motor",
            "M motor"});
            this.comboBox_PB.Location = new System.Drawing.Point(587, 160);
            this.comboBox_PB.Name = "comboBox_PB";
            this.comboBox_PB.Size = new System.Drawing.Size(164, 20);
            this.comboBox_PB.TabIndex = 43;
            this.comboBox_PB.SelectedIndexChanged += new System.EventHandler(this.comboBox_PB_SelectedIndexChanged);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label31.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label31.Location = new System.Drawing.Point(425, 160);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(27, 26);
            this.label31.TabIndex = 42;
            this.label31.Text = "B";
            // 
            // label_PAm
            // 
            this.label_PAm.AutoSize = true;
            this.label_PAm.Location = new System.Drawing.Point(641, 86);
            this.label_PAm.Name = "label_PAm";
            this.label_PAm.Size = new System.Drawing.Size(36, 12);
            this.label_PAm.TabIndex = 41;
            this.label_PAm.Text = "NONE";
            // 
            // numericUpDown_PAm
            // 
            this.numericUpDown_PAm.Location = new System.Drawing.Point(587, 84);
            this.numericUpDown_PAm.Name = "numericUpDown_PAm";
            this.numericUpDown_PAm.Size = new System.Drawing.Size(48, 19);
            this.numericUpDown_PAm.TabIndex = 40;
            this.numericUpDown_PAm.ValueChanged += new System.EventHandler(this.numericUpDown_PAm_ValueChanged);
            // 
            // label_PA
            // 
            this.label_PA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_PA.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_PA.Location = new System.Drawing.Point(587, 107);
            this.label_PA.Name = "label_PA";
            this.label_PA.Size = new System.Drawing.Size(164, 38);
            this.label_PA.TabIndex = 39;
            this.label_PA.Text = "0";
            this.label_PA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(542, 87);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(32, 12);
            this.label34.TabIndex = 38;
            this.label34.Text = "mode";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(542, 61);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(39, 12);
            this.label35.TabIndex = 37;
            this.label35.Text = "sensor";
            // 
            // comboBox_PA
            // 
            this.comboBox_PA.FormattingEnabled = true;
            this.comboBox_PA.Items.AddRange(new object[] {
            "NONE",
            "L motor",
            "M motor"});
            this.comboBox_PA.Location = new System.Drawing.Point(587, 58);
            this.comboBox_PA.Name = "comboBox_PA";
            this.comboBox_PA.Size = new System.Drawing.Size(164, 20);
            this.comboBox_PA.TabIndex = 36;
            this.comboBox_PA.SelectedIndexChanged += new System.EventHandler(this.comboBox_PA_SelectedIndexChanged);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label36.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label36.Location = new System.Drawing.Point(425, 58);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(27, 26);
            this.label36.TabIndex = 35;
            this.label36.Text = "A";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(328, 479);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(55, 16);
            this.checkBox1.TabIndex = 63;
            this.checkBox1.Text = "Focus";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.AllowDrop = true;
            this.textBox2.Location = new System.Drawing.Point(391, 498);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(373, 117);
            this.textBox2.TabIndex = 72;
            // 
            // label_P1_2
            // 
            this.label_P1_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_P1_2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_P1_2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label_P1_2.Location = new System.Drawing.Point(232, 107);
            this.label_P1_2.Name = "label_P1_2";
            this.label_P1_2.Size = new System.Drawing.Size(52, 38);
            this.label_P1_2.TabIndex = 73;
            this.label_P1_2.Text = "0";
            this.label_P1_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_P1_3
            // 
            this.label_P1_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_P1_3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_P1_3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label_P1_3.Location = new System.Drawing.Point(290, 107);
            this.label_P1_3.Name = "label_P1_3";
            this.label_P1_3.Size = new System.Drawing.Size(52, 38);
            this.label_P1_3.TabIndex = 74;
            this.label_P1_3.Text = "0";
            this.label_P1_3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_P2_3
            // 
            this.label_P2_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_P2_3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_P2_3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label_P2_3.Location = new System.Drawing.Point(290, 209);
            this.label_P2_3.Name = "label_P2_3";
            this.label_P2_3.Size = new System.Drawing.Size(52, 38);
            this.label_P2_3.TabIndex = 76;
            this.label_P2_3.Text = "0";
            this.label_P2_3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_P2_2
            // 
            this.label_P2_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_P2_2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_P2_2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label_P2_2.Location = new System.Drawing.Point(232, 209);
            this.label_P2_2.Name = "label_P2_2";
            this.label_P2_2.Size = new System.Drawing.Size(52, 38);
            this.label_P2_2.TabIndex = 75;
            this.label_P2_2.Text = "0";
            this.label_P2_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_P3_3
            // 
            this.label_P3_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_P3_3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_P3_3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label_P3_3.Location = new System.Drawing.Point(290, 311);
            this.label_P3_3.Name = "label_P3_3";
            this.label_P3_3.Size = new System.Drawing.Size(52, 38);
            this.label_P3_3.TabIndex = 78;
            this.label_P3_3.Text = "0";
            this.label_P3_3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_P3_2
            // 
            this.label_P3_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_P3_2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_P3_2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label_P3_2.Location = new System.Drawing.Point(232, 311);
            this.label_P3_2.Name = "label_P3_2";
            this.label_P3_2.Size = new System.Drawing.Size(52, 38);
            this.label_P3_2.TabIndex = 77;
            this.label_P3_2.Text = "0";
            this.label_P3_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_P4_3
            // 
            this.label_P4_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_P4_3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_P4_3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label_P4_3.Location = new System.Drawing.Point(290, 413);
            this.label_P4_3.Name = "label_P4_3";
            this.label_P4_3.Size = new System.Drawing.Size(52, 38);
            this.label_P4_3.TabIndex = 80;
            this.label_P4_3.Text = "0";
            this.label_P4_3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_P4_2
            // 
            this.label_P4_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_P4_2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_P4_2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label_P4_2.Location = new System.Drawing.Point(232, 413);
            this.label_P4_2.Name = "label_P4_2";
            this.label_P4_2.Size = new System.Drawing.Size(52, 38);
            this.label_P4_2.TabIndex = 79;
            this.label_P4_2.Text = "0";
            this.label_P4_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_P1_reset
            // 
            this.btn_P1_reset.Location = new System.Drawing.Point(344, 56);
            this.btn_P1_reset.Name = "btn_P1_reset";
            this.btn_P1_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_P1_reset.TabIndex = 81;
            this.btn_P1_reset.Text = "Reset";
            this.btn_P1_reset.UseVisualStyleBackColor = true;
            this.btn_P1_reset.Click += new System.EventHandler(this.btn_P1_reset_Click);
            // 
            // btn_PA_reset
            // 
            this.btn_PA_reset.Location = new System.Drawing.Point(757, 56);
            this.btn_PA_reset.Name = "btn_PA_reset";
            this.btn_PA_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_PA_reset.TabIndex = 82;
            this.btn_PA_reset.Text = "Reset";
            this.btn_PA_reset.UseVisualStyleBackColor = true;
            this.btn_PA_reset.Click += new System.EventHandler(this.btn_PA_reset_Click);
            // 
            // btn_PB_reset
            // 
            this.btn_PB_reset.Location = new System.Drawing.Point(757, 158);
            this.btn_PB_reset.Name = "btn_PB_reset";
            this.btn_PB_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_PB_reset.TabIndex = 84;
            this.btn_PB_reset.Text = "Reset";
            this.btn_PB_reset.UseVisualStyleBackColor = true;
            this.btn_PB_reset.Click += new System.EventHandler(this.btn_PB_reset_Click);
            // 
            // btn_P2_reset
            // 
            this.btn_P2_reset.Location = new System.Drawing.Point(344, 158);
            this.btn_P2_reset.Name = "btn_P2_reset";
            this.btn_P2_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_P2_reset.TabIndex = 83;
            this.btn_P2_reset.Text = "Reset";
            this.btn_P2_reset.UseVisualStyleBackColor = true;
            this.btn_P2_reset.Click += new System.EventHandler(this.btn_P2_reset_Click);
            // 
            // btn_PC_reset
            // 
            this.btn_PC_reset.Location = new System.Drawing.Point(757, 260);
            this.btn_PC_reset.Name = "btn_PC_reset";
            this.btn_PC_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_PC_reset.TabIndex = 86;
            this.btn_PC_reset.Text = "Reset";
            this.btn_PC_reset.UseVisualStyleBackColor = true;
            this.btn_PC_reset.Click += new System.EventHandler(this.btn_PC_reset_Click);
            // 
            // btn_P3_reset
            // 
            this.btn_P3_reset.Location = new System.Drawing.Point(344, 260);
            this.btn_P3_reset.Name = "btn_P3_reset";
            this.btn_P3_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_P3_reset.TabIndex = 85;
            this.btn_P3_reset.Text = "Reset";
            this.btn_P3_reset.UseVisualStyleBackColor = true;
            this.btn_P3_reset.Click += new System.EventHandler(this.btn_P3_reset_Click);
            // 
            // btn_PD_reset
            // 
            this.btn_PD_reset.Location = new System.Drawing.Point(757, 362);
            this.btn_PD_reset.Name = "btn_PD_reset";
            this.btn_PD_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_PD_reset.TabIndex = 88;
            this.btn_PD_reset.Text = "Reset";
            this.btn_PD_reset.UseVisualStyleBackColor = true;
            this.btn_PD_reset.Click += new System.EventHandler(this.btn_PD_reset_Click);
            // 
            // btn_P4_reset
            // 
            this.btn_P4_reset.Location = new System.Drawing.Point(344, 362);
            this.btn_P4_reset.Name = "btn_P4_reset";
            this.btn_P4_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_P4_reset.TabIndex = 87;
            this.btn_P4_reset.Text = "Reset";
            this.btn_P4_reset.UseVisualStyleBackColor = true;
            this.btn_P4_reset.Click += new System.EventHandler(this.btn_P4_reset_Click);
            // 
            // btn_end
            // 
            this.btn_end.Location = new System.Drawing.Point(174, 27);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(75, 23);
            this.btn_end.TabIndex = 90;
            this.btn_end.Text = "End";
            this.btn_end.UseVisualStyleBackColor = true;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // pictureBox_PD
            // 
            this.pictureBox_PD.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_PD.Image")));
            this.pictureBox_PD.Location = new System.Drawing.Point(425, 394);
            this.pictureBox_PD.Name = "pictureBox_PD";
            this.pictureBox_PD.Size = new System.Drawing.Size(111, 57);
            this.pictureBox_PD.TabIndex = 71;
            this.pictureBox_PD.TabStop = false;
            // 
            // pictureBox_P4
            // 
            this.pictureBox_P4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_P4.Image")));
            this.pictureBox_P4.Location = new System.Drawing.Point(12, 394);
            this.pictureBox_P4.Name = "pictureBox_P4";
            this.pictureBox_P4.Size = new System.Drawing.Size(111, 57);
            this.pictureBox_P4.TabIndex = 70;
            this.pictureBox_P4.TabStop = false;
            // 
            // pictureBox_PC
            // 
            this.pictureBox_PC.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_PC.Image")));
            this.pictureBox_PC.Location = new System.Drawing.Point(425, 292);
            this.pictureBox_PC.Name = "pictureBox_PC";
            this.pictureBox_PC.Size = new System.Drawing.Size(111, 57);
            this.pictureBox_PC.TabIndex = 69;
            this.pictureBox_PC.TabStop = false;
            // 
            // pictureBox_P3
            // 
            this.pictureBox_P3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_P3.Image")));
            this.pictureBox_P3.Location = new System.Drawing.Point(12, 292);
            this.pictureBox_P3.Name = "pictureBox_P3";
            this.pictureBox_P3.Size = new System.Drawing.Size(111, 57);
            this.pictureBox_P3.TabIndex = 68;
            this.pictureBox_P3.TabStop = false;
            // 
            // pictureBox_PB
            // 
            this.pictureBox_PB.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_PB.Image")));
            this.pictureBox_PB.Location = new System.Drawing.Point(425, 190);
            this.pictureBox_PB.Name = "pictureBox_PB";
            this.pictureBox_PB.Size = new System.Drawing.Size(111, 57);
            this.pictureBox_PB.TabIndex = 67;
            this.pictureBox_PB.TabStop = false;
            // 
            // pictureBox_P2
            // 
            this.pictureBox_P2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_P2.Image")));
            this.pictureBox_P2.Location = new System.Drawing.Point(12, 190);
            this.pictureBox_P2.Name = "pictureBox_P2";
            this.pictureBox_P2.Size = new System.Drawing.Size(111, 57);
            this.pictureBox_P2.TabIndex = 66;
            this.pictureBox_P2.TabStop = false;
            // 
            // pictureBox_PA
            // 
            this.pictureBox_PA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_PA.Image")));
            this.pictureBox_PA.Location = new System.Drawing.Point(425, 88);
            this.pictureBox_PA.Name = "pictureBox_PA";
            this.pictureBox_PA.Size = new System.Drawing.Size(111, 57);
            this.pictureBox_PA.TabIndex = 65;
            this.pictureBox_PA.TabStop = false;
            // 
            // pictureBox_P1
            // 
            this.pictureBox_P1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_P1.Image")));
            this.pictureBox_P1.Location = new System.Drawing.Point(12, 88);
            this.pictureBox_P1.Name = "pictureBox_P1";
            this.pictureBox_P1.Size = new System.Drawing.Size(111, 57);
            this.pictureBox_P1.TabIndex = 64;
            this.pictureBox_P1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 480);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 12);
            this.label4.TabIndex = 91;
            this.label4.Text = "コンソール";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 480);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 12);
            this.label5.TabIndex = 92;
            this.label5.Text = "コマンド";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 627);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_end);
            this.Controls.Add(this.btn_PD_reset);
            this.Controls.Add(this.btn_P4_reset);
            this.Controls.Add(this.btn_PC_reset);
            this.Controls.Add(this.btn_P3_reset);
            this.Controls.Add(this.btn_PB_reset);
            this.Controls.Add(this.btn_P2_reset);
            this.Controls.Add(this.btn_PA_reset);
            this.Controls.Add(this.btn_P1_reset);
            this.Controls.Add(this.label_P2);
            this.Controls.Add(this.label_P1);
            this.Controls.Add(this.label_P3);
            this.Controls.Add(this.label_P4);
            this.Controls.Add(this.label_P4_3);
            this.Controls.Add(this.label_P4_2);
            this.Controls.Add(this.label_P3_3);
            this.Controls.Add(this.label_P3_2);
            this.Controls.Add(this.label_P2_3);
            this.Controls.Add(this.label_P2_2);
            this.Controls.Add(this.label_P1_3);
            this.Controls.Add(this.label_P1_2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pictureBox_PD);
            this.Controls.Add(this.pictureBox_P4);
            this.Controls.Add(this.pictureBox_PC);
            this.Controls.Add(this.pictureBox_P3);
            this.Controls.Add(this.pictureBox_PB);
            this.Controls.Add(this.pictureBox_P2);
            this.Controls.Add(this.pictureBox_PA);
            this.Controls.Add(this.pictureBox_P1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label_PDm);
            this.Controls.Add(this.numericUpDown_PDm);
            this.Controls.Add(this.label_PD);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.comboBox_PD);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label_PCm);
            this.Controls.Add(this.numericUpDown_PCm);
            this.Controls.Add(this.label_PC);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.comboBox_PC);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label_PBm);
            this.Controls.Add(this.numericUpDown_PBm);
            this.Controls.Add(this.label_PB);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.comboBox_PB);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label_PAm);
            this.Controls.Add(this.numericUpDown_PAm);
            this.Controls.Add(this.label_PA);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.comboBox_PA);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label_P4m);
            this.Controls.Add(this.numericUpDown_P4m);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox_P4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label_P3m);
            this.Controls.Add(this.numericUpDown_P3m);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.comboBox_P3);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label_P2m);
            this.Controls.Add(this.numericUpDown_P2m);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_P2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label_P1m);
            this.Controls.Add(this.numericUpDown_P1m);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_P1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.comboBox_COM);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect_to_EV3";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_P1m)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_P2m)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_P4m)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_P3m)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PDm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PCm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PBm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PAm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_P4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_P3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_P2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_P1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBox_COM;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_P1;
        private System.Windows.Forms.NumericUpDown numericUpDown_P1m;
        private System.Windows.Forms.ComboBox comboBox_P1;
        private System.Windows.Forms.Label label_P1m;
        private System.Windows.Forms.Label label_P2m;
        private System.Windows.Forms.NumericUpDown numericUpDown_P2m;
        private System.Windows.Forms.Label label_P2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_P2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_P4m;
        private System.Windows.Forms.NumericUpDown numericUpDown_P4m;
        private System.Windows.Forms.Label label_P4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_P4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_P3m;
        private System.Windows.Forms.NumericUpDown numericUpDown_P3m;
        private System.Windows.Forms.Label label_P3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox_P3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label_PDm;
        private System.Windows.Forms.NumericUpDown numericUpDown_PDm;
        private System.Windows.Forms.Label label_PD;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox comboBox_PD;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label_PCm;
        private System.Windows.Forms.NumericUpDown numericUpDown_PCm;
        private System.Windows.Forms.Label label_PC;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox comboBox_PC;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label_PBm;
        private System.Windows.Forms.NumericUpDown numericUpDown_PBm;
        private System.Windows.Forms.Label label_PB;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.ComboBox comboBox_PB;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label_PAm;
        private System.Windows.Forms.NumericUpDown numericUpDown_PAm;
        private System.Windows.Forms.Label label_PA;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.ComboBox comboBox_PA;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBox_P1;
        private System.Windows.Forms.PictureBox pictureBox_PA;
        private System.Windows.Forms.PictureBox pictureBox_PB;
        private System.Windows.Forms.PictureBox pictureBox_P2;
        private System.Windows.Forms.PictureBox pictureBox_PC;
        private System.Windows.Forms.PictureBox pictureBox_P3;
        private System.Windows.Forms.PictureBox pictureBox_PD;
        private System.Windows.Forms.PictureBox pictureBox_P4;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label_P1_2;
        private System.Windows.Forms.Label label_P1_3;
        private System.Windows.Forms.Label label_P2_3;
        private System.Windows.Forms.Label label_P2_2;
        private System.Windows.Forms.Label label_P3_3;
        private System.Windows.Forms.Label label_P3_2;
        private System.Windows.Forms.Label label_P4_3;
        private System.Windows.Forms.Label label_P4_2;
        private System.Windows.Forms.Button btn_P1_reset;
        private System.Windows.Forms.Button btn_PA_reset;
        private System.Windows.Forms.Button btn_PB_reset;
        private System.Windows.Forms.Button btn_P2_reset;
        private System.Windows.Forms.Button btn_PC_reset;
        private System.Windows.Forms.Button btn_P3_reset;
        private System.Windows.Forms.Button btn_PD_reset;
        private System.Windows.Forms.Button btn_P4_reset;
        private System.Windows.Forms.ToolStripMenuItem コンソールToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem リセットToolStripMenuItem;
        private System.Windows.Forms.Button btn_end;
        private System.Windows.Forms.ToolStripMenuItem endToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 環境設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem コマンドToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

