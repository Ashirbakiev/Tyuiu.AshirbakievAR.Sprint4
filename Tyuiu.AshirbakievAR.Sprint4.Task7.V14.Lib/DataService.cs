using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.AshirbakievAR.Sprint4.Task7.V14.Lib
{
    public class DataService : ISprint4Task7V14
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[3, 4];
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrix[i, j] = int.Parse(value[i * 4 + j].ToString());
                }
            }
            foreach(int c in matrix)
            {
                if (c % 2 != 0) sum += c;
            }
            return sum;
        }
    }
}
