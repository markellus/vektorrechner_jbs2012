using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace VektorRechner
{
    class clsLinieBeschriftet
    {
        public void init(int x1, int y1, int x2, int y2, Pen farbe, string beschriftung)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.farbe = farbe;
            this.beschriftung = beschriftung;
        }

        public int x1 { get; set; }
        public int y1 { get; set; }
        public int x2 { get; set; }
        public int y2 { get; set; }
        public Pen farbe { get; set; }
        public string beschriftung { get; set; }

        public void zeichne(Graphics graphics)
        {
            graphics.DrawLine(farbe, x1, y1, x2, y2);
        }
    }
}
