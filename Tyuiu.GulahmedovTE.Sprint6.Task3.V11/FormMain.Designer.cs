namespace Tyuiu.GulahmedovTE.Sprint6.Task3.V11
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
            groupBox1 = new GroupBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            dataGridViewResult_KSJ = new DataGridView();
            dataGridViewTaskMatrix = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_KSJ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTaskMatrix).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dataGridViewResult_KSJ);
            groupBox1.Controls.Add(dataGridViewTaskMatrix);
            groupBox1.Location = new Point(17, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(798, 526);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Снимок_экрана_2024_12_11_181036;
            pictureBox2.Location = new Point(0, 129);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 181);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Снимок_экрана_2024_12_11_180923;
            pictureBox1.Location = new Point(0, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(561, 97);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(576, 433);
            button1.Name = "button1";
            button1.Size = new Size(211, 76);
            button1.TabIndex = 3;
            button1.Text = "Выполнить";
            button1.Click += button1_Click;
            // 
            // dataGridViewResult_KSJ
            // 
            dataGridViewResult_KSJ.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_KSJ.Location = new Point(540, 129);
            dataGridViewResult_KSJ.Name = "dataGridViewResult_KSJ";
            dataGridViewResult_KSJ.RowHeadersWidth = 51;
            dataGridViewResult_KSJ.Size = new Size(247, 287);
            dataGridViewResult_KSJ.TabIndex = 4;
            // 
            // dataGridViewTaskMatrix
            // 
            dataGridViewTaskMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTaskMatrix.Location = new Point(287, 129);
            dataGridViewTaskMatrix.Name = "dataGridViewTaskMatrix";
            dataGridViewTaskMatrix.RowHeadersWidth = 60;
            dataGridViewTaskMatrix.Size = new Size(247, 287);
            dataGridViewTaskMatrix.TabIndex = 1;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 562);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_KSJ).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTaskMatrix).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textbox;
        private DataGridView dataGridViewTaskMatrix;
        private Button button1;
        private DataGridView dataGridViewResult_KSJ;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}
