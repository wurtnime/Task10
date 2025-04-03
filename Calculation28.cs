using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0305
{
    class Calculation28
    {
        public void Calculate()
        {
            Console.Write("Введите число n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите число m: ");
            int m = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                int sumDigits = 0;
                int num = i;
                while (num > 0)
                {
                    sumDigits += num % 10;
                    num /= 10;
                }
                if (sumDigits * sumDigits == m)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
