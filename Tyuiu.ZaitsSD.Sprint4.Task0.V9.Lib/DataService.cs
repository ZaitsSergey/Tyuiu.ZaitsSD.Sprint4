using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ZaitsSD.Sprint4.Task0.V9.Lib
{
    public class DataService : ISprint4Task0V9
    {
        public int GetSumEvenArrEl(int[] array)
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
