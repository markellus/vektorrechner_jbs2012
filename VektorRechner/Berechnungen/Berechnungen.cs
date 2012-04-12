using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VektorRechner.Berechnungen
{
    public static class Berechnungen
    {   //2 Vektoren mit beliebig vielen Dimensionen werden addiert.
        public static double[] AddiereVektoren(double[] vektor1, double[] vektor2)
        {
            if (vektor1.Length != vektor2.Length)
            {
                MessageBox.Show("Beide Vektoren müssen dieselbe Anzahl an Dimensionen haben!");
                return null;
            }

            double[] vektor3 = new double[vektor1.Length];
            //Jede Dimension einzeln addieren
            for (int i = 0; i < vektor1.Length; i++)
            {
                vektor3[i] = vektor1[i] + vektor2[i];
            }

            return vektor3;
        }
        //2 Vektoren mit beliebig vielen Dimensionen werden subtrahiert.
        public static double[] SubtrahiereVektoren(double[] vektor1, double[] vektor2)
        {
            if (vektor1.Length != vektor2.Length)
            {
                MessageBox.Show("Beide Vektoren müssen dieselbe Anzahl an Dimensionen haben!");
                return null;
            }

            double[] vektor3 = new double[vektor1.Length];

            for (int i = 0; i < vektor1.Length; i++)
            {
                vektor3[i] = vektor1[i] - vektor2[i];
            }

            return vektor3;
        }
        //1 Vektor wird mit einer natürlichen Zahl multipliziert.
        public static double[] MultipliziereVektoren(double[] vektor1, double[] vektor2, double multiplikator)
        {
            double[] vektor3 = new double[vektor1.Length];

            for (int i = 0; i < vektor1.Length; i++)
            {
                vektor3[i] = vektor1[i] * multiplikator;
            }

            return vektor3;
        }
    }
}
