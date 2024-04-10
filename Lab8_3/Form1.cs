using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        private void startButton_Click(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
            chart1.Series[0].Points.Clear();

            double[] prob = new double[5] { (double)prob1Num.Value, (double)prob2Num.Value, (double)prob3Num.Value, 
                                            (double)prob4Num.Value, (double)prob5Num.Value };

            double sum = 0;
            for (int i = 0; i < 5; i++)
                sum += prob[i];

            if (sum != 1) errorLabel.Visible = true;

            int N = (int)nNum.Value;
            int[] statistics = new int[5] { 0, 0, 0, 0, 0 };

            for (int i = 0; i < N; i++)
            {
                double a = rnd.NextDouble();
                for (int j = 0; j < 5; j++)
                {
                    a -= prob[j];
                    if (a <= 0)
                    {
                        statistics[j]++;
                        break;
                    }
                }
            }

            double[] frequency = new double[5];

            for (int i = 0; i < 5; i++)
            {
                frequency[i] = (double)statistics[i] / N;
                chart1.Series[0].Points.Add(frequency[i]);
            }
            //chart1.Series[0].Points.Add(frequency);
        }
    }
}
