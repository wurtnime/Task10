using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0305
{
    class Calculation23
    {
        public void Calculate()
        {
            int sum = 0;
            for (int i = -20; i <= 20; i++)
            {
                if (i < 0 && i % 5 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"Сумма отрицательных чисел, кратных 5: {sum}");
        }
    }
}
