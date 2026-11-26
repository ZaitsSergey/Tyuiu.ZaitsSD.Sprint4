using Tyuiu.ZaitsSD.Sprint4.Task1.V13.Lib;
namespace Tyuiu.ZaitsSD.Sprint4.Task1.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void SumEvenNum()
        {
            int[] array = { 8, 1, 5, 4, 2, 1, 2, 7, 6, 1 };
            int res = ds.Calculate(array);
            int wait_res = 22;
            Assert.AreEqual(wait_res, res);
        }
    }
}
