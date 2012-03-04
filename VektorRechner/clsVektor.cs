using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace VektorRechner
{
    class clsVektor
    {
        public clsVektor(int x1, int x2, int xStartPunkt, int yStartPunkt, Pen farbe)
        {
            this.x1 = x1;
            this.x2 = x2;

            xStart = xStartPunkt;
            yStart = yStartPunkt;

            this.farbe = farbe;
        }

        public int x1 { get; set; }
        public int x2 { get; set; }
        public int xStart { get; set; }
        public int yStart { get; set; }
        public Pen farbe { get; set; }

        public void zeichne(Graphics graphics)
        {
            graphics.DrawLine(farbe, xStart, yStart, xStart + x1, yStart - x2);
        }
    }
}
