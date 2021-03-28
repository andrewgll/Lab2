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
            var smallest = new List<double>();

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                double min = matrix[0, i];
                for (int j = 1; j < matrix.GetLength(0); j++)
                    if (matrix[j, i] < min && matrix[j, i] > 0)
                        min = matrix[j, i];
                smallest.Add(min.ToString().Sum(c => c - '0'));
            }

            objChart.AxisY.Minimum = smallest.Min();
            objChart.AxisY.Maximum = smallest.Max();

            LineChart.Series.Add("Smallest num sum in collumn");
            LineChart.Series["Smallest num sum in collumn"].Color = Color.Red;
            LineChart.Series["Smallest num sum in collumn"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            LineChart.Series["Smallest num sum in collumn"].BorderWidth = 1;
            LineChart.Series["Smallest num sum in collumn"].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.None;
            LineChart.Series["Smallest num sum in collumn"].IsVisibleInLegend = false;
            LineChart.Series["Smallest num sum in collumn"].Color = Color.Red;
            for (int i = 1; i <= smallest.Count; i++)
            {
                LineChart.Series["Smallest num sum in collumn"].Points.AddXY(i, smallest[i - 1]);
            }

        }

    }
}
