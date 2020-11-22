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

        public static Vector rIntersect(this Vector v2, Vector v1)
        {
            double b1 = v1.Y;
            double b2 = 0;
            double k1 = b1 / v1.X;
            double k2 = v2.Y / v2.X;
            double x = (b2 - b1) / (k1 - k2);
            double y = k2 * x + b2;
            return - (new Vector(x, y) - v2);
        }
    }
}
