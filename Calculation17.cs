using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0305
{
    class Calculation17
    {
        public void Calculate()
        {
            Console.Write("Введите число n: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0)
                {
                    bool isPrime = true;
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
