using Tyuiu.NefedovIS.Sprint4.Task7.V17.Lib;
namespace Tyuiu.NefedovIS.Sprint4.Task7.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int rows = 3;
            int columns = 3;
            int[,] mtrx = new int[rows, columns];
            string str = "753159864";
            Assert.AreEqual(3, ds.Calculate(rows, columns, str));
        }
    }
}