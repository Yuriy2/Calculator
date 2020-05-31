using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to calculator !!!");
            Console.WriteLine("Enter Value One: ");
            int.TryParse(Console.ReadLine(), out int val1);
            Console.WriteLine("Enter Value Two: ");
            int.TryParse(Console.ReadLine(), out int val2);

            Console.WriteLine($"Sum: {Plus(val1, val2)}");
            Console.WriteLine($"Difference: {Difference(val1, val2)}");
            Console.WriteLine($"Multiplication: {Multiplication(val1, val2)}");


            if (Division(val1, val2) == 0)
                Console.WriteLine("Error: division by 0");
            else 
                Console.WriteLine($"Division: {Division(val1, val2)}");

            Console.ReadLine();
        }
        static double Plus(int a, int b)
        {
            return a + b;
        }
        static double Difference(int a, int b)
        {
            return a - b;
        }
        static double Multiplication(int a, int b)
        {
            return a * b;
        }
        static double Division(int a, int b)
        {
            if (b != 0)
                return (double)a / b;
            else
                return 0;
            
        }
    }
}
