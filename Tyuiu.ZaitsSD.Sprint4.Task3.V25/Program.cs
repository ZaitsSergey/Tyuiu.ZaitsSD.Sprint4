


using Tyuiu.ZaitsSD.Sprint4.Task3.V25.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tyuiu.ZaitsSD.Sprint4.Task3.V25
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
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Заиц Сергей Денисович | ПКТб-26-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан статический массив 5 на 5 из целых чисел от 2 до 7.                 *");
            Console.WriteLine("* Найти произведение элементов в четвёртом столбце массива.               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] matrix = { { 7, 3, 5, 3, 6 }, { 4, 6, 2, 5, 7 }, { 2, 3, 3, 3, 5 }, { 2, 7, 7, 6, 2 }, { 6, 6, 4, 3, 6 } };
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            Console.WriteLine("Матрица:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
            int res = ds.Calculate(matrix);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Произведение элементов четвёртого столбца = {res}");

        }
    }
}
