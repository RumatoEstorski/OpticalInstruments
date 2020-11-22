using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpticalInstruments
{
    public static class Extentions
    {
        public static void DrawVector(this Graphics g, Vector v, Pen pen, Point startPoint)
        {
            DrawVector(g, v, pen, new Vector(startPoint.X, startPoint.Y));
        }

        public static void DrawVector(this Graphics g, Vector v, Pen pen, Vector startVector)
        {
            Vector finish = startVector + v;
            Point s = startVector.GetPoint();
            Point f = finish.GetPoint();
            g.DrawLine(pen, s, f);
            g.DrawEllipse(pen, f.X - 2, f.Y - 2, 4, 4);
        }

        public static Point GetPoint(this Vector v)
        {
            return new Point((int)v.X, (int)v.Y);
        }

       public static Vector rV(this Control c)
       {
           return new Vector(c.Left + c.Width / 2, c.Top + c.Height / 2);
       }
    }
}
