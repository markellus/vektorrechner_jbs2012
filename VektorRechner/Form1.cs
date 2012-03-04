using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

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

        private double multiplikator = 0;

        bool is3D = false;
        bool isMultiplizieren = false;


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

        private void MultipliziereVektoren()
        {
            vektor3 = new double[vektor1.Length];

            for (int i = 0; i < vektor1.Length; i++)
            {
                vektor3[i] = vektor1[i] * multiplikator;
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
            else if (cboPlusMinus.SelectedIndex == 1)
            {
                SubtrahiereVektoren();
            }
            else
            {
                MultipliziereVektoren();
            }

            zeigeErgebnis();
        }

        private void werteEinlesen()
        {
            try
            {
                if (txtVektor11.Text == "" | txtVektor12.Text == "") { VektorDimensionException(); return; }

                vektor1[0] = Convert.ToDouble(txtVektor11.Text);
                vektor1[1] = Convert.ToDouble(txtVektor12.Text);
                if (txtVektor13.Text != "")
                {
                    is3D = true;
                    vektor1[2] = Convert.ToDouble(txtVektor13.Text);
                }


                if (isMultiplizieren)
                {
                    multiplikator = Convert.ToDouble(txtMultiplikator.Text);
                }
                else
                {

                    if (txtVektor21.Text == "" | txtVektor22.Text == "") { VektorDimensionException(); return; }

                    vektor2[0] = Convert.ToDouble(txtVektor21.Text);
                    vektor2[1] = Convert.ToDouble(txtVektor22.Text);
                    if (txtVektor23.Text != "")
                    {
                        is3D = true;
                        vektor2[2] = Convert.ToDouble(txtVektor23.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void zeigeErgebnis()
        {
            try
            {
                txtVektor31.Text = Convert.ToString(vektor3[0]);
                txtVektor32.Text = Convert.ToString(vektor3[1]);
                if (is3D)
                {
                    txtVektor33.Text = Convert.ToString(vektor3[2]);
                }
                btnGrafik.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void VektorDimensionException()
        {
            MessageBox.Show("Jeder Vektor muss mindestens zwei Dimensionen haben!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnGrafik_Click(object sender, EventArgs e)
        {

            if (!is3D)
            {
                
                Grafik2D grafik = new Grafik2D(Convert.ToInt32(vektor1[0]),Convert.ToInt32(vektor1[1]),Convert.ToInt32(vektor2[0]),Convert.ToInt32(vektor2[1]),Convert.ToInt32(vektor3[0]),Convert.ToInt32(vektor3[1]),Convert.ToInt32(txtStartX.Text),Convert.ToInt32(txtStartY.Text));
                grafik.Show();
            }
            else
            {
                MessageBox.Show("3D-Darstellung ist leider noch nicht möglich.");
                return;

                Process dxEngine = new Process();
                dxEngine.StartInfo.FileName = "dxEngine.exe"; //TODO: Befehlszeilenargumente
                dxEngine.Start();
            }
        }

        private void btnAnleitung_Click(object sender, EventArgs e)
        {
        }

        private void btnWeb_Click(object sender, EventArgs e)
        {
            Website web = new Website();
            web.Show();
        }

        private void btnKurs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In Kürze verfügbar. Prüfen Sie auf Updates!");
            return;

            Kurs kurs = new Kurs();
            kurs.Show();
        }

        private void cboPlusMinus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPlusMinus.SelectedIndex == 2) { MultipliziermodusAktivieren(); }
            else { MultipliziermodusDeaktivieren(); }
        }

        private void MultipliziermodusAktivieren()
        {
            txtVektor21.Visible = false;
            txtVektor22.Visible = false;
            txtVektor23.Visible = false;
            pictureBox2.Visible = false;

            txtMultiplikator.Visible = true;

            checkOrtsvektor.Checked = false;
            checkOrtsvektor.Enabled = false;

            isMultiplizieren = true;
        }

        private void MultipliziermodusDeaktivieren()
        {
            txtVektor21.Visible = true;
            txtVektor22.Visible = true;
            txtVektor23.Visible = true;
            pictureBox2.Visible = true;

            txtMultiplikator.Visible = false;

            checkOrtsvektor.Enabled = true;

            isMultiplizieren = false;
        }

        private void checkOrtsvektor_CheckedChanged(object sender, EventArgs e)
        {
        }


    }
}
