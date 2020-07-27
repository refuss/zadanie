using System;

namespace zadDom3._2
{
    class Calc1
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }
        public double Substraction(int a, int b)
        {
            return a - b;
        }
        public int Multiplication(int a, int b)
        {
            return a * b;
        }
        public float Division(int a, int b)
        {
            return a / b;
        }
    }

    class Calculator
    {
        //public double Sqrt(double a)
        //{
        //    return Sqrt(a);
        //}
        public double Pow(double a, double b)
        {
            return Math.Pow(a, 2.0);
        }
        public double Power(double a, double b)
        {
            return Math.Pow(a, 3.0);
        }
        public double Powerr(double a, double b)
        {
            return Math.Pow(a, b);
        }
    
        static void Main(string[] args)
        {
            Console.Write("Wybierz pierwszą wartość: ");
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Wybierz drugą wartość: ");
            int b;
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            
            Calc1 kalkulator = new Calc1();
            kalkulator.Addition(a, b);
            kalkulator.Substraction(a, b);
            kalkulator.Multiplication(a, b);
            if (b == 0)
            {
                Console.WriteLine("Nie dzielimy przez 0!");
            }
            else
            {
                kalkulator.Division(a, b);
            }
            //kalkulator.Sqrt(a);
            Calculator kalkulator2 = new Calculator();
            kalkulator2.Pow(a, 2.0);
            kalkulator2.Power(a, 3.0);
            kalkulator2.Powerr(a, b);
            Console.Write("Wybierz działanie:\n 1. Addition \n 2. Substraction \n 3. Multiplication \n 4. Division \n 5.Druga potęga \n 6.Trzecia potęga \n 7.Dowolna potęga \n");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Wynik dodawania: " + kalkulator.Addition(a,b));
                    break;
                case "2":
                    Console.WriteLine("Wynik odejmowania: " + kalkulator.Substraction(a,b));
                    break;
                case "3":
                    Console.WriteLine("Wynik mnożenia: " + kalkulator.Multiplication(a,b));
                    break;
                case "4":
                    if (b == 0)
                        Console.WriteLine("Nie dzielimy przez 0!");
                    else
                        Console.WriteLine("Wynik dzielenia: " + kalkulator.Division(a,b));
                    break;
                case "5":
                    Console.WriteLine("Wynik potęgowania (2 potęga): " + Math.Pow(a, 2.0));
                    break;
                case "6":
                    Console.WriteLine("Wynik potęgowania (3 potęga): " + Math.Pow(a, 3.0));
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
