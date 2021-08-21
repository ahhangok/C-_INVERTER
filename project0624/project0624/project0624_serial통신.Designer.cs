
namespace project0624
{
    partial class txb_SendData
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(txb_SendData));
            this.sPort = new System.IO.Ports.SerialPort(this.components);
            this.cmb_Comport = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Baud = new System.Windows.Forms.ComboBox();
            this.bt_Open = new System.Windows.Forms.Button();
            this.bt_Close = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_Plc연결 = new System.Windows.Forms.Button();
            this.btn_Plc연결종료 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_Right = new System.Windows.Forms.Button();
            this.btn_Run = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_Alarm = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_InvI = new System.Windows.Forms.Label();
            this.btn_R = new System.Windows.Forms.Button();
            this.btn_Low = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Middle = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_High = new System.Windows.Forms.Button();
            this.lbl_InvV = new System.Windows.Forms.Label();
            this.btn_Reverse = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_InvHz = new System.Windows.Forms.Label();
            this.cbx_RecHexa = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_RecData = new System.Windows.Forms.TextBox();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_Comport
            // 
            this.cmb_Comport.FormattingEnabled = true;
            this.cmb_Comport.Location = new System.Drawing.Point(32, 165);
            this.cmb_Comport.Name = "cmb_Comport";
            this.cmb_Comport.Size = new System.Drawing.Size(99, 23);
            this.cmb_Comport.TabIndex = 0;
            this.cmb_Comport.SelectedIndexChanged += new System.EventHandler(this.cmb_Comport_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM Port 선택";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(149, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "BaudRate 선택";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmb_Baud
            // 
            this.cmb_Baud.FormattingEnabled = true;
            this.cmb_Baud.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cmb_Baud.Location = new System.Drawing.Point(150, 165);
            this.cmb_Baud.Name = "cmb_Baud";
            this.cmb_Baud.Size = new System.Drawing.Size(99, 23);
            this.cmb_Baud.TabIndex = 3;
            this.cmb_Baud.SelectedIndexChanged += new System.EventHandler(this.cmb_Baud_SelectedIndexChanged);
            // 
            // bt_Open
            // 
            this.bt_Open.BackColor = System.Drawing.Color.LightGray;
            this.bt_Open.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_Open.Location = new System.Drawing.Point(32, 89);
            this.bt_Open.Name = "bt_Open";
            this.bt_Open.Size = new System.Drawing.Size(92, 32);
            this.bt_Open.TabIndex = 4;
            this.bt_Open.Text = "통신 접속";
            this.bt_Open.UseVisualStyleBackColor = false;
            this.bt_Open.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_Close
            // 
            this.bt_Close.BackColor = System.Drawing.Color.LightGray;
            this.bt_Close.Enabled = false;
            this.bt_Close.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_Close.ForeColor = System.Drawing.Color.Black;
            this.bt_Close.Location = new System.Drawing.Point(150, 89);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Size = new System.Drawing.Size(91, 32);
            this.bt_Close.TabIndex = 5;
            this.bt_Close.Text = "접속 해제";
            this.bt_Close.UseVisualStyleBackColor = false;
            this.bt_Close.Click += new System.EventHandler(this.bt_Close_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_Plc연결
            // 
            this.btn_Plc연결.BackColor = System.Drawing.Color.LightGray;
            this.btn_Plc연결.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Plc연결.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Plc연결.Location = new System.Drawing.Point(32, 310);
            this.btn_Plc연결.Name = "btn_Plc연결";
            this.btn_Plc연결.Size = new System.Drawing.Size(99, 37);
            this.btn_Plc연결.TabIndex = 28;
            this.btn_Plc연결.Text = "PLC접속";
            this.btn_Plc연결.UseVisualStyleBackColor = false;
            this.btn_Plc연결.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_Plc연결종료
            // 
            this.btn_Plc연결종료.BackColor = System.Drawing.Color.LightGray;
            this.btn_Plc연결종료.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Plc연결종료.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Plc연결종료.Location = new System.Drawing.Point(150, 310);
            this.btn_Plc연결종료.Name = "btn_Plc연결종료";
            this.btn_Plc연결종료.Size = new System.Drawing.Size(99, 37);
            this.btn_Plc연결종료.TabIndex = 29;
            this.btn_Plc연결종료.Text = "PLC 해제";
            this.btn_Plc연결종료.UseVisualStyleBackColor = false;
            this.btn_Plc연결종료.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(81)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbx_RecHexa);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txb_RecData);
            this.panel1.Controls.Add(this.bt_Open);
            this.panel1.Controls.Add(this.bt_Close);
            this.panel1.Controls.Add(this.btn_Plc연결종료);
            this.panel1.Controls.Add(this.cmb_Baud);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Plc연결);
            this.panel1.Controls.Add(this.cmb_Comport);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(146, 281);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 386);
            this.panel1.TabIndex = 34;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(81)))), ((int)(((byte)(94)))));
            this.button1.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 148);
            this.button1.TabIndex = 32;
            this.button1.Text = "통신 연결";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.circularProgressBar1);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btn_Right);
            this.panel2.Controls.Add(this.btn_Run);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.btn_Stop);
            this.panel2.Controls.Add(this.btn_Alarm);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.lbl_InvI);
            this.panel2.Controls.Add(this.btn_R);
            this.panel2.Controls.Add(this.btn_Low);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btn_Middle);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.btn_High);
            this.panel2.Controls.Add(this.lbl_InvV);
            this.panel2.Controls.Add(this.btn_Reverse);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lbl_InvHz);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(429, 723);
            this.panel2.TabIndex = 35;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(244, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 15);
            this.label13.TabIndex = 23;
            this.label13.Text = "RUN";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // btn_Right
            // 
            this.btn_Right.BackColor = System.Drawing.Color.LightGray;
            this.btn_Right.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Right.Font = new System.Drawing.Font("굴림", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Right.Location = new System.Drawing.Point(246, 135);
            this.btn_Right.Name = "btn_Right";
            this.btn_Right.Size = new System.Drawing.Size(60, 30);
            this.btn_Right.TabIndex = 1;
            this.btn_Right.Text = "정회전";
            this.btn_Right.UseVisualStyleBackColor = false;
            this.btn_Right.Click += new System.EventHandler(this.btn_Right_Click);
            // 
            // btn_Run
            // 
            this.btn_Run.BackColor = System.Drawing.Color.LightGray;
            this.btn_Run.Enabled = false;
            this.btn_Run.Location = new System.Drawing.Point(246, 104);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(30, 15);
            this.btn_Run.TabIndex = 3;
            this.btn_Run.UseVisualStyleBackColor = false;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(283, 83);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 15);
            this.label14.TabIndex = 24;
            this.label14.Text = "STOP";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.BackColor = System.Drawing.Color.LightGray;
            this.btn_Stop.Enabled = false;
            this.btn_Stop.Location = new System.Drawing.Point(295, 104);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(30, 15);
            this.btn_Stop.TabIndex = 26;
            this.btn_Stop.UseVisualStyleBackColor = false;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_Alarm
            // 
            this.btn_Alarm.BackColor = System.Drawing.Color.LightGray;
            this.btn_Alarm.Enabled = false;
            this.btn_Alarm.Location = new System.Drawing.Point(344, 104);
            this.btn_Alarm.Name = "btn_Alarm";
            this.btn_Alarm.Size = new System.Drawing.Size(30, 15);
            this.btn_Alarm.TabIndex = 27;
            this.btn_Alarm.UseVisualStyleBackColor = false;
            this.btn_Alarm.Click += new System.EventHandler(this.btn_Alarm_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(333, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 15);
            this.label15.TabIndex = 25;
            this.label15.Text = "ALARM";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // lbl_InvI
            // 
            this.lbl_InvI.AutoSize = true;
            this.lbl_InvI.BackColor = System.Drawing.Color.Transparent;
            this.lbl_InvI.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_InvI.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_InvI.Location = new System.Drawing.Point(114, 85);
            this.lbl_InvI.Name = "lbl_InvI";
            this.lbl_InvI.Size = new System.Drawing.Size(107, 38);
            this.lbl_InvI.TabIndex = 18;
            this.lbl_InvI.Text = "00.00";
            // 
            // btn_R
            // 
            this.btn_R.BackColor = System.Drawing.Color.LightGray;
            this.btn_R.Enabled = false;
            this.btn_R.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_R.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_R.Location = new System.Drawing.Point(28, 586);
            this.btn_R.Name = "btn_R";
            this.btn_R.Size = new System.Drawing.Size(83, 38);
            this.btn_R.TabIndex = 6;
            this.btn_R.Text = "가변저항";
            this.btn_R.UseVisualStyleBackColor = false;
            this.btn_R.Click += new System.EventHandler(this.btn_R_Click);
            // 
            // btn_Low
            // 
            this.btn_Low.BackColor = System.Drawing.Color.LightGray;
            this.btn_Low.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Low.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Low.Location = new System.Drawing.Point(342, 183);
            this.btn_Low.Name = "btn_Low";
            this.btn_Low.Size = new System.Drawing.Size(50, 30);
            this.btn_Low.TabIndex = 5;
            this.btn_Low.Text = "저속";
            this.btn_Low.UseVisualStyleBackColor = false;
            this.btn_Low.Click += new System.EventHandler(this.btn_Low_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.Firebrick;
            this.label8.Location = new System.Drawing.Point(29, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "출력전류";
            // 
            // btn_Middle
            // 
            this.btn_Middle.BackColor = System.Drawing.Color.LightGray;
            this.btn_Middle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Middle.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Middle.Location = new System.Drawing.Point(286, 183);
            this.btn_Middle.Name = "btn_Middle";
            this.btn_Middle.Size = new System.Drawing.Size(50, 30);
            this.btn_Middle.TabIndex = 4;
            this.btn_Middle.Text = "중속";
            this.btn_Middle.UseVisualStyleBackColor = false;
            this.btn_Middle.Click += new System.EventHandler(this.btn_Middle_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.Color.Firebrick;
            this.label10.Location = new System.Drawing.Point(29, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 25);
            this.label10.TabIndex = 21;
            this.label10.Text = "출력전압";
            // 
            // btn_High
            // 
            this.btn_High.BackColor = System.Drawing.Color.LightGray;
            this.btn_High.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.btn_High.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_High.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_High.Location = new System.Drawing.Point(230, 183);
            this.btn_High.Name = "btn_High";
            this.btn_High.Size = new System.Drawing.Size(50, 30);
            this.btn_High.TabIndex = 3;
            this.btn_High.Text = "고속";
            this.btn_High.UseVisualStyleBackColor = false;
            this.btn_High.Click += new System.EventHandler(this.btn_High_Click);
            // 
            // lbl_InvV
            // 
            this.lbl_InvV.AutoSize = true;
            this.lbl_InvV.BackColor = System.Drawing.Color.Transparent;
            this.lbl_InvV.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_InvV.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_InvV.Location = new System.Drawing.Point(114, 131);
            this.lbl_InvV.Name = "lbl_InvV";
            this.lbl_InvV.Size = new System.Drawing.Size(87, 38);
            this.lbl_InvV.TabIndex = 20;
            this.lbl_InvV.Text = "00.0";
            this.lbl_InvV.Click += new System.EventHandler(this.lbl_InvV_Click);
            // 
            // btn_Reverse
            // 
            this.btn_Reverse.BackColor = System.Drawing.Color.LightGray;
            this.btn_Reverse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Reverse.Font = new System.Drawing.Font("굴림", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Reverse.Location = new System.Drawing.Point(311, 135);
            this.btn_Reverse.Name = "btn_Reverse";
            this.btn_Reverse.Size = new System.Drawing.Size(60, 30);
            this.btn_Reverse.TabIndex = 2;
            this.btn_Reverse.Text = "역회전";
            this.btn_Reverse.UseVisualStyleBackColor = false;
            this.btn_Reverse.Click += new System.EventHandler(this.btn_Reverse_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(29, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "출력 Hz";
            // 
            // lbl_InvHz
            // 
            this.lbl_InvHz.AutoSize = true;
            this.lbl_InvHz.BackColor = System.Drawing.Color.Transparent;
            this.lbl_InvHz.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_InvHz.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_InvHz.Location = new System.Drawing.Point(114, 176);
            this.lbl_InvHz.Name = "lbl_InvHz";
            this.lbl_InvHz.Size = new System.Drawing.Size(107, 38);
            this.lbl_InvHz.TabIndex = 14;
            this.lbl_InvHz.Text = "00.00";
            this.lbl_InvHz.Click += new System.EventHandler(this.lbl_InvHz_Click);
            // 
            // cbx_RecHexa
            // 
            this.cbx_RecHexa.AutoSize = true;
            this.cbx_RecHexa.Font = new System.Drawing.Font("굴림", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbx_RecHexa.ForeColor = System.Drawing.Color.White;
            this.cbx_RecHexa.Location = new System.Drawing.Point(134, 203);
            this.cbx_RecHexa.Name = "cbx_RecHexa";
            this.cbx_RecHexa.Size = new System.Drawing.Size(70, 18);
            this.cbx_RecHexa.TabIndex = 32;
            this.cbx_RecHexa.Text = "HEXA";
            this.cbx_RecHexa.UseVisualStyleBackColor = true;
            this.cbx_RecHexa.CheckedChanged += new System.EventHandler(this.cbx_RecHexa_CheckedChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "수신데이터";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txb_RecData
            // 
            this.txb_RecData.Location = new System.Drawing.Point(32, 236);
            this.txb_RecData.Multiline = true;
            this.txb_RecData.Name = "txb_RecData";
            this.txb_RecData.Size = new System.Drawing.Size(217, 55);
            this.txb_RecData.TabIndex = 30;
            this.txb_RecData.TextChanged += new System.EventHandler(this.txb_RecData_TextChanged);
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("굴림", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.InnerColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(23, 437);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Maximum = 65;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.Firebrick;
            this.circularProgressBar1.ProgressWidth = 25;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("굴림", 36F);
            this.circularProgressBar1.Size = new System.Drawing.Size(97, 104);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "";
            this.circularProgressBar1.TabIndex = 35;
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.Value = 65;
            this.circularProgressBar1.Click += new System.EventHandler(this.circularProgressBar1_Click);
            // 
            // timer3
            // 
            this.timer3.Interval = 300;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 555);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "최대 Hz = 65";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(82, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 24);
            this.label6.TabIndex = 37;
            this.label6.Text = "< 통신 >";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(168, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(257, 247);
            this.label7.TabIndex = 37;
            this.label7.Text = "미쓰비시는 일제 강점기\r\n\r\n시대, 당시 조선인들을 \r\n\r\n강제로 징용하여 노역을 \r\n\r\n하게 했는데, 하시마 섬에서\r\n \r\n비인간적인 대우와 급" +
    "여\r\n\r\n 체불을 일삼았습니다.\r\n\r\n**전범기업 미쓰비시**";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(21, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(237, 38);
            this.label9.TabIndex = 38;
            this.label9.Text = "I LOVE KOREA";
            // 
            // txb_SendData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 755);
            this.Controls.Add(this.panel2);
            this.Name = "txb_SendData";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort sPort;
        private System.Windows.Forms.ComboBox cmb_Comport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Baud;
        private System.Windows.Forms.Button bt_Open;
        private System.Windows.Forms.Button bt_Close;
        private System.Windows.Forms.Label lbl_InvHz;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Reverse;
        private System.Windows.Forms.Button btn_High;
        private System.Windows.Forms.Button btn_Middle;
        private System.Windows.Forms.Button btn_Low;
        private System.Windows.Forms.Button btn_R;
        private System.Windows.Forms.Label lbl_InvV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_InvI;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_Run;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_Alarm;
        private System.Windows.Forms.Button btn_Plc연결;
        private System.Windows.Forms.Button btn_Plc연결종료;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Right;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cbx_RecHexa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_RecData;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
    }
}

