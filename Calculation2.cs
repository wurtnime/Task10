using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0305
{
    class Calculation2
    {
        public long CalculateFactorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Факторил отрицательного числа не определен.");
            }

            long resualt = 1;
            for (int i = 2; i <= n; i++)
            {
                resualt *= i;
            }
            return resualt;

        }
    }
}
