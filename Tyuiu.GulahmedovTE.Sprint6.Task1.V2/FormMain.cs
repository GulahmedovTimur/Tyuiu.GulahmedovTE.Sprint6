using Tyuiu.GulahmedovTE.Sprint6.Task1.V2.Lib;
namespace Tyuiu.GulahmedovTE.Sprint6.Task1.V2
{
    public partial class FormMain : Form

    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int len = ds.GetMassFunction(Convert.ToInt32(textBoxVarStart.Text), Convert.ToInt32(textBoxVarEnd.Text)).Length;
                int s = Convert.ToInt32(textBoxVarStart.Text);
                double[] mass = new double[len];
                mass = ds.GetMassFunction(Convert.ToInt32(textBoxVarStart.Text), Convert.ToInt32(textBoxVarEnd.Text));
                textBoxResult.Text = "";
                textBoxResult.AppendText("+---------+----------+" + Environment.NewLine);
                textBoxResult.AppendText("|    X    |    f(x)  |" + Environment.NewLine);
                textBoxResult.AppendText("+---------+----------+" + Environment.NewLine);
                string str;
                for (int i = 0; i < len; i++)
                {
                    str = String.Format("|{0,5:d}    |  {1,6:f2}  |", s, mass[i]);
                    textBoxResult.AppendText(str + Environment.NewLine);
                    s++;
                }
                textBoxResult.AppendText("+---------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("¬ведены неверные данные", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
