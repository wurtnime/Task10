using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0305
{
    class Calculation8
    {
        public void Calculate()
        {
            Console.Write("Введите число: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Простые множители: ");
            for (int i = 2; i <= num; i++)
            {
                while (num % i == 0)
                {
                    Console.Write(i + " ");
                    num /= i;
                }
            }
        }
    }
}
