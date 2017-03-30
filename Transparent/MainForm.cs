using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Transparent
{
    public partial class MainForm : Form
    {
        private readonly Graphics dc;
        private readonly Graphics dc_this;
        private readonly Pen penCircle = new Pen(Color.White, 1.3f);
        private Bitmap bmp = new Bitmap(600, 600);

        public MainForm()
        {
            InitializeComponent();
            dc = Graphics.FromImage(bmp);
            dc.InterpolationMode = InterpolationMode.Bilinear;
            dc.SmoothingMode = SmoothingMode.HighQuality;

            dc_this = this.CreateGraphics();
            penCircle.DashStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            penCircle.DashPattern = new float[] { 5, 10 };
            this.Location = new Point(660,240);
            dc.DrawEllipse(penCircle, 30, 30, 540, 540);
            dc.DrawRectangle(new Pen(Color.Blue), 0,0,100,100);
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

            dc.FillRectangle(Brushes.Black, 0, 0, 600, 600);
            dc.TranslateTransform(300, 300);
            dc.RotateTransform(.5f);
            dc.TranslateTransform(-300,-300);
            dc.DrawEllipse(penCircle, 30, 30, 540, 540);
            dc_this.DrawImage(bmp, 0, 0);
        }
    }
}
