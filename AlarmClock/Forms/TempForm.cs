using System;
using System.Media;
using System.Windows.Forms;

namespace AlarmClock.Forms
{
    public partial class TempForm : Form
    {
        SoundPlayer SoSoftPlayer = new SoundPlayer();
        Timer SoSoftTimer = new Timer();    // 定義計時器
        DateTime RingTime;                  // 提醒時間

        public TempForm()
        {
            //InitializeComponent();
            SoSoftPlayer.Stream = Properties.Resources.Ringin;
            SoSoftTimer.Interval = 400;     // 設定檢測間隔時間
            SoSoftTimer.Tick += new EventHandler(SoSoftTimer_Tick);
            //textBox_time.Text = DateTime.Now.AddHours(1).ToString();    // 設定初始鬧鐘預設值
        }
        void SoSoftTimer_Tick(object sender, EventArgs e)
        {
            // 提醒的時間條件
            if (DateTime.Now.CompareTo(RingTime) > 0)
            {
                Ringing();
            }
        }

        /// <summary>
        /// 提醒
        /// </summary>
        private void Ringing()
        {
            SoSoftTimer.Stop();//停止計時器 
            //加入提醒程式碼,包括響鈴。
            SoSoftPlayer.PlayLooping();//循環播放
            //SoSoftPlayer.Stop();
        }

        /// <summary> 
        /// 開啟鬧鐘 
        /// </summary> 
        /// <param name="sender"></param> 
        /// <param name="e"></param> 
        private void button_TurnOn_Click(object sender, EventArgs e)
        {
            //RingTime = Convert.ToDateTime(textBox_time.Text);
            SoSoftTimer.Start();//開始計時器
        }
    }
}
