using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;        //Serail 통신 필요.
using System.IO.Ports;  //Serial 통신 필요.
using System.Threading; //sleep 사용에 필요함
using ACTMULTILib; //PLC 통신연결 등록 MXComponent 사용)

namespace project0624
{
    public partial class txb_SendData : Form
    {
        ActEasyIF Myplc = new ActEasyIF(); //Myplc 이름으로 참조를 가지고 와서 new로 할당
       

        public txb_SendData()
        {
            InitializeComponent();
            GetAVailablePorts();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            int intHz = 0;
            circularProgressBar1.Value = intHz;

          
            //bt_Close.Enabled = false;
            CheckForIllegalCrossThreadCalls = false;

            panel1.Hide();

            //데이터 수신 스레드 error 방지
        }

        private void GetAVailablePorts()
        {
            string[] poers = SerialPort.GetPortNames();
            cmb_Comport.Items.AddRange(poers); //포트선택

        }

        //통신 연결
        private void button1_Click(object sender, EventArgs e)
        {
            timer3.Start();

            if (cmb_Comport.Text == "")
                {
                    MessageBox.Show("ComPort를 선택하여 주십시오.");
                    return;
                }
                if (cmb_Baud.Text == "")
                {
                    MessageBox.Show("통신속도를 선택하여 주십시오.");
                    return;
                }

                sPort.PortName = cmb_Comport.Text; //comport 번호를 입력한다
                sPort.BaudRate = int.Parse(cmb_Baud.Text); //통신 속도 입력.
                sPort.Open(); //포트 오픈 명령
                bt_Open.Enabled = false;
                bt_Open.BackColor = Color.Red;
                bt_Close.Enabled = true;


                //bt_Send.Enabled = true;
                //bt_Rec.Enabled = true;


                sPort.DataReceived += new SerialDataReceivedEventHandler(EventDataReceived); ;
            //COM PORT 수신버퍼에 데이터가 입력되면 자동으로 eventDataReceived로 이벤트가 발생된다.

            timer1.Enabled = true;

          


            // sPort.Write(txb_Send.Text);

        }

        //통신 해제
        private void bt_Close_Click(object sender, EventArgs e)
        {
            sPort.Close();
            bt_Close.Enabled = false;
            bt_Close.BackColor = Color.Red;
            bt_Open.Enabled = true;
            bt_Open.BackColor = Color.LightGray;
            //bt_Send.Enabled = false;
            //bt_Rec.Enabled = true;
            timer1.Enabled = false;
        }

        
       

        //데이터 송신
        private void bt_Send_Click(object sender, EventArgs e)
        {
           
            
        }

        private void txb_get_TextChanged(object sender, EventArgs e)
        {

        }

        //데이터 수신
        private void bt_Rec_Click(object sender, EventArgs e)
        {
            //txb_RecData.Text = sPort.ReadExisting();//데이터 수신
        }

        private void EventDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
           
                //txb_RecData.Text = "";
                Thread.Sleep(300); //지연시간
                int iSize = sPort.BytesToRead;

                string strdata = "";
                if (iSize == 0)
                {
                    return;
                }

                byte[] buffer = new byte[iSize];
                sPort.Read(buffer, 0, iSize);


                foreach (byte bData in buffer)
                {
                if (cbx_RecHexa.Checked)
                    strdata += "" + bData.ToString("x2");
                else
                {
                    strdata += "" + Convert.ToChar(bData);
                }
            }

            txb_RecData.Text += strdata;



            int i = strdata.Length;

                if (i == 22)
                {
                    //Hz
                    string strPvtHz, strCurrent, strVolt;
                    strPvtHz = strdata.Substring(6, 4); //왜 이렇게 ? =>  이자리에서 값이 온다. 
                    int intlnvhz = Convert.ToInt32(strPvtHz, 16); //현재 16진수                                        //lbl_lnvHz.Text=intInhz.ToString();
                    double Wreal1, Wreal2; // 무슨 변수
                    Wreal1 = intlnvhz;
                    Wreal2 = Wreal1 / 100; //소수점 표시를 위해 잘라준것
                    lbl_InvHz.Text = string.Format("{0,4:N2}", Wreal2);


                    //전류
                    strCurrent = strdata.Substring(10, 4); //왜 이렇게 ? =>  이자리에서 값이 온다. 
                    int intlntI = Convert.ToInt32(strCurrent, 16); //현재 16진수                                            //lbl_lnvHz.Text=intInhz.ToString();
                    double Wreal3, Wreal4; // 무슨 변수
                    Wreal3 = intlntI;
                    Wreal4 = Wreal3 / 100; //소수점 표시를 위해 잘라준것
                    lbl_InvI.Text = string.Format("{0,4:N2}", Wreal4);


                    //전압
                    strVolt = strdata.Substring(14, 4); //왜 이렇게 ? =>  이자리에서 값이 온다. 
                    int intlnvV = Convert.ToInt32(strVolt, 16); //현재 16진수                                          //lbl_lnvHz.Text=intInhz.ToString();
                    double Wreal5, Wreal6; // 무슨 변수
                    Wreal5 = intlnvV;
                    Wreal6 = Wreal5 / 10; //소수점 표시를 위해 잘라준것
                    lbl_InvV.Text = string.Format("{0,4:N1}", Wreal6);

                    
                    //Myplc.SetDevice("M6", 1);
                    Myplc.SetDevice("D100", intlnvhz);
                    Myplc.SetDevice("D101", intlntI);
                    Myplc.SetDevice("D102", intlnvV);



            }
            
            //txb_RecData.Text = sPort.ReadExisting();//데이터 수신
            //txb_RecData.Text = Rxdata;*/
        }

        //연속전송
        private void cbx_Send_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        //타이머가 돌아갈 때마다 수신 버튼을 눌러줌
        private void timer1_Tick(object sender, EventArgs e)
        {
            txb_RecData.Text = "";
            Thread.Sleep(300);
            //bt_Send.PerformClick();
            string str1 = "01 03 00 c8 00 03 84 35"; //00 c8이 인버터에 내장되어있는 어드레스 00 03은 개수 84 35 CRC

            byte[] bSendData = new byte[200];
            int iSendCount = 0;
            try
            {


                foreach (string str in str1.Split())
                {
                    if (str != null && str != null)
                    {
                        bSendData[iSendCount++] = Convert.ToByte(str, 16);
                    }

                }
                sPort.Write(bSendData, 0, iSendCount);



            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Send Data Exception");
            }

            
        }

        
        //PLC 연결
        private void button1_Click_1(object sender, EventArgs e)
        {
            int StNo = 2; //Station 번호 변수 설정
            Myplc.ActLogicalStationNumber = StNo; // station 번호 입력(1번)
            int iRet = Myplc.Open();
            if (iRet == 0) // 통신접속 상태 확인
            {
                btn_Plc연결.BackColor = Color.Red;
                btn_Plc연결.Enabled = false;
                btn_Plc연결종료.Enabled = true;
                btn_Plc연결종료.BackColor = Color.LightGray;

            }
            else
            {
                //iRet에서 받아온 10진수를 16진수 바꾸고 문자열로 변환
                MessageBox.Show(iRet.ToString("X2"), "PLC접속 이상발생", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
            timer2.Enabled = true;
        }


        //PLC 해제
        private void button2_Click(object sender, EventArgs e)
        {
            int iRet = Myplc.Close();//plc 접속종료
            if (iRet == 0)
            {
                btn_Plc연결.BackColor = Color.LightGray;
                btn_Plc연결.Enabled = true;
                btn_Plc연결종료.BackColor = Color.Red;
                btn_Plc연결종료.Enabled = false;
            }
            else
            {
                MessageBox.Show(iRet.ToString("X2"), "PLC접속종료 이상발생", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            timer2.Enabled = false;
        }

       //정방향
        private void btn_Right_Click(object sender, EventArgs e)
        {
            
            if (btn_Right.BackColor == Color.LightGray)
            {
                btn_Right.BackColor = Color.Red;
                Myplc.SetDevice2("B0", 1);
                Myplc.SetDevice2("M0", 1);
                Myplc.SetDevice2("X0", 1);
                btn_Reverse.BackColor = Color.LightGray;
                Myplc.SetDevice("B1", 0);
                Myplc.SetDevice("M1", 0);
            }else if(btn_Right.BackColor == Color.Red)
            {
                btn_Right.BackColor = Color.LightGray;
                Myplc.SetDevice2("B0", 0);
                Myplc.SetDevice2("M0", 0);
                Myplc.SetDevice2("X0", 0);
            }

            if (btn_Right.BackColor == Color.LightGray && btn_Reverse.BackColor == Color.LightGray )
            {
                btn_R.BackColor = Color.LightGray;
            }
        }


        
        //역방향
        private void btn_Reverse_Click(object sender, EventArgs e)
        {
           
            if (btn_Reverse.BackColor == Color.LightGray)
            {
                btn_Reverse.BackColor = Color.Red;
                Myplc.SetDevice2("B1", 1);
                Myplc.SetDevice2("M1", 1);
                Myplc.SetDevice2("X0", 1);
                btn_Right.BackColor = Color.LightGray;
                Myplc.SetDevice("B0", 0);
                Myplc.SetDevice("M0", 0);
            }
            else if (btn_Reverse.BackColor == Color.Red)
            {
                btn_Reverse.BackColor = Color.LightGray;
                Myplc.SetDevice2("B1", 0);
                Myplc.SetDevice2("M1", 0);
                Myplc.SetDevice2("X0", 0);
            }

            if (btn_Right.BackColor == Color.LightGray && btn_Reverse.BackColor == Color.LightGray)
            {
                btn_R.BackColor = Color.LightGray;
            }
        }

        //고속
        private void btn_High_Click(object sender, EventArgs e)
        {
            if (btn_High.BackColor == Color.LightGray)
            {
                Myplc.SetDevice2("B2", 1);
                Myplc.SetDevice2("M2", 1);
                Myplc.SetDevice2("M3", 0);
                Myplc.SetDevice2("M4", 0);

                btn_High.BackColor = Color.Red;
                btn_Middle.BackColor = Color.LightGray;
                btn_Low.BackColor = Color.LightGray;
                btn_R.BackColor = Color.LightGray;
            }else if(btn_High.BackColor == Color.Red)
            {
              
                Myplc.SetDevice2("M2", 0);
                btn_High.BackColor = Color.LightGray;
                btn_Middle.BackColor = Color.LightGray;
                btn_Low.BackColor = Color.LightGray;
                btn_R.BackColor = Color.LightGray;
            }

            if(btn_High.BackColor == Color.LightGray && btn_Middle.BackColor ==Color.LightGray && btn_Low.BackColor == Color.LightGray)
            {
                btn_R.BackColor = Color.Red;

            }
            


        }


        //중속
        private void btn_Middle_Click(object sender, EventArgs e)
        {
            if (btn_Middle.BackColor == Color.LightGray)
            {
                Myplc.SetDevice2("B3", 1);
                Myplc.SetDevice2("M2", 0);
                Myplc.SetDevice2("M3", 1);
                Myplc.SetDevice2("M4", 0);

                btn_High.BackColor = Color.LightGray;
                btn_Middle.BackColor = Color.Red;
                btn_Low.BackColor = Color.LightGray;
                btn_R.BackColor = Color.LightGray;
            }
            else if (btn_Middle.BackColor == Color.Red)
            {

                Myplc.SetDevice2("M3", 0);
                btn_High.BackColor = Color.LightGray;
                btn_Middle.BackColor = Color.LightGray;
                btn_Low.BackColor = Color.LightGray;
                btn_R.BackColor = Color.LightGray;
            }

            if (btn_High.BackColor == Color.LightGray && btn_Middle.BackColor == Color.LightGray && btn_Low.BackColor == Color.LightGray)
            {
                btn_R.BackColor = Color.Red;
            }

        }


        //저속
        private void btn_Low_Click(object sender, EventArgs e)
        {
            if (btn_Low.BackColor == Color.LightGray)
            {
                Myplc.SetDevice2("B4", 1);
                Myplc.SetDevice2("M2", 0);
                Myplc.SetDevice2("M3", 0);
                Myplc.SetDevice2("M4", 1);

                btn_High.BackColor = Color.LightGray;
                btn_Middle.BackColor = Color.LightGray;
                btn_Low.BackColor = Color.Red;
                btn_R.BackColor = Color.LightGray;
            }
            else if (btn_Low.BackColor == Color.Red)
            {

                Myplc.SetDevice2("M4", 0);
                btn_High.BackColor = Color.LightGray;
                btn_Middle.BackColor = Color.LightGray;
                btn_Low.BackColor = Color.LightGray;
                btn_R.BackColor = Color.LightGray;
            }

            //고속, 중속, 저속에 불이 꺼지면 가변저항 켜짐
            if (btn_High.BackColor == Color.LightGray && btn_Middle.BackColor == Color.LightGray && btn_Low.BackColor == Color.LightGray)
            {
                btn_R.BackColor = Color.Red;
            }
        }

        
        //RUN, STOP, ALARM(고장시 들어옴) 불
        private void timer2_Tick(object sender, EventArgs e)
        {
           

            short Lamp;
            Myplc.GetDevice2("M10", out Lamp);

            if(Lamp == 0)
            {
                btn_Run.BackColor = Color.White;
            }
            else
            {
                btn_Run.BackColor = Color.Red;
            }

            Myplc.GetDevice2("M11", out Lamp);
            if (Lamp == 0)
            {
                btn_Stop.BackColor = Color.White;
            }
            else
            {
                btn_Stop.BackColor = Color.Red;
            }

            Myplc.GetDevice2("M12", out Lamp);
            if (Lamp == 0)
            {
                btn_Alarm.BackColor = Color.White;
            }
            else
            {
                btn_Alarm.BackColor = Color.Red;
            }

            int M0_state, M1_state, M2_state, M3_state, M4_state, M5_state;

            Myplc.GetDevice("M0", out M0_state);
            Myplc.GetDevice("M1", out M1_state);
            Myplc.GetDevice("M2", out M2_state);
            Myplc.GetDevice("M3", out M3_state);
            Myplc.GetDevice("M4", out M4_state);
            Myplc.GetDevice("M5", out M5_state);

            if (M0_state == 0)
            {
                btn_Right.BackColor = Color.LightGray;
            }
            else if (M0_state == 1)
            {
                btn_Right.BackColor = Color.Red;
            }

            if (M1_state == 0)
            {
                btn_Reverse.BackColor = Color.LightGray;
            }
            else if (M1_state == 1)
            {
                btn_Reverse.BackColor = Color.Red;
            }

            if (M2_state == 0)
            {
                btn_High.BackColor = Color.LightGray;
            }
            else if (M2_state == 1)
            {
                btn_High.BackColor = Color.Red;
            }

            if (M3_state == 0)
            {
                btn_Middle.BackColor = Color.LightGray;
            }
            else if (M3_state == 1)
            {
                btn_Middle.BackColor = Color.Red;
            }

            if (M4_state == 0)
            {
                btn_Low.BackColor = Color.LightGray;
            }
            else if (M4_state == 1)
            {
                btn_Low.BackColor = Color.Red;
            }

            if (M5_state == 0)
            {
                btn_R.BackColor = Color.LightGray;
            }
            else if (M5_state == 1)
            {
                btn_R.BackColor = Color.Red;
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
           
              

            if (panel1.Visible ==true)
            {
                panel1.Hide();
            }
            else if (panel1.Visible == false){
                panel1.Show();
            }
            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbx_SendHexa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbx_RecHexa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lbl_InvV_Click(object sender, EventArgs e)
        {

        }

        private void lbl_InvHz_Click(object sender, EventArgs e)
        {

        }

        private void btn_R_Click(object sender, EventArgs e)
        {
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if(btn_R.BackColor == Color.Red)
            {
                int intHz = (int)Math.Truncate(double.Parse(lbl_InvHz.Text));
                circularProgressBar1.Value = intHz;
            }
            else if(btn_R.BackColor == Color.LightGray)
            {
                int intHz = 0;
                circularProgressBar1.Value = intHz;
            }
           
            //MessageBox.Show(intHz.ToString());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btn_Run_Click(object sender, EventArgs e)
        {

        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {

        }

        private void btn_Alarm_Click(object sender, EventArgs e)
        {

        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void cmb_Comport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmb_Baud_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cbx_RecHexa_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void txb_RecData_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
