﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using VektorRechner.Berechnungen;

namespace VektorRechner
{
    class clsVektor
    {
        public int x1 { get; set; }
        public int x2 { get; set; }
        public int xStart { get; set; }
        public int yStart { get; set; }
        public Pen farbe { get; set; }

        private int x1InPixel;
        private int x2InPixel;
        private int xStartInPixel;
        private int yStartInPixel;

        public clsVektor(int x1, int x2, int xStartPunkt, int yStartPunkt, Pen farbe)
        {
            this.x1 = x1;
            this.x2 = x2;

            xStart = xStartPunkt;
            yStart = yStartPunkt;
            //Den Stift transparent machen
            Pen tempfarbe = new Pen(Color.FromArgb(128,farbe.Color));
            //Der Pfeil am Ende des Vektors
            Point[] pts = { new Point(-3, 0), new Point(3, 0), new Point(0, 4), new Point(-3, 0) };
            GraphicsPath path = new GraphicsPath();
            path.AddLines(pts);
            GraphicsPath fill = new GraphicsPath();
            fill.FillMode = FillMode.Alternate;
            CustomLineCap customLineCap = new CustomLineCap(fill, path);
            tempfarbe.CustomEndCap = customLineCap;
            //Den fertig konfigurierten Stift speichern
            this.farbe = tempfarbe;
            //Die Werte in Bildschirmpixel umrechnen
            ÜbertrageAufPixelEbene();
        }

        private void ÜbertrageAufPixelEbene()
        {
            x1InPixel = KoordinatenMatrix.berechneStrecke(x1);
            x2InPixel = KoordinatenMatrix.berechneStrecke(x2);
            xStartInPixel = KoordinatenMatrix.berechnePixelX(xStart);
            yStartInPixel = KoordinatenMatrix.berechnePixelY(yStart);
        }

        public void zeichne(Graphics graphics)
        {
            int endPunktX = xStartInPixel + x1InPixel;
            int endPunktY = yStartInPixel - x2InPixel ;
            graphics.DrawLine(farbe, xStartInPixel, yStartInPixel, endPunktX, endPunktY);
        }
    }
}
