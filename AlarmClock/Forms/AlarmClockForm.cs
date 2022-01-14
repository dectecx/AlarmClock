using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        private void TimeZoneBtn_Click(object sender, EventArgs e)
        {
            Form form = new TimezoneForm(this);
            form.Show();
        }
    }
}
