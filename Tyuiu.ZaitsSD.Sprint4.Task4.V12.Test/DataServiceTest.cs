using Tyuiu.ZaitsSD.Sprint4.Task4.V12.Lib;
namespace Tyuiu.ZaitsSD.Sprint4.Task4.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void ReplaceEvenNumMatrix()
        {
            int[,] matrix = { { 3, 6, 6, 8, 8 }, { 2, 7, 2, 4, 6 }, { 3, 6, 2, 6, 4 }, { 8, 6, 2, 7, 3 }, { 8, 7, 6, 6, 6 } };
            int[,] res = ds.Calculate(matrix);
            int[,] wait_res = { { 3, 1, 1, 1, 1 }, { 1, 7, 1, 1, 1 }, { 3, 1, 1, 1, 1 }, { 1, 1, 1, 7, 3 }, { 1, 7, 1, 1, 1 } };
            CollectionAssert.AreEqual(wait_res, res);
        }
    }
}
