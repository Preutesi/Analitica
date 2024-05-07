using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analitica3R
{
    public partial class DistanzaTraDuePunti : Form
    {
        public DistanzaTraDuePunti()
        {
            InitializeComponent();
        }

        //Variabili globali
        double d = 0;

        private void xMin_ValueChanged(object sender, EventArgs e)
        {
            xMax.Minimum = xMin.Value + 1;
        }

        private void xMax_ValueChanged(object sender, EventArgs e)
        {
            xMin.Maximum = xMax.Value - 1;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            yMax.Minimum = yMin.Value + 1;
        }

        private void yMax_ValueChanged(object sender, EventArgs e)
        {
            yMin.Maximum = yMax.Value - 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            d = Math.Sqrt(Math.Pow((double)(x1.Value - x2.Value), 2) + Math.Pow((double)(y1.Value - y2.Value), 2));
            output.Text = "Distanza\n" + Math.Round(d, 3);
            output.Visible = true;
        }

        private void x1_ValueChanged(object sender, EventArgs e)
        {
            output.Visible = false;
        }
    }
}
