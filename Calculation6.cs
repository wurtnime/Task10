using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0305
{
    class Calculation6
    {
        public void Calculate()
        {
            Console.Write("Введите число N: ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
