using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0305
{
    class Calculation25
    {
        public void Calculate()
        {
            Console.Write("Введите число N: ");
            int N = int.Parse(Console.ReadLine());
            int sumOfSquares = 0;
            int squareOfSum = 0;
            for (int i = 1; i <= N; i++)
            {
                sumOfSquares += i * i;
                squareOfSum += i;
            }
            squareOfSum *= squareOfSum;
            int difference = squareOfSum - sumOfSquares;
            Console.WriteLine($"Разность квадратов: {difference}");
        }
    }
}
