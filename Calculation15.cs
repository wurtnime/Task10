using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0305
{
    class Calculation15
    {
        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public void Calculate()
        {
            Console.Write("Введите число n: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                if (GCD(i, n) == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
