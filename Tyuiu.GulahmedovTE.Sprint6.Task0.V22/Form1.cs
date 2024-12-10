using System.Windows.Forms.VisualStyles;
using Tyuiu.GulahmedovTE.Sprint6.Task0.V22.Lib;
namespace Tyuiu.GulahmedovTE.Sprint6.Task0.V22
{
    public partial class Form1 : Form
    {
        DataService ds = new DataService();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            double result = ds.Calculate(x);
            textBoxResult.Text = result.ToString();
        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
