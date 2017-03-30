using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transparent
{
    public partial class MainForm : Form
    {
        private readonly Graphics dc;
        private readonly Graphics dc_this;
        private Pen penCircle = new Pen(Color.White);
        private readonly Bitmap bmp = new Bitmap(600, 600);

        public MainForm()
        {
            InitializeComponent();
            dc = Graphics.FromImage(bmp);
            dc_this = this.CreateGraphics();
            penCircle.DashStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            penCircle.DashPattern = new float[] { 5, 10 };
            this.Location = new Point(660,240);
            dc.DrawEllipse(penCircle, 30, 30, 540, 540);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            this.TransparencyKey = Color.Black;
            timer.Start();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            dc_this.DrawImage(bmp, 0, 0);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;
            int second = DateTime.Now.Second;
            labelHourAndMinute.Text = (hour >=10 ? hour.ToString() : '0' + hour.ToString() )+ ":" +
                (minute >= 10 ? minute.ToString() : '0' + minute.ToString());
            labelSecond.Text = second >= 10 ? second.ToString() :'0'+second.ToString();
        }
    }
}
