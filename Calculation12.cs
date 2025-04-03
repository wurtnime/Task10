using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0305
{
    class Calculation12
    {
        public void Calculate()
        {
            int product = 1;
            for (int i = -80; i <= 80; i++)
            {
                if (i % 2 != 0 && i % 7 == 0)
                {
                    product *= i;
                }
            }
            Console.WriteLine($"Произведение: {product}");
        }
    }
}
