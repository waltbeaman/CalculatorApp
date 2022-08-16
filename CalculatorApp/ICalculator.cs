using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    internal interface ICalculator
    {
        double Addition(long a, long b);
        double Subtraction(long a, long b);
        double Multiplication(long a, long b);
        double Division(long a, long b);
    }
}
