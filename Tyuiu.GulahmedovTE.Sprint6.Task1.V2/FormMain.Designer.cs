namespace Tyuiu.GulahmedovTE.Sprint6.Task1.V2
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
            groupBox2 = new GroupBox();
            textBoxResult = new TextBox();
            textBoxVarStart = new TextBox();
            textBoxVarEnd = new TextBox();
            groupBox3 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(19, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(554, 304);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxResult);
            groupBox2.Location = new Point(579, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(242, 403);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод данных";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(6, 31);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(230, 366);
            textBoxResult.TabIndex = 0;
            // 
            // textBoxVarStart
            // 
            textBoxVarStart.Location = new Point(19, 49);
            textBoxVarStart.Name = "textBoxVarStart";
            textBoxVarStart.Size = new Size(150, 23);
            textBoxVarStart.TabIndex = 2;
            // 
            // textBoxVarEnd
            // 
            textBoxVarEnd.Location = new Point(193, 49);
            textBoxVarEnd.Name = "textBoxVarEnd";
            textBoxVarEnd.Size = new Size(150, 23);
            textBoxVarEnd.TabIndex = 3;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(textBoxVarEnd);
            groupBox3.Controls.Add(textBoxVarStart);
            groupBox3.Location = new Point(19, 336);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(368, 93);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ввод данных";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(193, 30);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 5;
            label2.Text = "Конец шага:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 30);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 4;
            label1.Text = "Старт шага:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 255);
            button1.Font = new Font("Segoe UI", 14F);
            button1.Location = new Point(393, 336);
            button1.Name = "button1";
            button1.Size = new Size(45, 93);
            button1.TabIndex = 5;
            button1.Text = "?";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 192);
            button2.Location = new Point(444, 336);
            button2.Name = "button2";
            button2.Size = new Size(129, 93);
            button2.TabIndex = 0;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 19);
            label4.Name = "label4";
            label4.Size = new Size(422, 15);
            label4.TabIndex = 0;
            label4.Text = "Вывести таблицу значений ф-ции на заданном диапазоне [-5; 5] с шагом 1.";
            label4.Click += label4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Снимок_экрана_2024_12_11_023052;
            pictureBox1.Location = new Point(6, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(249, 51);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 446);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 2 | Гюльахмедов Т. Э.";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBoxVarStart;
        private TextBox textBoxVarEnd;
        private GroupBox groupBox3;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button button1;
        private Button button2;
        private TextBox textBoxResult;
        private Label label4;
        private PictureBox pictureBox1;
    }
}
