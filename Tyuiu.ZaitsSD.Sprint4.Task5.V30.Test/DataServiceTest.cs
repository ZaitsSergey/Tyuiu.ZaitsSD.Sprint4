using Tyuiu.ZaitsSD.Sprint4.Task5.V30.Lib;
namespace Tyuiu.ZaitsSD.Sprint4.Task5.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void SumPositiveNum()
        {
            int[,] matrix = { { -2, 0, 4 }, { 1, -1, 3 } };
            int res = ds.Calculate(matrix);
            int res_wait = 8;
            Assert.AreEqual(res_wait, res);
        }
    }
}
