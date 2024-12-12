namespace Tyuiu.GulahmedovTE.Sprint6.Task6.V26
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
            buttonOpenFile = new Button();
            openFileDialogTask = new OpenFileDialog();
            buttonResult = new Button();
            textBoxStart = new TextBox();
            textBoxInPutData = new TextBox();
            groupBoxOutPutData = new GroupBox();
            textBoxResult = new TextBox();
            groupBoxOutPutData.SuspendLayout();
            SuspendLayout();
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Location = new Point(46, 51);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(105, 86);
            buttonOpenFile.TabIndex = 0;
            buttonOpenFile.Text = "открыть файл";
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // buttonResult
            // 
            buttonResult.Location = new Point(157, 51);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(105, 86);
            buttonResult.TabIndex = 1;
            buttonResult.Text = "Результат";
            buttonResult.UseVisualStyleBackColor = true;
            buttonResult.Click += buttonResult_Click;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(46, 177);
            textBoxStart.Multiline = true;
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(223, 181);
            textBoxStart.TabIndex = 2;
            // 
            // textBoxInPutData
            // 
            textBoxInPutData.Location = new Point(275, 177);
            textBoxInPutData.Multiline = true;
            textBoxInPutData.Name = "textBoxInPutData";
            textBoxInPutData.Size = new Size(223, 181);
            textBoxInPutData.TabIndex = 3;
            // 
            // groupBoxOutPutData
            // 
            groupBoxOutPutData.Controls.Add(textBoxResult);
            groupBoxOutPutData.Controls.Add(textBoxInPutData);
            groupBoxOutPutData.Controls.Add(textBoxStart);
            groupBoxOutPutData.Controls.Add(buttonResult);
            groupBoxOutPutData.Controls.Add(buttonOpenFile);
            groupBoxOutPutData.Location = new Point(1, 4);
            groupBoxOutPutData.Name = "groupBoxOutPutData";
            groupBoxOutPutData.Size = new Size(790, 438);
            groupBoxOutPutData.TabIndex = 4;
            groupBoxOutPutData.TabStop = false;
            groupBoxOutPutData.Text = "groupBox1";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(504, 177);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(223, 181);
            textBoxResult.TabIndex = 4;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxOutPutData);
            Name = "FormMain";
            Text = "Form1";
            groupBoxOutPutData.ResumeLayout(false);
            groupBoxOutPutData.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOpenFile;
        private OpenFileDialog openFileDialogTask;
        private Button buttonResult;
        private TextBox textBoxStart;
        private TextBox textBoxInPutData;
        private GroupBox groupBoxOutPutData;
        private TextBox textBoxResult;
    }
}
