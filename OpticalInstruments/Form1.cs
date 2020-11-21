using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpticalInstruments
{
    public partial class Form1 : Form
    {
        int f, d, F;
        Graphics g;
        Vector v;
        Point pStart, pFinish, pointSart;
        private object currObject = null;
        public Form1()
        {
            InitializeComponent();
            this.MouseMove += new MouseEventHandler(mouseEvent);
            this.MouseClick += new MouseEventHandler(mouseClick);
            //d = (F*f)/(f-F);
            g = CreateGraphics();
            v = new Vector(pb1.Location.X + pb1.Width / 2, pb1.Location.Y + pb1.Height / 2);
           // pb3.Location.X=new Point

            d = pb3.Location.X - (pb2.Location.X + pb2.Width);
            f = pb1.Location.X - (pb3.Location.X + pb3.Width);
            pStart = new Point(0, pb3.Location.Y + pb3.Height / 2);
            pFinish = new Point(this.Size.Width, pb3.Location.Y + pb3.Height / 2);
            pointSart = new Point(pb2.Location.X + pb2.Width/2, pb2.Location.Y + pb2.Height/2);
        }//pb2.Location.X + f + d + pb1.Width + pb2.Width + pb3.Width

        private void button1_Click(object sender, EventArgs e)
        {
            g.DrawVector(v, Pens.Red, pointSart);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            F = Convert.ToInt32(Focus.Text);
            g.DrawLine(Pens.Black, pStart, pFinish);
            g.DrawLine(Pens.Black, pb3.Location.X + pb3.Width + F * 45, pb3.Location.Y + pb3.Height / 2 - 20, pb3.Location.X + pb3.Width + F * 45, pb3.Location.Y + pb3.Height / 2 + 20);
            g.DrawLine(Pens.Black, pb3.Location.X - F * 45, pb3.Location.Y + pb3.Height / 2 - 20, pb3.Location.X - F * 45, pb3.Location.Y + pb3.Height / 2 + 20);
            g.DrawLine(Pens.Black, pb3.Location.X + pb3.Width + F * 45 * 2, pb3.Location.Y + pb3.Height / 2 - 20, pb3.Location.X + pb3.Width + F * 45 * 2, pb3.Location.Y + pb3.Height / 2 + 20);
            g.DrawLine(Pens.Black, pb3.Location.X - F * 45 * 2, pb3.Location.Y + pb3.Height / 2 - 20, pb3.Location.X - F * 45 * 2, pb3.Location.Y + pb3.Height / 2 + 20);
            
        }

        private void mouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button.ToString() == "Right")
                currObject = null;
        }

        private void mouseEvent(object sender, MouseEventArgs e)
        {
            // pb2.Location = new Point(Cursor.Position.X-100, Cursor.Position.Y-100);
            if (currObject != null) 
            currObject.GetType().GetProperty("Location").SetValue(currObject, new Point(Cursor.Position.X-50, Cursor.Position.Y-50 ));
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            currObject = sender;
        }

    }
}
