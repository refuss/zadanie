using System;

namespace zadDom3._2
{
    class Calculator
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
            if (b == 0)
            {
                Console.Write("Nie dzielimy przez 0!");
            }
            return a / b;
        }
    }
    
    class Program
    {
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
            Console.Write("Wybierz działanie:\n 1. Addition \n 2. Substraction \n 3. Multiplication \n 4. Division \n");
            Calculator kalkulator = new Calculator();
            kalkulator.Addition(a, b);
            kalkulator.Substraction(a, b);
            kalkulator.Multiplication(a, b);
            kalkulator.Division(a, b);
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Wynik dodawania: " + (a + b));
                    break;
                case "2":
                    Console.WriteLine("Wynik odejmowania: " + (a - b));
                    break;
                case "3":
                    Console.WriteLine("Wynik mnożenia: " + (a * b));
                    break;
                case "4":
                    if (b == 0)
                        Console.WriteLine("Nie dzielimy przez 0!");
                    else
                        Console.WriteLine("Wynik dzielenia: " + (a / b));
                    break;
                default:
                    Console.WriteLine("Nie wybrano działania!");
                    break;
            }
                    Console.ReadKey();
        }
    }
}
