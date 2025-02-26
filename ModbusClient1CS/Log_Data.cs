using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ModbusClientCS
{
    public partial class Log_Data : Form
    {
        private static Log_Data _instance = null;
        private static List<(string sendTime, string recvTime, string type, string data)> logList
            = new List<(string, string, string, string)>();

        public Log_Data()
        {
            InitializeComponent();
            _instance = this;
            RefreshLogGrid();
        }

        #region (1)그리드 뷰 로그 관련
        public static void AddLog(string sendTime, string recvTime, string type, string data) // 로그 창 로그 추가 함수
        {
            logList.Add((sendTime, recvTime, type, data));
            if (_instance != null && !_instance.IsDisposed)
            {
                _instance.poisonDataGridView1.Rows.Add(
                    sendTime, recvTime, type, data
                );
            }
        }
        private void RefreshLogGrid() // Grid뷰 초기화
        {
            poisonDataGridView1.Rows.Clear();
            foreach (var item in logList)
            {
                poisonDataGridView1.Rows.Add(
                    item.sendTime, item.recvTime, item.type, item.data
                );
            }
        }
        #endregion

        #region (2)로그 정보 텍스트 파일에 저장
        public static void SaveLogToFile(string sendTime, string recvTime, string type, string data)
        {
            //절대경로에 저장
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LogData");
            string fileName = DateTime.Now.ToString("yyyyMMdd") + ".txt";
            string filePath = Path.Combine(directoryPath, fileName);

            try
            {
                // 경로가 존재하지 않으면 폴더 먼저 생성
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                // 로그 파일에 데이터 추가 (append 모드)
                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    //컬럼별 값들 가져옴
                    sw.WriteLine(sendTime + " " + recvTime + " " + type + " " + data + " ");
                    //sw.WriteLine($"{sendTime},{recvTime},{type},{data}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("로그 저장 중 오류 발생: " + ex.Message);
            }
        }
        #endregion
    }
}
