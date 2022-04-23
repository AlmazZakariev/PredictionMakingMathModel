using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization;
using System.Windows.Forms.DataVisualization.Charting;
using MathModelLib;

namespace MathModelForms
{    
    public partial class Form1 : Form
    {
        bool[] btnClickedShow = new bool[3];
        Data data = new Data("Data.txt");
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(40, 40, 40);
            ShowGraph(data);         
            label1.ForeColor = Color.FromArgb(219,215,210);
            label2.ForeColor = Color.FromArgb(219, 215, 210);
            label3.ForeColor = Color.FromArgb(219, 215, 210);
            label1.Text += ("   " +data.RegressionEq());
            //label2.Text += (" 0,748362361");
            label2.Text += " " + data.PirsonKoef.ToString();
            label3.Text += " " + Math.Pow(data.PirsonKoef,2).ToString();
        }
        private void ShowGraph(Data data)
        {
            chart1.Series[0].ChartType = SeriesChartType.Spline;
            chart1.Series[0].LegendText = "Уравнение регрессии";
            chart1.Series[0].Color = Color.FromArgb(56, 85, 224);            
            chart1.Series.Add("Корреляционное поле");            
            chart1.Series[1].Color = Color.FromArgb(76, 187, 23);
            chart1.Series[1].ChartType = SeriesChartType.Point;
            chart1.Series.Add("Прогноз");
            chart1.Series[2].ChartType = SeriesChartType.Point;
            chart1.Series[2].MarkerSize = 7;
            chart1.Series[2].Color = Color.FromArgb(213, 62, 7);
        }

        private void btnRegressionEq_Click(object sender, EventArgs e)
        {
            int btnNum = 0;
            if (!btnClickedShow[0])
            {
                for (int i = 0; i < data.Count; i++)
                {
                    chart1.Series[btnNum].Points.AddXY(data.MyData[i, 0], data.Function(i + 1));
                }
                btnClickedShow[btnNum] = true;
            }
            else
            {
                chart1.Series[btnNum].Points.Clear();
                btnClickedShow[btnNum] = false;
            }
        }

        private void btnCorrelationField_Click(object sender, EventArgs e)
        {
            int btnNum = 1;

            if (!btnClickedShow[btnNum])
            {
                for (int i = 0; i < data.Count; i++)
                {
                    chart1.Series[btnNum].Points.AddXY(data.MyData[i, 0], data.MyData[i, 1]);
                }
                btnClickedShow[btnNum] = true;
            }
            else
            {
                chart1.Series[btnNum].Points.Clear();
                btnClickedShow[btnNum] = false;
            }


        }

        private void btnPrediction_Click(object sender, EventArgs e)
        {
            int btnNum = 2;
            if (!btnClickedShow[btnNum])
            {
                for (int i = data.Count; i < data.Count + 3; i++)
                {
                    chart1.Series[btnNum].Points.AddXY(i + 1, data.Function(i + 1));
                }
                btnClickedShow[btnNum] = true;
            }
            else
            {
                chart1.Series[btnNum].Points.Clear();
                btnClickedShow[btnNum] = false;
            }
        }
    }
}
