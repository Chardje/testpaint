using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testpaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ResizeRedraw = true;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            int w = ClientRectangle.Width/2 ;
            int h = ClientRectangle.Height/2 ;
            int min = Math.Min(w,h);
            e.Graphics.FillEllipse(
                brush: Brushes.Red,
                x: ClientRectangle.X + w / 2,
                y: ClientRectangle.Y + h / 2,
                width: min,
                height: min);
            e.Graphics.DrawString(Convert.ToString(DateTime.Now), Font, Brushes.Blue, w, h);
            
        }

        private void timerSeconds_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            Debug.WriteLine($"{now} {now.Hour} {now.Minute} {now.Second}");
            Invalidate();
        }
    }
}
