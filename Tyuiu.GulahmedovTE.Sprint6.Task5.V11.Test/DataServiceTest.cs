using Tyuiu.GulahmedovTE.Sprint6.Task5.V11.Lib;
namespace Tyuiu.GulahmedovTE.Sprint6.Task5.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\gytim\source\repos\Tyuiu.GulahmedovTE.Sprint6\Tyuiu.GulahmedovTE.Sprint6.Task5.V11\bin\Debug\net8.0-windows\InPutDataFileTask5V11.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}