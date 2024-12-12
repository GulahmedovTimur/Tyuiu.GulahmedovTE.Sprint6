using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GulahmedovTE.Sprint6.Task6.V26.Lib
{
    public class DataService : ISprint6Task6V26
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] mas = line.Split(' ');
                    // Проверяем, есть ли хотя бы одно слово в строке
                    if (mas.Length > 0)
                    {
                        // Добавляем последнее слово к результату
                        resStr += mas[mas.Length - 1] + " ";
                    }
                }
            }
            return resStr.Trim(); // Убираем лишние пробелы в конце
        }

        public string CollectTextFromFile(string str, string path)
        {
            throw new NotImplementedException();
        }
    }
}