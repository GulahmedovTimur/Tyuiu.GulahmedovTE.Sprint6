namespace Tyuiu.GulahmedovTE.Sprint6.Task2.V9
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            textBoxStopStep = new TextBox();
            textBoxStartStep = new TextBox();
            button1 = new Button();
            groupBox3 = new GroupBox();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridView = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            buttonStart_Click = new Button();
            pictureBox2 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(814, 333);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(textBoxStopStep);
            groupBox2.Controls.Add(textBoxStartStep);
            groupBox2.Location = new Point(18, 352);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(459, 103);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод данных";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(237, 19);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 4;
            label2.Text = "Конец шага:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 20);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 3;
            label1.Text = "Старт шага:";
            // 
            // textBoxStopStep
            // 
            textBoxStopStep.Location = new Point(237, 38);
            textBoxStopStep.Name = "textBoxStopStep";
            textBoxStopStep.Size = new Size(216, 23);
            textBoxStopStep.TabIndex = 2;
            // 
            // textBoxStartStep
            // 
            textBoxStartStep.Location = new Point(6, 38);
            textBoxStartStep.Name = "textBoxStartStep";
            textBoxStartStep.Size = new Size(216, 23);
            textBoxStartStep.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(483, 352);
            button1.Name = "button1";
            button1.Size = new Size(98, 103);
            button1.TabIndex = 2;
            button1.Text = "?";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(chartFunction);
            groupBox3.Controls.Add(dataGridView);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(832, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(654, 443);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод данных:";
            // 
            // chartFunction
            // 
            chartArea2.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartFunction.Legends.Add(legend2);
            chartFunction.Location = new Point(173, 42);
            chartFunction.Name = "chartFunction";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartFunction.Series.Add(series2);
            chartFunction.Size = new Size(475, 378);
            chartFunction.TabIndex = 3;
            chartFunction.Text = "chart1";
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView.Location = new Point(6, 42);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.Size = new Size(158, 378);
            dataGridView.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.HeaderText = "X";
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.HeaderText = "F(X)";
            Column2.Name = "Column2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 0;
            label3.Text = "Результат:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 47);
            label4.Name = "label4";
            label4.Size = new Size(507, 15);
            label4.TabIndex = 0;
            label4.Text = "Протабулировать ф-цию син() на заданном диапазоне. Результат вывести и в DataFridView";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Снимок_экрана_2024_12_11_161547;
            pictureBox1.Location = new Point(6, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(273, 50);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // buttonStart_Click
            // 
            buttonStart_Click.Location = new Point(587, 352);
            buttonStart_Click.Name = "buttonStart_Click";
            buttonStart_Click.Size = new Size(239, 103);
            buttonStart_Click.TabIndex = 7;
            buttonStart_Click.Text = "Выполнить";
            buttonStart_Click.UseVisualStyleBackColor = true;
            buttonStart_Click.Click += button3_Click;
            buttonStart_Click.MouseDown += buttonStart_Click_MouseDown;
            buttonStart_Click.MouseEnter += buttonStart_Click_MouseEnter;
            buttonStart_Click.MouseLeave += buttonStart_Click_MouseLeave;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Снимок_экрана_2024_12_11_165024;
            pictureBox2.Location = new Point(6, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(793, 300);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1498, 486);
            Controls.Add(buttonStart_Click);
            Controls.Add(groupBox3);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 9 | Гюльахмедов Т. Э.";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBoxStartStep;
        private Label label2;
        private Label label1;
        private TextBox textBoxStopStep;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label4;
        private GroupBox groupBox3;
        private Label label3;
        private Button buttonStart_Click;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private PictureBox pictureBox2;
    }
}
