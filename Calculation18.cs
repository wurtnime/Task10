using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0305
{
    class Calculation18
    {
        private bool IsPrime(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }

        public void Calculate()
        {
            int count = 0;
            int num = 2;
            while (count < 100)
            {
                if (IsPrime(num))
                {
                    Console.WriteLine(num);
                    count++;
                }
                num++;
            }
        }
    }
}
