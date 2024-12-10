using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GulahmedovTE.Sprint6.Task1.V2.Lib
{
    public class DataService : ISprint6Task1V2
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res = new double[stopValue - startValue + 1];
            int d = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                if (Math.Sin(i) + 2 != 0)
                {
                    double r = (5 * i + 2.5) / (Math.Sin(i) + 2) + 2 * i + 2;
                    res[d] = Math.Round(r, 2);
                }
                else
                {
                    res[d] = 0;
                }
                d++;
            }
            return res;
        }
    }
}