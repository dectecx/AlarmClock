using AlarmClock.Forms;
using System.Windows.Forms;

namespace AlarmClock
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SetTabPageWithForm(AlarmClockTabPage, new AlarmClockForm());
            SetTabPageWithForm(StopwatchTabPage, new StopwatchForm());
            SetTabPageWithForm(CountdownTabPage, new CountdownForm());
        }

        private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            switch ((sender as TabControl).SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
            }
        }

        /// <summary>
        /// 設定tabPage內容
        /// </summary>
        /// <param name="tabPage">標籤頁物件</param>
        /// <param name="childForm">表單物件</param>
        private void SetTabPageWithForm(TabPage tabPage, Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            tabPage.Controls.Add(childForm);
            tabPage.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}