// Control_data.cs
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace ModbusClientCS
{
    public partial class Control_data : Form
    {
        // Recipe 데이터 저장용 List
        private List<Con_Register_data> recipeDataList = new List<Con_Register_data>();

        public Control_data()
        {
            InitializeComponent();
            LoadRecipesFromFile(); // 프로그램 시작 시 데이터 복원
        }

        #region JSON 형태로 데이터 저장
        private void SaveRecipesToFile()
        {
            string filePath = "recipes.json";
            string jsonData = JsonSerializer.Serialize(recipeDataList);
            File.WriteAllText(filePath, jsonData);
        }
        #endregion

        #region JSON 파일에서 레시피 불러오기
        private void LoadRecipesFromFile()
        {
            string filePath = "recipes.json";
            if (File.Exists(filePath))
            {
                string jsonData = File.ReadAllText(filePath);
                recipeDataList = JsonSerializer.Deserialize<List<Con_Register_data>>(jsonData) ?? new List<Con_Register_data>();

                // ListBox 복원
                foreach (var data in recipeDataList)
                {
                    string time = DateTime.Now.ToString("d");
                    Recipe_list.Items.Add($"이름 : {data.recipe_name} / 날짜 : {time}");
                }
            }
        }
        #endregion

        #region 레시피 변경/저장, 삭제 버튼
        private void Recipe_send_button_Click(object sender, EventArgs e)
        {
            // 값이 비어 있으면 0을 할당하는 함수
            int ParseOrDefault(TextBox textBox)
            {
                return string.IsNullOrWhiteSpace(textBox.Text) ? 0 : int.Parse(textBox.Text);
            }

            // 필수 입력값 검사 함수
            bool IsRequiredFieldEmpty(params TextBox[] textBoxes)
            {
                return textBoxes.Any(tb => string.IsNullOrWhiteSpace(tb.Text));
            }

            // 필수 입력값 확인
            if (IsRequiredFieldEmpty(textBox1, textBox2, Recipe_name_textbox))
            {
                MessageBox.Show("온도, 압력, 유량, 레시피 이름 값은 반드시 입력해야 합니다.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // 저장하지 않고 함수 종료
            }

            // code0=온도, code1=압력, code2=유량, code3=O3, code4=N2
            Con_Register_data newData = new Con_Register_data();
            newData.transaction_id = 1;
            newData.function_code = 0x10;
            newData.start_address = 0;
            newData.register_num = 16;

            // 필수 입력값 (무조건 입력해야 함)
            newData.chamber_temp = int.Parse(textBox1.Text);
            newData.chamber_press = int.Parse(textBox2.Text);

            newData.gas_O3 = ParseOrDefault(textBox8);
            newData.gas_N2 = ParseOrDefault(textBox9);
            newData.gas_ZrO2 = ParseOrDefault(textBox10);
            newData.gas_HfO2 = ParseOrDefault(textBox11);
            newData.gas_H2O2 = ParseOrDefault(textBox12);
            newData.gas_TMA = ParseOrDefault(textBox13);

            newData.recipe_name = Recipe_name_textbox.Text;

            DateTime now = DateTime.Now;

            string time = string.Format("{0:d}", now);

            // 중복된 recipe_name이 있는지 확인
            bool isDuplicate = recipeDataList.Any(r => r.recipe_name == newData.recipe_name);


            if (!isDuplicate)
            {
                Recipe_list.Items.Add($"이름 : {newData.recipe_name} / 날짜 : {time}");

                // List에 추가 (중복 허용 안 함)
                recipeDataList.Add(newData);
                MainForm.SavedControlData.Add(newData);

                MessageBox.Show("레시피가 저장되었습니다.");
            }
            else
            {
                MessageBox.Show("이미 존재하는 레시피 이름입니다. 다른 이름을 입력하세요.");
            }
        }
        private void Recipe_Delete_button_Click(object sender, EventArgs e)
        {
            // 선택된 아이템에서 recipe_name 추출
            string selectedText = Recipe_list.SelectedItem.ToString();
            string recipeName = ExtractRecipeName(selectedText);

            // List에서 검색
            Con_Register_data foundData = recipeDataList.FirstOrDefault(r => r.recipe_name == recipeName);

            recipeDataList.Remove(foundData);       // 리스트에서 제거
            Recipe_list.Items.Remove(selectedText); // 리스트박스에서 제거
        }
        #endregion

        #region 리스트 박스 항목 선택시 이벤트
        private string ExtractRecipeName(string selectedText)
        {
            // "이름 : " 이후의 부분만 가져옴
            string[] parts = selectedText.Split(new string[] { "이름 : ", " / 날짜 :" }, StringSplitOptions.None);
            return parts.Length > 1 ? parts[1].Trim() : string.Empty;
        }
        private void Recipe_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();

            if (Recipe_list.SelectedItem != null)
            {
                // 선택된 아이템에서 recipe_name 추출
                string selectedText = Recipe_list.SelectedItem.ToString();
                string recipeName = ExtractRecipeName(selectedText);

                // List에서 검색
                Con_Register_data foundData = recipeDataList.FirstOrDefault(r => r.recipe_name == recipeName);

                textBox1.Text = foundData.chamber_temp.ToString();
                textBox2.Text = foundData.chamber_press.ToString();
                textBox8.Text = foundData.gas_O3.ToString();
                textBox9.Text = foundData.gas_N2.ToString();
                textBox10.Text = foundData.gas_ZrO2.ToString();
                textBox11.Text = foundData.gas_HfO2.ToString();
                textBox12.Text = foundData.gas_H2O2.ToString();
                textBox13.Text = foundData.gas_TMA.ToString();
                Recipe_name_textbox.Text = foundData.recipe_name;

            }
        }

        // 폼 종료시 이벤트
        private void Control_data_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveRecipesToFile();
        }

        // 저장된 레시피 가져와서 저장하기
        private void Recipe_list_button_Click(object sender, EventArgs e)
        {
            // 값이 비어 있으면 0을 할당하는 함수
            int ParseOrDefault(TextBox textBox)
            {
                return string.IsNullOrWhiteSpace(textBox.Text) ? 0 : int.Parse(textBox.Text);
            }

            // 필수 입력값 검사 함수
            bool IsRequiredFieldEmpty(params TextBox[] textBoxes)
            {
                return textBoxes.Any(tb => string.IsNullOrWhiteSpace(tb.Text));
            }

            // 필수 입력값 확인
            if (IsRequiredFieldEmpty(textBox1, textBox2, Recipe_name_textbox))
            {
                MessageBox.Show("온도, 압력, 유량, 레시피 이름 값은 반드시 입력해야 합니다.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // 저장하지 않고 함수 종료
            }
            // code0=온도, code1=압력, code2=유량, code3=O3, code4=N2
            Con_Register_data newData = new Con_Register_data();
            newData.transaction_id = 1;
            newData.function_code = 0x10;
            newData.start_address = 0;
            newData.register_num = 16;

            // 필수 입력값 (무조건 입력해야 함)
            newData.chamber_temp = int.Parse(textBox1.Text);
            newData.chamber_press = int.Parse(textBox2.Text);
            newData.chamber_flow = 0;

            newData.gas_O3 = ParseOrDefault(textBox8);
            newData.gas_N2 = ParseOrDefault(textBox9);
            newData.gas_ZrO2 = ParseOrDefault(textBox10);
            newData.gas_HfO2 = ParseOrDefault(textBox11);
            newData.gas_H2O2 = ParseOrDefault(textBox12);
            newData.gas_TMA = ParseOrDefault(textBox13);

            newData.recipe_name = Recipe_name_textbox.Text;

            MainForm.SavedControlData.Add(newData);
            MessageBox.Show("레시피 불러옴");

        }
    }
}
#endregion
