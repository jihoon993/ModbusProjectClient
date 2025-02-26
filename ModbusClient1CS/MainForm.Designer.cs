namespace ModbusClientCS
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            groupBox1 = new GroupBox();
            Gas_progress = new ProgressBar();
            Chamber_Torr_progress = new ProgressBar();
            Chamber_Temp_progress = new ProgressBar();
            recv_strr = new TextBox();
            recv_cham_torr = new TextBox();
            recv_cham_temp = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            groupBox2 = new GroupBox();
            label14 = new Label();
            label9 = new Label();
            Control_data_button = new Button();
            Log_data_button = new Button();
            Process_progress = new ProgressBar();
            Process_Stop = new Button();
            Process_Start = new Button();
            groupBox3 = new GroupBox();
            panel3 = new Panel();
            chamber_ready_panel = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            Dry_pump_button = new Button();
            label12 = new Label();
            label13 = new Label();
            recv_o3 = new TextBox();
            recv_n2 = new TextBox();
            groupBox5 = new GroupBox();
            recv_tma = new TextBox();
            recv_h2o2 = new TextBox();
            recv_hfo2 = new TextBox();
            recv_zro2 = new TextBox();
            groupBox6 = new GroupBox();
            N2_valOff = new Button();
            N2_valOn = new Button();
            O3_valOff = new Button();
            O3_valOn = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox4 = new GroupBox();
            thunderRadioButton2 = new ReaLTaiizor.Controls.ThunderRadioButton();
            thunderRadioButton1 = new ReaLTaiizor.Controls.ThunderRadioButton();
            label8 = new Label();
            progressBar1 = new ProgressBar();
            label7 = new Label();
            label6 = new Label();
            label2 = new Label();
            textBox4 = new TextBox();
            Exit_button = new Button();
            process1 = new System.Diagnostics.Process();
            groupBox7 = new GroupBox();
            wafer_amount_textbox = new TextBox();
            label30 = new Label();
            Wafer_setting_button = new Button();
            wafer_flat_area_textbox = new TextBox();
            wafer_loading_textbox = new TextBox();
            wafer_size_textbox = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label17 = new Label();
            O3_CheckBox = new CheckBox();
            N2_CheckBox = new CheckBox();
            Dry_Pump_Check_Box = new CheckBox();
            ZrO2_CheckBox = new CheckBox();
            HfO2_CheckBox = new CheckBox();
            H2O2_CheckBox = new CheckBox();
            TMA_CheckBox = new CheckBox();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            ZrO2_valOff = new Button();
            ZrO2_valOn = new Button();
            HfO2_valOff = new Button();
            HfO2_valOn = new Button();
            H2O2_valOff = new Button();
            H2O2_valOn = new Button();
            TMA_valOff = new Button();
            TMA_valOn = new Button();
            panel1 = new Panel();
            label29 = new Label();
            groupBox10 = new GroupBox();
            recipe_panel_name = new TextBox();
            label28 = new Label();
            groupBox8 = new GroupBox();
            recipe_panel_TMA = new TextBox();
            label15 = new Label();
            recipe_panel_H2O2 = new TextBox();
            label16 = new Label();
            recipe_panel_HfO2 = new TextBox();
            label22 = new Label();
            recipe_panel_ZrO2 = new TextBox();
            label23 = new Label();
            recipe_panel_N2 = new TextBox();
            label24 = new Label();
            recipe_panel_O3 = new TextBox();
            label25 = new Label();
            groupBox9 = new GroupBox();
            recipe_panel_torr = new TextBox();
            recipe_panel_temp = new TextBox();
            label26 = new Label();
            label27 = new Label();
            panel2 = new Panel();
            wafer_amount_panel1 = new Panel();
            wafer_amount_panel2 = new Panel();
            wafer_amount_panel3 = new Panel();
            wafer_amount_panel4 = new Panel();
            wafer_amount_panel5 = new Panel();
            label31 = new Label();
            label32 = new Label();
            label33 = new Label();
            label34 = new Label();
            label35 = new Label();
            wafer_amount_panel6 = new Panel();
            label36 = new Label();
            pictureBox2 = new PictureBox();
            groupBox11 = new GroupBox();
            Plasma_Control_button = new Button();
            plasma_reflected_textbox = new TextBox();
            plasma_forward_textbox = new TextBox();
            rf_power_textbox = new TextBox();
            label39 = new Label();
            label38 = new Label();
            label37 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox7.SuspendLayout();
            panel1.SuspendLayout();
            groupBox10.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox9.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox11.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Gas_progress);
            groupBox1.Controls.Add(Chamber_Torr_progress);
            groupBox1.Controls.Add(Chamber_Temp_progress);
            groupBox1.Controls.Add(recv_strr);
            groupBox1.Controls.Add(recv_cham_torr);
            groupBox1.Controls.Add(recv_cham_temp);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(37, 291);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(245, 159);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "챔버 내부 상태 / 진행도";
            // 
            // Gas_progress
            // 
            Gas_progress.BackColor = SystemColors.Highlight;
            Gas_progress.ForeColor = Color.Yellow;
            Gas_progress.Location = new Point(163, 112);
            Gas_progress.Name = "Gas_progress";
            Gas_progress.Size = new Size(76, 23);
            Gas_progress.TabIndex = 14;
            // 
            // Chamber_Torr_progress
            // 
            Chamber_Torr_progress.BackColor = SystemColors.Highlight;
            Chamber_Torr_progress.ForeColor = Color.Yellow;
            Chamber_Torr_progress.Location = new Point(163, 70);
            Chamber_Torr_progress.Name = "Chamber_Torr_progress";
            Chamber_Torr_progress.Size = new Size(76, 23);
            Chamber_Torr_progress.TabIndex = 13;
            // 
            // Chamber_Temp_progress
            // 
            Chamber_Temp_progress.BackColor = SystemColors.Highlight;
            Chamber_Temp_progress.ForeColor = Color.Yellow;
            Chamber_Temp_progress.Location = new Point(163, 28);
            Chamber_Temp_progress.Name = "Chamber_Temp_progress";
            Chamber_Temp_progress.Size = new Size(76, 23);
            Chamber_Temp_progress.TabIndex = 12;
            // 
            // recv_strr
            // 
            recv_strr.BackColor = Color.FromArgb(128, 255, 128);
            recv_strr.Enabled = false;
            recv_strr.Location = new Point(115, 112);
            recv_strr.Name = "recv_strr";
            recv_strr.ReadOnly = true;
            recv_strr.Size = new Size(42, 23);
            recv_strr.TabIndex = 5;
            recv_strr.TextAlign = HorizontalAlignment.Center;
            // 
            // recv_cham_torr
            // 
            recv_cham_torr.BackColor = Color.FromArgb(128, 255, 128);
            recv_cham_torr.Enabled = false;
            recv_cham_torr.Location = new Point(115, 70);
            recv_cham_torr.Name = "recv_cham_torr";
            recv_cham_torr.ReadOnly = true;
            recv_cham_torr.Size = new Size(42, 23);
            recv_cham_torr.TabIndex = 4;
            recv_cham_torr.TextAlign = HorizontalAlignment.Center;
            // 
            // recv_cham_temp
            // 
            recv_cham_temp.BackColor = Color.FromArgb(128, 255, 128);
            recv_cham_temp.Enabled = false;
            recv_cham_temp.ImeMode = ImeMode.NoControl;
            recv_cham_temp.Location = new Point(115, 28);
            recv_cham_temp.Name = "recv_cham_temp";
            recv_cham_temp.ReadOnly = true;
            recv_cham_temp.Size = new Size(42, 23);
            recv_cham_temp.TabIndex = 3;
            recv_cham_temp.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 73);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 1;
            label4.Text = "챔버 압력(Torr)   :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 31);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 0;
            label3.Text = "챔버 온도(℃)      :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 112);
            label5.Name = "label5";
            label5.Size = new Size(107, 15);
            label5.TabIndex = 2;
            label5.Text = "가스 유량(sccm)  :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label9);
            groupBox2.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            groupBox2.ForeColor = SystemColors.ActiveCaptionText;
            groupBox2.Location = new Point(12, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1066, 98);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(246, 8);
            label14.Name = "label14";
            label14.Size = new Size(11, 90);
            label14.TabIndex = 10;
            label14.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label9.Location = new Point(557, 43);
            label9.Name = "label9";
            label9.Size = new Size(74, 21);
            label9.TabIndex = 7;
            label9.Text = "진행도 : ";
            // 
            // Control_data_button
            // 
            Control_data_button.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            Control_data_button.ForeColor = SystemColors.ActiveCaptionText;
            Control_data_button.Location = new Point(292, 26);
            Control_data_button.Name = "Control_data_button";
            Control_data_button.Size = new Size(106, 54);
            Control_data_button.TabIndex = 11;
            Control_data_button.Text = "설정";
            Control_data_button.UseVisualStyleBackColor = true;
            Control_data_button.Click += Control_data_button_Click;
            // 
            // Log_data_button
            // 
            Log_data_button.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            Log_data_button.ForeColor = SystemColors.ActiveCaptionText;
            Log_data_button.Location = new Point(420, 26);
            Log_data_button.Name = "Log_data_button";
            Log_data_button.Size = new Size(104, 55);
            Log_data_button.TabIndex = 9;
            Log_data_button.Text = "로그 데이터 확인";
            Log_data_button.UseVisualStyleBackColor = true;
            Log_data_button.Click += Log_data_button_Click;
            // 
            // Process_progress
            // 
            Process_progress.Location = new Point(658, 33);
            Process_progress.Name = "Process_progress";
            Process_progress.Size = new Size(401, 48);
            Process_progress.TabIndex = 8;
            // 
            // Process_Stop
            // 
            Process_Stop.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            Process_Stop.ForeColor = SystemColors.ActiveCaptionText;
            Process_Stop.Location = new Point(145, 26);
            Process_Stop.Name = "Process_Stop";
            Process_Stop.Size = new Size(97, 55);
            Process_Stop.TabIndex = 6;
            Process_Stop.Text = "Stop";
            Process_Stop.UseVisualStyleBackColor = true;
            Process_Stop.Click += Process_Stop_Click;
            // 
            // Process_Start
            // 
            Process_Start.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Process_Start.ForeColor = Color.Red;
            Process_Start.Location = new Point(28, 26);
            Process_Start.Name = "Process_Start";
            Process_Start.Size = new Size(97, 55);
            Process_Start.TabIndex = 5;
            Process_Start.Text = "Start";
            Process_Start.UseVisualStyleBackColor = true;
            Process_Start.Click += Process_Start_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(panel3);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(pictureBox1);
            groupBox3.ForeColor = SystemColors.ControlLightLight;
            groupBox3.Location = new Point(305, 260);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(256, 366);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chamber";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(chamber_ready_panel);
            panel3.Location = new Point(223, 10);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(31, 25);
            panel3.TabIndex = 58;
            // 
            // chamber_ready_panel
            // 
            chamber_ready_panel.BackColor = Color.Green;
            chamber_ready_panel.Location = new Point(4, 3);
            chamber_ready_panel.Margin = new Padding(2);
            chamber_ready_panel.Name = "chamber_ready_panel";
            chamber_ready_panel.Size = new Size(24, 20);
            chamber_ready_panel.TabIndex = 59;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 19);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 1;
            label1.Text = "Quartz Boat";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Highlight;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.KakaoTalk_20250224_155348771;
            pictureBox1.Location = new Point(42, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 320);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Dry_pump_button
            // 
            Dry_pump_button.BackColor = SystemColors.Control;
            Dry_pump_button.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Dry_pump_button.ForeColor = Color.FromArgb(0, 0, 192);
            Dry_pump_button.Location = new Point(397, 122);
            Dry_pump_button.Name = "Dry_pump_button";
            Dry_pump_button.RightToLeft = RightToLeft.No;
            Dry_pump_button.Size = new Size(80, 78);
            Dry_pump_button.TabIndex = 7;
            Dry_pump_button.Text = "Dry Pump";
            Dry_pump_button.UseVisualStyleBackColor = false;
            Dry_pump_button.Click += Dry_pump_button_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(11, 29);
            label12.Name = "label12";
            label12.Size = new Size(26, 17);
            label12.TabIndex = 9;
            label12.Text = "O3";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label13.ForeColor = SystemColors.ButtonFace;
            label13.Location = new Point(11, 84);
            label13.Name = "label13";
            label13.Size = new Size(26, 17);
            label13.TabIndex = 10;
            label13.Text = "N2";
            // 
            // recv_o3
            // 
            recv_o3.BackColor = Color.FromArgb(128, 255, 128);
            recv_o3.Enabled = false;
            recv_o3.Location = new Point(77, 29);
            recv_o3.Name = "recv_o3";
            recv_o3.Size = new Size(90, 23);
            recv_o3.TabIndex = 11;
            recv_o3.TextAlign = HorizontalAlignment.Center;
            // 
            // recv_n2
            // 
            recv_n2.BackColor = Color.FromArgb(128, 255, 128);
            recv_n2.Enabled = false;
            recv_n2.Location = new Point(77, 83);
            recv_n2.Name = "recv_n2";
            recv_n2.Size = new Size(90, 23);
            recv_n2.TabIndex = 12;
            recv_n2.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(recv_tma);
            groupBox5.Controls.Add(recv_h2o2);
            groupBox5.Controls.Add(recv_hfo2);
            groupBox5.Controls.Add(recv_zro2);
            groupBox5.Controls.Add(recv_n2);
            groupBox5.Controls.Add(recv_o3);
            groupBox5.Controls.Add(label12);
            groupBox5.Controls.Add(label13);
            groupBox5.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            groupBox5.ForeColor = SystemColors.Control;
            groupBox5.Location = new Point(685, 260);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(188, 342);
            groupBox5.TabIndex = 13;
            groupBox5.TabStop = false;
            groupBox5.Text = "유량";
            // 
            // recv_tma
            // 
            recv_tma.BackColor = Color.FromArgb(128, 255, 128);
            recv_tma.Enabled = false;
            recv_tma.Location = new Point(77, 306);
            recv_tma.Name = "recv_tma";
            recv_tma.Size = new Size(90, 23);
            recv_tma.TabIndex = 16;
            recv_tma.TextAlign = HorizontalAlignment.Center;
            // 
            // recv_h2o2
            // 
            recv_h2o2.BackColor = Color.FromArgb(128, 255, 128);
            recv_h2o2.Enabled = false;
            recv_h2o2.Location = new Point(77, 257);
            recv_h2o2.Name = "recv_h2o2";
            recv_h2o2.Size = new Size(90, 23);
            recv_h2o2.TabIndex = 15;
            recv_h2o2.TextAlign = HorizontalAlignment.Center;
            // 
            // recv_hfo2
            // 
            recv_hfo2.BackColor = Color.FromArgb(128, 255, 128);
            recv_hfo2.Enabled = false;
            recv_hfo2.Location = new Point(77, 198);
            recv_hfo2.Name = "recv_hfo2";
            recv_hfo2.Size = new Size(90, 23);
            recv_hfo2.TabIndex = 14;
            recv_hfo2.TextAlign = HorizontalAlignment.Center;
            // 
            // recv_zro2
            // 
            recv_zro2.BackColor = Color.FromArgb(128, 255, 128);
            recv_zro2.Enabled = false;
            recv_zro2.Location = new Point(77, 139);
            recv_zro2.Name = "recv_zro2";
            recv_zro2.Size = new Size(90, 23);
            recv_zro2.TabIndex = 13;
            recv_zro2.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox6
            // 
            groupBox6.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            groupBox6.ForeColor = SystemColors.ButtonHighlight;
            groupBox6.Location = new Point(873, 260);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(119, 342);
            groupBox6.TabIndex = 14;
            groupBox6.TabStop = false;
            groupBox6.Text = "밸브 설정";
            // 
            // N2_valOff
            // 
            N2_valOff.ForeColor = SystemColors.ActiveCaptionText;
            N2_valOff.Location = new Point(931, 340);
            N2_valOff.Name = "N2_valOff";
            N2_valOff.Size = new Size(46, 29);
            N2_valOff.TabIndex = 15;
            N2_valOff.Text = "Close";
            N2_valOff.UseVisualStyleBackColor = true;
            N2_valOff.Click += N2_valOff_Click;
            // 
            // N2_valOn
            // 
            N2_valOn.ForeColor = SystemColors.ActiveCaptionText;
            N2_valOn.Location = new Point(879, 340);
            N2_valOn.Name = "N2_valOn";
            N2_valOn.Size = new Size(46, 29);
            N2_valOn.TabIndex = 14;
            N2_valOn.Text = "Open";
            N2_valOn.UseVisualStyleBackColor = true;
            N2_valOn.Click += N2_valOn_Click;
            // 
            // O3_valOff
            // 
            O3_valOff.ForeColor = SystemColors.ActiveCaptionText;
            O3_valOff.Location = new Point(929, 286);
            O3_valOff.Name = "O3_valOff";
            O3_valOff.Size = new Size(46, 29);
            O3_valOff.TabIndex = 13;
            O3_valOff.Text = "Close";
            O3_valOff.UseVisualStyleBackColor = true;
            O3_valOff.Click += O3_valOff_Click;
            // 
            // O3_valOn
            // 
            O3_valOn.ForeColor = SystemColors.ActiveCaptionText;
            O3_valOn.Location = new Point(877, 286);
            O3_valOn.Name = "O3_valOn";
            O3_valOn.Size = new Size(46, 29);
            O3_valOn.TabIndex = 12;
            O3_valOn.Text = "Open";
            O3_valOn.UseVisualStyleBackColor = true;
            O3_valOn.Click += O3_valOn_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(thunderRadioButton2);
            groupBox4.Controls.Add(thunderRadioButton1);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(progressBar1);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(textBox4);
            groupBox4.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            groupBox4.ForeColor = SystemColors.ButtonHighlight;
            groupBox4.Location = new Point(217, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(795, 77);
            groupBox4.TabIndex = 17;
            groupBox4.TabStop = false;
            groupBox4.Text = "* 상태 값 표시 *";
            // 
            // thunderRadioButton2
            // 
            thunderRadioButton2.BackColor = Color.Transparent;
            thunderRadioButton2.Checked = false;
            thunderRadioButton2.Enabled = false;
            thunderRadioButton2.ForeColor = Color.WhiteSmoke;
            thunderRadioButton2.Location = new Point(367, 36);
            thunderRadioButton2.Name = "thunderRadioButton2";
            thunderRadioButton2.Size = new Size(16, 16);
            thunderRadioButton2.TabIndex = 23;
            // 
            // thunderRadioButton1
            // 
            thunderRadioButton1.BackColor = Color.Transparent;
            thunderRadioButton1.Checked = true;
            thunderRadioButton1.Enabled = false;
            thunderRadioButton1.ForeColor = Color.WhiteSmoke;
            thunderRadioButton1.Location = new Point(236, 37);
            thunderRadioButton1.Name = "thunderRadioButton1";
            thunderRadioButton1.Size = new Size(16, 16);
            thunderRadioButton1.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(706, 36);
            label8.Name = "label8";
            label8.Size = new Size(86, 17);
            label8.TabIndex = 21;
            label8.Text = ": 진행도 표시";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(497, 33);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(192, 25);
            progressBar1.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(386, 36);
            label7.Name = "label7";
            label7.Size = new Size(73, 17);
            label7.TabIndex = 19;
            label7.Text = ": 밸브 닫힘";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(262, 36);
            label6.Name = "label6";
            label6.Size = new Size(78, 17);
            label6.TabIndex = 17;
            label6.Text = ": 밸브 열림 ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 36);
            label2.Name = "label2";
            label2.Size = new Size(130, 17);
            label2.TabIndex = 5;
            label2.Text = ": 서버에서 받아온 값";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(128, 255, 128);
            textBox4.Enabled = false;
            textBox4.ImeMode = ImeMode.NoControl;
            textBox4.Location = new Point(16, 33);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(42, 25);
            textBox4.TabIndex = 4;
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // Exit_button
            // 
            Exit_button.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Exit_button.ForeColor = SystemColors.ActiveCaptionText;
            Exit_button.Location = new Point(1106, 24);
            Exit_button.Name = "Exit_button";
            Exit_button.Size = new Size(113, 66);
            Exit_button.TabIndex = 18;
            Exit_button.Text = "Exit";
            Exit_button.UseVisualStyleBackColor = true;
            Exit_button.Click += Exit_button_Click;
            // 
            // process1
            // 
            process1.StartInfo.Domain = "";
            process1.StartInfo.LoadUserProfile = false;
            process1.StartInfo.Password = null;
            process1.StartInfo.StandardErrorEncoding = null;
            process1.StartInfo.StandardInputEncoding = null;
            process1.StartInfo.StandardOutputEncoding = null;
            process1.StartInfo.UseCredentialsForNetworkingOnly = false;
            process1.StartInfo.UserName = "";
            process1.SynchronizingObject = this;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(wafer_amount_textbox);
            groupBox7.Controls.Add(label30);
            groupBox7.Controls.Add(Wafer_setting_button);
            groupBox7.Controls.Add(wafer_flat_area_textbox);
            groupBox7.Controls.Add(wafer_loading_textbox);
            groupBox7.Controls.Add(wafer_size_textbox);
            groupBox7.Controls.Add(label10);
            groupBox7.Controls.Add(label11);
            groupBox7.Controls.Add(label17);
            groupBox7.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            groupBox7.ForeColor = SystemColors.ControlLightLight;
            groupBox7.Location = new Point(39, 95);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(245, 188);
            groupBox7.TabIndex = 23;
            groupBox7.TabStop = false;
            groupBox7.Text = "웨이퍼 정보";
            // 
            // wafer_amount_textbox
            // 
            wafer_amount_textbox.BackColor = Color.FromArgb(128, 255, 128);
            wafer_amount_textbox.Enabled = false;
            wafer_amount_textbox.Location = new Point(168, 120);
            wafer_amount_textbox.Margin = new Padding(2);
            wafer_amount_textbox.Name = "wafer_amount_textbox";
            wafer_amount_textbox.Size = new Size(67, 23);
            wafer_amount_textbox.TabIndex = 8;
            wafer_amount_textbox.TextAlign = HorizontalAlignment.Center;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(7, 120);
            label30.Name = "label30";
            label30.Size = new Size(150, 15);
            label30.TabIndex = 7;
            label30.Text = "웨이퍼 개수(매)              :";
            // 
            // Wafer_setting_button
            // 
            Wafer_setting_button.BackgroundImageLayout = ImageLayout.None;
            Wafer_setting_button.ForeColor = SystemColors.ActiveCaptionText;
            Wafer_setting_button.Location = new Point(62, 146);
            Wafer_setting_button.Name = "Wafer_setting_button";
            Wafer_setting_button.Size = new Size(113, 23);
            Wafer_setting_button.TabIndex = 6;
            Wafer_setting_button.Text = "웨이퍼 정보 수정";
            Wafer_setting_button.UseVisualStyleBackColor = true;
            Wafer_setting_button.Click += Wafer_setting_button_Click;
            // 
            // wafer_flat_area_textbox
            // 
            wafer_flat_area_textbox.BackColor = Color.FromArgb(128, 255, 128);
            wafer_flat_area_textbox.Enabled = false;
            wafer_flat_area_textbox.Location = new Point(168, 89);
            wafer_flat_area_textbox.Margin = new Padding(2);
            wafer_flat_area_textbox.Name = "wafer_flat_area_textbox";
            wafer_flat_area_textbox.Size = new Size(67, 23);
            wafer_flat_area_textbox.TabIndex = 5;
            wafer_flat_area_textbox.TextAlign = HorizontalAlignment.Center;
            // 
            // wafer_loading_textbox
            // 
            wafer_loading_textbox.BackColor = Color.FromArgb(128, 255, 128);
            wafer_loading_textbox.Enabled = false;
            wafer_loading_textbox.Location = new Point(167, 57);
            wafer_loading_textbox.Margin = new Padding(2);
            wafer_loading_textbox.Name = "wafer_loading_textbox";
            wafer_loading_textbox.Size = new Size(67, 23);
            wafer_loading_textbox.TabIndex = 4;
            wafer_loading_textbox.TextAlign = HorizontalAlignment.Center;
            // 
            // wafer_size_textbox
            // 
            wafer_size_textbox.BackColor = Color.FromArgb(128, 255, 128);
            wafer_size_textbox.Enabled = false;
            wafer_size_textbox.Location = new Point(167, 27);
            wafer_size_textbox.Margin = new Padding(2);
            wafer_size_textbox.Name = "wafer_size_textbox";
            wafer_size_textbox.Size = new Size(67, 23);
            wafer_size_textbox.TabIndex = 3;
            wafer_size_textbox.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(7, 90);
            label10.Name = "label10";
            label10.Size = new Size(148, 15);
            label10.TabIndex = 2;
            label10.Text = "웨이퍼 평탄 영역(mm)    :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 60);
            label11.Name = "label11";
            label11.Size = new Size(153, 15);
            label11.TabIndex = 1;
            label11.Text = "웨이퍼 로딩 방식(FOUP)  : ";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(7, 32);
            label17.Name = "label17";
            label17.Size = new Size(150, 15);
            label17.TabIndex = 0;
            label17.Text = "웨이퍼 크기(inches)        :";
            // 
            // O3_CheckBox
            // 
            O3_CheckBox.AutoSize = true;
            O3_CheckBox.BackColor = SystemColors.Highlight;
            O3_CheckBox.Location = new Point(622, 291);
            O3_CheckBox.Margin = new Padding(2);
            O3_CheckBox.Name = "O3_CheckBox";
            O3_CheckBox.Size = new Size(15, 14);
            O3_CheckBox.TabIndex = 24;
            O3_CheckBox.UseVisualStyleBackColor = false;
            // 
            // N2_CheckBox
            // 
            N2_CheckBox.AutoSize = true;
            N2_CheckBox.Location = new Point(622, 349);
            N2_CheckBox.Margin = new Padding(2);
            N2_CheckBox.Name = "N2_CheckBox";
            N2_CheckBox.Size = new Size(15, 14);
            N2_CheckBox.TabIndex = 25;
            N2_CheckBox.UseVisualStyleBackColor = true;
            // 
            // Dry_Pump_Check_Box
            // 
            Dry_Pump_Check_Box.AutoSize = true;
            Dry_Pump_Check_Box.Location = new Point(433, 225);
            Dry_Pump_Check_Box.Margin = new Padding(2);
            Dry_Pump_Check_Box.Name = "Dry_Pump_Check_Box";
            Dry_Pump_Check_Box.Size = new Size(15, 14);
            Dry_Pump_Check_Box.TabIndex = 26;
            Dry_Pump_Check_Box.UseVisualStyleBackColor = true;
            // 
            // ZrO2_CheckBox
            // 
            ZrO2_CheckBox.AutoSize = true;
            ZrO2_CheckBox.Location = new Point(622, 407);
            ZrO2_CheckBox.Margin = new Padding(2);
            ZrO2_CheckBox.Name = "ZrO2_CheckBox";
            ZrO2_CheckBox.Size = new Size(15, 14);
            ZrO2_CheckBox.TabIndex = 27;
            ZrO2_CheckBox.UseVisualStyleBackColor = true;
            // 
            // HfO2_CheckBox
            // 
            HfO2_CheckBox.AutoSize = true;
            HfO2_CheckBox.Location = new Point(622, 465);
            HfO2_CheckBox.Margin = new Padding(2);
            HfO2_CheckBox.Name = "HfO2_CheckBox";
            HfO2_CheckBox.Size = new Size(15, 14);
            HfO2_CheckBox.TabIndex = 28;
            HfO2_CheckBox.UseVisualStyleBackColor = true;
            // 
            // H2O2_CheckBox
            // 
            H2O2_CheckBox.AutoSize = true;
            H2O2_CheckBox.Location = new Point(622, 521);
            H2O2_CheckBox.Margin = new Padding(2);
            H2O2_CheckBox.Name = "H2O2_CheckBox";
            H2O2_CheckBox.Size = new Size(15, 14);
            H2O2_CheckBox.TabIndex = 29;
            H2O2_CheckBox.UseVisualStyleBackColor = true;
            // 
            // TMA_CheckBox
            // 
            TMA_CheckBox.AutoSize = true;
            TMA_CheckBox.Location = new Point(622, 570);
            TMA_CheckBox.Margin = new Padding(2);
            TMA_CheckBox.Name = "TMA_CheckBox";
            TMA_CheckBox.Size = new Size(15, 14);
            TMA_CheckBox.TabIndex = 30;
            TMA_CheckBox.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label18.ForeColor = SystemColors.ButtonFace;
            label18.Location = new Point(692, 404);
            label18.Name = "label18";
            label18.Size = new Size(39, 17);
            label18.TabIndex = 33;
            label18.Text = "ZrO2";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label19.ForeColor = SystemColors.ButtonFace;
            label19.Location = new Point(692, 462);
            label19.Name = "label19";
            label19.Size = new Size(41, 17);
            label19.TabIndex = 34;
            label19.Text = "HfO2";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label20.ForeColor = SystemColors.ButtonFace;
            label20.Location = new Point(692, 518);
            label20.Name = "label20";
            label20.Size = new Size(44, 17);
            label20.TabIndex = 35;
            label20.Text = "H2O2";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label21.ForeColor = SystemColors.ButtonFace;
            label21.Location = new Point(692, 567);
            label21.Name = "label21";
            label21.Size = new Size(38, 17);
            label21.TabIndex = 36;
            label21.Text = "TMA";
            // 
            // ZrO2_valOff
            // 
            ZrO2_valOff.ForeColor = SystemColors.ActiveCaptionText;
            ZrO2_valOff.Location = new Point(931, 393);
            ZrO2_valOff.Name = "ZrO2_valOff";
            ZrO2_valOff.Size = new Size(46, 29);
            ZrO2_valOff.TabIndex = 38;
            ZrO2_valOff.Text = "Close";
            ZrO2_valOff.UseVisualStyleBackColor = true;
            ZrO2_valOff.Click += ZrO2_valOff_Click;
            // 
            // ZrO2_valOn
            // 
            ZrO2_valOn.ForeColor = SystemColors.ActiveCaptionText;
            ZrO2_valOn.Location = new Point(879, 393);
            ZrO2_valOn.Name = "ZrO2_valOn";
            ZrO2_valOn.Size = new Size(46, 29);
            ZrO2_valOn.TabIndex = 37;
            ZrO2_valOn.Text = "Open";
            ZrO2_valOn.UseVisualStyleBackColor = true;
            ZrO2_valOn.Click += ZrO2_valOn_Click;
            // 
            // HfO2_valOff
            // 
            HfO2_valOff.ForeColor = SystemColors.ActiveCaptionText;
            HfO2_valOff.Location = new Point(931, 452);
            HfO2_valOff.Name = "HfO2_valOff";
            HfO2_valOff.Size = new Size(46, 29);
            HfO2_valOff.TabIndex = 40;
            HfO2_valOff.Text = "Close";
            HfO2_valOff.UseVisualStyleBackColor = true;
            HfO2_valOff.Click += HfO2_valOff_Click;
            // 
            // HfO2_valOn
            // 
            HfO2_valOn.ForeColor = SystemColors.ActiveCaptionText;
            HfO2_valOn.Location = new Point(879, 452);
            HfO2_valOn.Name = "HfO2_valOn";
            HfO2_valOn.Size = new Size(46, 29);
            HfO2_valOn.TabIndex = 39;
            HfO2_valOn.Text = "Open";
            HfO2_valOn.UseVisualStyleBackColor = true;
            HfO2_valOn.Click += HfO2_valOn_Click;
            // 
            // H2O2_valOff
            // 
            H2O2_valOff.ForeColor = SystemColors.ActiveCaptionText;
            H2O2_valOff.Location = new Point(931, 512);
            H2O2_valOff.Name = "H2O2_valOff";
            H2O2_valOff.Size = new Size(46, 29);
            H2O2_valOff.TabIndex = 42;
            H2O2_valOff.Text = "Close";
            H2O2_valOff.UseVisualStyleBackColor = true;
            H2O2_valOff.Click += H2O2_valOff_Click;
            // 
            // H2O2_valOn
            // 
            H2O2_valOn.ForeColor = SystemColors.ActiveCaptionText;
            H2O2_valOn.Location = new Point(879, 512);
            H2O2_valOn.Name = "H2O2_valOn";
            H2O2_valOn.Size = new Size(46, 29);
            H2O2_valOn.TabIndex = 41;
            H2O2_valOn.Text = "Open";
            H2O2_valOn.UseVisualStyleBackColor = true;
            H2O2_valOn.Click += H2O2_valOn_Click;
            // 
            // TMA_valOff
            // 
            TMA_valOff.ForeColor = SystemColors.ActiveCaptionText;
            TMA_valOff.Location = new Point(931, 561);
            TMA_valOff.Name = "TMA_valOff";
            TMA_valOff.Size = new Size(46, 29);
            TMA_valOff.TabIndex = 44;
            TMA_valOff.Text = "Close";
            TMA_valOff.UseVisualStyleBackColor = true;
            TMA_valOff.Click += TMA_valOff_Click;
            // 
            // TMA_valOn
            // 
            TMA_valOn.ForeColor = SystemColors.ActiveCaptionText;
            TMA_valOn.Location = new Point(879, 561);
            TMA_valOn.Name = "TMA_valOn";
            TMA_valOn.Size = new Size(46, 29);
            TMA_valOn.TabIndex = 43;
            TMA_valOn.Text = "Open";
            TMA_valOn.UseVisualStyleBackColor = true;
            TMA_valOn.Click += TMA_valOn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label29);
            panel1.Controls.Add(groupBox10);
            panel1.Controls.Add(groupBox8);
            panel1.Controls.Add(groupBox9);
            panel1.Location = new Point(1018, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 605);
            panel1.TabIndex = 45;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label29.Location = new Point(39, 22);
            label29.Name = "label29";
            label29.Size = new Size(149, 25);
            label29.TabIndex = 25;
            label29.Text = "* 작업중 레시피";
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(recipe_panel_name);
            groupBox10.Controls.Add(label28);
            groupBox10.Location = new Point(3, 71);
            groupBox10.Name = "groupBox10";
            groupBox10.Size = new Size(239, 51);
            groupBox10.TabIndex = 24;
            groupBox10.TabStop = false;
            // 
            // recipe_panel_name
            // 
            recipe_panel_name.Enabled = false;
            recipe_panel_name.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            recipe_panel_name.ForeColor = Color.FromArgb(64, 0, 0);
            recipe_panel_name.Location = new Point(96, 19);
            recipe_panel_name.Name = "recipe_panel_name";
            recipe_panel_name.ReadOnly = true;
            recipe_panel_name.Size = new Size(124, 23);
            recipe_panel_name.TabIndex = 1;
            recipe_panel_name.TextAlign = HorizontalAlignment.Center;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label28.Location = new Point(24, 22);
            label28.Name = "label28";
            label28.Size = new Size(66, 15);
            label28.TabIndex = 0;
            label28.Text = "레시피명 : ";
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(recipe_panel_TMA);
            groupBox8.Controls.Add(label15);
            groupBox8.Controls.Add(recipe_panel_H2O2);
            groupBox8.Controls.Add(label16);
            groupBox8.Controls.Add(recipe_panel_HfO2);
            groupBox8.Controls.Add(label22);
            groupBox8.Controls.Add(recipe_panel_ZrO2);
            groupBox8.Controls.Add(label23);
            groupBox8.Controls.Add(recipe_panel_N2);
            groupBox8.Controls.Add(label24);
            groupBox8.Controls.Add(recipe_panel_O3);
            groupBox8.Controls.Add(label25);
            groupBox8.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            groupBox8.ForeColor = SystemColors.ActiveCaptionText;
            groupBox8.Location = new Point(3, 285);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(239, 294);
            groupBox8.TabIndex = 23;
            groupBox8.TabStop = false;
            // 
            // recipe_panel_TMA
            // 
            recipe_panel_TMA.BackColor = Color.White;
            recipe_panel_TMA.Enabled = false;
            recipe_panel_TMA.Location = new Point(135, 233);
            recipe_panel_TMA.Name = "recipe_panel_TMA";
            recipe_panel_TMA.ReadOnly = true;
            recipe_panel_TMA.Size = new Size(90, 23);
            recipe_panel_TMA.TabIndex = 27;
            recipe_panel_TMA.TextAlign = HorizontalAlignment.Center;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label15.ForeColor = SystemColors.ActiveCaptionText;
            label15.Location = new Point(24, 235);
            label15.Name = "label15";
            label15.Size = new Size(96, 17);
            label15.TabIndex = 28;
            label15.Text = "TMA(sccm)  : ";
            // 
            // recipe_panel_H2O2
            // 
            recipe_panel_H2O2.BackColor = Color.White;
            recipe_panel_H2O2.Enabled = false;
            recipe_panel_H2O2.Location = new Point(135, 187);
            recipe_panel_H2O2.Name = "recipe_panel_H2O2";
            recipe_panel_H2O2.ReadOnly = true;
            recipe_panel_H2O2.Size = new Size(90, 23);
            recipe_panel_H2O2.TabIndex = 25;
            recipe_panel_H2O2.TextAlign = HorizontalAlignment.Center;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label16.ForeColor = SystemColors.ActiveCaptionText;
            label16.Location = new Point(24, 189);
            label16.Name = "label16";
            label16.Size = new Size(97, 17);
            label16.TabIndex = 26;
            label16.Text = "H2O2(sccm) : ";
            // 
            // recipe_panel_HfO2
            // 
            recipe_panel_HfO2.BackColor = Color.White;
            recipe_panel_HfO2.Enabled = false;
            recipe_panel_HfO2.Location = new Point(135, 143);
            recipe_panel_HfO2.Name = "recipe_panel_HfO2";
            recipe_panel_HfO2.ReadOnly = true;
            recipe_panel_HfO2.Size = new Size(90, 23);
            recipe_panel_HfO2.TabIndex = 23;
            recipe_panel_HfO2.TextAlign = HorizontalAlignment.Center;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label22.ForeColor = SystemColors.ActiveCaptionText;
            label22.Location = new Point(24, 145);
            label22.Name = "label22";
            label22.Size = new Size(94, 17);
            label22.TabIndex = 24;
            label22.Text = "HfO2(sccm) : ";
            // 
            // recipe_panel_ZrO2
            // 
            recipe_panel_ZrO2.BackColor = Color.White;
            recipe_panel_ZrO2.Enabled = false;
            recipe_panel_ZrO2.Location = new Point(135, 104);
            recipe_panel_ZrO2.Name = "recipe_panel_ZrO2";
            recipe_panel_ZrO2.ReadOnly = true;
            recipe_panel_ZrO2.Size = new Size(90, 23);
            recipe_panel_ZrO2.TabIndex = 21;
            recipe_panel_ZrO2.TextAlign = HorizontalAlignment.Center;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label23.ForeColor = SystemColors.ActiveCaptionText;
            label23.Location = new Point(24, 106);
            label23.Name = "label23";
            label23.Size = new Size(92, 17);
            label23.TabIndex = 22;
            label23.Text = "ZrO2(sccm) : ";
            // 
            // recipe_panel_N2
            // 
            recipe_panel_N2.BackColor = Color.White;
            recipe_panel_N2.Enabled = false;
            recipe_panel_N2.Location = new Point(135, 64);
            recipe_panel_N2.Name = "recipe_panel_N2";
            recipe_panel_N2.ReadOnly = true;
            recipe_panel_N2.Size = new Size(90, 23);
            recipe_panel_N2.TabIndex = 12;
            recipe_panel_N2.TextAlign = HorizontalAlignment.Center;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label24.ForeColor = SystemColors.ActiveCaptionText;
            label24.Location = new Point(24, 66);
            label24.Name = "label24";
            label24.Size = new Size(89, 17);
            label24.TabIndex = 20;
            label24.Text = "N2(sccm)   : ";
            // 
            // recipe_panel_O3
            // 
            recipe_panel_O3.BackColor = Color.White;
            recipe_panel_O3.Enabled = false;
            recipe_panel_O3.Location = new Point(135, 26);
            recipe_panel_O3.Name = "recipe_panel_O3";
            recipe_panel_O3.ReadOnly = true;
            recipe_panel_O3.Size = new Size(90, 23);
            recipe_panel_O3.TabIndex = 11;
            recipe_panel_O3.TextAlign = HorizontalAlignment.Center;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label25.ForeColor = SystemColors.ActiveCaptionText;
            label25.Location = new Point(24, 28);
            label25.Name = "label25";
            label25.Size = new Size(84, 17);
            label25.TabIndex = 19;
            label25.Text = "O3(sccm)   :";
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(recipe_panel_torr);
            groupBox9.Controls.Add(recipe_panel_temp);
            groupBox9.Controls.Add(label26);
            groupBox9.Controls.Add(label27);
            groupBox9.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            groupBox9.ForeColor = SystemColors.ActiveCaptionText;
            groupBox9.Location = new Point(3, 139);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(239, 130);
            groupBox9.TabIndex = 22;
            groupBox9.TabStop = false;
            // 
            // recipe_panel_torr
            // 
            recipe_panel_torr.BackColor = Color.White;
            recipe_panel_torr.Enabled = false;
            recipe_panel_torr.Location = new Point(135, 72);
            recipe_panel_torr.Name = "recipe_panel_torr";
            recipe_panel_torr.ReadOnly = true;
            recipe_panel_torr.Size = new Size(85, 23);
            recipe_panel_torr.TabIndex = 4;
            recipe_panel_torr.TextAlign = HorizontalAlignment.Center;
            // 
            // recipe_panel_temp
            // 
            recipe_panel_temp.BackColor = Color.White;
            recipe_panel_temp.Enabled = false;
            recipe_panel_temp.ImeMode = ImeMode.NoControl;
            recipe_panel_temp.Location = new Point(135, 37);
            recipe_panel_temp.Name = "recipe_panel_temp";
            recipe_panel_temp.ReadOnly = true;
            recipe_panel_temp.Size = new Size(85, 23);
            recipe_panel_temp.TabIndex = 3;
            recipe_panel_temp.TextAlign = HorizontalAlignment.Center;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(6, 75);
            label26.Name = "label26";
            label26.Size = new Size(106, 15);
            label26.TabIndex = 1;
            label26.Text = "챔버 압력(Torr)   :";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(6, 40);
            label27.Name = "label27";
            label27.Size = new Size(105, 15);
            label27.TabIndex = 0;
            label27.Text = "챔버 온도(℃)      :";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(Exit_button);
            panel2.Controls.Add(Control_data_button);
            panel2.Controls.Add(Process_Stop);
            panel2.Controls.Add(Process_Start);
            panel2.Controls.Add(Log_data_button);
            panel2.Controls.Add(Process_progress);
            panel2.Controls.Add(groupBox2);
            panel2.Location = new Point(11, 632);
            panel2.Name = "panel2";
            panel2.Size = new Size(1267, 115);
            panel2.TabIndex = 46;
            // 
            // wafer_amount_panel1
            // 
            wafer_amount_panel1.BackColor = Color.White;
            wafer_amount_panel1.Location = new Point(92, 596);
            wafer_amount_panel1.Margin = new Padding(2);
            wafer_amount_panel1.Name = "wafer_amount_panel1";
            wafer_amount_panel1.Size = new Size(188, 20);
            wafer_amount_panel1.TabIndex = 47;
            // 
            // wafer_amount_panel2
            // 
            wafer_amount_panel2.BackColor = Color.White;
            wafer_amount_panel2.Location = new Point(92, 572);
            wafer_amount_panel2.Margin = new Padding(2);
            wafer_amount_panel2.Name = "wafer_amount_panel2";
            wafer_amount_panel2.Size = new Size(188, 20);
            wafer_amount_panel2.TabIndex = 48;
            // 
            // wafer_amount_panel3
            // 
            wafer_amount_panel3.BackColor = Color.White;
            wafer_amount_panel3.Location = new Point(92, 548);
            wafer_amount_panel3.Margin = new Padding(2);
            wafer_amount_panel3.Name = "wafer_amount_panel3";
            wafer_amount_panel3.Size = new Size(188, 20);
            wafer_amount_panel3.TabIndex = 49;
            // 
            // wafer_amount_panel4
            // 
            wafer_amount_panel4.BackColor = Color.White;
            wafer_amount_panel4.Location = new Point(92, 524);
            wafer_amount_panel4.Margin = new Padding(2);
            wafer_amount_panel4.Name = "wafer_amount_panel4";
            wafer_amount_panel4.Size = new Size(188, 20);
            wafer_amount_panel4.TabIndex = 50;
            // 
            // wafer_amount_panel5
            // 
            wafer_amount_panel5.BackColor = Color.White;
            wafer_amount_panel5.Location = new Point(92, 500);
            wafer_amount_panel5.Margin = new Padding(2);
            wafer_amount_panel5.Name = "wafer_amount_panel5";
            wafer_amount_panel5.Size = new Size(188, 20);
            wafer_amount_panel5.TabIndex = 51;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.ForeColor = Color.White;
            label31.Location = new Point(41, 596);
            label31.Margin = new Padding(2, 0, 2, 0);
            label31.Name = "label31";
            label31.Size = new Size(40, 15);
            label31.TabIndex = 52;
            label31.Text = "100매";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.ForeColor = Color.White;
            label32.Location = new Point(41, 572);
            label32.Margin = new Padding(2, 0, 2, 0);
            label32.Name = "label32";
            label32.Size = new Size(40, 15);
            label32.TabIndex = 53;
            label32.Text = "110매";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.ForeColor = Color.White;
            label33.Location = new Point(41, 548);
            label33.Margin = new Padding(2, 0, 2, 0);
            label33.Name = "label33";
            label33.Size = new Size(40, 15);
            label33.TabIndex = 54;
            label33.Text = "120매";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.ForeColor = Color.White;
            label34.Location = new Point(41, 524);
            label34.Margin = new Padding(2, 0, 2, 0);
            label34.Name = "label34";
            label34.Size = new Size(40, 15);
            label34.TabIndex = 55;
            label34.Text = "130매";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.ForeColor = Color.White;
            label35.Location = new Point(41, 500);
            label35.Margin = new Padding(2, 0, 2, 0);
            label35.Name = "label35";
            label35.Size = new Size(40, 15);
            label35.TabIndex = 56;
            label35.Text = "140매";
            // 
            // wafer_amount_panel6
            // 
            wafer_amount_panel6.BackColor = Color.White;
            wafer_amount_panel6.Location = new Point(92, 476);
            wafer_amount_panel6.Margin = new Padding(2);
            wafer_amount_panel6.Name = "wafer_amount_panel6";
            wafer_amount_panel6.Size = new Size(188, 20);
            wafer_amount_panel6.TabIndex = 52;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.ForeColor = Color.White;
            label36.Location = new Point(41, 476);
            label36.Margin = new Padding(2, 0, 2, 0);
            label36.Name = "label36";
            label36.Size = new Size(40, 15);
            label36.TabIndex = 57;
            label36.Text = "150매";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo2;
            pictureBox2.Location = new Point(8, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(203, 86);
            pictureBox2.TabIndex = 58;
            pictureBox2.TabStop = false;
            // 
            // groupBox11
            // 
            groupBox11.Controls.Add(Plasma_Control_button);
            groupBox11.Controls.Add(plasma_reflected_textbox);
            groupBox11.Controls.Add(plasma_forward_textbox);
            groupBox11.Controls.Add(rf_power_textbox);
            groupBox11.Controls.Add(label39);
            groupBox11.Controls.Add(label38);
            groupBox11.Controls.Add(label37);
            groupBox11.ForeColor = SystemColors.ControlLightLight;
            groupBox11.Location = new Point(685, 102);
            groupBox11.Name = "groupBox11";
            groupBox11.Size = new Size(307, 152);
            groupBox11.TabIndex = 59;
            groupBox11.TabStop = false;
            groupBox11.Text = "Plasma";
            // 
            // Plasma_Control_button
            // 
            Plasma_Control_button.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Plasma_Control_button.ForeColor = SystemColors.ActiveCaptionText;
            Plasma_Control_button.Location = new Point(155, 117);
            Plasma_Control_button.Name = "Plasma_Control_button";
            Plasma_Control_button.Size = new Size(100, 25);
            Plasma_Control_button.TabIndex = 6;
            Plasma_Control_button.Text = "플라즈마 설정";
            Plasma_Control_button.UseVisualStyleBackColor = true;
            Plasma_Control_button.Click += Plasma_Control_button_Click;
            // 
            // plasma_reflected_textbox
            // 
            plasma_reflected_textbox.BackColor = Color.FromArgb(128, 255, 128);
            plasma_reflected_textbox.Enabled = false;
            plasma_reflected_textbox.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            plasma_reflected_textbox.Location = new Point(146, 82);
            plasma_reflected_textbox.Name = "plasma_reflected_textbox";
            plasma_reflected_textbox.ReadOnly = true;
            plasma_reflected_textbox.Size = new Size(118, 23);
            plasma_reflected_textbox.TabIndex = 5;
            plasma_reflected_textbox.TextAlign = HorizontalAlignment.Center;
            // 
            // plasma_forward_textbox
            // 
            plasma_forward_textbox.BackColor = Color.FromArgb(128, 255, 128);
            plasma_forward_textbox.Enabled = false;
            plasma_forward_textbox.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            plasma_forward_textbox.Location = new Point(146, 53);
            plasma_forward_textbox.Name = "plasma_forward_textbox";
            plasma_forward_textbox.ReadOnly = true;
            plasma_forward_textbox.Size = new Size(118, 23);
            plasma_forward_textbox.TabIndex = 4;
            plasma_forward_textbox.TextAlign = HorizontalAlignment.Center;
            // 
            // rf_power_textbox
            // 
            rf_power_textbox.BackColor = Color.FromArgb(128, 255, 128);
            rf_power_textbox.Enabled = false;
            rf_power_textbox.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            rf_power_textbox.Location = new Point(146, 25);
            rf_power_textbox.Name = "rf_power_textbox";
            rf_power_textbox.ReadOnly = true;
            rf_power_textbox.Size = new Size(118, 23);
            rf_power_textbox.TabIndex = 3;
            rf_power_textbox.TextAlign = HorizontalAlignment.Center;
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label39.Location = new Point(23, 85);
            label39.Name = "label39";
            label39.Size = new Size(113, 15);
            label39.TabIndex = 2;
            label39.Text = "plasma_reflected :";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label38.Location = new Point(21, 58);
            label38.Name = "label38";
            label38.Size = new Size(115, 15);
            label38.TabIndex = 1;
            label38.Text = " plasma_forward  :";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label37.Location = new Point(27, 28);
            label37.Name = "label37";
            label37.Size = new Size(113, 15);
            label37.TabIndex = 0;
            label37.Text = "rf_power            : ";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(1288, 757);
            Controls.Add(groupBox11);
            Controls.Add(pictureBox2);
            Controls.Add(label36);
            Controls.Add(wafer_amount_panel6);
            Controls.Add(label35);
            Controls.Add(label34);
            Controls.Add(label33);
            Controls.Add(label32);
            Controls.Add(label31);
            Controls.Add(wafer_amount_panel5);
            Controls.Add(wafer_amount_panel4);
            Controls.Add(wafer_amount_panel3);
            Controls.Add(wafer_amount_panel2);
            Controls.Add(wafer_amount_panel1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(TMA_valOff);
            Controls.Add(TMA_valOn);
            Controls.Add(H2O2_valOff);
            Controls.Add(H2O2_valOn);
            Controls.Add(HfO2_valOff);
            Controls.Add(HfO2_valOn);
            Controls.Add(ZrO2_valOff);
            Controls.Add(ZrO2_valOn);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(TMA_CheckBox);
            Controls.Add(H2O2_CheckBox);
            Controls.Add(HfO2_CheckBox);
            Controls.Add(ZrO2_CheckBox);
            Controls.Add(N2_valOff);
            Controls.Add(N2_valOn);
            Controls.Add(Dry_Pump_Check_Box);
            Controls.Add(N2_CheckBox);
            Controls.Add(O3_valOff);
            Controls.Add(O3_valOn);
            Controls.Add(O3_CheckBox);
            Controls.Add(groupBox7);
            Controls.Add(groupBox4);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(Dry_pump_button);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.Disable;
            Name = "MainForm";
            Text = "ALD Furnace Develop";
            Load += MainForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox10.ResumeLayout(false);
            groupBox10.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox11.ResumeLayout(false);
            groupBox11.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button Process_Stop;
        private Button Process_Start;
        private GroupBox groupBox3;
        private PictureBox pictureBox1;
        private Label label1;
        private Button Dry_pump_button;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox recv_strr;
        private TextBox recv_cham_torr;
        private TextBox recv_cham_temp;
        private Label label9;
        private ProgressBar Process_progress;
        private Label label12;
        private Label label13;
        private TextBox recv_o3;
        private TextBox recv_n2;
        private Button Log_data_button;
        private Label label14;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private Button O3_valOn;
        private Button O3_valOff;
        private Button N2_valOff;
        private Button N2_valOn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ProgressBar Chamber_Temp_progress;
        private ProgressBar Gas_progress;
        private ProgressBar Chamber_Torr_progress;
        private Button Control_data_button;
        private GroupBox groupBox4;
        private Label label2;
        private TextBox textBox4;
        private Label label6;
        private Label label7;
        private Label label8;
        private ProgressBar progressBar1;
        private Button Exit_button;
        private System.Diagnostics.Process process1;
        private ReaLTaiizor.Controls.ThunderRadioButton thunderRadioButton1;
        private ReaLTaiizor.Controls.ThunderRadioButton thunderRadioButton2;
        private GroupBox groupBox7;
        private Label label10;
        private Label label11;
        private Label label17;
        private TextBox wafer_flat_area_textbox;
        private TextBox wafer_loading_textbox;
        private TextBox wafer_size_textbox;
        private CheckBox O3_CheckBox;
        private CheckBox N2_CheckBox;
        private CheckBox Dry_Pump_Check_Box;
        private CheckBox HfO2_CheckBox;
        private CheckBox ZrO2_CheckBox;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private CheckBox TMA_CheckBox;
        private CheckBox H2O2_CheckBox;
        private TextBox recv_tma;
        private TextBox recv_h2o2;
        private TextBox recv_hfo2;
        private TextBox recv_zro2;
        private Button H2O2_valOff;
        private Button H2O2_valOn;
        private Button HfO2_valOff;
        private Button HfO2_valOn;
        private Button ZrO2_valOff;
        private Button ZrO2_valOn;
        private Button TMA_valOff;
        private Button TMA_valOn;
        private Button Wafer_setting_button;
        private Panel panel1;
        private GroupBox groupBox8;
        private TextBox recipe_panel_TMA;
        private Label label15;
        private TextBox recipe_panel_H2O2;
        private Label label16;
        private TextBox recipe_panel_HfO2;
        private Label label22;
        private TextBox recipe_panel_ZrO2;
        private Label label23;
        private TextBox recipe_panel_N2;
        private Label label24;
        private TextBox recipe_panel_O3;
        private Label label25;
        private GroupBox groupBox9;
        private TextBox recipe_panel_torr;
        private TextBox recipe_panel_temp;
        private Label label26;
        private Label label27;
        private GroupBox groupBox10;
        private Label label28;
        private TextBox recipe_panel_name;
        private Label label29;
        private Panel panel2;
        private TextBox wafer_amount_textbox;
        private Label label30;
        private Label label36;
        private Panel wafer_amount_panel6;
        private Label label35;
        private Label label34;
        private Label label33;
        private Label label32;
        private Label label31;
        private Panel wafer_amount_panel5;
        private Panel wafer_amount_panel4;
        private Panel wafer_amount_panel3;
        private Panel wafer_amount_panel2;
        private Panel wafer_amount_panel1;
        private Panel panel3;
        private Panel chamber_ready_panel;
        private PictureBox pictureBox2;
        private GroupBox groupBox11;
        private Label label39;
        private Label label38;
        private Label label37;
        private TextBox rf_power_textbox;
        private TextBox plasma_reflected_textbox;
        private TextBox plasma_forward_textbox;
        private Button Plasma_Control_button;
    }
}