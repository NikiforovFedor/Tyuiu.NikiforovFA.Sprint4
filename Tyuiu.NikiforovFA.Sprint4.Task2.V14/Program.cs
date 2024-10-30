using Tyuiu.NikiforovFA.Sprint4.Task2.V14.Lib;
namespace Tyuiu.NikiforovFA.Sprint4.Task2.V14
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
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Никифоров Федор Александрович | ПКТб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая вычисляет произведение     *");
            Console.WriteLine("* нечетных элементов массива                                              *");
            Console.WriteLine("***************************************************************************");
            int len;
            Random rand = new Random();
            Console.WriteLine("* Введите длину массива:                                                  *");
            len = Convert.ToInt32(Console.ReadLine());
            int[] res = new int[len];
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = rand.Next(1, 8);
            }
            //for (int i = 0; i < res.Length; i++)
            //{
            //    Console.WriteLine(res[i]);
            //}
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine(ds.Calculate(res));
            

        }
    }
}
