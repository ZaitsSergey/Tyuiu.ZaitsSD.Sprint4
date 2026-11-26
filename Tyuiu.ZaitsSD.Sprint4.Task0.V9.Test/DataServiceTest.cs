using Tyuiu.ZaitsSD.Sprint4.Task0.V9.Lib;
namespace Tyuiu.ZaitsSD.Sprint4.Task0.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void SumEvenNum()
        {
            int[] array = { 4, 6, 2, 8, 4, 5, 6, 9, 8, 7 };
            int res = ds.GetSumEvenArrEl(array);
            int wait_res = 38;
            Assert.AreEqual(wait_res, res);
        }
    }
}
