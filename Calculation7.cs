using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0305
{
    class Calculation7
    {
        public void Calculate()
        {
            Console.Write("Введите число: ");
            int num = int.Parse(Console.ReadLine());
            bool isPowerOfTwo = (num > 0) && ((num & (num - 1)) == 0);
            Console.WriteLine(isPowerOfTwo ? "Да" : "Нет");
        }
    }
}
