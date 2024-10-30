using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.NikiforovFA.Sprint4.Task3.V10.Lib
{
    public class DataService : ISprint4Task3V10
    {
        public int Calculate(int[,] array)
        {
            int m = 0;
            for (int i = 0; i < 5; i++)
            {
                if (array[3, i] > m) 
                {
                    m = array[2, i];
                }
                else { continue; }
            }
            return m;
        }
    }
}
