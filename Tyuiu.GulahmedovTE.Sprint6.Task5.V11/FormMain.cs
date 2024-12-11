using System;
using Tyuiu.GulahmedovTE.Sprint6.Task5.V11.Lib;
namespace Tyuiu.GulahmedovTE.Sprint6.Task5.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\gytim\source\repos\Tyuiu.GulahmedovTE.Sprint6\Tyuiu.GulahmedovTE.Sprint6.Task5.V11\bin\Debug\net8.0-windows\InPutDataFileTask5V11.txt";

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            dataGridViewResult.ColumnCount = 2;
            dataGridViewResult.Columns[0].Width = 20;
            dataGridViewResult.Columns[1].Width = 50;

            this.chart1.ChartAreas[0].AxisX.Title = "ось x";
            this.chart1.ChartAreas[0].AxisY.Title = "ось y";

            chart1.Series[0].Points.Clear();
            double[] numMass = new double[ds.len];

            numMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numMass.Length; i++)
            {
                dataGridViewResult.Rows.Add(Convert.ToString(i), Convert.ToString(numMass[i]));
                chart1.Series[0].Points.AddXY(i, numMass[i]);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
