using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace zadDom3._2
{
    class GetData
    {
        public void GetValues(out double a, out double b)
        {
            Console.Write("Wybierz pierwszą wartość: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Wybierz drugą wartość: ");
            b = Convert.ToInt32(Console.ReadLine());
        }
    }
    static class Calc1
    {
        public static double Addition(double a, double b)
        {
            return a + b;
        }
        public static double Substraction(double a, double b)
        {
            return a - b;
        }
        public static double Multiplication(double a, double b)
        {
            return a * b;
        }
        public static double Division(double a, double b)
        {
            return a / b;
        }
        public static double Pow(double a)
        {
            return a * a;
        }
        public static double Power(double a)
        {
            return a * a * a;
        }
        public static double Powerr(double a, double b)
        {
            return Math.Pow(a, b);
        }
        static void Main(string[] args)
        {
            double a,b;
            GetData values = new GetData();
            values.GetValues(out a, out b);
            Console.WriteLine();
            Console.Write("Wybierz działanie:\n 1. Addition \n 2. Substraction \n 3. Multiplication \n 4. Division \n 5.Druga potęga \n 6.Trzecia potęga \n 7.Dowolna potęga \n");
            Console.WriteLine();
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Wynik dodawania: " + Calc1.Addition(a, b));
                    break;
                case "2":
                    Console.WriteLine("Wynik odejmowania: " + Calc1.Substraction(a, b));
                    break;
                case "3":
                    Console.WriteLine("Wynik mnożenia: " + Calc1.Multiplication(a, b));
                    break;
                case "4":
                    if (b == 0)
                        Console.WriteLine("Nie dzielimy przez 0!");
                    else
                        Console.WriteLine("Wynik dzielenia: " + Calc1.Division(a, b));
                    break;
                case "5":
                    Console.WriteLine("Wynik potęgowania (2 potęga): " + Calc1.Pow(a));
                    break;
                case "6":
                    Console.WriteLine("Wynik potęgowania (3 potęga): " + Calc1.Power(a));
                    break;
                case "7":
                    Console.WriteLine("Wynik potęgowania (potęga dowolna): " + Math.Pow(a, b));
                    break;
                default:
                    Console.WriteLine("Nie wybrano działania!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
