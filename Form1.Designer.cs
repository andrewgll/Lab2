
namespace Lab2_true
{
    partial class Lab2Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MatrixGridView = new System.Windows.Forms.DataGridView();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.LoadButton = new System.Windows.Forms.Button();
            this.OpenChartButton = new System.Windows.Forms.Button();
            this.TaskButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MatrixGridView
            // 
            this.MatrixGridView.AllowUserToAddRows = false;
            this.MatrixGridView.AllowUserToDeleteRows = false;
            this.MatrixGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MatrixGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatrixGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.MatrixGridView.Location = new System.Drawing.Point(0, 0);
            this.MatrixGridView.Name = "MatrixGridView";
            this.MatrixGridView.RowHeadersWidth = 82;
            this.MatrixGridView.RowTemplate.Height = 33;
            this.MatrixGridView.Size = new System.Drawing.Size(1015, 432);
            this.MatrixGridView.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // LoadButton
            // 
            this.LoadButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.LoadButton.Location = new System.Drawing.Point(0, 432);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(314, 251);
            this.LoadButton.TabIndex = 1;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // OpenChartButton
            // 
            this.OpenChartButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.OpenChartButton.Enabled = false;
            this.OpenChartButton.Location = new System.Drawing.Point(788, 432);
            this.OpenChartButton.Name = "OpenChartButton";
            this.OpenChartButton.Size = new System.Drawing.Size(227, 251);
            this.OpenChartButton.TabIndex = 2;
            this.OpenChartButton.Text = "Open chart";
            this.OpenChartButton.UseVisualStyleBackColor = true;
            this.OpenChartButton.Click += new System.EventHandler(this.OpenChartButton_Click);
            // 
            // TaskButton
            // 
            this.TaskButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TaskButton.Enabled = false;
            this.TaskButton.Location = new System.Drawing.Point(314, 432);
            this.TaskButton.Name = "TaskButton";
            this.TaskButton.Size = new System.Drawing.Size(474, 251);
            this.TaskButton.TabIndex = 3;
            this.TaskButton.Text = "Task";
            this.TaskButton.UseVisualStyleBackColor = true;
            this.TaskButton.Click += new System.EventHandler(this.TaskButton_Click);
            // 
            // Lab2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 683);
            this.Controls.Add(this.TaskButton);
            this.Controls.Add(this.OpenChartButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.MatrixGridView);
            this.Name = "Lab2Form";
            this.Text = "Lab 2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Lab2Form_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.MatrixGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView MatrixGridView;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button OpenChartButton;
        private System.Windows.Forms.Button TaskButton;
    }
}

