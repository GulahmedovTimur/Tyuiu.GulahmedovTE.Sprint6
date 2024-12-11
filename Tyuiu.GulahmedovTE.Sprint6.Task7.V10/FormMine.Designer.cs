namespace Tyuiu.GulahmedovTE.Sprint6.Task7.V10
{
    partial class FormMine
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
            button_Save = new Button();
            button_Done = new Button();
            button_OpenFile = new Button();
            openFileDialogTask = new OpenFileDialog();
            saveFileDialogMatrix = new SaveFileDialog();
            dataGridViewInMatrix = new DataGridView();
            dataGridViewOutMatrix = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInMatrix).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutMatrix).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewOutMatrix);
            groupBox1.Controls.Add(dataGridViewInMatrix);
            groupBox1.Controls.Add(button_Save);
            groupBox1.Controls.Add(button_Done);
            groupBox1.Controls.Add(button_OpenFile);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(988, 637);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // button_Save
            // 
            button_Save.Location = new Point(295, 26);
            button_Save.Name = "button_Save";
            button_Save.Size = new Size(134, 102);
            button_Save.TabIndex = 3;
            button_Save.Text = "button1";
            button_Save.UseVisualStyleBackColor = true;
            button_Save.Click += button_Save_Click;
            // 
            // button_Done
            // 
            button_Done.Enabled = false;
            button_Done.Location = new Point(155, 26);
            button_Done.Name = "button_Done";
            button_Done.Size = new Size(134, 102);
            button_Done.TabIndex = 2;
            button_Done.Text = "Done";
            button_Done.UseVisualStyleBackColor = true;
            button_Done.Click += button_Done_Click;
            // 
            // button_OpenFile
            // 
            button_OpenFile.Location = new Point(15, 26);
            button_OpenFile.Name = "button_OpenFile";
            button_OpenFile.Size = new Size(134, 102);
            button_OpenFile.TabIndex = 0;
            button_OpenFile.Text = "открыть файл";
            button_OpenFile.UseVisualStyleBackColor = true;
            button_OpenFile.Click += button_OpenFile_Click;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            openFileDialogTask.FileOk += openFileDialogTask_FileOk;
            // 
            // dataGridViewInMatrix
            // 
            dataGridViewInMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInMatrix.Location = new Point(15, 192);
            dataGridViewInMatrix.Name = "dataGridViewInMatrix";
            dataGridViewInMatrix.RowHeadersWidth = 51;
            dataGridViewInMatrix.Size = new Size(426, 370);
            dataGridViewInMatrix.TabIndex = 4;
            // 
            // dataGridViewOutMatrix
            // 
            dataGridViewOutMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutMatrix.Location = new Point(447, 192);
            dataGridViewOutMatrix.Name = "dataGridViewOutMatrix";
            dataGridViewOutMatrix.RowHeadersWidth = 51;
            dataGridViewOutMatrix.Size = new Size(426, 370);
            dataGridViewOutMatrix.TabIndex = 5;
            dataGridViewOutMatrix.CellContentClick += dataGridViewOutMatrix_CellContentClick;
            // 
            // FormMine
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 661);
            Controls.Add(groupBox1);
            Name = "FormMine";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInMatrix).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutMatrix).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button_OpenFile;
        private Button button_Done;
        private Button button_Save;
        private OpenFileDialog openFileDialogTask;
        private SaveFileDialog saveFileDialogMatrix;
        private DataGridView dataGridViewOutMatrix;
        private DataGridView dataGridViewInMatrix;
    }
}
