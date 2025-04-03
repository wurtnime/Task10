using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0305
{
    class Calculation19
    {
        public void Calculate()
        {
            Console.Write("Введите число m: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Введите число n: ");
            int n = int.Parse(Console.ReadLine());
            long product = 1;
            for (int i = m; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    product *= i * i;
                }
            }
            Console.WriteLine($"Произведение квадратов четных чисел: {product}");
        }
    }
}
