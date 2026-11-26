using Tyuiu.ZaitsSD.Sprint4.Task7.V23.Lib;
namespace Tyuiu.ZaitsSD.Sprint4.Task7.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void CheckEvenNumMatrix()
        {
            string value = "678135972584";
            int res = ds.Calculate(4, 3, value);
            int res_wait = 5;
            Assert.AreEqual(res_wait, res);
        }
    }
}
