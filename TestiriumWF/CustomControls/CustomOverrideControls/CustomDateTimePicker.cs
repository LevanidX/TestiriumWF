using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace TestiriumWF.CustomControls.CustomOverrideControls
{
    public partial class CustomDateTimePicker : UserControl
    {
        private Bitmap bmp = null;
        public CustomDateTimePicker()
        {
            InitializeComponent();

            bmp = new Bitmap(5, 5);
            bmp.SetPixel(2, 2, Color.Red); //Placeholder, Load the bitmap here
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == 0xf) //WM_PAINT message
            {
                Graphics g = Graphics.FromHwnd(m.HWnd);
                g.DrawImage(bmp, ClientRectangle.Width - 8, 3);
                g.Dispose();
            }
        }
    }
}
