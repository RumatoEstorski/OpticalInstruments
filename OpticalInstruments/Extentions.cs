using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpticalInstruments
{
    public static class Extentions
    {
        public static void DrawVector(this Graphics g, Vector v, Pen pen, Point startPoint)
        {
            Point finishPoint = new Point(startPoint.X + (int)v.X, startPoint.Y + (int)v.Y);
            g.DrawLine(pen, startPoint, finishPoint);
            g.DrawEllipse(pen, finishPoint.X-2, finishPoint.Y-2, 4, 4);
        }
    }
}
