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

        private double[] vektor1 = new double[3];
        private double[] vektor2 = new double[3];
        private double[] vektor3 = new double[3];

        private void AddiereVektoren()
        {
            if (vektor1.Length != vektor2.Length)
            {
                MessageBox.Show("Beide Vektoren müssen dieselbe Anzahl an Dimensionen haben!");
                return;
            }

            vektor3 = new double[vektor1.Length];

            for (int i = 0; i < vektor1.Length; i++)
            {
                vektor3[i] = vektor1[i] + vektor2[i];
            }
        }

        private void SubtrahiereVektoren()
        {
            if (vektor1.Length != vektor2.Length)
            {
                MessageBox.Show("Beide Vektoren müssen dieselbe Anzahl an Dimensionen haben!");
                return;
            }

            vektor3 = new double[vektor1.Length];

            for (int i = 0; i < vektor1.Length; i++)
            {
                vektor3[i] = vektor1[i] - vektor2[i];
            }          
        }

        private void btnÜber_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.Show();
        }

        private void btnAusrechnen_Click(object sender, EventArgs e)
        {
            werteEinlesen();

            if (cboPlusMinus.SelectedIndex == 0)
            {
                AddiereVektoren();
            }
            else
            {
                SubtrahiereVektoren();
            }

            zeigeErgebnis();
        }

        private void werteEinlesen()
        {
            vektor1[0] = Convert.ToDouble(txtVektor11.Text);
            vektor1[1] = Convert.ToDouble(txtVektor12.Text);
            vektor1[2] = Convert.ToDouble(txtVektor13.Text);

            vektor2[0] = Convert.ToDouble(txtVektor21.Text);
            vektor2[1] = Convert.ToDouble(txtVektor22.Text);
            vektor2[2] = Convert.ToDouble(txtVektor23.Text);
        }

        private void zeigeErgebnis()
        {
            txtVektor31.Text = Convert.ToString(vektor3[0]);
            txtVektor32.Text = Convert.ToString(vektor3[1]);
            txtVektor33.Text = Convert.ToString(vektor3[2]);
        }
    }
}
