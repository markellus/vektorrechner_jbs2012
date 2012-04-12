using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VektorRechner.Berechnungen
{
    public static class KoordinatenMatrix
    {
        public static int skalierung = 1;

        public static int berechnePixelX(int value)
        {
            return (value * 20 / skalierung + 305);
        }

        public static int berechnePixelY(int value)
        {
            return (305 - value * 20 / skalierung);
        }

        public static int berechneStrecke(int value)
        {
            return (value * 20 / skalierung);
        }

        public static int berechneBeschriftung(int value)
        {
            return value * skalierung;
        }
    }
}