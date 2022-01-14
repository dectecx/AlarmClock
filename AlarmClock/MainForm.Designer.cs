namespace AlarmClock
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AlarmClockTabPage = new System.Windows.Forms.TabPage();
            this.StopwatchTabPage = new System.Windows.Forms.TabPage();
            this.CountdownTabPage = new System.Windows.Forms.TabPage();
            this.TimezoneTabPage = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AlarmClockTabPage);
            this.tabControl1.Controls.Add(this.StopwatchTabPage);
            this.tabControl1.Controls.Add(this.CountdownTabPage);
            this.tabControl1.Controls.Add(this.TimezoneTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(658, 520);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // AlarmClockTabPage
            // 
            this.AlarmClockTabPage.Location = new System.Drawing.Point(4, 25);
            this.AlarmClockTabPage.Name = "AlarmClockTabPage";
            this.AlarmClockTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AlarmClockTabPage.Size = new System.Drawing.Size(650, 491);
            this.AlarmClockTabPage.TabIndex = 0;
            this.AlarmClockTabPage.Text = "鬧鐘";
            this.AlarmClockTabPage.UseVisualStyleBackColor = true;
            // 
            // StopwatchTabPage
            // 
            this.StopwatchTabPage.Location = new System.Drawing.Point(4, 25);
            this.StopwatchTabPage.Name = "StopwatchTabPage";
            this.StopwatchTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.StopwatchTabPage.Size = new System.Drawing.Size(650, 491);
            this.StopwatchTabPage.TabIndex = 1;
            this.StopwatchTabPage.Text = "計時器";
            this.StopwatchTabPage.UseVisualStyleBackColor = true;
            // 
            // CountdownTabPage
            // 
            this.CountdownTabPage.Location = new System.Drawing.Point(4, 25);
            this.CountdownTabPage.Name = "CountdownTabPage";
            this.CountdownTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CountdownTabPage.Size = new System.Drawing.Size(650, 491);
            this.CountdownTabPage.TabIndex = 2;
            this.CountdownTabPage.Text = "倒數器";
            this.CountdownTabPage.UseVisualStyleBackColor = true;
            // 
            // TimezoneTabPage
            // 
            this.TimezoneTabPage.Location = new System.Drawing.Point(4, 25);
            this.TimezoneTabPage.Name = "TimezoneTabPage";
            this.TimezoneTabPage.Size = new System.Drawing.Size(650, 491);
            this.TimezoneTabPage.TabIndex = 3;
            this.TimezoneTabPage.Text = "切換時區";
            this.TimezoneTabPage.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 520);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "時鐘";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AlarmClockTabPage;
        private System.Windows.Forms.TabPage StopwatchTabPage;
        private System.Windows.Forms.TabPage CountdownTabPage;
        private System.Windows.Forms.TabPage TimezoneTabPage;
    }
}

