using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModbusClientCS
{
    public partial class Plasma_Control : Form
    {
        private List<Con_Register_data> recipeDataList = new List<Con_Register_data>();

        private MainForm mainForm;

        public Plasma_Control(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

        }

        private void Plasma_Control_Send_button_Click(object sender, EventArgs e) // 플라즈마 값 서버에 전송
        {
            if (mainForm.stream == null) return;

            int rf_power;
            int forwardText = int.Parse(plasma_forward_textbox.Text);
            int reflectedText = int.Parse(plasma_reflected_textbox.Text);

            // 조건 추가: 둘 중 하나라도 0이면 rf_power = 1
            if (forwardText == 0 || reflectedText == 0)
            {
                rf_power = 1;
            }
            else
            {
                rf_power = 0;
            }


            byte[] sendBuf = new byte[19];

            sendBuf[0] = 0x00;  // TID 
            sendBuf[1] = 0x0B;  // TID 

            sendBuf[2] = 0x00;  // Protocol hi
            sendBuf[3] = 0x00;  // Protocol lo

            sendBuf[4] = (byte)(sendBuf.Length - 6 >> 8);
            sendBuf[5] = (byte)(sendBuf.Length - 6 & 0xFF);

            sendBuf[6] = 0x01;  // DevID

            sendBuf[7] = 0x10;  // Function=WriteMultiple

            sendBuf[8] = 0x00;  // start hi
            sendBuf[9] = 0x0D;  // start lo

            sendBuf[10] = 0x00; // qty hi
            sendBuf[11] = 0x03; // qty lo

            sendBuf[12] = 0x06; // byte count

            sendBuf[13] = (byte)(rf_power >> 8);
            sendBuf[14] = (byte)(rf_power & 0xFF);

            sendBuf[15] = (byte)(forwardText >> 8);
            sendBuf[16] = (byte)(forwardText & 0xFF);

            sendBuf[17] = (byte)(reflectedText >> 8);
            sendBuf[18] = (byte)(reflectedText & 0xFF);

            try
            {
                mainForm.stream.Write(sendBuf, 0, sendBuf.Length);
                Thread.Sleep(100);
                ReadInitialPlasmaSettings();
                MessageBox.Show("Plasma 데이터 전송 완료!");
                // 로그
                Log_Data.AddLog(
                    DateTime.Now.ToString("HH:mm:ss.fff"),
                    "",
                    "SEND",
                    "WaferSend => " + BitConverter.ToString(sendBuf)
                );
                //로그 데이터 확인 창 안켜도 텍스트 파일에 값 저장
                Log_Data.AddLog(
                    DateTime.Now.ToString("HH:mm:ss.fff"),
                    "",
                    "SEND",
                    "WaferSend => " + BitConverter.ToString(sendBuf)
                );

            }
            catch (Exception ex)
            {
                MessageBox.Show("Wafer 데이터 전송 오류: " + ex.Message);
            }
        }
        private void ReadInitialPlasmaSettings()  // Plasma 정보 읽기 요청
        {
            if (mainForm.stream == null) return;

            byte[] sendBuf = new byte[12];
            sendBuf[0] = 0x00;  // TID hi
            sendBuf[1] = 0x0B;  // TID lo

            sendBuf[2] = 0x00;  // Protocol hi
            sendBuf[3] = 0x00;  // Protocol lo

            sendBuf[4] = (byte)(sendBuf.Length - 6 >> 8);
            sendBuf[5] = (byte)(sendBuf.Length - 6 & 0xFF);

            sendBuf[6] = 0x01;  // DevID

            sendBuf[7] = 0x03;  // Function=ReadHolding

            sendBuf[8] = 0x00;  // start hi
            sendBuf[9] = 0x0D;  // start lo

            sendBuf[10] = 0x00; // qty hi
            sendBuf[11] = 0x03; // qty lo

            try
            {
                mainForm.stream.Write(sendBuf, 0, sendBuf.Length);

                // 로그
                Log_Data.AddLog(
                    DateTime.Now.ToString("HH:mm:ss.fff"),
                    "",
                    "SEND",
                    "ReadInitial => " + BitConverter.ToString(sendBuf)
                );
                //로그 데이터 확인 창 안켜도 텍스트 파일에 값 저장
                Log_Data.AddLog(
                    DateTime.Now.ToString("HH:mm:ss.fff"),
                    "",
                    "SEND",
                    "ReadInitial => " + BitConverter.ToString(sendBuf)
                );

            }
            catch (Exception ex)
            {
                MessageBox.Show("초기값 읽기 오류: " + ex.Message);
            }
        }
    }


}
