using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VektorRechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double[] AddiereVektoren(double[] vektor1, double[] vektor2)
        {
            if (vektor1.Length != vektor2.Length)
            {
                MessageBox.Show("Beide Vektoren müssen dieselbe Anzahl an Dimensionen haben!");
                return null;
            }

            double[] ergebnis = new double[vektor1.Length];

            for (int i = 0; i > vektor1.Length; i++)
            {
                ergebnis[i] = vektor1[i] + vektor2[i];
            }

            return ergebnis;
        }

        private double[] SubtrahiereVektoren(double[] vektor1, double[] vektor2)
        {
            if (vektor1.Length != vektor2.Length)
            {
                MessageBox.Show("Beide Vektoren müssen dieselbe Anzahl an Dimensionen haben!");
                return null;
            }

            double[] ergebnis = new double[vektor1.Length];

            for (int i = 0; i > vektor1.Length; i++)
            {
                ergebnis[i] = vektor1[i] - vektor2[i];
            }

            return ergebnis;
        }
    }
}
