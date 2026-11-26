using Tyuiu.ZaitsSD.Sprint4.Task0.V9.Lib;
namespace Tyuiu.ZaitsSD.Sprint4.Task0.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Заиц С. Д. | ПКТб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Заиц Сергей Денисович | ПКТб-26-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан массив из 10 целых чисел от 0 до 9.                                 *");
            Console.WriteLine("* Подсчитать сумму чётных элементов массива.                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] array = { 4, 6, 2, 8, 4, 5, 6, 9, 8, 7 };
            Console.WriteLine($"Список элементов: {string.Join(',', array)}");
            int res = ds.GetSumEvenArrEl(array);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Сумма чётных элементов = {res}");

        }
    }
}
