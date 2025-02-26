using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ModbusClientCS
{
    
    public partial class Wafer_Control_data : Form
    {
        private List<Con_Register_data> recipeDataList = new List<Con_Register_data>();

        private MainForm mainForm;

        public Wafer_Control_data(MainForm mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;

            // 콤보박스 디폴트 값 첫번째 요소로 설정 
            wafer_size_combobox.SelectedIndex = Properties.Settings.Default.WaferSize;
            wafer_loading_combobox.SelectedIndex = Properties.Settings.Default.WaferLoading;
            wafer_flat_area_combobox.SelectedIndex = Properties.Settings.Default.WaferFlat;
            wafer_amount_combobox.SelectedIndex = Properties.Settings.Default.WaferAmount;
        }

        #region (1)웨이퍼 정보 서버에 전송 및 값 읽어오기
        private void Wafer_Send_button_Click(object sender, EventArgs e) // Wafer 정보 서버에 전송
        {
            if (mainForm.stream == null) return;

            // 콤보박스에서 선택된 값 가져오기
            int waferSize = wafer_size_combobox.SelectedIndex switch
            {
                0 => 8,
                1 => 12
            };

            int wafer_loading_check = wafer_loading_combobox.SelectedIndex == 0 ? 0 : 1;

            int wafer_flat_area_check = wafer_flat_area_combobox.SelectedIndex switch
            {
                0 => 10,
                1 => 20,
                2 => 30,
                3 => 40,
                4 => 50,
                _ => 0
            };

            int wafer_amout_check = wafer_amount_combobox.SelectedIndex switch
            {
                0 => 100,
                1 => 110,
                2 => 120,
                3 => 130,
                4 => 140,
                5 => 150
            };

            byte[] sendBuf = new byte[21];
            sendBuf[0] = 0x00;  // TID 
            sendBuf[1] = 0x04;  // TID 

            sendBuf[2] = 0x00;  // Protocol hi
            sendBuf[3] = 0x00;  // Protocol lo

            sendBuf[4] = (byte)(sendBuf.Length - 6 >> 8);
            sendBuf[5] = (byte)(sendBuf.Length - 6 & 0xFF);

            sendBuf[6] = 0x01;  // DevID

            sendBuf[7] = 0x10;  // Function=WriteMultiple

            sendBuf[8] = 0x00;  // start hi
            sendBuf[9] = 0x00;  // start lo

            sendBuf[10] = 0x00; // qty hi
            sendBuf[11] = 0x03; // qty lo

            sendBuf[12] = 0x06; // byte count

            // 콤보박스 값 설정
            sendBuf[13] = (byte)(waferSize >> 8);
            sendBuf[14] = (byte)(waferSize & 0xFF);

            sendBuf[15] = (byte)(wafer_loading_check >> 8);
            sendBuf[16] = (byte)(wafer_loading_check & 0xFF);

            sendBuf[17] = (byte)(wafer_flat_area_check >> 8);
            sendBuf[18] = (byte)(wafer_flat_area_check & 0xFF);

            sendBuf[19] = (byte)(wafer_amout_check >> 8);
            sendBuf[20] = (byte)(wafer_amout_check & 0xFF);

            try
            {
                mainForm.stream.Write(sendBuf, 0, sendBuf.Length);
                Thread.Sleep(100);
                ReadInitialWaferSettings();
                MessageBox.Show("전송 완료!");
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
        private void ReadInitialWaferSettings()  // Wafer 정보 읽기 요청
        {
            if (mainForm.stream == null) return;

            byte[] sendBuf = new byte[12];
            sendBuf[0] = 0x00;  // TID hi
            sendBuf[1] = 0x04;  // TID lo

            sendBuf[2] = 0x00;  // Protocol hi
            sendBuf[3] = 0x00;  // Protocol lo

            sendBuf[4] = (byte)(sendBuf.Length - 6 >> 8);
            sendBuf[5] = (byte)(sendBuf.Length - 6 & 0xFF);

            sendBuf[6] = 0x01;  // DevID

            sendBuf[7] = 0x03;  // Function=ReadHolding

            sendBuf[8] = 0x00;  // start hi
            sendBuf[9] = 0x00;  // start lo

            sendBuf[10] = 0x00; // qty hi
            sendBuf[11] = 0x12; // qty lo

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


            // 콤보박스의 선택된 값들을 애플리케이션 설정에 저장
            Properties.Settings.Default.WaferSize = wafer_size_combobox.SelectedIndex;
            Properties.Settings.Default.WaferLoading = wafer_loading_combobox.SelectedIndex;
            Properties.Settings.Default.WaferFlat = wafer_flat_area_combobox.SelectedIndex;
            Properties.Settings.Default.WaferAmount = wafer_amount_combobox.SelectedIndex;

            // 설정을 저장
            Properties.Settings.Default.Save();
        }
        #endregion
    }
}
