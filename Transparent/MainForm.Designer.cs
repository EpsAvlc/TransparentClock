namespace Transparent
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelHourAndMinute = new System.Windows.Forms.Label();
            this.labelSecond = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelHourAndMinute
            // 
            this.labelHourAndMinute.AutoSize = true;
            this.labelHourAndMinute.BackColor = System.Drawing.Color.Black;
            this.labelHourAndMinute.Font = new System.Drawing.Font("Letter Gothic Std", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHourAndMinute.ForeColor = System.Drawing.Color.White;
            this.labelHourAndMinute.Location = new System.Drawing.Point(87, 219);
            this.labelHourAndMinute.Name = "labelHourAndMinute";
            this.labelHourAndMinute.Size = new System.Drawing.Size(340, 117);
            this.labelHourAndMinute.TabIndex = 0;
            this.labelHourAndMinute.Text = "00:00";
            // 
            // labelSecond
            // 
            this.labelSecond.AutoSize = true;
            this.labelSecond.BackColor = System.Drawing.Color.Black;
            this.labelSecond.Font = new System.Drawing.Font("Letter Gothic Std", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSecond.ForeColor = System.Drawing.Color.White;
            this.labelSecond.Location = new System.Drawing.Point(433, 279);
            this.labelSecond.Name = "labelSecond";
            this.labelSecond.Size = new System.Drawing.Size(109, 78);
            this.labelSecond.TabIndex = 1;
            this.labelSecond.Text = "00";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.labelSecond);
            this.Controls.Add(this.labelHourAndMinute);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHourAndMinute;
        private System.Windows.Forms.Label labelSecond;
        private System.Windows.Forms.Timer timer;
    }
}

