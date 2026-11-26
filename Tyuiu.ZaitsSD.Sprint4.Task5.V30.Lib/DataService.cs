using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ZaitsSD.Sprint4.Task5.V30.Lib
{
    public class DataService : ISprint4Task5V30
    {
        public int Calculate(int[,] matrix)
        {
            int res = 0;
            foreach (int item in matrix)
            {
                if (item > 0) res += item;
            }
            return res;
        }
    }
}
