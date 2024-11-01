using Tyuiu.NikiforovFA.Sprint4.Task4.V26.Lib;
namespace Tyuiu.NikiforovFA.Sprint4.Task4.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Никифоров Ф.А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Никифоров Федор Александрович | ПКТб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая заменяет нечетные значения *");
            Console.WriteLine("* матрицы на 0                                                            *");
            Console.WriteLine("***************************************************************************");
            int[,] res = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine($"Введите элемент с индексами ({i}, {j}): ");
                    res[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("* Исходная матрица:                                                       *");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j != 4)
                    {
                        Console.Write(res[i, j] + " ");
                    }
                    else
                    {
                        Console.Write(res[i, j]);
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("* Результат:                                                              *");
            int[,] r = ds.Calculate(res);
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j != 4)
                    {
                        Console.Write(r[i, j] + " ");
                    }
                    else
                    {
                        Console.Write(r[i, j]);
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
