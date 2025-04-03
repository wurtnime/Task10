using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0305
{
    class Calculation14
    {
        public void Calculate()
        {
            Console.Write("Введите число n: ");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 100; i <= 999; i++)
            {
                if (i > n)
                {
                    count++;
                }
            }
            Console.WriteLine($"Количество чисел: {count}");
        }
    }
}
