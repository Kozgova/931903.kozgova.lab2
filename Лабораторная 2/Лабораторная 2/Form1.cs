using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        const double k = 0.05;

        Random random = new Random();

        double rateD, rateE;
        int days;
        bool button = false;

        private void btPredict_Click(object sender, EventArgs e)
        {
            if (button)
            {
                btPredict.Text = "Start";
                timer1.Stop();
            }
            else
            {
                rateD = (double)edRateD.Value;
                rateE = (double)edRateE.Value;
                days = (int)chart1.ChartAreas[0].AxisX.Minimum;

                chart1.Series[0].Points.Clear();
                chart1.Series[0].Points.AddXY(0, rateD);

                chart1.Series[1].Points.Clear();
                chart1.Series[1].Points.AddXY(0, rateE);

                btPredict.Text = "Stop";
                timer1.Start();
            }

            button = !button;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rateD = rateD * (1 + k * (random.NextDouble() - 0.5));
            chart1.Series[0].Points.AddXY(days, rateD);

            rateE = rateE * (1 + k * (random.NextDouble() - 0.5));
            chart1.Series[1].Points.AddXY(days, rateE);
        }
    }
}