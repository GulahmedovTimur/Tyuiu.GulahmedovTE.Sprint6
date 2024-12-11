using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GulahmedovTE.Sprint6.Task7.V10.Lib
{
    public class DataService : ISprint6Task7V10
    {
        public int[,] GetMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0) + 1;
            int colums = matrix.Length / rows;

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[4, j] >= 5 && matrix[4, j] <= 10)
                {
                    matrix[4, j] = 0;
                }
            }
            return matrix;
        }
    }
}