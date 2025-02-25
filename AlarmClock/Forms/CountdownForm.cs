﻿using System;
using System.Media;
using System.Windows.Forms;

namespace AlarmClock.Forms
{
    public partial class CountdownForm : Form
    {
        /// <summary>
        /// 音效播放器
        /// </summary>
        SoundPlayer Player;

        /// <summary>
        /// 倒數時間
        /// </summary>
        private TimeSpan CountdownTime;

        public CountdownForm()
        {
            InitializeComponent();
            Player = new SoundPlayer();
            Reset();

            // 初始化下拉選單
            for (int i = 0; i < 24; i++)
            {
                HourComboBox.Items.Insert(i, i);
            }
            for (int i = 0; i < 60; i++)
            {
                MinuteComboBox.Items.Insert(i, i);
                SecondComboBox.Items.Insert(i, i);
            }
            HourComboBox.SelectedIndex = 0;
            MinuteComboBox.SelectedIndex = 0;
            SecondComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// 碼表timer
        /// </summary>
        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            if (CountdownTime > new TimeSpan(0, 0, 0))
            {
                CountdownLabel.Text = CountdownTime.Hours.ToString("00") + ":" + CountdownTime.Minutes.ToString("00") + ":" + CountdownTime.Seconds.ToString("00");
                CountdownTime = CountdownTime.Add(new TimeSpan(0, 0, 0, 0, -100));
            }
            else
            {
                CountdownTime = new TimeSpan(0, 0, 0);
                CountdownLabel.Text = "00:00:00";
                CountdownTimer.Stop();
                Ringing();
                // 延遲10秒自動關閉的訊息框
                MessageBox.Show(new DelayCloseForm(10 * 1000), "倒數時間到！", "倒數器");
                Player.Stop();
                Reset();
            }
        }

        /// <summary>
        /// 響鈴
        /// </summary>
        private void Ringing()
        {
            Player.Stream = Properties.Resources.Ringin;

            // 循環播放
            Player.PlayLooping();
        }

        /// <summary>
        /// 開始
        /// </summary>
        private void StartBtn_Click(object sender, EventArgs e)
        {
            int hour = (int)HourComboBox.SelectedItem;
            int minute = (int)MinuteComboBox.SelectedItem;
            int second = (int)SecondComboBox.SelectedItem;
            CountdownTime = new TimeSpan(hour, minute, second);
            if (CountdownTime.TotalSeconds > 0)
            {
                StatusLabel.Text = "";
                StartBtn.Hide();
                StopBtn.Show();
                EndBtn.Show();
                HourComboBox.Hide();
                MinuteComboBox.Hide();
                SecondComboBox.Hide();
                CountdownLabel.Show();
                CountdownTimer.Start();
                CountdownLabel.Text = CountdownTime.Hours.ToString("00") + ":" + CountdownTime.Minutes.ToString("00") + ":" + CountdownTime.Seconds.ToString("00");
            }
            else
            {
                StatusLabel.Text = "請設定大於0分0秒以上的時間";
            }
        }

        /// <summary>
        /// 暫停
        /// </summary>
        private void StopBtn_Click(object sender, EventArgs e)
        {
            if (CountdownTimer.Enabled)
            {
                StatusLabel.Text = "暫停中";
                StopBtn.Text = "繼續";
                CountdownTimer.Stop();
            }
            else
            {
                StatusLabel.Text = "";
                StopBtn.Text = "暫停";
                CountdownTimer.Start();
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
            HourComboBox.Show();
            MinuteComboBox.Show();
            SecondComboBox.Show();
            CountdownLabel.Hide();
            CountdownTimer.Stop();
        }
    }
}
