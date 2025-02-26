namespace ModbusClientCS
{
    partial class Wafer_Control_data
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
            groupBox2 = new GroupBox();
            wafer_flat_area_combobox = new ComboBox();
            wafer_loading_combobox = new ComboBox();
            wafer_size_combobox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label6 = new Label();
            Wafer_Send_button = new Button();
            label3 = new Label();
            wafer_amount_combobox = new ComboBox();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(wafer_amount_combobox);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(wafer_flat_area_combobox);
            groupBox2.Controls.Add(wafer_loading_combobox);
            groupBox2.Controls.Add(wafer_size_combobox);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label6);
            groupBox2.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            groupBox2.ForeColor = SystemColors.ControlLightLight;
            groupBox2.Location = new Point(50, 50);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(341, 275);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "웨이퍼 정보";
            // 
            // wafer_flat_area_combobox
            // 
            wafer_flat_area_combobox.FormattingEnabled = true;
            wafer_flat_area_combobox.Items.AddRange(new object[] { "100(N)", "100(P)", "111(N)", "111(P)", "Notch type" });
            wafer_flat_area_combobox.Location = new Point(211, 140);
            wafer_flat_area_combobox.Name = "wafer_flat_area_combobox";
            wafer_flat_area_combobox.Size = new Size(120, 33);
            wafer_flat_area_combobox.TabIndex = 8;
            // 
            // wafer_loading_combobox
            // 
            wafer_loading_combobox.FormattingEnabled = true;
            wafer_loading_combobox.Items.AddRange(new object[] { "Single", "Batch" });
            wafer_loading_combobox.Location = new Point(211, 95);
            wafer_loading_combobox.Name = "wafer_loading_combobox";
            wafer_loading_combobox.Size = new Size(120, 33);
            wafer_loading_combobox.TabIndex = 7;
            // 
            // wafer_size_combobox
            // 
            wafer_size_combobox.FormattingEnabled = true;
            wafer_size_combobox.Items.AddRange(new object[] { "8", "12" });
            wafer_size_combobox.Location = new Point(211, 48);
            wafer_size_combobox.Name = "wafer_size_combobox";
            wafer_size_combobox.Size = new Size(120, 33);
            wafer_size_combobox.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 148);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(196, 25);
            label1.TabIndex = 2;
            label1.Text = "웨이퍼 평탄 영역(mm)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 100);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(209, 25);
            label2.TabIndex = 1;
            label2.Text = "웨이퍼 로딩 방식(FOUP)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 52);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(174, 25);
            label6.TabIndex = 0;
            label6.Text = "웨이퍼 크기(inches)";
            // 
            // Wafer_Send_button
            // 
            Wafer_Send_button.Location = new Point(137, 352);
            Wafer_Send_button.Margin = new Padding(4, 5, 4, 5);
            Wafer_Send_button.Name = "Wafer_Send_button";
            Wafer_Send_button.Size = new Size(174, 38);
            Wafer_Send_button.TabIndex = 24;
            Wafer_Send_button.Text = "설정 값 보내기";
            Wafer_Send_button.UseVisualStyleBackColor = true;
            Wafer_Send_button.Click += Wafer_Send_button_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 196);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(138, 25);
            label3.TabIndex = 9;
            label3.Text = "웨이퍼 개수(매)";
            // 
            // wafer_amount_combobox
            // 
            wafer_amount_combobox.FormattingEnabled = true;
            wafer_amount_combobox.Items.AddRange(new object[] { "100", "110", "120", "130", "140", "150" });
            wafer_amount_combobox.Location = new Point(211, 196);
            wafer_amount_combobox.Name = "wafer_amount_combobox";
            wafer_amount_combobox.Size = new Size(120, 33);
            wafer_amount_combobox.TabIndex = 10;
            // 
            // Wafer_Control_data
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(449, 450);
            Controls.Add(Wafer_Send_button);
            Controls.Add(groupBox2);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Wafer_Control_data";
            Text = "웨이퍼 정보 수정";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private ComboBox wafer_flat_area_combobox;
        private ComboBox wafer_loading_combobox;
        private ComboBox wafer_size_combobox;
        private Label label1;
        private Label label2;
        private Label label6;
        private Button Wafer_Send_button;
        private ComboBox wafer_amount_combobox;
        private Label label3;
    }
}