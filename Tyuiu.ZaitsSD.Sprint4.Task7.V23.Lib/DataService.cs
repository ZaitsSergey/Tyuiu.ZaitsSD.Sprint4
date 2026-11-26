using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ZaitsSD.Sprint4.Task7.V23.Lib
{
    public class DataService : ISprint4Task7V23
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[n, m];
            int index = 0;
            int res = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = value[index] - '0';
                    if (matrix[i, j] % 2 == 0) res++;
                    index++;
                }
            }
            return res;
        }
    }
}
