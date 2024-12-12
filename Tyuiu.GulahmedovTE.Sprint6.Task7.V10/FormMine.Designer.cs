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
            dataGridViewOut = new DataGridView();
            dataGridViewIn = new DataGridView();
            buttonSave = new Button();
            buttonDone = new Button();
            buttonOpen = new Button();
            openFileDialogTask = new OpenFileDialog();
            saveFileDialogMatrix = new SaveFileDialog();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewOut);
            groupBox1.Controls.Add(dataGridViewIn);
            groupBox1.Controls.Add(buttonSave);
            groupBox1.Controls.Add(buttonDone);
            groupBox1.Controls.Add(buttonOpen);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(988, 637);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // dataGridViewOut
            // 
            dataGridViewOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut.Location = new Point(447, 192);
            dataGridViewOut.Name = "dataGridViewOut";
            dataGridViewOut.RowHeadersWidth = 51;
            dataGridViewOut.Size = new Size(426, 370);
            dataGridViewOut.TabIndex = 5;
            dataGridViewOut.CellContentClick += dataGridViewOutMatrix_CellContentClick;
            // 
            // dataGridViewIn
            // 
            dataGridViewIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn.Location = new Point(15, 192);
            dataGridViewIn.Name = "dataGridViewIn";
            dataGridViewIn.RowHeadersWidth = 51;
            dataGridViewIn.Size = new Size(426, 370);
            dataGridViewIn.TabIndex = 4;
            dataGridViewIn.CellContentClick += dataGridViewInMatrix_CellContentClick;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(295, 26);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(134, 102);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "button1";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += button_Save_Click;
            // 
            // buttonDone
            // 
            buttonDone.Enabled = false;
            buttonDone.Location = new Point(155, 26);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(134, 102);
            buttonDone.TabIndex = 2;
            buttonDone.Text = "Done";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += button_Done_Click;
            // 
            // buttonOpen
            // 
            buttonOpen.Location = new Point(15, 26);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(134, 102);
            buttonOpen.TabIndex = 0;
            buttonOpen.Text = "открыть файл";
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += button_OpenFile_Click;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            openFileDialogTask.FileOk += openFileDialogTask_FileOk;
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonOpen;
        private Button buttonDone;
        private Button buttonSave;
        private OpenFileDialog openFileDialogTask;
        private SaveFileDialog saveFileDialogMatrix;
        private DataGridView dataGridViewOut;
        private DataGridView dataGridViewIn;
    }
}
