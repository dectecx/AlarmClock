﻿namespace AlarmClock
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
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.AlarmClockTabPage = new System.Windows.Forms.TabPage();
            this.StopwatchTabPage = new System.Windows.Forms.TabPage();
            this.CountdownTabPage = new System.Windows.Forms.TabPage();
            this.MainTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.AlarmClockTabPage);
            this.MainTabControl.Controls.Add(this.StopwatchTabPage);
            this.MainTabControl.Controls.Add(this.CountdownTabPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(308, 326);
            this.MainTabControl.TabIndex = 0;
            // 
            // AlarmClockTabPage
            // 
            this.AlarmClockTabPage.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AlarmClockTabPage.Location = new System.Drawing.Point(4, 22);
            this.AlarmClockTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.AlarmClockTabPage.Name = "AlarmClockTabPage";
            this.AlarmClockTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.AlarmClockTabPage.Size = new System.Drawing.Size(300, 300);
            this.AlarmClockTabPage.TabIndex = 0;
            this.AlarmClockTabPage.Text = "鬧鐘";
            this.AlarmClockTabPage.UseVisualStyleBackColor = true;
            // 
            // StopwatchTabPage
            // 
            this.StopwatchTabPage.Location = new System.Drawing.Point(4, 22);
            this.StopwatchTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.StopwatchTabPage.Name = "StopwatchTabPage";
            this.StopwatchTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.StopwatchTabPage.Size = new System.Drawing.Size(300, 300);
            this.StopwatchTabPage.TabIndex = 1;
            this.StopwatchTabPage.Text = "計時器";
            this.StopwatchTabPage.UseVisualStyleBackColor = true;
            // 
            // CountdownTabPage
            // 
            this.CountdownTabPage.Location = new System.Drawing.Point(4, 22);
            this.CountdownTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.CountdownTabPage.Name = "CountdownTabPage";
            this.CountdownTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.CountdownTabPage.Size = new System.Drawing.Size(300, 300);
            this.CountdownTabPage.TabIndex = 2;
            this.CountdownTabPage.Text = "倒數器";
            this.CountdownTabPage.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 326);
            this.Controls.Add(this.MainTabControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "時鐘";
            this.MainTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage AlarmClockTabPage;
        private System.Windows.Forms.TabPage StopwatchTabPage;
        private System.Windows.Forms.TabPage CountdownTabPage;
    }
}

