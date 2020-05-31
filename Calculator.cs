using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Calculator
{
    public class Calculator
    {
        public int valueOne { get; set; }
        public int valueTwo { get; set; }
       
        public double Plus(int a, int b)
        {
            return a + b;
        }
        public double Difference(int a, int b)
        {
            return a - b;
        }
        public double Multiplication(int a, int b)
        {
            return a * b;
        }
        public double Division(int a, int b)
        {
            if (b != 0)
                return (double)a / b;
            else
                return 0;

        }
    }
}
