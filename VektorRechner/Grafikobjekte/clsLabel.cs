using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace VektorRechner
{
    class clsLabel
    {
        public clsLabel(int x, int y, Font schrift,Brush farbe, string text)
        {
            this.x = x;
            this.y = y;
            Schrift = schrift;
            this.farbe = farbe;
            this.text = text;
        }

        public int x { get; set; }
        public int y { get; set; }
        public Font Schrift { get; set; }
        public Brush farbe { get; set; }
        public string text { get; set; }

        public void zeichne(Graphics graphics)
        {
            graphics.DrawString(text, Schrift, farbe, x, y, StringFormat.GenericDefault);
        }
    }
}
