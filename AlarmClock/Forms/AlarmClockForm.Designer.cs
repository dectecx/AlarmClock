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
            this.label1 = new System.Windows.Forms.Label();
            this.NowLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TimezoneLabel = new System.Windows.Forms.Label();
            this.TimeZoneBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(77, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "AlarmClock";
            // 
            // NowLabel
            // 
            this.NowLabel.AutoSize = true;
            this.NowLabel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NowLabel.Location = new System.Drawing.Point(123, 33);
            this.NowLabel.Name = "NowLabel";
            this.NowLabel.Size = new System.Drawing.Size(110, 24);
            this.NowLabel.TabIndex = 1;
            this.NowLabel.Text = "{{系統時間}}";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "系統時間：";
            // 
            // TimezoneLabel
            // 
            this.TimezoneLabel.AutoSize = true;
            this.TimezoneLabel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TimezoneLabel.Location = new System.Drawing.Point(12, 9);
            this.TimezoneLabel.Name = "TimezoneLabel";
            this.TimezoneLabel.Size = new System.Drawing.Size(105, 24);
            this.TimezoneLabel.TabIndex = 4;
            this.TimezoneLabel.Text = "當前時區：";
            // 
            // TimeZoneBtn
            // 
            this.TimeZoneBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TimeZoneBtn.FlatAppearance.BorderSize = 0;
            this.TimeZoneBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimeZoneBtn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TimeZoneBtn.Location = new System.Drawing.Point(127, 9);
            this.TimeZoneBtn.Name = "TimeZoneBtn";
            this.TimeZoneBtn.Size = new System.Drawing.Size(65, 24);
            this.TimeZoneBtn.TabIndex = 5;
            this.TimeZoneBtn.Text = "UTC+8";
            this.TimeZoneBtn.UseVisualStyleBackColor = false;
            this.TimeZoneBtn.Click += new System.EventHandler(this.TimeZoneBtn_Click);
            // 
            // AlarmClockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.TimeZoneBtn);
            this.Controls.Add(this.TimezoneLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NowLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AlarmClockForm";
            this.Text = "AlarmClockForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NowLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TimezoneLabel;
        private System.Windows.Forms.Button TimeZoneBtn;
    }
}