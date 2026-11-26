using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ZaitsSD.Sprint4.Task6.V17.Lib
{
    public class DataService : ISprint4Task6V17
    {
        public int Calculate(string[] array)
        {
            return Array.FindAll(array, item => item.Length == 6).Length;
        }
    }
}
