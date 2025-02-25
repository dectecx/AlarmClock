﻿using System;
using System.Windows.Forms;

namespace AlarmClock.Forms
{
    public partial class StopwatchForm : Form
    {
        /// <summary>
        /// 碼表時間
        /// </summary>
        private TimeSpan StopwatchTime;

        public StopwatchForm()
        {
            InitializeComponent();
            Reset();
        }

        /// <summary>
        /// 碼表timer
        /// </summary>
        private void StopwatchTimer_Tick(object sender, EventArgs e)
        {
            StopwatchLabel.Text = StopwatchTime.Hours.ToString("00") + ":" + StopwatchTime.Minutes.ToString("00") + ":" + StopwatchTime.Seconds.ToString("00");
            StopwatchTime = StopwatchTime.Add(new TimeSpan(0, 0, 0, 0, 100));
        }

        /// <summary>
        /// 開始
        /// </summary>
        private void StartBtn_Click(object sender, EventArgs e)
        {
            StopwatchTime = new TimeSpan(0, 0, 0);
            StartBtn.Hide();
            StopBtn.Show();
            EndBtn.Show();
            StopwatchTimer.Start();
            StopwatchLabel.Text = StopwatchTime.Hours.ToString("00") + ":" + StopwatchTime.Minutes.ToString("00") + ":" + StopwatchTime.Seconds.ToString("00");
        }

        /// <summary>
        /// 暫停
        /// </summary>
        private void StopBtn_Click(object sender, EventArgs e)
        {
            if (StopwatchTimer.Enabled)
            {
                StatusLabel.Text = "暫停中";
                StopBtn.Text = "繼續";
                StopwatchTimer.Stop();
            }
            else
            {
                StatusLabel.Text = "";
                StopBtn.Text = "暫停";
                StopwatchTimer.Start();
            }
        }

        /// <summary>
        /// 停止
        /// </summary>
        private void EndBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        /// <summary>
        /// 重設
        /// </summary>
        private void Reset()
        {
            StatusLabel.Text = "";
            StartBtn.Show();
            StopBtn.Hide();
            EndBtn.Hide();
            StopwatchTimer.Stop();
        }
    }
}
