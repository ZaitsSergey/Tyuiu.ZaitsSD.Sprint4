using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ZaitsSD.Sprint4.Task2.V3.Lib
{
    public class DataService : ISprint4Task2V3
    {
        public int Calculate(int[] array)
        {
            int res = 0;
            foreach (int item in array)
            {
                if (item % 2 == 0) res += item;
            }
            return res;
        }
    }
}
