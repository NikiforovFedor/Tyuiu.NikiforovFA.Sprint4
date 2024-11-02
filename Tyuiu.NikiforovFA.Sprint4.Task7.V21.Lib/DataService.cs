using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.NikiforovFA.Sprint4.Task7.V21.Lib
{
    public class DataService : ISprint4Task7V21
    {
        public int Calculate(int n, int m, string value)
        {
            int sum = 0;
            int k = 0;  
            int[,] mat = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mat[i, j] = int.Parse(value.Substring(k, 1));
                    k++;
                }
            }
            for (int i = 0;i < n; i++)
            {
                for(int j = 0;j < m; j++)
                {
                    if (mat[i, j] % 2 == 0)
                    {
                        sum += mat[i, j];
                    }
                    else { continue; }
                }
            }
            return sum;
        }
    }
}
