using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0305
{
    class Calculation24
    {
        public void Calculate()
        {
            int sum = 0;
            for (int i = 1; i < 100; i++)
            {
                if (i % 4 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"Сумма положительных чисел, кратных 4: {sum}");
        }
    }
}
