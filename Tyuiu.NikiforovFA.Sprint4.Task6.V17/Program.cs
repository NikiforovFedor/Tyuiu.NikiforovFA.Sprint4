using Tyuiu.NikiforovFA.Sprint4.Task6.V17.Lib;
namespace Tyuiu.NikiforovFA.Sprint4.Task6.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Никифоров Ф.А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Никифоров Федор Александрович | ПКТб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая считает количество         *");
            Console.WriteLine("* элементов, длина которых равна 6.                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходный массив:                                                        *");
            string[] s = { "Python", "JavaScript", "Java", "C#", "Swift", "Kotlin", "Ruby" };

            foreach (string s2 in s)
            {
                if (s2 != "Ruby")
                {
                    Console.Write(s2 + ", ");
                }
                else
                {
                    Console.WriteLine(s2);
                }
            }
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine(ds.Calculate(s));
        }
    }
}
