using System;
using System.Windows.Forms;

namespace AlarmClock.Forms
{
    public partial class AlarmClockForm : Form
    {
        /// <summary>
        /// 時區
        /// </summary>
        private int timezone;

        public AlarmClockForm()
        {
            InitializeComponent();
            timezone = 8;
        }

        /// <summary>
        /// 取得時區
        /// </summary>
        public int GetTimezone()
        {
            return this.timezone;
        }

        /// <summary>
        /// 設定時區
        /// </summary>
        /// <param name="timezone">時區</param>
        public void SetTimezone(int timezone)
        {
            this.timezone = timezone;
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
        /// 系統時間timer
        /// </summary>
        private void SysTimer_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.UtcNow.AddHours(timezone);
            NowLabel.Text = now.ToString();
        }
    }
}
