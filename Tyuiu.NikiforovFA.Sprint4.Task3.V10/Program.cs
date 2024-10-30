using Tyuiu.NikiforovFA.Sprint4.Task3.V10.Lib;
namespace Tyuiu.NikiforovFA.Sprint4.Task3.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Никифоров Ф.А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы                                                *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Никифоров Федор Александрович | ПКТб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая вычисляет максимальное     *");
            Console.WriteLine("* значение в 3 строке матрицы                                             *");
            Console.WriteLine("***************************************************************************");
            int[,] res = {{5, 7, 6, 6, 5 },
                         { 5, 5, 5, 4, 6 },
                         { 8, 5, 7, 4, 7 },
                         { 7, 6, 7, 4, 7 },
                         { 5, 8, 7, 8, 8 }};
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine(ds.Calculate(res));
        }
    }
}
