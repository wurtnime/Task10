﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0305
{
    class Calculation10
    {
        public void Calculate()
        {
            Console.Write("Введите число m: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Введите число n: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = m; i <= n; i++)
            {
                sum += i * i;
            }
            Console.WriteLine($"Сумма квадратов: {sum}");
        }
    }
}
