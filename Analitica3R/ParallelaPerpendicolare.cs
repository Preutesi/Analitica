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
    public partial class ParallelaPerpendicolare : Form
    {
        public ParallelaPerpendicolare()
        {
            InitializeComponent();
        }
        //variabili globali
        decimal aParallela = 0;
        decimal bParallela = 0;
        decimal cParallela = 0;
        decimal aPerpendicolare = 0;
        decimal bPerpendicolare = 0;
        decimal cPerpendicolare = 0;
        bool calcolata = false;

        private void a_ValueChanged(object sender, EventArgs e)
        {
            labelErrore.Visible = a.Value == 0 && b.Value == 0;
            button1.Enabled = !labelErrore.Visible;
            outputParallela.Visible = false;
            outputPerpendicolare.Visible = false;
            calcolata = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calcolata = true;
            outputParallela.Visible = false;
            outputPerpendicolare.Visible = false;
            string retta = "";
            if (parallelaCheck.Checked)
            {
                aParallela = a.Value;
                bParallela = b.Value;
                cParallela = -a.Value * x0.Value - b.Value * y0.Value;
                if (aParallela != 0)
                    retta = aParallela.ToString() + "*x";
                if (bParallela !=0)
                {
                    if (bParallela > 0 && retta.Length > 0)
                        retta += "+";
                    retta += bParallela.ToString() + "*y";
                }
                if (cParallela != 0)
                {
                    if (cParallela > 0)
                        retta += "+";
                    retta += cParallela.ToString();
                }
                retta += "=0";
                outputParallela.Text = "Retta parallela\n"+ retta;
                outputParallela.Visible = true;
            }
            retta = "";
            if (perpendicolareCheck.Checked)
            {
                aPerpendicolare = b.Value;
                bPerpendicolare = -a.Value;
                cPerpendicolare = a.Value * y0.Value - b.Value * x0.Value;
                if (aPerpendicolare != 0)
                    retta = aPerpendicolare.ToString() + "*x";
                if (bPerpendicolare != 0)
                {
                    if (bPerpendicolare > 0 && retta.Length > 0)
                        retta += "+";
                    retta += bPerpendicolare.ToString() + "*y";
                }
                if (cPerpendicolare != 0)
                {
                    if (cPerpendicolare > 0)
                        retta += "+";
                    retta += cPerpendicolare.ToString();
                }
                retta += "=0";
                outputPerpendicolare.Text = "Retta perpendicolare\n" + retta;
                outputPerpendicolare.Visible = true;
            }
        }

        private void parallelaCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (calcolata)
                button1.PerformClick();
        }
    }
}
