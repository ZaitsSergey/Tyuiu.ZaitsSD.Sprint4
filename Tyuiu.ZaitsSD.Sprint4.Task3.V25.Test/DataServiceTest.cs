using Tyuiu.ZaitsSD.Sprint4.Task3.V25.Lib;
namespace Tyuiu.ZaitsSD.Sprint4.Task3.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void ProductFourthColumn()
        {
            int[,] matrix = { { 7, 3, 5, 3, 6 }, { 4, 6, 2, 5, 7 }, { 2, 3, 3, 3, 5 }, { 2, 7, 7, 6, 2 }, { 6, 6, 4, 3, 6 } };
            int res = ds.Calculate(matrix);
            int res_wait = 810;
            Assert.AreEqual(res_wait, res);
        }
    }
}
