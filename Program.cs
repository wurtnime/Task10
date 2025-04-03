using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0305
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Практическая работа номер 10");
            Console.WriteLine("1 - 30");
            int input = Convert.ToInt32(Console.ReadLine());

            int a, n, x, m;
            switch (input)
            {
                case 1:
                    Console.WriteLine("Введите целое число:");
                     a = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите целую степень:");
                     n = Convert.ToInt32(Console.ReadLine());

                    Calculation1 calculator1 = new Calculation1();
                    double pow = calculator1.Calculator(a, n);

                    Console.WriteLine($"Число А в степени N: {pow}");
                    Console.ReadLine();

                    break;

                case 2:
                    Console.WriteLine("Введите целое число");
                     n = int.Parse(Console.ReadLine());

                    Calculation2 calculator2 = new Calculation2();
                    long  factorial = calculator2.CalculateFactorial((int)n);

                    Console.WriteLine($"Фаркториал {n} = {factorial}");
                    Console.ReadLine();

                    break;

                case 3:

                    Calculation3 calculator3 = new Calculation3();
                    calculator3.Calculate();

                    break;

                case 4:

                    Calculation4 calculator4 = new Calculation4();
                    calculator4.Calculate();

                    break; 

                case 5:
                    Calculation5 calculator5 = new Calculation5();
                    calculator5.Calculate();

                    break;

                case 6:

                    Calculation6 calculator6 = new Calculation6();
                    calculator6.Calculate();

                    break;

                case 7:

                    Calculation7 calculator7 = new Calculation7();
                    calculator7.Calculate();

                    break;

                case 8:

                    Calculation8 calculator8 = new Calculation8();
                    calculator8.Calculate();

                    break;

                case 9:
                    Calculation9 calculator9 = new Calculation9();
                    calculator9.Calculate();
                    break;

                case 10:
                    Calculation10 calculator10 = new Calculation10();
                    calculator10.Calculate();
                    break;

                case 11:
                    Calculation11 calculator11 = new Calculation11();
                    calculator11.Calculate();
                    break;

                case 12:
                    Calculation12 calculator12 = new Calculation12();
                    calculator12.Calculate();
                    break;

                case 13:
                    Calculation13 calculator13 = new Calculation13();
                    calculator13.Calculate();
                    break;

                case 14:
                    Calculation14 calculator14 = new Calculation14();
                    calculator14.Calculate();
                    break;

                case 15:

                    Calculation15 calculator15 = new Calculation15();
                    calculator15.Calculate();
                    break;

                case 16:
                    Calculation16 calculator16 = new Calculation16();
                    calculator16.Calculate();
                    break;

                case 17:
                    Calculation17 calculator17 = new Calculation17();
                    calculator17.Calculate();
                    break;

                case 18:
                    Calculation18 calculator18 = new Calculation18();
                    calculator18.Calculate();
                        break;

                case 19:
                    Calculation19 calculator19 = new Calculation19();
                    calculator19.Calculate();
                    break;

                case 20:
                    Calculation20 calculation20 = new Calculation20();
                    calculation20.Calculate();
                    break;

                case 21:
                    Calculation21 calculation21 = new Calculation21();
                    calculation21.Calculate();
                    break;

                case 22:
                    Calculation22 calculation22 = new Calculation22();
                    calculation22.Calculate();
                    break;

                case 23:
                    Calculation23 calculation23 = new Calculation23();
                    calculation23.Calculate();
                    break;

                case 24:
                    Calculation24 calculation24 = new Calculation24();
                    calculation24.Calculate();
                    break;

                case 25:
                    Calculation25 calculation25 = new Calculation25();
                    calculation25.Calculate();
                    break;

                case 26:
                    Calculation26 calculation26 = new Calculation26();
                    calculation26.Calculate();
                    break;

                case 27:
                    Calculation27 calculation27 = new Calculation27();
                    calculation27.Calculate();
                    break;

                case 28:
                    Calculation28 calculation28 = new Calculation28();
                    calculation28.Calculate();
                    break;

                case 29:
                    Calculation29 calculation29 = new Calculation29();
                    calculation29.Calculate();
                    break;

                case 30:
                    Calculation30 calculation30 = new Calculation30();
                    calculation30.Calculate();
                    break;
            }
        }
    }
}