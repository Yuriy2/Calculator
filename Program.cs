using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to calculator !!!");
            Calculator calculator = new Calculator();
            var StartCalc = true;
            while(StartCalc)
            {
                Console.WriteLine("\nEnter Value One: ");
                int.TryParse(Console.ReadLine(), out int val);
                Console.WriteLine("Enter Value Two: ");
                int.TryParse(Console.ReadLine(), out int val2);
                Console.WriteLine("Select an action: ");
                Console.WriteLine("\n1-Plus" +
                                  "\n2-Difference" +
                                  "\n3-Multiplication" +
                                  "\n4-Division" +
                                  "\n5-Exit");
                int.TryParse(Console.ReadLine(), out int select);
                switch (select)
                {
                    case 1:
                        {
                            Console.WriteLine($"Sum: {calculator.Plus(val, val2)}");

                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine($"Difference: {calculator.Difference(val, val2)}");
                            break;
                        }
                    case 3:
                        {

                            Console.WriteLine($"Multiplication: {calculator.Multiplication(val, val2)}");
                            break;
                        }
                    case 4:
                        {
                            if (calculator.Division(val, val2) == 0)
                                Console.WriteLine("Error: division by 0");
                            else
                                Console.WriteLine($"Division: {calculator.Division(val, val2)}");
                            break;
                        }
                    case 5:
                        {
                            StartCalc = false;
                            break;
                        }
                    default:
                        Console.WriteLine("Input Error !!!");
                        break;
                }

            }
            Console.WriteLine("You have left the calculator application.");
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
