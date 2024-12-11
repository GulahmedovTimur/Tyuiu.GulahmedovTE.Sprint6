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
        static string openFilePath;
        static int rows;
        static int columns;

        DataService ds = new DataService();

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

            // Выделите массив данных

            int[,] arrayValue = new int[rows, columns];

            arrayValue = LoadFromFileData(openFilePath);

            dataGridViewInMatrix.RowCount = rows;
            dataGridViewInMatrix.ColumnCount = columns;
            dataGridViewOutMatrix.RowCount = rows;
            dataGridViewOutMatrix.ColumnCount = columns;

            // Задаём ширину столбцов dataGridViewInMatrix_ATI

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInMatrix.Columns[i].Width = 50;
                dataGridViewOutMatrix.Columns[i].Width = 50;
            }

            // Добавьте данные в dataGridViewInMatrix_ATI

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInMatrix.Rows[r].Cells[c].Value = arrayValue[r, c];
                }
            }
            arrayValue = ds.GetMatrix(LoadFromFileData(openFilePath));
            button_Done.Enabled = true;
        }

        private void button_Done_Click(object sender, EventArgs e)
        {
            // Выделите массив данных
            int[,] arrayValue = new int[rows, columns];
            arrayValue = ds.GetMatrix(LoadFromFileData(openFilePath));

            // Добавьте данные в  dataGridViewOutMatrix_ATI
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutMatrix.Rows[r].Cells[c].Value = arrayValue[r, c];
                }
            }
            button_Save.Enabled = true;

        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix.ShowDialog();

            string path = saveFileDialogMatrix.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutMatrix.RowCount; // количество строк
            int columns = dataGridViewOutMatrix.ColumnCount; // количество столбцов

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutMatrix.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutMatrix.Rows[i].Cells[j].Value;
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
    }
}
