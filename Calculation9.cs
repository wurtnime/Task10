using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0305
{
    class Calculation9
    {
        public void Calculate()
        {
            Console.Write("Введите число x: ");
            int x = int.Parse(Console.ReadLine());
            for (int i = 2; i <= x; i++)
            {
                int sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                    }
                }
                if (sum == i)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
