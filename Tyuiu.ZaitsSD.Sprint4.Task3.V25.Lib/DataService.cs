using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ZaitsSD.Sprint4.Task3.V25.Lib
{
    public class DataService : ISprint4Task3V25
    {
        public int Calculate(int[,] array)
        {
            int res = 1;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                res *= array[i, 3];
            }
            return res;
        }
    }
}
