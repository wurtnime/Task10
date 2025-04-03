using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0305
{
    class Calculation21
    {
        public void Calculate()
        {
            Console.Write("Введите число N: ");
            int N = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= N; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i * i * i;
                }
            }
            Console.WriteLine($"Сумма кубов нечетных чисел: {sum}");
        }
    }
}
