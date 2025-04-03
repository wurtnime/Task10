using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0305
{
    class Calculation1
    {
        public double Calculator(double a, double n)
        {
            if (n % 1 != 0)
            {
                Console.WriteLine("Степень не целая!");
            }

            double count = Math.Pow(a, n);
            return count;
        }
    }
}
