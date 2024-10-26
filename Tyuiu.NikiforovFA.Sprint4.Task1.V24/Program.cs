using Tyuiu.NikiforovFA.Sprint4.Task1.V24.Lib;
namespace Tyuiu.NikiforovFA.Sprint4.Task1.V24
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
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Никифоров Федор Александрович | ПКТб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая вычисляет произведение     *");
            Console.WriteLine("* нечетных элементов массива                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Введите исходные данные:                                                *");
            int[] res = new int[16];
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine("Введите " + i + " элемент массива");
                res[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine(ds.Calculate(res));


            
        }
    }
    
}
