using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class Calculator : ICalculator
    {
        public double Addition(long a, long b)
        {
            return a + b;
        }
        public double Subtraction(long a, long b)
        {
            return a - b;
        }
        public double Multiplication(long a, long b)
        {
            return a * b;
        }
        public double Division(long a, long b)
        {
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
        }

    }
}
