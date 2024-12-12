using Tyuiu.GulahmedovTE.Sprint6.Task7.V10.Lib;
namespace Tyuiu.GulahmedovTE.Sprint6.Task7.V10
{
    public partial class FormMine : Form
    {
        public FormMine()
        {
            InitializeComponent();

            openFileDialogTask.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
            saveFileDialogMatrix.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
        }
        static int rows;
        static int columns;
        static string? openFilePath;
        DataService dataService = new DataService();

        public int[,] LoadFromFileData(string path)
        {
            string fileData = File.ReadAllText(path);

            // Разделение на строки 

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            // Определяем количество строк и столбцов

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            // Выделите массив данных
            int[,] arrayValue = new int[rows, columns];

            // Заполняем массив данными 

            for (int i = 0; i < rows; i++)
            {
                string[] line_mas = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    arrayValue[i, j] = Convert.ToInt32(line_mas[j]);
                }
            }
            return arrayValue;
        }

        private void button_OpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;

            if (openFilePath != null)
            {
                int[,] arrayValues = dataService.GetMatrix(openFilePath);

                rows = arrayValues.GetLength(0);
                columns = arrayValues.GetLength(1);

                dataGridViewIn.ColumnCount = columns;
                dataGridViewIn.RowCount = rows;
                dataGridViewOut.ColumnCount = columns;
                dataGridViewOut.RowCount = rows;

                for (int i = 0; i < columns; i++)
                {
                    dataGridViewIn.Columns[i].Width = 25;
                    dataGridViewOut.Columns[i].Width = 25;
                }
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewIn.Rows[i].Cells[j].Value = arrayValues[i, j];
                    }
                }
                buttonDone.Enabled = true;
            }
       
        }

        private void button_Done_Click(object sender, EventArgs e)
        {
            int[,] values = dataService.GetMatrix(openFilePath);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOut.Rows[i].Cells[j].Value = values[i, j];
                }
            }
            buttonSave.Enabled = true;

        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix.ShowDialog();

            string path = saveFileDialogMatrix.FileName;

            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                File.Delete(path);
            }

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewOut.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewOut.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void openFileDialogTask_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void dataGridViewOutMatrix_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewInMatrix_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
