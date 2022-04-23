using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MathModel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            double x = 1;
            InitializeComponent();
            int[] tetta = new int[] { 0, 3, 6, 10, 15, 24 };
            double[] C = new double[] { 0.5, 116, 0.4, 0, 5, 21 };
            chart1.Series[0].Name = "θ = 0";
            chart1.Series[0].ChartType = SeriesChartType.Spline;
            for (int i = 0; i < 6; i++)
            {
                if (i > 0)
                {
                    chart1.Series.Add("θ = " + tetta[i]);
                    chart1.Series[i].ChartType = SeriesChartType.Spline;
                }
                for (int j = 0; j < 16; j++)
                {
                    
                    chart1.Series[i].Points.AddXY(j, Funk(tetta[i], C, j, x));
                    if (Funk(tetta[i], C, j, x) < 0)
                    {
                        break;
                    }
                }
            }
        }
        private static double Funk(int tetta, double[] C , double lambda, double x )
        {
            double oneDevBeta = OneDevideBetta(lambda, tetta);
            return C[0] * (C[1] * oneDevBeta - C[2] * 1 / oneDevBeta * tetta - C[3] * Math.Pow(tetta, x) - C[4]) * Math.Pow(Math.E, (-C[5] * oneDevBeta));
        }
        private static double OneDevideBetta(double lambda, double tetta)
        {
            return 1 / (lambda + 0.08 * tetta) - 0.035 / (1 + tetta * tetta * tetta);
        }
    }
}
