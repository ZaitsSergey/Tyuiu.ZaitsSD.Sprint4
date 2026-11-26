

using Tyuiu.ZaitsSD.Sprint4.Task2.V3.Lib;
namespace Tyuiu.ZaitsSD.Sprint4.Task2.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();
            Console.Title = "Спринт #4 | Выполнил: Заиц С. Д. | ПКТб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Заиц Сергей Денисович | ПКТб-26-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Заполнить массив из 12 элементов случайными числами от 2 до 7.          *");
            Console.WriteLine("* Подсчитать сумму чётных элементов массива.                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int len_list = 12;
            int[] array = new int[len_list];
            for (int i = 0; i < len_list; i++)
            {
                array[i] = rnd.Next(2, 8);
            }
            Console.WriteLine($"Список элементов: {string.Join(',', array)}");
            int res = ds.Calculate(array);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Сумма чётных элементов = {res}");

        }
    }
}
