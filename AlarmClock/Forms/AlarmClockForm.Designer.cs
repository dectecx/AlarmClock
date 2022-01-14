namespace AlarmClock.Forms
{
    partial class AlarmClockForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlarmClockForm));
            this.NowLabelText = new System.Windows.Forms.Label();
            this.NowLabel = new System.Windows.Forms.Label();
            this.TimezoneLabel = new System.Windows.Forms.Label();
            this.TimeZoneBtn = new System.Windows.Forms.Button();
            this.NowTimer = new System.Windows.Forms.Timer(this.components);
            this.AlarmTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.SwithBtn = new System.Windows.Forms.Button();
            this.HourComboBox = new System.Windows.Forms.ComboBox();
            this.MinuteComboBox = new System.Windows.Forms.ComboBox();
            this.HourLabel = new System.Windows.Forms.Label();
            this.MinuteLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.AlarmClockLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NowLabelText
            // 
            this.NowLabelText.AutoSize = true;
            this.NowLabelText.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NowLabelText.Location = new System.Drawing.Point(85, 33);
            this.NowLabelText.Name = "NowLabelText";
            this.NowLabelText.Size = new System.Drawing.Size(93, 20);
            this.NowLabelText.TabIndex = 1;
            this.NowLabelText.Text = "{{系統時間}}";
            // 
            // NowLabel
            // 
            this.NowLabel.AutoSize = true;
            this.NowLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NowLabel.Location = new System.Drawing.Point(0, 33);
            this.NowLabel.Name = "NowLabel";
            this.NowLabel.Size = new System.Drawing.Size(89, 20);
            this.NowLabel.TabIndex = 2;
            this.NowLabel.Text = "系統時間：";
            // 
            // TimezoneLabel
            // 
            this.TimezoneLabel.AutoSize = true;
            this.TimezoneLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TimezoneLabel.Location = new System.Drawing.Point(0, 9);
            this.TimezoneLabel.Name = "TimezoneLabel";
            this.TimezoneLabel.Size = new System.Drawing.Size(89, 20);
            this.TimezoneLabel.TabIndex = 4;
            this.TimezoneLabel.Text = "當前時區：";
            // 
            // TimeZoneBtn
            // 
            this.TimeZoneBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TimeZoneBtn.FlatAppearance.BorderSize = 0;
            this.TimeZoneBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimeZoneBtn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TimeZoneBtn.Location = new System.Drawing.Point(88, 9);
            this.TimeZoneBtn.Name = "TimeZoneBtn";
            this.TimeZoneBtn.Size = new System.Drawing.Size(80, 24);
            this.TimeZoneBtn.TabIndex = 5;
            this.TimeZoneBtn.Text = "UTC+8";
            this.TimeZoneBtn.UseVisualStyleBackColor = false;
            this.TimeZoneBtn.Click += new System.EventHandler(this.TimeZoneBtn_Click);
            // 
            // NowTimer
            // 
            this.NowTimer.Enabled = true;
            this.NowTimer.Tick += new System.EventHandler(this.NowTimer_Tick);
            // 
            // AlarmTextBox
            // 
            this.AlarmTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AlarmTextBox.Location = new System.Drawing.Point(12, 130);
            this.AlarmTextBox.Name = "AlarmTextBox";
            this.AlarmTextBox.Size = new System.Drawing.Size(200, 29);
            this.AlarmTextBox.TabIndex = 7;
            this.AlarmTextBox.Text = "標題1";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TitleLabel.Location = new System.Drawing.Point(12, 102);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(41, 20);
            this.TitleLabel.TabIndex = 8;
            this.TitleLabel.Text = "標題";
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ValueLabel.Location = new System.Drawing.Point(12, 169);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(41, 20);
            this.ValueLabel.TabIndex = 9;
            this.ValueLabel.Text = "時間";
            // 
            // SwithBtn
            // 
            this.SwithBtn.BackColor = System.Drawing.Color.Transparent;
            this.SwithBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SwithBtn.BackgroundImage")));
            this.SwithBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SwithBtn.FlatAppearance.BorderSize = 0;
            this.SwithBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SwithBtn.Location = new System.Drawing.Point(229, 191);
            this.SwithBtn.Name = "SwithBtn";
            this.SwithBtn.Size = new System.Drawing.Size(50, 35);
            this.SwithBtn.TabIndex = 10;
            this.SwithBtn.UseVisualStyleBackColor = false;
            this.SwithBtn.Click += new System.EventHandler(this.SwithBtn_Click);
            // 
            // HourComboBox
            // 
            this.HourComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HourComboBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HourComboBox.FormattingEnabled = true;
            this.HourComboBox.Location = new System.Drawing.Point(12, 196);
            this.HourComboBox.Name = "HourComboBox";
            this.HourComboBox.Size = new System.Drawing.Size(63, 28);
            this.HourComboBox.TabIndex = 11;
            this.HourComboBox.SelectedIndexChanged += new System.EventHandler(this.HourComboBox_SelectedIndexChanged);
            // 
            // MinuteComboBox
            // 
            this.MinuteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MinuteComboBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MinuteComboBox.FormattingEnabled = true;
            this.MinuteComboBox.Location = new System.Drawing.Point(115, 196);
            this.MinuteComboBox.Name = "MinuteComboBox";
            this.MinuteComboBox.Size = new System.Drawing.Size(63, 28);
            this.MinuteComboBox.TabIndex = 12;
            this.MinuteComboBox.SelectedIndexChanged += new System.EventHandler(this.MinuteComboBox_SelectedIndexChanged);
            // 
            // HourLabel
            // 
            this.HourLabel.AutoSize = true;
            this.HourLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HourLabel.Location = new System.Drawing.Point(81, 199);
            this.HourLabel.Name = "HourLabel";
            this.HourLabel.Size = new System.Drawing.Size(25, 20);
            this.HourLabel.TabIndex = 13;
            this.HourLabel.Text = "時";
            // 
            // MinuteLabel
            // 
            this.MinuteLabel.AutoSize = true;
            this.MinuteLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MinuteLabel.Location = new System.Drawing.Point(184, 199);
            this.MinuteLabel.Name = "MinuteLabel";
            this.MinuteLabel.Size = new System.Drawing.Size(25, 20);
            this.MinuteLabel.TabIndex = 14;
            this.MinuteLabel.Text = "分";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.EmailLabel.Location = new System.Drawing.Point(12, 237);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(73, 20);
            this.EmailLabel.TabIndex = 15;
            this.EmailLabel.Text = "錯過提醒";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.EmailTextBox.Location = new System.Drawing.Point(12, 265);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(267, 29);
            this.EmailTextBox.TabIndex = 16;
            this.EmailTextBox.Text = "請輸入Email@gmail.com";
            // 
            // AlarmClockLabel
            // 
            this.AlarmClockLabel.AutoSize = true;
            this.AlarmClockLabel.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AlarmClockLabel.Location = new System.Drawing.Point(78, 63);
            this.AlarmClockLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AlarmClockLabel.Name = "AlarmClockLabel";
            this.AlarmClockLabel.Size = new System.Drawing.Size(145, 40);
            this.AlarmClockLabel.TabIndex = 0;
            this.AlarmClockLabel.Text = "鬧鐘設定";
            // 
            // AlarmClockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.MinuteLabel);
            this.Controls.Add(this.HourLabel);
            this.Controls.Add(this.MinuteComboBox);
            this.Controls.Add(this.HourComboBox);
            this.Controls.Add(this.SwithBtn);
            this.Controls.Add(this.ValueLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.AlarmTextBox);
            this.Controls.Add(this.TimeZoneBtn);
            this.Controls.Add(this.TimezoneLabel);
            this.Controls.Add(this.NowLabel);
            this.Controls.Add(this.NowLabelText);
            this.Controls.Add(this.AlarmClockLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AlarmClockForm";
            this.Text = "AlarmClockForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NowLabelText;
        private System.Windows.Forms.Label NowLabel;
        private System.Windows.Forms.Label TimezoneLabel;
        private System.Windows.Forms.Button TimeZoneBtn;
        private System.Windows.Forms.Timer NowTimer;
        private System.Windows.Forms.TextBox AlarmTextBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.Button SwithBtn;
        private System.Windows.Forms.ComboBox HourComboBox;
        private System.Windows.Forms.ComboBox MinuteComboBox;
        private System.Windows.Forms.Label HourLabel;
        private System.Windows.Forms.Label MinuteLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label AlarmClockLabel;
    }
}