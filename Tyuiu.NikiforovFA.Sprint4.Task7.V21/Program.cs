using Tyuiu.NikiforovFA.Sprint4.Task7.V21.Lib;
namespace Tyuiu.NikiforovFA.Sprint4.Task7.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Никифоров Ф.А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Добавление итоговых решений по спринту                            *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Никифоров Федор Александрович | ПКТб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая считает сумму четных       *");
            Console.WriteLine("* элементов строки, превращая ее в матрицу 4 на 3                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходный строка:                                                        *");
            string s = "425963128528";
            Console.WriteLine(s);
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine(ds.Calculate(4, 3, s));
        }
    }
}
