using Tyuiu.GulahmedovTE.Sprint6.Task1.V2.Lib;
namespace Tyuiu.GulahmedovTE.Sprint6.Task1.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetMass()
        {
            DataService ds = new DataService();
            double[] wait = new double[] { -2.16, 3.25, 6.64 };
            int start = -1, end = 1;
            double[] res = new double[ds.GetMassFunction(start, end).Length];
            res = ds.GetMassFunction(start, end);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}