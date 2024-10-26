using Tyuiu.NikiforovFA.Sprint4.Task0.V29.Lib;
namespace Tyuiu.NikiforovFA.Sprint4.Task0.V29
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
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Никифоров Федор Александрович | ПКТб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая вычисляет сумуу нечетных   *");
            Console.WriteLine("* элементов массива                                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.WriteLine("{ 7, 4, 3, 2, 1, 5, 9, 8, 7, 4 }");
            Console.WriteLine("* Результат:                                                              *");
            int[] res = { 7, 4, 3, 2, 1, 5, 9, 8, 7, 4 };
            Console.WriteLine(ds.GetSumOddArrEl(res));
        }
    }
}
