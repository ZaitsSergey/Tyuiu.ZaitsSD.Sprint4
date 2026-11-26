using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ZaitsSD.Sprint4.Task1.V13.Lib
{
    public class DataService : ISprint4Task1V13
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
