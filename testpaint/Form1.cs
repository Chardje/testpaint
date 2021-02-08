using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            int h = ClientRectangle.Height;
            int min = Math.Min(w, h);
            e.Graphics.FillEllipse(
                brush: Brushes.Red,
                x: (ClientRectangle.Width- min)/2,
                y: (ClientRectangle.Height- min)/2,
                width: min,
                height: min) ;
            
            int x = 12;
            e.Graphics.FillEllipse(
                brush: Brushes.Blue,
                x: (float)(ClientRectangle.Width -( min - Math.Pow(min, 1 / x))),
                y: (float)(ClientRectangle.Height  -( min - Math.Pow(min,1 / x))),
                width: (float) Math.Pow(min,1/x),
                height: (float)Math.Pow(min,1/x));
            
            for (int i=0;i<x;i++)
            {

            }
        }
       
    }
}
