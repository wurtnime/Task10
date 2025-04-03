using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0305
{
    class Calculation22
    {
        public void Calculate()
        {
     
            Console.Write("Введите число m: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Введите число n: ");
            int n = int.Parse(Console.ReadLine());
            
            int difference = n - m;
            int squareDifference = difference * difference;
         
            Console.WriteLine($"Квадрат разности чисел от {m} до {n}: {squareDifference}");
        }
    }
}
