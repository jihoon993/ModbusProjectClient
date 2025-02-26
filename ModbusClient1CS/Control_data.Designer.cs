namespace ModbusClientCS
{
    partial class Control_data
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox5 = new GroupBox();
            textBox13 = new TextBox();
            label14 = new Label();
            textBox12 = new TextBox();
            label11 = new Label();
            textBox11 = new TextBox();
            label10 = new Label();
            textBox10 = new TextBox();
            label9 = new Label();
            textBox9 = new TextBox();
            label13 = new Label();
            textBox8 = new TextBox();
            label12 = new Label();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            Recipe_list = new ListBox();
            label7 = new Label();
            Recipe_name_textbox = new TextBox();
            label8 = new Label();
            Recipe_Delete_button = new Button();
            Recipe_send_button = new Button();
            Recipe_list_button = new Button();
            groupBox5.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(textBox13);
            groupBox5.Controls.Add(label14);
            groupBox5.Controls.Add(textBox12);
            groupBox5.Controls.Add(label11);
            groupBox5.Controls.Add(textBox11);
            groupBox5.Controls.Add(label10);
            groupBox5.Controls.Add(textBox10);
            groupBox5.Controls.Add(label9);
            groupBox5.Controls.Add(textBox9);
            groupBox5.Controls.Add(label13);
            groupBox5.Controls.Add(textBox8);
            groupBox5.Controls.Add(label12);
            groupBox5.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            groupBox5.ForeColor = SystemColors.Control;
            groupBox5.Location = new Point(12, 161);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(239, 337);
            groupBox5.TabIndex = 21;
            groupBox5.TabStop = false;
            groupBox5.Text = "가스 제어";
            // 
            // textBox13
            // 
            textBox13.BackColor = Color.White;
            textBox13.Location = new Point(143, 233);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(90, 23);
            textBox13.TabIndex = 27;
            textBox13.TextAlign = HorizontalAlignment.Center;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label14.ForeColor = SystemColors.ButtonFace;
            label14.Location = new Point(24, 235);
            label14.Name = "label14";
            label14.Size = new Size(91, 17);
            label14.TabIndex = 28;
            label14.Text = "TMA(sccm) : ";
            // 
            // textBox12
            // 
            textBox12.BackColor = Color.White;
            textBox12.Location = new Point(143, 187);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(90, 23);
            textBox12.TabIndex = 25;
            textBox12.TextAlign = HorizontalAlignment.Center;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label11.ForeColor = SystemColors.ButtonFace;
            label11.Location = new Point(24, 189);
            label11.Name = "label11";
            label11.Size = new Size(97, 17);
            label11.TabIndex = 26;
            label11.Text = "H2O2(sccm) : ";
            // 
            // textBox11
            // 
            textBox11.BackColor = Color.White;
            textBox11.Location = new Point(143, 143);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(90, 23);
            textBox11.TabIndex = 23;
            textBox11.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label10.ForeColor = SystemColors.ButtonFace;
            label10.Location = new Point(24, 145);
            label10.Name = "label10";
            label10.Size = new Size(94, 17);
            label10.TabIndex = 24;
            label10.Text = "HfO2(sccm) : ";
            // 
            // textBox10
            // 
            textBox10.BackColor = Color.White;
            textBox10.Location = new Point(143, 104);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(90, 23);
            textBox10.TabIndex = 21;
            textBox10.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(24, 106);
            label9.Name = "label9";
            label9.Size = new Size(92, 17);
            label9.TabIndex = 22;
            label9.Text = "ZrO2(sccm) : ";
            // 
            // textBox9
            // 
            textBox9.BackColor = Color.White;
            textBox9.Location = new Point(143, 64);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(90, 23);
            textBox9.TabIndex = 12;
            textBox9.TextAlign = HorizontalAlignment.Center;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label13.ForeColor = SystemColors.ButtonFace;
            label13.Location = new Point(24, 66);
            label13.Name = "label13";
            label13.Size = new Size(79, 17);
            label13.TabIndex = 20;
            label13.Text = "N2(sccm) : ";
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.White;
            textBox8.Location = new Point(143, 26);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(90, 23);
            textBox8.TabIndex = 11;
            textBox8.TextAlign = HorizontalAlignment.Center;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(24, 28);
            label12.Name = "label12";
            label12.Size = new Size(74, 17);
            label12.TabIndex = 19;
            label12.Text = "O3(sccm) :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(239, 130);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "챔버 컨트롤";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.Location = new Point(143, 72);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(85, 23);
            textBox2.TabIndex = 4;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.ImeMode = ImeMode.NoControl;
            textBox1.Location = new Point(143, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(85, 23);
            textBox1.TabIndex = 3;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 75);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 1;
            label4.Text = "챔버 압력(Torr)   :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 40);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 0;
            label3.Text = "챔버 온도(℃)      :";
            // 
            // Recipe_list
            // 
            Recipe_list.FormattingEnabled = true;
            Recipe_list.ItemHeight = 15;
            Recipe_list.Location = new Point(271, 24);
            Recipe_list.Name = "Recipe_list";
            Recipe_list.Size = new Size(208, 394);
            Recipe_list.TabIndex = 25;
            Recipe_list.SelectedIndexChanged += Recipe_list_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(260, 473);
            label7.Name = "label7";
            label7.Size = new Size(131, 15);
            label7.TabIndex = 26;
            label7.Text = "* 선택한 레시피 삭제 : ";
            // 
            // Recipe_name_textbox
            // 
            Recipe_name_textbox.Location = new Point(358, 429);
            Recipe_name_textbox.Name = "Recipe_name_textbox";
            Recipe_name_textbox.Size = new Size(121, 23);
            Recipe_name_textbox.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(260, 432);
            label8.Name = "label8";
            label8.Size = new Size(91, 15);
            label8.TabIndex = 29;
            label8.Text = "* 레시피 이름 : ";
            // 
            // Recipe_Delete_button
            // 
            Recipe_Delete_button.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Recipe_Delete_button.Location = new Point(397, 463);
            Recipe_Delete_button.Name = "Recipe_Delete_button";
            Recipe_Delete_button.Size = new Size(82, 35);
            Recipe_Delete_button.TabIndex = 30;
            Recipe_Delete_button.Text = "레시피 삭제";
            Recipe_Delete_button.UseVisualStyleBackColor = true;
            Recipe_Delete_button.Click += Recipe_Delete_button_Click;
            // 
            // Recipe_send_button
            // 
            Recipe_send_button.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Recipe_send_button.Location = new Point(86, 504);
            Recipe_send_button.Name = "Recipe_send_button";
            Recipe_send_button.Size = new Size(101, 51);
            Recipe_send_button.TabIndex = 24;
            Recipe_send_button.Text = "레시피 저장";
            Recipe_send_button.UseVisualStyleBackColor = true;
            Recipe_send_button.Click += Recipe_send_button_Click;
            // 
            // Recipe_list_button
            // 
            Recipe_list_button.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Recipe_list_button.Location = new Point(319, 504);
            Recipe_list_button.Name = "Recipe_list_button";
            Recipe_list_button.Size = new Size(111, 49);
            Recipe_list_button.TabIndex = 31;
            Recipe_list_button.Text = "레시피 불러오기";
            Recipe_list_button.UseVisualStyleBackColor = true;
            Recipe_list_button.Click += Recipe_list_button_Click;
            // 
            // Control_data
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(549, 576);
            Controls.Add(Recipe_list_button);
            Controls.Add(Recipe_Delete_button);
            Controls.Add(label8);
            Controls.Add(Recipe_name_textbox);
            Controls.Add(label7);
            Controls.Add(Recipe_list);
            Controls.Add(Recipe_send_button);
            Controls.Add(groupBox5);
            Controls.Add(groupBox1);
            Name = "Control_data";
            Text = "Control_data";
            FormClosing += Control_data_FormClosing;
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox5;
        private TextBox textBox9;
        private Label label13;
        private TextBox textBox8;
        private Label label12;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private ListBox Recipe_list;
        private Label label7;
        private TextBox Recipe_name_textbox;
        private Label label8;
        private Button Recipe_Delete_button;
        private TextBox textBox13;
        private Label label14;
        private TextBox textBox12;
        private Label label11;
        private TextBox textBox11;
        private Label label10;
        private TextBox textBox10;
        private Label label9;
        private Button Recipe_send_button;
        private Button Recipe_list_button;
    }
}