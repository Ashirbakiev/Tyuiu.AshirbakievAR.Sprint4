using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.AshirbakievAR.Sprint4.Task4.V17.Lib
{
    public class DataService : ISprint4Task4V17
    {
        public int Calculate(int[,] matrix)
        {
            int sum = 0;
            foreach(int c in matrix)
            {
                if (c % 2 == 0) sum += c;
            }
            return sum;
        }
    }
}
