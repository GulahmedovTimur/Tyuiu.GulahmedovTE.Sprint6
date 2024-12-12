using Tyuiu.GulahmedovTE.Sprint6.Task7.V10;
namespace Tyuiu.GulahmedovTE.Sprint6.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\gytim\source\repos\Tyuiu.GulahmedovTE.Sprint6\InPutDataFileTask7V10.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);

        }
    }
}