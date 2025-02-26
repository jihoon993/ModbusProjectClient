namespace ModbusClientCS
{
    partial class Plasma_Control
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
            groupBox11 = new GroupBox();
            plasma_reflected_textbox = new TextBox();
            plasma_forward_textbox = new TextBox();
            label39 = new Label();
            label38 = new Label();
            Plasma_Control_Send_button = new Button();
            groupBox11.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox11
            // 
            groupBox11.Controls.Add(plasma_reflected_textbox);
            groupBox11.Controls.Add(plasma_forward_textbox);
            groupBox11.Controls.Add(label39);
            groupBox11.Controls.Add(label38);
            groupBox11.ForeColor = SystemColors.ControlLightLight;
            groupBox11.Location = new Point(36, 40);
            groupBox11.Name = "groupBox11";
            groupBox11.Size = new Size(302, 139);
            groupBox11.TabIndex = 60;
            groupBox11.TabStop = false;
            groupBox11.Text = "Plasma";
            // 
            // plasma_reflected_textbox
            // 
            plasma_reflected_textbox.BackColor = Color.White;
            plasma_reflected_textbox.Location = new Point(151, 85);
            plasma_reflected_textbox.Name = "plasma_reflected_textbox";
            plasma_reflected_textbox.Size = new Size(118, 23);
            plasma_reflected_textbox.TabIndex = 5;
            plasma_reflected_textbox.TextAlign = HorizontalAlignment.Center;
            // 
            // plasma_forward_textbox
            // 
            plasma_forward_textbox.BackColor = Color.White;
            plasma_forward_textbox.Location = new Point(151, 45);
            plasma_forward_textbox.Name = "plasma_forward_textbox";
            plasma_forward_textbox.Size = new Size(118, 23);
            plasma_forward_textbox.TabIndex = 4;
            plasma_forward_textbox.TextAlign = HorizontalAlignment.Center;
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label39.Location = new Point(28, 88);
            label39.Name = "label39";
            label39.Size = new Size(113, 15);
            label39.TabIndex = 2;
            label39.Text = "plasma_reflected :";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label38.Location = new Point(26, 50);
            label38.Name = "label38";
            label38.Size = new Size(115, 15);
            label38.TabIndex = 1;
            label38.Text = " plasma_forward  :";
            // 
            // Plasma_Control_Send_button
            // 
            Plasma_Control_Send_button.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Plasma_Control_Send_button.ForeColor = SystemColors.ActiveCaptionText;
            Plasma_Control_Send_button.Location = new Point(127, 197);
            Plasma_Control_Send_button.Name = "Plasma_Control_Send_button";
            Plasma_Control_Send_button.Size = new Size(141, 42);
            Plasma_Control_Send_button.TabIndex = 6;
            Plasma_Control_Send_button.Text = "플라즈마 설정값 전송";
            Plasma_Control_Send_button.UseVisualStyleBackColor = true;
            Plasma_Control_Send_button.Click += Plasma_Control_Send_button_Click;
            // 
            // Plasma_Control
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(394, 268);
            Controls.Add(Plasma_Control_Send_button);
            Controls.Add(groupBox11);
            Name = "Plasma_Control";
            Text = "Plasma_Control";
            groupBox11.ResumeLayout(false);
            groupBox11.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox11;
        private Button Plasma_Control_Send_button;
        private TextBox plasma_reflected_textbox;
        private TextBox plasma_forward_textbox;
        private Label label39;
        private Label label38;
    }
}