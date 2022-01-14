using System;
using System.Windows.Forms;

namespace AlarmClock.Forms
{
    public partial class AlarmClockForm : Form
    {
        /// <summary>
        /// 時區
        /// </summary>
        private int Timezone;

        /// <summary>
        /// 是否開啟鬧鐘
        /// </summary>
        private bool IsOpen;

        /// <summary>
        /// 鬧鐘時間
        /// </summary>
        private DateTime AlarmTime;

        public AlarmClockForm()
        {
            InitializeComponent();
            Timezone = 8;

            // 初始化下拉選單
            for (int i = 0; i < 24; i++)
            {
                HourComboBox.Items.Insert(i, i);
            }
            for (int i = 0; i < 60; i++)
            {
                MinuteComboBox.Items.Insert(i, i);
            }
            HourComboBox.SelectedIndex = 0;
            MinuteComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// 取得時區
        /// </summary>
        public int GetTimezone()
        {
            return Timezone;
        }

        /// <summary>
        /// 設定時區
        /// </summary>
        /// <param name="timezone">時區</param>
        public void SetTimezone(int timezone)
        {
            // 更新鬧鐘原本設定的時間
            int subHour = timezone - Timezone;       // 計算 新設定的時區 與 原先設定的時區 時間差
            AlarmTime = AlarmTime.AddHours(subHour); // 鬧鐘加上時間差
            HourComboBox.SelectedIndex = AlarmTime.Hour;

            // 更新時區
            Timezone = timezone;
            if (timezone == 0)
            {
                TimeZoneBtn.Text = "UTC";
            }
            else if (timezone > 0)
            {
                TimeZoneBtn.Text = "UTC+" + timezone.ToString();
            }
            else
            {
                TimeZoneBtn.Text = "UTC" + timezone.ToString();
            }
        }

        /// <summary>
        /// 時區切換按鈕
        /// </summary>
        private void TimeZoneBtn_Click(object sender, EventArgs e)
        {
            // 顯示時區設定Form
            Form form = new TimezoneForm(this);
            form.Show();
        }

        /// <summary>
        /// 當前時間timer
        /// </summary>
        private void NowTimer_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.UtcNow.AddHours(Timezone);
            NowLabelText.Text = now.ToString();

            if (IsOpen)
            {
                if (AlarmTime.Hour == now.Hour && AlarmTime.Minute == now.Minute)
                {
                    IsOpen = false;
                    SwithBtn.BackgroundImage = Properties.Resources.switch_button_off;

                    string alarmText = AlarmTextBox.Text;
                    // 延遲30秒自動關閉的訊息框
                    MessageBox.Show(new DelayCloseForm(30 * 1000), alarmText, "鬧鐘");
                }
            }
        }

        /// <summary>
        /// 鬧鐘開關
        /// </summary>
        private void SwithBtn_Click(object sender, EventArgs e)
        {
            if (IsOpen)
            {
                IsOpen = false;
                SwithBtn.BackgroundImage = Properties.Resources.switch_button_off;
            }
            else
            {
                IsOpen = true;
                SwithBtn.BackgroundImage = Properties.Resources.switch_button_on;
            }
        }

        /// <summary>
        /// 鬧鐘小時更新
        /// </summary>
        private void HourComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int hour = Convert.ToInt32(HourComboBox.SelectedItem);
            int minute = Convert.ToInt32(MinuteComboBox.SelectedItem);
            AlarmTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hour, minute, 0);
        }

        /// <summary>
        /// 鬧鐘分鐘更新
        /// </summary>
        private void MinuteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int hour = Convert.ToInt32(HourComboBox.SelectedItem);
            int minute = Convert.ToInt32(MinuteComboBox.SelectedItem);
            AlarmTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hour, minute, 0);
        }
    }
}
