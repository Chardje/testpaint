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
            int w = ClientRectangle.Width ;
            int h = ClientRectangle.Height ;
            int min = Math.Min(w,h);
            e.Graphics.FillEllipse(
                brush: Brushes.Red,
                x: (ClientRectangle.Width - min) / 2,
                y: (ClientRectangle.Height - min) / 2,
                width: min,
                height: min);
            e.Graphics.DrawString(Convert.ToString(DateTime.Now), Font, Brushes.Blue, w/2, h/2);
            Pen skyBluePen = new Pen(Brushes.DeepSkyBlue);
            skyBluePen.Width = 2.0F;
            skyBluePen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
            for (int i=0;i<60;i++)
            {
                float p1w = (float)((w / 2) + (Math.Cos(6 * i) * (min / 2-min/20)));
                float p1h = (float)((h / 2) + (Math.Sin(6 * i) * (min / 2 - min / 20)));
                float p2w = (float)((w/2)+(Math.Cos(6 * i) * min/2));
                float p2h = (float)((h/2)+(Math.Sin(6 * i) * min/2));

                e.Graphics.DrawLine(skyBluePen,p1w,p1h,p2w,p2h);
            }
            


        }

        private void timerSeconds_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            Debug.WriteLine($"{now} {now.Hour} {now.Minute} {now.Second}");
            Invalidate();
        }
    }
}
