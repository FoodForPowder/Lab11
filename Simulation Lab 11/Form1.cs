using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulation_Lab_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double mean, var, d, av = 0, v = 0, eA, eV;
        int M;
        List<int> Stat = new List<int>();
        List<double> xi = new List<double>();
        Random rand = new Random();

        private void btStart_Click(object sender, EventArgs e)
        {
            double chi = 0;
            mean = (double)ed1.Value;
            var = (double)ed1.Value;
            M = (int)edN.Value;

            for (int i = 0; i < M; i++)
            {
                d = 0;
                for (int j = 0; j < 12; j++)
                {
                    d += rand.NextDouble();
                }
                d -= 6;
                xi.Add(var * d + mean);
            }

            double min = double.MaxValue, max = double.MinValue;
            for (int i = 0; i < M; i++)
            {
                if (xi[i] < min) min = xi[i];
                else if (xi[i] > max) max = xi[i];
            }
            max = Math.Ceiling(max);
            min = Math.Floor(min);

            int N = (int)(max + Math.Abs(min));
            for (int i = 0; i < N; i++)
            {
                Stat.Add(0);
            }

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (xi[i] > (j + min) && xi[i] <= (j + min + 1))
                    {
                        Stat[j]++;
                    }
                }
            }

            for (int i = 0; i < M; i++)
            {
                av += xi[i];
                v += xi[i] * xi[i];
            }
            av /= M;
            v /= M;
            v -= -av * av;

            eA = Math.Abs(av - mean)/mean;
            eV = Math.Abs(v - var)/var;

            double[] p = new double[N];
            for (int i = 0; i < N; i++)
            {
                p[i] = Math.Exp(-Math.Pow(((i + min + i + min + 1) / 2) - mean, 2) / (2 * var)) / Math.Sqrt(var * Math.PI * 2);
            }

            for (int i = 0; i < N; i++)
            {
                chi += (Stat[i] * Stat[i]) / (p[i] * M);
            }
            chi = chi - M;

            tbAv.Text = Convert.ToString(Math.Round(av, 2));
            tbVar.Text = Convert.ToString(Math.Round(v, 2));
            tbEAr.Text = Convert.ToString(Math.Round(eA, 1)) + "%";
            tbEVar.Text = Convert.ToString(Math.Round(eV, 1)) + "%";

            for (int i = 0; i < N; i++) { chart1.Series[0].Points.AddXY("(" + (i + min) + "-" + (i + min + 1) + "]", Stat[i]); }
            tbv.Text = "Вывод: чем больше размер выборки, тем точнее результаты.  ";
        }

    }
}
