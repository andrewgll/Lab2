using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_true
{
    public partial class Lab2Form : Form
    {

        public Lab2Form()
        {
            InitializeComponent();
        }


        private (List<string[]>, bool) GetRows(string fileName = "")
        {
            var matrix = new List<string[]>();
            bool isValidData = false;
            openFileDialog.InitialDirectory = @"C:\Users\";
            openFileDialog.FileName = fileName;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                isValidData = true;
                using (var reader = new StreamReader(openFileDialog.FileName))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var row = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        if (matrix.Count > 0 && row.Length != matrix[0].Length)
                        {
                            MessageBox.Show($"Invalid data in {openFileDialog.FileName}, line {matrix.Count + 1}", "Error");
                            isValidData = false;
                            break;
                        }
                        foreach (var item in row)
                        {
                            int i = 0;
                            isValidData = int.TryParse(item, out i);
                            if (!isValidData)
                            {
                                MessageBox.Show($"Invalid data in {openFileDialog.FileName}\nline {matrix.Count + 1}, element \"{item}\" is not valid!", "Error");
                                break;
                            }
                        }
                        matrix.Add(row);
                    }
                }
            }
            return (matrix, isValidData);
        }

        private void FillGrid(List<string[]> rows, DataGridView grid)
        {
            grid.Rows.Clear();
            grid.ColumnCount = rows[0].Length;
            foreach (var row in rows)
            {
                grid.Rows.Add(row);

            }
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            var (rows1, isValid) = GetRows("matrix.txt");
            if (isValid && rows1.Count > 0)
            {
                FillGrid(rows1, MatrixGridView);
            }

            OpenChartButton.Enabled = true;
            TaskButton.Enabled = true;
            
        }

        private bool TryParseGrid(DataGridView grid, out double[,] matrix)
        {
            matrix = new double[grid.RowCount, grid.ColumnCount];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    try
                    {
                        matrix[i, j] = Convert.ToDouble(grid[j, i].Value);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show($"Invalid value in cell ({i}, {j})");
                        grid[i, j].Selected = true;
                        return false;
                    }
                }
            }
            return true;
        }

        private void TaskButton_Click(object sender, EventArgs e)
        {
          
            if (TryParseGrid(MatrixGridView, out var matrix))
            {
                for (int i = 0; i < matrix.GetLength(1); i++)
                {
                    bool isMin = true;
                    for (int j = 0; j < matrix.GetLength(0) - 1; j++)
                        if (matrix[j, i] < matrix[j + 1, i])
                            isMin = false;

                    if (isMin)
                        MatrixGridView.Columns[i].DefaultCellStyle.BackColor = Color.Red;
                    else
                        MatrixGridView.Columns[i].DefaultCellStyle.BackColor = Color.White;
                    
                }
            }
        }



        private void OpenChartButton_Click(object sender, EventArgs e)
        {
                var chartForm = TryParseGrid(MatrixGridView, out var matrix) ? new ChartForm(matrix) : null;
                chartForm.Show();
        }

        private void Lab2Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            TextWriter txt = new StreamWriter(openFileDialog.FileName);
            for (int i = 0; i < MatrixGridView.Rows.Count; i++)
            {
                for (int j = 0; j < MatrixGridView.Columns.Count; j++)
                {
                    txt.Write(MatrixGridView[j, i].Value.ToString() + " ");
                }
                txt.WriteLine();
            }
            txt.Close();
        }
    }
}
