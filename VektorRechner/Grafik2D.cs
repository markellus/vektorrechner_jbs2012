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
    public partial class Grafik2D : Form
    {
        clsKoordinatensystem koordinatensystem;


        public Grafik2D(int v1x1, int v1x2, int v2x1, int v2x2, int v3x1, int v3x2, int xStart, int yStart)
        {
            koordinatensystem = new clsKoordinatensystem(1,v1x1,v1x2,v2x1,v2x2,v3x1,v3x2,xStart,yStart);
            InitializeComponent();
        }

        private void Grafik2D_Paint(object sender, PaintEventArgs e)
        {
            koordinatensystem.zeichne(e.Graphics);
        }
    }
}
