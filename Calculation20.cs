using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0305
{
    class Calculation20
    {
        public void Calculate()
        {
            Console.Write("Введите число n: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 1)
                    sum += i;
                else
                    sum -= i;
            }
            Console.WriteLine($"Результат: {sum}");
        }
    }
}
