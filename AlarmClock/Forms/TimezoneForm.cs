using System;
using System.Drawing;
using System.Windows.Forms;

namespace AlarmClock.Forms
{
    public partial class TimezoneForm : Form
    {
        /// <summary>
        /// 鬧鐘Form
        /// </summary>
        private AlarmClockForm alarmClockForm;

        /// <summary>
        /// 當前選擇的時區
        /// </summary>
        private int CurrentSelectedZone;

        public TimezoneForm(AlarmClockForm alarmClockForm)
        {
            InitializeComponent();
            this.alarmClockForm = alarmClockForm;
            this.CurrentSelectedZone = alarmClockForm.GetTimezone();
            alarmClockForm.SetTimezone(0);

            // 初始化所有按鈕的顏色、Click事件
            ResetBtnColor();
            // UTC-1 ~ UTC-11
            for (int i = 1; i < 12; i++)
            {
                Button btn = (Button)this.Controls.Find("zoneR" + i.ToString().PadLeft(2, '0') + "Btn", true)[0];
                if (CurrentSelectedZone == i * -1)
                {
                    SetBtnColor(btn);
                }
                btn.Tag = i;
                btn.Click += new EventHandler(Common_ZoneXXBtn_Click);
            }
            // UTC 、 UTC+1 ~ UTC+12
            for (int i = 0; i < 13; i++)
            {
                Button btn = (Button)this.Controls.Find("zone" + i.ToString().PadLeft(2, '0') + "Btn", true)[0];
                if (CurrentSelectedZone == i)
                {
                    SetBtnColor(btn);
                }
                btn.Tag = i;
                btn.Click += new EventHandler(Common_ZoneXXBtn_Click);
            }
        }

        /// <summary>
        /// 重設所有按鈕顏色
        /// </summary>
        private void ResetBtnColor()
        {
            // UTC-1 ~ UTC-11
            for (int i = 1; i < 12; i++)
            {
                Button btn = (Button)this.Controls.Find("zoneR" + i.ToString().PadLeft(2, '0') + "Btn", true)[0];
                btn.BackColor = SystemColors.Control;
            }
            // UTC 、 UTC+1 ~ UTC+12
            for (int i = 0; i < 13; i++)
            {
                Button btn = (Button)this.Controls.Find("zone" + i.ToString().PadLeft(2, '0') + "Btn", true)[0];
                btn.BackColor = SystemColors.Control;
            }
        }

        /// <summary>
        /// 設定按鈕顏色
        /// </summary>
        /// <param name="button">按鈕物件</param>
        private void SetBtnColor(Button button)
        {
            button.BackColor = SystemColors.ActiveCaption;
        }

        /// <summary>
        /// 時區按鈕Click事件
        /// </summary>
        private void Common_ZoneXXBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            ResetBtnColor();
            SetBtnColor(btn);
            CurrentSelectedZone = (int)btn.Tag;
        }

        /// <summary>
        /// 取消變更
        /// </summary>
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 確定變更
        /// </summary>
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            alarmClockForm.SetTimezone(CurrentSelectedZone);
        }
    }
}
