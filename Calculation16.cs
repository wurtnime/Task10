using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0305
{
    class Calculation16
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
            Console.Write("Введите число p: ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("Введите число q: ");
            int q = int.Parse(Console.ReadLine());
            for (int i = 1; i <= q; i++)
            {
                if (q % i == 0 && GCD(i, p) == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
