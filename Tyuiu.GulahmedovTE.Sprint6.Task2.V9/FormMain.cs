using Tyuiu.GulahmedovTE.Sprint6.Task2.V9.Lib;
namespace Tyuiu.GulahmedovTE.Sprint6.Task2.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep.Text);
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction.Titles.Add("График функции sin(x)");
                this.chartFunction.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";
                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridView.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click_MouseEnter(object sender, EventArgs e)
        {
            buttonStart_Click.BackColor = Color.Red;
        }

        private void buttonStart_Click_MouseLeave(object sender, EventArgs e)
        {
            buttonStart_Click.BackColor = Color.Green;
        }

        private void buttonStart_Click_MouseDown(object sender, MouseEventArgs e)
        {
            buttonStart_Click.BackColor = Color.Blue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ибксб-24-1 Тимурчик Гюльахмедов", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
