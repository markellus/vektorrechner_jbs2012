using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using VektorRechner.Berechnungen;

namespace VektorRechner
{
    class clsKoordinatensystem
    {

        private List<clsLinie> linienBeschriftungXY = new List<clsLinie>();
        clsLinie linieX;
        clsLinie linieY;

        private List<clsLabel> linienBeschriftungLabel = new List<clsLabel>();

        private List<clsVektor> vektoren = new List<clsVektor>();


        public clsKoordinatensystem(int Skalierung, int v1x1, int v1x2, int v2x1, int v2x2, int v3x1, int v3x2, int xStart, int yStart, int rechenart)
        {
            //Skalierung einstellen
            skalierung = Skalierung;
            KoordinatenMatrix.skalierung = skalierung;
            ErstelleAchsen();
            ErstelleAchsenLinien();
            //Die Beschriftungen deklarieren
            for (int i = 0; i < 30; i++)
            {
                if ((i - 15) != 0 && (i - 15) != -1)
                {
                    linienBeschriftungLabel.Add(new clsLabel(i * 20, 315, new Font("Arial", 8), Brushes.Black, Convert.ToString((i - 15) * skalierung)));
                }
            }

            int beschriftung = 15;

            for (int i = 0; i < 30; i++)
            {
                if (i - 15 != 0)
                {
                    linienBeschriftungLabel.Add(new clsLabel(280, i * 20, new Font("Arial", 8), Brushes.Black, Convert.ToString(beschriftung * skalierung)));
                }
                beschriftung -= 1;
            }
            //Die Vektoren deklarieren
            int StartPunktX = KoordinatenMatrix.berechnePixelX(xStart);
            int StartPunktY = KoordinatenMatrix.berechnePixelX(yStart);
            if (rechenart == 0)
            {
                vektoren.Add(new clsVektor(KoordinatenMatrix.berechneStrecke(v1x1), KoordinatenMatrix.berechneStrecke(v1x2), StartPunktX, StartPunktY, Pens.Red));
                vektoren.Add(new clsVektor(KoordinatenMatrix.berechneStrecke(v2x1), KoordinatenMatrix.berechneStrecke(v2x2), KoordinatenMatrix.berechnePixelX(v1x1), KoordinatenMatrix.berechnePixelY(v1x2), Pens.Blue));
                vektoren.Add(new clsVektor(KoordinatenMatrix.berechneStrecke(v3x1), KoordinatenMatrix.berechneStrecke(v3x2), StartPunktX, StartPunktY, Pens.YellowGreen));
            }

            else if (rechenart == 1)
            {
                vektoren.Add(new clsVektor(KoordinatenMatrix.berechneStrecke(v1x1), KoordinatenMatrix.berechneStrecke(v1x2), StartPunktX, StartPunktY, Pens.Red));
                vektoren.Add(new clsVektor(KoordinatenMatrix.berechneStrecke(v2x1), KoordinatenMatrix.berechneStrecke(v2x2), StartPunktX, StartPunktY, Pens.Blue));
                vektoren.Add(new clsVektor(KoordinatenMatrix.berechneStrecke(v3x1), KoordinatenMatrix.berechneStrecke(v3x2), StartPunktX, StartPunktY, Pens.YellowGreen));
            }
            else
            {
                vektoren.Add(new clsVektor(KoordinatenMatrix.berechneStrecke(v3x1), KoordinatenMatrix.berechneStrecke(v3x2), StartPunktX, StartPunktY, Pens.YellowGreen));
                vektoren.Add(new clsVektor(KoordinatenMatrix.berechneStrecke(v1x1), KoordinatenMatrix.berechneStrecke(v1x2), StartPunktX, StartPunktY, Pens.Red));
            }

        }

        private void ErstelleAchsen()
        {
            //Die X- und Y- Linien deklarieren
            linieX = new clsLinie(5, 305, 605, 305);
            linieY = new clsLinie(305, 5, 305, 605);
        }

        private void ErstelleAchsenLinien()
        {
            //Die Querlinien deklarieren
            for (int i = 0; i < 30; i++)
            {
                linienBeschriftungXY.Add(new clsLinie(i * 20 + 5, 300, i * 20 + 5, 310));
            }

            for (int i = 0; i < 30; i++)
            {
                linienBeschriftungXY.Add(new clsLinie(300, i * 20 + 5, 310, i * 20 + 5));
            }
        }

        public int skalierung { get; set; }
        //Zeichnet alle Linien, label und Vektoren
        public void zeichne(Graphics graphics)
        {
            linieX.zeichne(graphics);
            linieY.zeichne(graphics);

            foreach (clsLinie linie in linienBeschriftungXY)
            {
                linie.zeichne(graphics);
            }

            foreach (clsLabel label in linienBeschriftungLabel)
            {
                label.zeichne(graphics);
            }

            foreach (clsVektor vektor in vektoren)
            {
                vektor.zeichne(graphics);
            }
        }
    }
}
