using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace AlarmClock.Forms
{
    public partial class DelayCloseForm : Form
    {
        public DelayCloseForm(int interval = 500)
        {
            InitializeComponent();
            //計時器
            this.components = new Container();
            Timer timer1 = new Timer(this.components);
            timer1.Enabled = true;
            timer1.Interval = interval;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
