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

            d = pbLense.Location.X - (pb2.Location.X + pb2.Width);
            f = pb1.Location.X - (pbLense.Location.X + pbLense.Width);
            pStart = new Point(0, pbLense.Location.Y + pbLense.Height / 2);
            pFinish = new Point(this.Size.Width, pbLense.Location.Y + pbLense.Height / 2);
            pointSart = new Point(pb2.Location.X + pb2.Width/2, pb2.Location.Y + pb2.Height/2);
        }//pb2.Location.X + f + d + pb1.Width + pb2.Width + pb3.Width

        private void button1_Click(object sender, EventArgs e)
        {
            g.DrawVector(v, Pens.Red, pointSart);

        }

       // private void button6_Click(object sender, EventArgs e)
       // {
            //pbLense.Image = ((Image img = new Image"lince2"))); 
       // }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.Clear(BackColor);
            F = Focus.Value*100;
            g.DrawLine(Pens.Black, pStart, pFinish);
            g.DrawLine(Pens.Black, pbLense.Location.X + pbLense.Width + F * 45, pbLense.Location.Y + pbLense.Height / 2 - 20, pbLense.Location.X + pbLense.Width + F * 45, pbLense.Location.Y + pbLense.Height / 2 + 20);
            g.DrawLine(Pens.Black, pbLense.Location.X - F * 45, pbLense.Location.Y + pbLense.Height / 2 - 20, pbLense.Location.X - F * 45, pbLense.Location.Y + pbLense.Height / 2 + 20);
            g.DrawLine(Pens.Black, pbLense.Location.X + pbLense.Width + F * 45 * 2, pbLense.Location.Y + pbLense.Height / 2 - 20, pbLense.Location.X + pbLense.Width + F * 45 * 2, pbLense.Location.Y + pbLense.Height / 2 + 20);
            g.DrawLine(Pens.Black, pbLense.Location.X - F * 45 * 2, pbLense.Location.Y + pbLense.Height / 2 - 20, pbLense.Location.X - F * 45 * 2, pbLense.Location.Y + pbLense.Height / 2 + 20);

            Pen pen = Pens.Red;
            Vector focus = new Vector(1, 0)*F;
            Vector start = pbLense.rV() - 2*focus;
            g.DrawVector(focus * 4, Pens.Black, start);

           

            Vector pad = (pbLense.rV()- pb2.rV()).Projection(focus);
            g.DrawVector(pad, pen, pb2.rV());
            Vector lense = (pb2.rV() + pad) - pbLense.rV();

            Vector toFocus = focus - lense;

            Vector toLense = pbLense.rV() - pb2.rV();

            Vector toPb2 = toFocus.rIntersect(toLense);
            Vector lTopb2 = focus + toPb2;
            g.DrawVector(toPb2,Pens.Yellow,pbLense.rV() + focus);
            g.DrawVector(lTopb2, Pens.Blue, pbLense.rV());
        
        }



       

        private void mouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button.ToString() == "Right")
            {
                currObject = null;
                return;
            }
            currObject = sender;
        }

        private void mouseEvent(object sender, MouseEventArgs e)
        {
            // pb2.Location = new Point(Cursor.Position.X-100, Cursor.Position.Y-100);
            if (currObject != null) 
            currObject.GetType().GetProperty("Location").SetValue(currObject, new Point(Cursor.Position.X-50 - Left, Cursor.Position.Y-50 - Top));//semiwidth/height
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            
        }

    }
}
