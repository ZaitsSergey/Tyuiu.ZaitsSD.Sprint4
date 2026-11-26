using Tyuiu.ZaitsSD.Sprint4.Task2.V3.Lib;
namespace Tyuiu.ZaitsSD.Sprint4.Task2.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void SumEvenNum()
        {
            int[] array = { 2, 3, 4, 5, 6, 7, 2, 3, 4, 5, 6, 7 };
            int res = ds.Calculate(array);
            int wait_res = 24;
            Assert.AreEqual(wait_res, res);
        }
    }
}
