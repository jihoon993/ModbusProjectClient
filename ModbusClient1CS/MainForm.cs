using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
  
namespace ModbusClientCS
{
    public partial class MainForm : Form
    {
        #region (1) 필드/멤버 변수
        // 서버 주소/포트
        private const string ServerIP = "192.168.0.144";
        private const int ServerPort = 502;

        // TCP 통신 객체
        private TcpClient client;
        public NetworkStream stream;

        // Control_data에서 저장된 값들
        public static List<Con_Register_data> SavedControlData = new List<Con_Register_data>();

        // Server에서 가져와 저장한 값
        public static List<Con_Register_data> SavedServerData = new List<Con_Register_data>();

        // 로컬 단계 진행도 타이머
        private System.Windows.Forms.Timer localStageTimer;
        private int stageIndex = 0;     // 단계 (0=온도,1=압력,2=유량,3=오존,4=질소)
        private int[] stageValues = new int[16]; // 5개 세팅값
        private int progressValue = 0;  // 0~100 진행도
        #endregion

        #region (2) 메인폼 로드 & 서버 연결
        public MainForm()
        {
            InitializeComponent();

            this.Paint += DrawPipeLine;

        }

        private void MainForm_Paint(object? sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // (A) 서버 연결
            ConnectServer();

            // (B) 서버 초기값(온도/압력/유량 등) 한 번 읽기 => 0x03 
            ReadInitialChamberSettings(0); // register 초기값
            ReadInitialValveSettings(0);   // coil 초기값

            // (C) 서버 응답 수신 스레드 시작
            Thread recvThread = new Thread(ReceiveDataLoop);
            recvThread.IsBackground = true;
            recvThread.Start();

            // 폼 닫힐 때 서버 연결 해제
            this.FormClosing += MainForm_FormClosing;
        }

        // TCP 연결
        private void ConnectServer()
        {
            try
            {
                client = new TcpClient(ServerIP, ServerPort);
                stream = client.GetStream();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"서버 연결 실패: {ex.Message}");
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisconnectServer();
        }

        private void DisconnectServer()
        {
            if (stream != null) stream.Close();
            if (client != null) client.Close();
        }
        #endregion

        #region (3) 서버 응답 수신 (ReceiveDataLoop)
        // 서버가 보내는 16진수 응답을 계속 받아서 파싱.
        // 예: 0x03 응답에서 [12..(12+qty*2-1)] 구간에 레지스터 값이 들어있음.
        private void ReceiveDataLoop()
        {
            while (true)
            {
                try
                {
                    if (stream == null || !stream.CanRead)
                    {
                        Thread.Sleep(100);
                        continue;
                    }

                    byte[] recvBuf = new byte[255];
                    int bytesRead = stream.Read(recvBuf, 0, recvBuf.Length);
                    int transid = (recvBuf[0] << 8) | recvBuf[1];
                    if (bytesRead > 0)
                    {
                        // 로그 기록
                        Log_Data.AddLog(
                            "",
                            DateTime.Now.ToString("HH:mm:ss.fff"),
                            "RECV",
                            BitConverter.ToString(recvBuf, 0, bytesRead)
                        );
                        //로그 데이터 확인 창 안켜도 텍스트 파일에 값 저장
                        Log_Data.SaveLogToFile(
                            "",
                            DateTime.Now.ToString("HH:mm:ss.fff"),
                            "RECV",
                            BitConverter.ToString(recvBuf, 0, bytesRead)
                        );
                        // 0x03 응답 예시: [10..11]=Qty, [12..] = register data
                        if (transid == 0)
                        {
                            int qty = (recvBuf[10] << 8) | recvBuf[11];
                            // 예: 5개 레지스터 => [12..21] 
                            //if (qty >= 5 && bytesRead >= 12 + qty * 2)
                            //{
                            int chamber_temp = (recvBuf[12] << 8) | recvBuf[13];
                            int chamber_press = (recvBuf[14] << 8) | recvBuf[15];
                            int chamber_flow = (recvBuf[16] << 8) | recvBuf[17];
                            int o3_val = (recvBuf[18] << 8) | recvBuf[19];
                            int n2_val = (recvBuf[20] << 8) | recvBuf[21];
                            int zro2_val = (recvBuf[22] << 8) | recvBuf[23];
                            int hfo2_val = (recvBuf[24] << 8) | recvBuf[25];
                            int h2o2_val = (recvBuf[26] << 8) | recvBuf[27];
                            int tma_val = (recvBuf[28] << 8) | recvBuf[29];
                            int wafer_size = (recvBuf[30] << 8) | recvBuf[31];
                            int wafer_loading = (recvBuf[32] << 8) | recvBuf[33];
                            int wafer_flat_area = (recvBuf[34] << 8) | recvBuf[35];
                            int wafer_amount = (recvBuf[36] << 8) | recvBuf[37];
                            int rf_power = (recvBuf[38] << 8) | recvBuf[39];
                            int plasma_forward   = (recvBuf[40] << 8) | recvBuf[41];
                            int plasma_reflected = (recvBuf[42] << 8) | recvBuf[43];

                            Con_Register_data serverData =
                                new Con_Register_data(
                                    chamber_temp,
                                    chamber_press,
                                    chamber_flow,
                                    o3_val,
                                    n2_val,
                                    zro2_val,
                                    hfo2_val,
                                    h2o2_val,
                                    tma_val,
                                    wafer_size,
                                    wafer_loading,
                                    wafer_flat_area,
                                    wafer_amount,
                                    rf_power,
                                    plasma_forward,
                                    plasma_reflected
                                );

                            SavedServerData.Add(serverData);

                            // UI 표시
                            this.Invoke((MethodInvoker)delegate
                            {
                                ShowWaferData(serverData);
                                StartLocalStageSimulation("transid_0", serverData);   
                                ShowPlasmaData(serverData);
                            });
                        }
                        else if (transid == 1)
                        {
                            int qty = (recvBuf[10] << 8) | recvBuf[11];

                            int chamber_temp = (recvBuf[12] << 8) | recvBuf[13];
                            int chamber_press = (recvBuf[14] << 8) | recvBuf[15];
                            int chamber_flow = (recvBuf[16] << 8) | recvBuf[17];
                            int o3_val = (recvBuf[18] << 8) | recvBuf[19];
                            int n2_val = (recvBuf[20] << 8) | recvBuf[21];
                            int zro2_val = (recvBuf[22] << 8) | recvBuf[23];
                            int hfo2_val = (recvBuf[24] << 8) | recvBuf[25];
                            int h2o2_val = (recvBuf[26] << 8) | recvBuf[27];
                            int tma_val = (recvBuf[28] << 8) | recvBuf[29];

                            Con_Register_data serverData =
                                new Con_Register_data(
                                    chamber_temp,
                                    chamber_press,
                                    chamber_flow,
                                    o3_val,
                                    n2_val,
                                    zro2_val,
                                    hfo2_val,
                                    h2o2_val,
                                    tma_val
                                );

                            SavedServerData.Add(serverData);

                            // UI 표시
                            this.Invoke((MethodInvoker)delegate
                            {
                                StartLocalStageSimulation("transid_1", serverData);
                            });
                        }
                        else if (transid == 4)
                        {
                            int wafer_size = (recvBuf[30] << 8) | recvBuf[31];
                            int wafer_loading = (recvBuf[32] << 8) | recvBuf[33];
                            int wafer_flat_area = (recvBuf[34] << 8) | recvBuf[35];
                            int wafer_amount = (recvBuf[36] << 8) | recvBuf[37];

                            Con_Register_data serverData =
                                    new Con_Register_data(
                                        wafer_size,
                                        wafer_loading,
                                        wafer_flat_area,
                                        wafer_amount
                                    );
                            ChangeWaferData(serverData);
                        }
                        else if (transid == 11)
                        {
                            int rf_power = (recvBuf[38] << 8) | recvBuf[39];
                            int plasma_forward = (recvBuf[40] << 8) | recvBuf[41];
                            int plasma_reflected = (recvBuf[42] << 8) | recvBuf[43];

                            Con_Register_data serverData =
                                    new Con_Register_data(
                                        rf_power,
                                        plasma_forward,
                                        plasma_reflected
                                        );

                             ChangePlasmaData(serverData);

                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("수신 오류 : " + e.Message);
                }
            }
        }
        #endregion

        #region (4) 초기값 읽기 요청 (0x03, 0x01)
        /// <summary>
        /// 폼 로드 시 서버에 0x03 패킷(12바이트) 전송하여 HoldingRegister 5개(온도,압력,유량,오존,질소) 읽음.
        /// 서버는 응답에서 [12..21]에 실제값을 16진수로 담아 보냄.
        /// </summary>
        private void ReadInitialChamberSettings(ushort tid) // 레지스터
        {
            if (stream == null) return;

            byte[] sendBuf = new byte[12];
            sendBuf[0] = (byte)((tid >> 8) & 0xFF);
            sendBuf[1] = (byte)(tid & 0xFF);

            sendBuf[2] = 0x00;  // Protocol hi
            sendBuf[3] = 0x00;  // Protocol lo

            sendBuf[4] = (byte)(sendBuf.Length - 6 >> 8);
            sendBuf[5] = (byte)(sendBuf.Length - 6 & 0xFF);

            sendBuf[6] = 0x01;  // DevID

            sendBuf[7] = 0x03;  // Function=ReadHolding

            sendBuf[8] = 0x00;  // start hi
            sendBuf[9] = 0x00;  // start lo

            sendBuf[10] = 0x00; // qty hi
            sendBuf[11] = 0x15; // qty lo

            try
            {
                stream.Write(sendBuf, 0, sendBuf.Length);

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

        private void ReadInitialValveSettings(ushort tid) // 밸브
        {
            if (stream == null) return;

            byte[] sendBuf = new byte[12];
            sendBuf[0] = (byte)((tid >> 8) & 0xFF);
            sendBuf[1] = (byte)(tid & 0xFF);

            sendBuf[2] = 0x00;  // Protocol hi
            sendBuf[3] = 0x00;  // Protocol lo

            sendBuf[4] = (byte)(sendBuf.Length - 6 >> 8);
            sendBuf[5] = (byte)(sendBuf.Length - 6 & 0xFF);

            sendBuf[6] = 0x01;  // DevID

            sendBuf[7] = 0x01;  // Function=Read_Coil

            sendBuf[8] = 0x00;  // start hi
            sendBuf[9] = 0x00;  // start lo

            sendBuf[10] = 0x00; // qty hi
            sendBuf[11] = 0x08; // qty lo

            try
            {
                stream.Write(sendBuf, 0, sendBuf.Length);

                // 로그
                Log_Data.AddLog(
                    DateTime.Now.ToString("HH:mm:ss.fff"),
                    "",
                    "SEND",
                    "ReadInitial => " + BitConverter.ToString(sendBuf)
                );
                //로그 데이터 확인 창 안켜도 텍스트 파일에 값 저장
                Log_Data.SaveLogToFile(
                    DateTime.Now.ToString("HH:mm:ss.fff"),
                    "",
                    "SEND",
                    "ReadInitial => " + BitConverter.ToString(sendBuf)
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Coil 초기값 읽기 오류: " + ex.Message);
            }
        }
        #endregion

        #region (5) Start / Stop
        private void Process_Start_Click(object sender, EventArgs e)
        {
            if (SavedControlData.Count == 0)
            {
                MessageBox.Show("설정된 값이 없습니다! Control_data에서 세팅하세요.");
                return;
            }

            Con_Register_data lastData = SavedControlData[SavedControlData.Count - 1];
            SendRecipeStatus();

            // 1) 0x10 (Write Multiple Register) 패킷 만들기  
            byte[] sendBuf = BuildWriteMultiplePacket(lastData, tid: 1);

            try
            {
                // 2) 전송
                stream.Write(sendBuf, 0, sendBuf.Length);
                Thread.Sleep(100);
                ReadInitialChamberSettings(1);
                // 로그
                Log_Data.AddLog("",
                    DateTime.Now.ToString("HH:mm:ss.fff"),
                    "SEND",
                    "Start => " + BitConverter.ToString(sendBuf)
                    );
                //로그 데이터 확인 창 안켜도 텍스트 파일에 값 저장
                Log_Data.SaveLogToFile("",
                    DateTime.Now.ToString("HH:mm:ss.fff"),
                    "SEND",
                    "Start => " + BitConverter.ToString(sendBuf)
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Start 전송 오류: " + ex.Message);
            }

        }

        private byte[] BuildWriteMultiplePacket(Con_Register_data data, ushort tid)
        {
            byte[] packet = new byte[31];

            // (A) Transaction ID
            packet[0] = (byte)((tid >> 8) & 0xFF);
            packet[1] = (byte)(tid & 0xFF);

            // (B) Protocol=0
            packet[2] = 0x00;
            packet[3] = 0x00;

            // (C) Length=17 (0x0011)
            packet[4] = 0x00;
            packet[5] = 0x17;

            // (D) dev=1
            packet[6] = 0x01;

            // (E) func=0x10
            packet[7] = 0x10;

            // (F) start=0x0000
            packet[8] = 0x00;
            packet[9] = 0x00;

            // (G) qty=8
            packet[10] = 0x00;
            packet[11] = 0x09;

            // (H) byteCount=10
            packet[12] = 0x12;

            // (I) 5개 레지스터
            // data.code0=온도 ...
            int temp = data.chamber_temp;
            int press = data.chamber_press;
            int flow = data.chamber_flow;
            int o3 = data.gas_O3;
            int n2 = data.gas_N2;
            int zro2 = data.gas_ZrO2;
            int hfo2 = data.gas_HfO2;
            int h2o2 = data.gas_H2O2;
            int tma = data.gas_TMA;

            // 레지스터는 2바이트씩
            // 첫 바이트는 보통 0x00, 두 번째 바이트에 실제값
            packet[13] = (byte)(temp >> 8);        // HighByte
            packet[14] = (byte)(temp & 0xFF);      // LowByte

            packet[15] = (byte)(press >> 8);
            packet[16] = (byte)(press & 0xFF);

            packet[17] = (byte)(flow >> 8);
            packet[18] = (byte)(flow & 0xFF);

            packet[19] = (byte)(o3 >> 8);
            packet[20] = (byte)(o3 & 0xFF);

            packet[21] = (byte)(n2 >> 8);
            packet[22] = (byte)(n2 & 0xFF);

            packet[23] = (byte)(zro2 >> 8);
            packet[24] = (byte)(zro2 & 0xFF);

            packet[25] = (byte)(hfo2 >> 8);
            packet[26] = (byte)(hfo2 & 0xFF);

            packet[27] = (byte)(h2o2 >> 8);
            packet[28] = (byte)(h2o2 & 0xFF);

            packet[29] = (byte)(tma >> 8);
            packet[30] = (byte)(tma & 0xFF);

            return packet;
        }

        private void Process_Stop_Click(object sender, EventArgs e)
        {
            byte[] coil = BuildSingleCoilPacket(tid: 2, coilAddr: 0, onOff: true);
            try
            {
                stream.Write(coil, 0, coil.Length);
                //로그
                Log_Data.AddLog(
                    "",
                    DateTime.Now.ToString("HH:mm:ss.fff"),
                    "SEND",
                    "Stop => " + BitConverter.ToString(coil)
                );
                //로그 데이터 확인 창 안켜도 텍스트 파일에 값 저장
                Log_Data.SaveLogToFile(
                    "",
                    DateTime.Now.ToString("HH:mm:ss.fff"),
                    "SEND",
                    "Stop => " + BitConverter.ToString(coil)
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Stop 오류: " + ex.Message);
            }

            // 로컬 단계 타이머 중지
            if (localStageTimer != null) localStageTimer.Stop();
            progressValue = 0;
            Process_progress.Value = 0;
        }

        // 현재 레시피 정보에 저장한 레시피 텍스트 출력
        private void SendRecipeStatus()
        {
            Con_Register_data lastData = SavedControlData[SavedControlData.Count - 1];

            recipe_panel_name.Text = lastData.recipe_name;
            recipe_panel_temp.Text = lastData.chamber_temp.ToString();
            recipe_panel_torr.Text = lastData.chamber_press.ToString();
            recipe_panel_O3.Text = lastData.gas_O3.ToString();
            recipe_panel_N2.Text = lastData.gas_N2.ToString();
            recipe_panel_ZrO2.Text = lastData.gas_ZrO2.ToString();
            recipe_panel_HfO2.Text = lastData.gas_HfO2.ToString();
            recipe_panel_H2O2.Text = lastData.gas_H2O2.ToString();
            recipe_panel_TMA.Text = lastData.gas_TMA.ToString();
        }
        #endregion

        #region (6) DryPump / Valves
        private void Dry_pump_button_Click(object sender, EventArgs e)
        {
            byte[] coil = BuildSingleCoilPacket(tid: 3, coilAddr: 1, onOff: true);
            try
            {
                stream.Write(coil, 0, coil.Length);
                Thread.Sleep(100);
                ReadInitialValveSettings(3);
                Log_Data.AddLog("", DateTime.Now.ToString("HH:mm:ss.fff"),
                    "SEND", "DryPump => " + BitConverter.ToString(coil));

                Log_Data.SaveLogToFile("", DateTime.Now.ToString("HH:mm:ss.fff"),
                    "SEND", "DryPump => " + BitConverter.ToString(coil));
                MessageBox.Show("Dry Pump 동작중!");
                Dry_Pump_Check_Box.Checked = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("DryPump 오류: " + ex.Message);
            }
            Thread.Sleep(3000); // 3초간 멈춤
            // 종료 신호 
            byte[] coils = BuildSingleCoilPacket(tid: 3, coilAddr: 1, onOff: false);
            try
            {
                stream.Write(coils, 0, coils.Length);
                Thread.Sleep(100);
                ReadInitialValveSettings(3);
                Log_Data.AddLog("", DateTime.Now.ToString("HH:mm:ss.fff"),
                    "SEND", "DryPump => " + BitConverter.ToString(coil));

                Log_Data.SaveLogToFile("", DateTime.Now.ToString("HH:mm:ss.fff"),
                    "SEND", "DryPump => " + BitConverter.ToString(coil));
                MessageBox.Show("Dry Pump 종료!");

                Dry_Pump_Check_Box.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("DryPump 멈춤 오류: " + ex.Message);
            }
        }
        private void O3_valOn_Click(object sender, EventArgs e)
        {
            byte[] coil = BuildSingleCoilPacket(tid: 5, coilAddr: 2, onOff: true);
            try
            {
                stream.Write(coil, 0, coil.Length);
                Thread.Sleep(100);
                ReadInitialValveSettings(5);
                Log_Data.AddLog("", DateTime.Now.ToString("HH:mm:ss.fff"),
                    "SEND", "O3 => " + BitConverter.ToString(coil));

                Log_Data.SaveLogToFile("", DateTime.Now.ToString("HH:mm:ss.fff"),
                    "SEND", "O3 => " + BitConverter.ToString(coil));
                O3_CheckBox.Checked = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
        private void O3_valOff_Click(object sender, EventArgs e)
        {
            byte[] coil = BuildSingleCoilPacket(tid: 5, coilAddr: 2, onOff: false);
            stream.Write(coil, 0, coil.Length);
            Thread.Sleep(100);
            ReadInitialValveSettings(5);
            Log_Data.AddLog("", DateTime.Now.ToString("HH:mm:ss.fff"),
                "SEND", "O3 => " + BitConverter.ToString(coil));

            Log_Data.SaveLogToFile("", DateTime.Now.ToString("HH:mm:ss.fff"),
                "SEND", "O3 => " + BitConverter.ToString(coil));
            O3_CheckBox.Checked = false;
        }
        private void N2_valOn_Click(object sender, EventArgs e)
        {
            byte[] coil = BuildSingleCoilPacket(tid: 6, coilAddr: 3, onOff: true);
            stream.Write(coil, 0, coil.Length);
            Thread.Sleep(100);
            ReadInitialValveSettings(6);
            Log_Data.AddLog("", DateTime.Now.ToString("HH:mm:ss.fff"),
                "SEND", "N2 => " + BitConverter.ToString(coil));

            Log_Data.SaveLogToFile("", DateTime.Now.ToString("HH:mm:ss.fff"),
                "SEND", "N2 => " + BitConverter.ToString(coil));
            N2_CheckBox.Checked = true;
        }
        private void N2_valOff_Click(object sender, EventArgs e)
        {
            byte[] coil = BuildSingleCoilPacket(tid: 6, coilAddr: 3, onOff: false);
            stream.Write(coil, 0, coil.Length);
            Thread.Sleep(100);
            ReadInitialValveSettings(6);
            Log_Data.AddLog("", DateTime.Now.ToString("HH:mm:ss.fff"),
                "SEND", "N2 => " + BitConverter.ToString(coil));

            Log_Data.SaveLogToFile("", DateTime.Now.ToString("HH:mm:ss.fff"),
                "SEND", "N2 => " + BitConverter.ToString(coil));
            N2_CheckBox.Checked = false;
        }
        private void ZrO2_valOn_Click(object sender, EventArgs e)
        {
            byte[] coil = BuildSingleCoilPacket(tid: 7, coilAddr: 4, onOff: true);
            stream.Write(coil, 0, coil.Length);
            Thread.Sleep(100);
            ReadInitialValveSettings(7);
            Log_Data.AddLog("", DateTime.Now.ToString("HH:mm:ss.fff"),
                "SEND", "ZrO2 => " + BitConverter.ToString(coil));

            Log_Data.SaveLogToFile("", DateTime.Now.ToString("HH:mm:ss.fff"),
                "SEND", "ZrO2 => " + BitConverter.ToString(coil));
            ZrO2_CheckBox.Checked = true;
        }
        private void ZrO2_valOff_Click(object sender, EventArgs e)
        {
            byte[] coil = BuildSingleCoilPacket(tid: 7, coilAddr: 4, onOff: false);
            stream.Write(coil, 0, coil.Length);
            Thread.Sleep(100);
            ReadInitialValveSettings(7);
            Log_Data.AddLog("", DateTime.Now.ToString("HH:mm:ss.fff"),
                "SEND", "ZrO2 => " + BitConverter.ToString(coil));

            Log_Data.SaveLogToFile("", DateTime.Now.ToString("HH:mm:ss.fff"),
                "SEND", "ZrO2 => " + BitConverter.ToString(coil));
            ZrO2_CheckBox.Checked = false;
        }
        private void HfO2_valOn_Click(object sender, EventArgs e)
        {
            byte[] coil = BuildSingleCoilPacket(tid: 8, coilAddr: 5, onOff: true);
            stream.Write(coil, 0, coil.Length);
            Thread.Sleep(100);
            ReadInitialValveSettings(8);
            Log_Data.AddLog("", DateTime.Now.ToString("HH:mm:ss.fff"),
                "SEND", "HfO2 => " + BitConverter.ToString(coil));

            Log_Data.SaveLogToFile("", DateTime.Now.ToString("HH:mm:ss.fff"),
                "SEND", "HfO2 => " + BitConverter.ToString(coil));
            HfO2_CheckBox.Checked = true;
        }
        private void HfO2_valOff_Click(object sender, EventArgs e)
        {
            byte[] coil = BuildSingleCoilPacket(tid: 8, coilAddr: 5, onOff: false);
            stream.Write(coil, 0, coil.Length);
            Thread.Sleep(100);
            ReadInitialValveSettings(8);
            Log_Data.AddLog("", DateTime.Now.ToString("HH:mm:ss.fff"),
                "SEND", "HfO2 => " + BitConverter.ToString(coil));

            Log_Data.SaveLogToFile("", DateTime.Now.ToString("HH:mm:ss.fff"),
                "SEND", "HfO2 => " + BitConverter.ToString(coil));
            HfO2_CheckBox.Checked = false;
        }
        private void H2O2_valOn_Click(object sender, EventArgs e)
        {
            byte[] coil = BuildSingleCoilPacket(tid: 9, coilAddr: 6, onOff: true);
            stream.Write(coil, 0, coil.Length);
            Thread.Sleep(100);
            ReadInitialValveSettings(9);
            Log_Data.AddLog("", DateTime.Now.ToString("HH:mm:ss.fff"),
                "SEND", "H2O2 => " + BitConverter.ToString(coil));

            Log_Data.SaveLogToFile("", DateTime.Now.ToString("HH:mm:ss.fff"),
                "SEND", "H2O2 => " + BitConverter.ToString(coil));
            H2O2_CheckBox.Checked = true;
        }
        private void H2O2_valOff_Click(object sender, EventArgs e)
        {
            byte[] coil = BuildSingleCoilPacket(tid: 9, coilAddr: 6, onOff: false);
            stream.Write(coil, 0, coil.Length);
            Thread.Sleep(100);
            ReadInitialValveSettings(9);
            Log_Data.AddLog("", DateTime.Now.ToString("HH:mm:ss.fff"),
                "SEND", "H2O2 => " + BitConverter.ToString(coil));

            Log_Data.SaveLogToFile("", DateTime.Now.ToString("HH:mm:ss.fff"),
                "SEND", "H2O2 => " + BitConverter.ToString(coil));
            H2O2_CheckBox.Checked = false;
        }
        private void TMA_valOn_Click(object sender, EventArgs e)
        {
            byte[] coil = BuildSingleCoilPacket(tid: 10, coilAddr: 7, onOff: true);
            stream.Write(coil, 0, coil.Length);
            Thread.Sleep(100);
            ReadInitialValveSettings(10);
            Log_Data.AddLog("", DateTime.Now.ToString("HH:mm:ss.fff"),
                "SEND", "TMA => " + BitConverter.ToString(coil));

            Log_Data.SaveLogToFile("", DateTime.Now.ToString("HH:mm:ss.fff"),
                "SEND", "TMA => " + BitConverter.ToString(coil));
            TMA_CheckBox.Checked = true;
        }
        private void TMA_valOff_Click(object sender, EventArgs e)
        {
            byte[] coil = BuildSingleCoilPacket(tid: 10, coilAddr: 7, onOff: false);
            stream.Write(coil, 0, coil.Length);
            Thread.Sleep(100);
            ReadInitialValveSettings(10);
            Log_Data.AddLog("", DateTime.Now.ToString("HH:mm:ss.fff"),
                "SEND", "TMA => " + BitConverter.ToString(coil));

            Log_Data.SaveLogToFile("", DateTime.Now.ToString("HH:mm:ss.fff"),
                "SEND", "TMA => " + BitConverter.ToString(coil));
            TMA_CheckBox.Checked = false;
        }
        private byte[] BuildSingleCoilPacket(ushort tid, ushort coilAddr, bool onOff)
        {
            byte[] packet = new byte[12];
            // TID
            packet[0] = (byte)((tid >> 8) & 0xFF);
            packet[1] = (byte)(tid & 0xFF);
            // Protocol=0
            packet[2] = 0x00;
            packet[3] = 0x00;
            // length=6
            packet[4] = 0x00;
            packet[5] = 0x06;
            // DevID=1
            packet[6] = 0x01;
            // func=0x05
            packet[7] = 0x05;

            // coilAddr
            packet[8] = (byte)((coilAddr >> 8) & 0xFF);
            packet[9] = (byte)(coilAddr & 0xFF);

            // val=0xFF00(ON)/0x0000(OFF)
            ushort val = (ushort)(onOff ? 0xFF00 : 0x0000);
            packet[10] = (byte)((val >> 8) & 0xFF);
            packet[11] = (byte)(val & 0xFF);

            return packet;
        }
        #endregion

        #region (7) 로컬 8단계 시뮬레이션 (1초마다 6.25씩)
        /// <summary>
        /// 8단계(온도->압력->유량->오존->질소->wafer_size->wafer_loading->wafer_flat_area)
        /// 하나의 진행도 바를 0→100%로 약 16초간 올리면서, 
        /// progressValue가 (stageIndex+1)*12.5 에 도달할 때마다 
        /// 한 단계를 완료시키는 방식.
        /// </summary>

        private void ChangeWaferData(Con_Register_data data)
        {
            // 모든 값을 byte 타입으로 변환하여 stageValues 배열에 저장
            stageValues[0] = (byte)data.wafer_size;
            stageValues[1] = (byte)(data.wafer_loading == 0 ? 0 : 1);
            stageValues[2] = data.wafer_flat_area;
            stageValues[3] = (byte)data.wafer_amount;

            // 웨이퍼 정보 영역에 byte 값 표시
            if (data.wafer_size > 0)
            {
                byte waferSize = (byte)data.wafer_size;
                wafer_size_textbox.Text = waferSize.ToString();
            }
            if (data.wafer_loading >= 0)
            {
                string waferLoading = (byte)(data.wafer_loading == 0 ? 0 : 1) switch
                {
                    0 => "Single",
                    1 => "Batch"
                };
                wafer_loading_textbox.Text = waferLoading;
            }
            if (data.wafer_flat_area >= 0)
            {
                string waferFlatArea = (byte)(data.wafer_flat_area) switch
                {
                    10 => "100(N)",
                    20 => "100(P)",
                    30 => "111(N)",
                    40 => "111(P)",
                    50 => "Notch Type"
                };

                wafer_flat_area_textbox.Text = waferFlatArea;
            }
            if (data.wafer_amount > 0)
            {
                byte waferAmount = (byte)data.wafer_amount;
                wafer_amount_textbox.Text = waferAmount.ToString();

                switch (waferAmount)
                {
                    case 100:
                        wafer_amount_panel1.BackColor = Color.Red;
                        wafer_amount_panel2.BackColor = Color.White;
                        wafer_amount_panel3.BackColor = Color.White;
                        wafer_amount_panel4.BackColor = Color.White;
                        wafer_amount_panel5.BackColor = Color.White;
                        wafer_amount_panel6.BackColor = Color.White;
                        break;
                    case 110:
                        wafer_amount_panel1.BackColor = Color.Red;
                        wafer_amount_panel2.BackColor = Color.Red;
                        wafer_amount_panel3.BackColor = Color.White;
                        wafer_amount_panel4.BackColor = Color.White;
                        wafer_amount_panel5.BackColor = Color.White;
                        wafer_amount_panel6.BackColor = Color.White;
                        break;
                    case 120:
                        wafer_amount_panel1.BackColor = Color.Red;
                        wafer_amount_panel2.BackColor = Color.Red;
                        wafer_amount_panel3.BackColor = Color.Red;
                        wafer_amount_panel4.BackColor = Color.White;
                        wafer_amount_panel5.BackColor = Color.White;
                        wafer_amount_panel6.BackColor = Color.White;
                        break;
                    case 130:
                        wafer_amount_panel1.BackColor = Color.Red;
                        wafer_amount_panel2.BackColor = Color.Red;
                        wafer_amount_panel3.BackColor = Color.Red;
                        wafer_amount_panel4.BackColor = Color.Red;
                        wafer_amount_panel5.BackColor = Color.White;
                        wafer_amount_panel6.BackColor = Color.White;
                        break;
                    case 140:
                        wafer_amount_panel1.BackColor = Color.Red;
                        wafer_amount_panel2.BackColor = Color.Red;
                        wafer_amount_panel3.BackColor = Color.Red;
                        wafer_amount_panel4.BackColor = Color.Red;
                        wafer_amount_panel5.BackColor = Color.Red;
                        wafer_amount_panel6.BackColor = Color.White;
                        break;
                    case 150:
                        wafer_amount_panel1.BackColor = Color.Red;
                        wafer_amount_panel2.BackColor = Color.Red;
                        wafer_amount_panel3.BackColor = Color.Red;
                        wafer_amount_panel4.BackColor = Color.Red;
                        wafer_amount_panel5.BackColor = Color.Red;
                        wafer_amount_panel6.BackColor = Color.Red;
                        break;
                }
                chamber_ready_panel.BackColor = Color.Green;
            }
        }

        private DateTime StageStartTime; //시작 시간 기록할 변수 선언
        private void StartLocalStageSimulation(string flag, Con_Register_data data)
        {
            if (chamber_ready_panel.BackColor == Color.Green)
            {
                // 기존 stageValues 설정
                stageValues[0] = data.chamber_temp;
                stageValues[1] = data.chamber_press;
                stageValues[2] = data.chamber_flow;
                stageValues[3] = data.gas_O3;
                stageValues[4] = data.gas_N2;
                stageValues[5] = data.gas_ZrO2;
                stageValues[6] = data.gas_HfO2;
                stageValues[7] = data.gas_H2O2;
                stageValues[8] = data.gas_TMA;


                // 단계 인덱스와 진행도(double)
                stageIndex = 0;
                // progressValue를 double로 선언해야 6.25 같은 소수점 누적 가능
                // double 선언해야하는데 안되서 그냥 int로 박아버림 (int)로 되어있는 부분들
                progressValue = (int)0.0;

                // 프로그레스바 초기화 (int 변환 필요)
                Process_progress.Value = 0;

                StageStartTime = DateTime.Now;

                // 타이머 설정
                if (localStageTimer != null)
                    localStageTimer.Stop();

                localStageTimer = new System.Windows.Forms.Timer();
                localStageTimer.Interval = 1000; // 1초
                localStageTimer.Tick += LocalStageTimer_Tick;
                localStageTimer.Start();
            }
            else
            {
                MessageBox.Show("Chamber 내부의 Wafer가 준비되지 않았습니다!");
            }

        }

        /// <summary>
        /// 1초마다 progressValue += 6.25 → 약 16초 후 100. 시간은 그때그때 다르므로 16초 라고 단정짓지 말기 ok?
        /// 단계별 임계점 = 12.5%, 25.0%, 37.5% ... 100% 까지 
        /// => if progressValue >= (stageIndex+1)*12.5 => 그 단계 완료
        /// </summary>
        private void LocalStageTimer_Tick(object sender, EventArgs e)
        {
            // (1) 진행도 증가 (double)
            progressValue += (int)5.55;   //9개 기준으로 변경해야 함    // progressValue += 50; 이게 기존 코드 
            if (progressValue > (int)100.0)
                progressValue = (int)100.0;

            // (2) 프로그레스바에 표시 => int 캐스팅 필요
            //    암시적 변환 안 되므로 (int) 로 바꾸고 
            //(int)Math.Round(progressValue); 이대로는 안되니까 (double 추가) 
            Process_progress.Value = (int)Math.Round((double)progressValue);   //Process_progress.Value = Math.Min(progressValue, 100); 이게 기존코드
                                                                               // 왜 Round 썼냐 하면 반올림 하기 위해서 정수로 받아와야하기 때문에 
                                                                               // (3) "단계 완료" 판단
                                                                               //     예: stageIndex=0 => 단계별로 임계점 도달 12.5
                                                                               //         stageIndex=1 => 25.0 ...
            while (stageIndex < 9
                //2초마다 다음 case로
                && progressValue >= (stageIndex + 1) * 11.1)
            {
                // stageIndex번째 단계 완료 처리
                switch (stageIndex)
                {
                    case 0: // 온도
                        recv_cham_temp.Text = stageValues[0].ToString();
                        Chamber_Temp_progress.Value = 100;
                        break;
                    case 1: // 압력
                        recv_cham_torr.Text = stageValues[1].ToString();
                        Chamber_Torr_progress.Value = 100;
                        break;
                    case 2: // 유량
                        recv_strr.Text = stageValues[2].ToString();
                        Gas_progress.Value = 0;
                        break;
                    case 3: // 오존
                        O3_CheckBox.Checked = true;
                        recv_o3.Text = stageValues[3].ToString();
                        recv_strr.Text = stageValues[3].ToString();
                        Gas_progress.Value = 100;
                        break;
                    case 4: // 질소
                        Gas_progress.Value = 0;
                        O3_CheckBox.Checked = false;
                        ShowAutoClosingMessageBox("N2유입중... 반응물 제거중... (H2O2 Purge)", "Purge", 400);
                        N2_CheckBox.Checked = true;
                        recv_n2.Text = stageValues[4].ToString();
                        recv_strr.Text = stageValues[4].ToString();
                        Gas_progress.Value = 100;
                        break;
                    case 5: // ZrO2
                        Gas_progress.Value = 0;
                        N2_CheckBox.Checked = false;
                        ShowAutoClosingMessageBox("N2유입중... 반응물 제거중... (H2O2 Purge)", "Purge", 400);
                        ZrO2_CheckBox.Checked = true;
                        recv_zro2.Text = stageValues[5].ToString();
                        recv_strr.Text = stageValues[5].ToString();
                        Gas_progress.Value = 100;
                        break;
                    case 6: // HfO2
                        Gas_progress.Value = 0;
                        ZrO2_CheckBox.Checked = false;
                        ShowAutoClosingMessageBox("N2유입중... 반응물 제거중... (H2O2 Purge)", "Purge", 400);
                        HfO2_CheckBox.Checked = true;
                        recv_hfo2.Text = stageValues[6].ToString();
                        recv_strr.Text = stageValues[6].ToString();
                        Gas_progress.Value = 100;
                        break;
                    case 7:// H2O2
                        Gas_progress.Value = 0;
                        HfO2_CheckBox.Checked = false;
                        ShowAutoClosingMessageBox("N2유입중... 반응물 제거중... (H2O2 Purge)", "Purge", 400);
                        H2O2_CheckBox.Checked = true;
                        recv_h2o2.Text = stageValues[7].ToString();
                        recv_strr.Text = stageValues[7].ToString();
                        Gas_progress.Value = 100;
                        break;
                    case 8: // TMA
                        Gas_progress.Value = 0;
                        H2O2_CheckBox.Checked = false;
                        ShowAutoClosingMessageBox("N2유입중... 반응물 제거중... (H2O2 Purge)", "Purge", 400);
                        TMA_CheckBox.Checked = true;
                        recv_tma.Text = stageValues[8].ToString();
                        recv_strr.Text = stageValues[8].ToString();
                        Gas_progress.Value = 100;
                        // Chamber와 Wafer 쌓이는 부분 초기화 해주기
                        WaferAmountReset();
                        break;
                }

                stageIndex++;

                // 모든 단계(0~8) 완료하면 타이머 정지
                if (stageIndex >= 9)
                {
                    localStageTimer.Stop();


                    //경과시간 구하는 코드 추가 
                    TimeSpan elapesd = DateTime.Now - StageStartTime;
                    double seconds = elapesd.TotalSeconds;
                    // 여기까지 F2 는 소수점 2자리까지 보여주기 위해 설정

                    MessageBox.Show($"설정 완료!(걸린시간 : {seconds:F2} 초)");
                    recv_strr.Text = "0";
                    TMA_CheckBox.Checked = false;
                    // Wafer 이전값으로 재설정
                    WaferAmountBeforeSetting();

                    break;
                }
            }

        }


        /// <summary>
        /// 일정 시간이 지나면 자동으로 닫히는 메시지 박스
        /// </summary>
        public static void ShowAutoClosingMessageBox(string message, string caption, int timeout)
        {
            System.Threading.Timer timer = null;
            timer = new System.Threading.Timer((state) =>
            {
                IntPtr mbWnd = FindWindow(null, caption);
                if (mbWnd != IntPtr.Zero)
                {
                    SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
                }
                timer.Dispose();
            }, null, timeout, System.Threading.Timeout.Infinite);

            MessageBox.Show(message, caption);
        }

        // P/Invoke 선언
        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        private const uint WM_CLOSE = 0x0010;
        #endregion

        #region (8)폼 이동 wafer_setting/ Log_data / Control_data / Plasma / Exit 
        private void Log_data_button_Click(object sender, EventArgs e)
        {
            Log_Data logForm = new Log_Data();
            logForm.Show();
        }

        private void Control_data_button_Click(object sender, EventArgs e)
        {
            Control_data cdForm = new Control_data();
            cdForm.Show();

        }
        private void Wafer_setting_button_Click(object sender, EventArgs e)
        {
            Wafer_Control_data cdForm = new Wafer_Control_data(this);
            cdForm.Show();
        }
        private void Plasma_Control_button_Click(object sender, EventArgs e)
        {
            Plasma_Control cdForm = new Plasma_Control(this);
            cdForm.Show();
        }
        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region(9) 배관라인 그리기
        private void DrawPipeLine(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 2);

            // Gas Line 가스 배관 라인
            g.DrawLine(pen, 560, 294, 700, 294);
            g.DrawLine(pen, 560, 304, 700, 304);
            g.DrawEllipse(pen, 618, 287, 20, 20);

            g.DrawLine(pen, 560, 352, 700, 352);
            g.DrawLine(pen, 560, 362, 700, 362);
            g.DrawEllipse(pen, 618, 345, 20, 20);

            g.DrawLine(pen, 560, 408, 700, 408);
            g.DrawLine(pen, 560, 418, 700, 418);
            g.DrawEllipse(pen, 618, 402, 20, 20);

            g.DrawLine(pen, 560, 466, 700, 466);
            g.DrawLine(pen, 560, 476, 700, 476);
            g.DrawEllipse(pen, 618, 462, 20, 20);

            g.DrawLine(pen, 560, 524, 700, 524);
            g.DrawLine(pen, 560, 534, 700, 534);
            g.DrawEllipse(pen, 618, 518, 20, 20);

            g.DrawLine(pen, 560, 574, 700, 574);
            g.DrawLine(pen, 560, 584, 700, 584);
            g.DrawEllipse(pen, 618, 567, 20, 20);


            // Dry Pump 배관 라인
            g.DrawEllipse(pen, 429, 220, 20, 20);
            g.DrawLine(pen, 435, 200, 435, 400);
            g.DrawLine(pen, 445, 200, 445, 400);
        }

        #endregion

        #region (10) 웨이퍼 관련 함수
        private void ShowWaferData(Con_Register_data data)
        {
            // 모든 값을 byte 타입으로 변환하여 stageValues 배열에 저장
            stageValues[9] = (byte)data.wafer_size;
            stageValues[10] = (byte)(data.wafer_loading == 0 ? 0 : 1);
            stageValues[11] = data.wafer_flat_area;
            stageValues[12] = (byte)data.wafer_amount;

            // 웨이퍼 정보 영역에 byte 값 표시
            if (data.wafer_size > 0)
            {
                string waferSize = data.wafer_size.ToString();
                wafer_size_textbox.Text = waferSize.ToString();
            }
            if (data.wafer_loading >= 0)
            {
                string waferLoading = (data.wafer_loading == 0 ? 0 : 1) switch
                {
                    0 => "Single",
                    1 => "Batch"
                };
                wafer_loading_textbox.Text = waferLoading;
            }
            if (data.wafer_flat_area >= 0)
            {
                string waferFlatArea = data.wafer_flat_area switch
                {
                    10 => "100(N)",
                    20 => "100(P)",
                    30 => "111(N)",
                    40 => "111(P)",
                    50 => "Notch Type"
                };

                wafer_flat_area_textbox.Text = waferFlatArea;
            }
            if (data.wafer_amount >= 0)
            {
                int waferAmount = data.wafer_amount;
                wafer_amount_textbox.Text = waferAmount.ToString();

                switch (waferAmount)
                {
                    case 100:
                        wafer_amount_panel1.BackColor = Color.Red;
                        wafer_amount_panel2.BackColor = Color.White;
                        wafer_amount_panel3.BackColor = Color.White;
                        wafer_amount_panel4.BackColor = Color.White;
                        wafer_amount_panel5.BackColor = Color.White;
                        wafer_amount_panel6.BackColor = Color.White;
                        break;
                    case 110:
                        wafer_amount_panel1.BackColor = Color.Red;
                        wafer_amount_panel2.BackColor = Color.Red;
                        wafer_amount_panel3.BackColor = Color.White;
                        wafer_amount_panel4.BackColor = Color.White;
                        wafer_amount_panel5.BackColor = Color.White;
                        wafer_amount_panel6.BackColor = Color.White;
                        break;
                    case 120:
                        wafer_amount_panel1.BackColor = Color.Red;
                        wafer_amount_panel2.BackColor = Color.Red;
                        wafer_amount_panel3.BackColor = Color.Red;
                        wafer_amount_panel4.BackColor = Color.White;
                        wafer_amount_panel5.BackColor = Color.White;
                        wafer_amount_panel6.BackColor = Color.White;
                        break;
                    case 130:
                        wafer_amount_panel1.BackColor = Color.Red;
                        wafer_amount_panel2.BackColor = Color.Red;
                        wafer_amount_panel3.BackColor = Color.Red;
                        wafer_amount_panel4.BackColor = Color.Red;
                        wafer_amount_panel5.BackColor = Color.White;
                        wafer_amount_panel6.BackColor = Color.White;
                        break;
                    case 140:
                        wafer_amount_panel1.BackColor = Color.Red;
                        wafer_amount_panel2.BackColor = Color.Red;
                        wafer_amount_panel3.BackColor = Color.Red;
                        wafer_amount_panel4.BackColor = Color.Red;
                        wafer_amount_panel5.BackColor = Color.Red;
                        wafer_amount_panel6.BackColor = Color.White;
                        break;
                    case 150:
                        wafer_amount_panel1.BackColor = Color.Red;
                        wafer_amount_panel2.BackColor = Color.Red;
                        wafer_amount_panel3.BackColor = Color.Red;
                        wafer_amount_panel4.BackColor = Color.Red;
                        wafer_amount_panel5.BackColor = Color.Red;
                        wafer_amount_panel6.BackColor = Color.Red;
                        break;
                }
                chamber_ready_panel.BackColor = Color.Green;
            }
        }
        public void WaferAmountReset()
        {
            chamber_ready_panel.BackColor = Color.Red;
            wafer_amount_panel1.BackColor = Color.White;
            wafer_amount_panel2.BackColor = Color.White;
            wafer_amount_panel3.BackColor = Color.White;
            wafer_amount_panel4.BackColor = Color.White;
            wafer_amount_panel5.BackColor = Color.White;
            wafer_amount_panel6.BackColor = Color.White;
        }
        public void WaferAmountBeforeSetting()
        {
            int waferAmount = int.Parse(wafer_amount_textbox.Text);

            Thread_Setting settingForm = new Thread_Setting();
            settingForm.ShowDialog();

            MessageBox.Show("웨이퍼 적재 완료!");
            switch (waferAmount)
            {
                case 100:
                    wafer_amount_panel1.BackColor = Color.Red;
                    wafer_amount_panel2.BackColor = Color.White;
                    wafer_amount_panel3.BackColor = Color.White;
                    wafer_amount_panel4.BackColor = Color.White;
                    wafer_amount_panel5.BackColor = Color.White;
                    wafer_amount_panel6.BackColor = Color.White;
                    break;
                case 110:
                    wafer_amount_panel1.BackColor = Color.Red;
                    wafer_amount_panel2.BackColor = Color.Red;
                    wafer_amount_panel3.BackColor = Color.White;
                    wafer_amount_panel4.BackColor = Color.White;
                    wafer_amount_panel5.BackColor = Color.White;
                    wafer_amount_panel6.BackColor = Color.White;
                    break;
                case 120:
                    wafer_amount_panel1.BackColor = Color.Red;
                    wafer_amount_panel2.BackColor = Color.Red;
                    wafer_amount_panel3.BackColor = Color.Red;
                    wafer_amount_panel4.BackColor = Color.White;
                    wafer_amount_panel5.BackColor = Color.White;
                    wafer_amount_panel6.BackColor = Color.White;
                    break;
                case 130:
                    wafer_amount_panel1.BackColor = Color.Red;
                    wafer_amount_panel2.BackColor = Color.Red;
                    wafer_amount_panel3.BackColor = Color.Red;
                    wafer_amount_panel4.BackColor = Color.Red;
                    wafer_amount_panel5.BackColor = Color.White;
                    wafer_amount_panel6.BackColor = Color.White;
                    break;
                case 140:
                    wafer_amount_panel1.BackColor = Color.Red;
                    wafer_amount_panel2.BackColor = Color.Red;
                    wafer_amount_panel3.BackColor = Color.Red;
                    wafer_amount_panel4.BackColor = Color.Red;
                    wafer_amount_panel5.BackColor = Color.Red;
                    wafer_amount_panel6.BackColor = Color.White;
                    break;
                case 150:
                    wafer_amount_panel1.BackColor = Color.Red;
                    wafer_amount_panel2.BackColor = Color.Red;
                    wafer_amount_panel3.BackColor = Color.Red;
                    wafer_amount_panel4.BackColor = Color.Red;
                    wafer_amount_panel5.BackColor = Color.Red;
                    wafer_amount_panel6.BackColor = Color.Red;
                    break;
            }
            chamber_ready_panel.BackColor = Color.Green;
        }
        #endregion

        #region(11) 플라즈마 함수
        private void ChangePlasmaData(Con_Register_data data)
        {
            stageValues[13] = (byte)data.rf_power;
            stageValues[14] = (byte)data.plasma_forward;
            stageValues[15] = (byte)data.plasma_reflected;
            if (data.rf_power >= 0)
            {
                string rfPowerText = (byte)(data.rf_power == 0 ? 0 : 1) switch
                {
                    0 => "ON",
                    1 => "OFF"
                };
                rf_power_textbox.Text = rfPowerText;
            }

            // 3. plasma_forward 값 표시
            if (data.plasma_forward >= 0)
            {
                plasma_forward_textbox.Text = data.plasma_forward.ToString();
            }

            // 4. plasma_reflected 값 표시
            if (data.plasma_reflected >= 0)
            {
                plasma_reflected_textbox.Text = data.plasma_reflected.ToString();
            }

        }

        private void ShowPlasmaData(Con_Register_data data)
        {
            // 1. stageValues 배열에 Plasma 데이터 저장
            stageValues[13] = (byte)(data.rf_power);
            stageValues[14] = (byte)data.plasma_forward;
            stageValues[15] = (byte)data.plasma_reflected;

            // 3. plasma_forward 값 표시
            if (data.plasma_forward > 0)
            {
                plasma_forward_textbox.Text = data.plasma_forward.ToString();
            }

            // 4. plasma_reflected 값 표시
            if (data.plasma_reflected > 0)
            {
                plasma_reflected_textbox.Text = data.plasma_reflected.ToString();
            }
        }

        #endregion
    }
}
