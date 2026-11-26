
using Tyuiu.ZaitsSD.Sprint4.Task1.V13.Lib;
namespace Tyuiu.ZaitsSD.Sprint4.Task1.V13
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
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Заиц Сергей Денисович | ПКТб-26-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Ввести 10 целых чисел в диапазоне от 0 до 8 с клавиатуры.               *");
            Console.WriteLine("* Подсчитать сумму чётных элементов массива.                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int len_list = 10;
            int[] array = new int[len_list];
            for (int i = 0; i < len_list; i++)
            {
                Console.WriteLine($"Введите значение {i} элемента массива");
                array[i] = int.Parse(Console.ReadLine()!);
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
