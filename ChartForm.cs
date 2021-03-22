using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_true
{
    public partial class ChartForm : Form
    {
        double[,] matrix;
        public ChartForm(double[,] matrix)
        {
            this.matrix = matrix;
            InitializeComponent();
        }

        private void ChartForm_Load(object sender, EventArgs e)
        {
            LineChart.Series.Clear();

            var objChart = LineChart.ChartAreas[0];
            objChart.AxisX.Minimum = 1;
            objChart.AxisX.Maximum = matrix.GetLength(1);
            var ga = new List<double>();

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                double k = 1;
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    k *= matrix[j, i];
                }
                ga.Add(Math.Pow(Math.Abs(k), 1 / (double)matrix.GetLength(0)));
            }

            objChart.AxisY.Minimum = ga.Min() - ga.Min() % 0.01 + 0.01;
            objChart.AxisY.Maximum = ga.Max() - ga.Max() % 0.01 + 0.01;

            LineChart.Series.Add("Geometric Avarage");
            LineChart.Series["Geometric Avarage"].Color = Color.Red;
            LineChart.Series["Geometric Avarage"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            for (int i = 1; i <= ga.Count; i++)
            {
                LineChart.Series["Geometric Avarage"].Points.AddXY(i, ga[i - 1]);
            }

        }

    }
}
