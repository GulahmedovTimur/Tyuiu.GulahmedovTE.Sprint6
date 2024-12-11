using Tyuiu.GulahmedovTE.Sprint6.Task3.V11.Lib;
namespace Tyuiu.GulahmedovTE.Sprint6.Task3.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] { { 27, -15,14, 2, 27 },
                                                {-8, 14, -10, 33, 0 },
                                                    {1, 7, -11, -11, 23 },
                                                   { -13, -20, 15, 16, 34},
                                                {-3, 1, -1, 5, 1 } };

        private void button1_Click(object sender, EventArgs e)
        {
            var sortedMtrx = ds.Calculate(mtrx);
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewResult_KSJ.ColumnCount = columns;
            dataGridViewResult_KSJ.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewResult_KSJ.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult_KSJ.Rows[i].Cells[j].Value = Convert.ToString(sortedMtrx[i, j]);
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewTaskMatrix.ColumnCount = columns;
            dataGridViewTaskMatrix.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewTaskMatrix.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewTaskMatrix.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }
    }
}
