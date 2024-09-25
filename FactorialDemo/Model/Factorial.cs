using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialDemo.Model
{
    internal class Factorial
    {
        public int CalculateFactorial(int num)
        {
            int answer = 1;

            for (int i = 1; i <= num; i++)
            {
                answer *= i;
            }

            return answer;
        }
    }
}
