﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0305
{
    class Calculation13
    {
        public void Calculate()
        {
            int sum = 0;
            for (int i = -10; i <= 10; i++)
            {
                if (i > 0 && i % 9 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"Сумма: {sum}");
        }
    }
}
