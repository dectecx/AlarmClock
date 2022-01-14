namespace AlarmClock.Forms
{
    partial class StopwatchForm
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
            this.StartBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.StopwatchLabel = new System.Windows.Forms.Label();
            this.StopwatchTimer = new System.Windows.Forms.Timer(this.components);
            this.StatusLabel = new System.Windows.Forms.Label();
            this.HourLabel = new System.Windows.Forms.Label();
            this.SecondLabel = new System.Windows.Forms.Label();
            this.MinuteLabel = new System.Windows.Forms.Label();
            this.EndBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(51, 255);
            this.StartBtn.Margin = new System.Windows.Forms.Padding(2);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(198, 33);
            this.StartBtn.TabIndex = 13;
            this.StartBtn.Text = "開始";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.Location = new System.Drawing.Point(153, 256);
            this.StopBtn.Margin = new System.Windows.Forms.Padding(2);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(136, 33);
            this.StopBtn.TabIndex = 14;
            this.StopBtn.Text = "暫停";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Visible = false;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // StopwatchLabel
            // 
            this.StopwatchLabel.AutoSize = true;
            this.StopwatchLabel.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.StopwatchLabel.Location = new System.Drawing.Point(78, 96);
            this.StopwatchLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StopwatchLabel.Name = "StopwatchLabel";
            this.StopwatchLabel.Size = new System.Drawing.Size(145, 40);
            this.StopwatchLabel.TabIndex = 12;
            this.StopwatchLabel.Text = "00:00:00";
            // 
            // StopwatchTimer
            // 
            this.StopwatchTimer.Tick += new System.EventHandler(this.StopwatchTimer_Tick);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.StatusLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.StatusLabel.Location = new System.Drawing.Point(219, 160);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(34, 17);
            this.StatusLabel.TabIndex = 22;
            this.StatusLabel.Text = "狀態";
            // 
            // HourLabel
            // 
            this.HourLabel.AutoSize = true;
            this.HourLabel.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HourLabel.Location = new System.Drawing.Point(83, 56);
            this.HourLabel.Name = "HourLabel";
            this.HourLabel.Size = new System.Drawing.Size(49, 40);
            this.HourLabel.TabIndex = 18;
            this.HourLabel.Text = "時";
            // 
            // SecondLabel
            // 
            this.SecondLabel.AutoSize = true;
            this.SecondLabel.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SecondLabel.Location = new System.Drawing.Point(174, 56);
            this.SecondLabel.Name = "SecondLabel";
            this.SecondLabel.Size = new System.Drawing.Size(49, 40);
            this.SecondLabel.TabIndex = 17;
            this.SecondLabel.Text = "秒";
            // 
            // MinuteLabel
            // 
            this.MinuteLabel.AutoSize = true;
            this.MinuteLabel.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MinuteLabel.Location = new System.Drawing.Point(128, 56);
            this.MinuteLabel.Name = "MinuteLabel";
            this.MinuteLabel.Size = new System.Drawing.Size(49, 40);
            this.MinuteLabel.TabIndex = 16;
            this.MinuteLabel.Text = "分";
            // 
            // EndBtn
            // 
            this.EndBtn.Location = new System.Drawing.Point(12, 256);
            this.EndBtn.Name = "EndBtn";
            this.EndBtn.Size = new System.Drawing.Size(136, 32);
            this.EndBtn.TabIndex = 15;
            this.EndBtn.Text = "停止";
            this.EndBtn.UseVisualStyleBackColor = true;
            this.EndBtn.Visible = false;
            this.EndBtn.Click += new System.EventHandler(this.EndBtn_Click);
            // 
            // StopwatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.HourLabel);
            this.Controls.Add(this.SecondLabel);
            this.Controls.Add(this.MinuteLabel);
            this.Controls.Add(this.EndBtn);
            this.Controls.Add(this.StopwatchLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StopwatchForm";
            this.Text = "StopwatchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.Label StopwatchLabel;
        private System.Windows.Forms.Timer StopwatchTimer;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label HourLabel;
        private System.Windows.Forms.Label SecondLabel;
        private System.Windows.Forms.Label MinuteLabel;
        private System.Windows.Forms.Button EndBtn;
    }
}