using Tyuiu.ZaitsSD.Sprint4.Task6.V17.Lib;
namespace Tyuiu.ZaitsSD.Sprint4.Task6.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void WordCheck()
        {
            string[] array = { "Python", "JavaScript", "Java", "C#", "Swift", "Kotlin", "Ruby" };
            int res = ds.Calculate(array);
            int res_wait = 2;
            Assert.AreEqual(res_wait, res);
        }
    }
}
