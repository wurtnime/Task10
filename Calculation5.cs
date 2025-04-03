using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0305
{
    class Calculation5
    {
        public void Calculate()
        {
            Console.Write("Введите число N: ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                if (i % 5 != 0 && i % 3 == 0)
                {
                    int sumDigits = 0;
                    int num = i;
                    while (num > 0)
                    {
                        sumDigits += num % 10;
                        num /= 10;
                    }
                    if (sumDigits % 5 != 0 && sumDigits % 3 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
