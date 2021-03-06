﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace VektorRechner
{
    class clsLinie
    {
        public clsLinie(int x1, int y1, int x2, int y2)
        {
            init(x1, y1, x2, y2, Pens.Black);
        }

        public clsLinie(int x1, int y1, int x2, int y2, Pen farbe)
        {
            init(x1, y1, x2, y2, farbe);
        }
        public void init(int x1, int y1, int x2, int y2, Pen farbe)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.farbe = farbe;
        }

        public int x1 { get; set; }
        public int y1 { get; set; }
        public int x2 { get; set; }
        public int y2 { get; set; }
        public Pen farbe { get; set; }

        public void zeichne(Graphics graphics)
        {
            graphics.DrawLine(farbe, x1, y1, x2, y2);
        }

    }
}
