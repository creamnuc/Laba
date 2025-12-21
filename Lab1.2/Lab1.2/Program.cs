using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._2
{
    internal class Program
    {
        public class Calculator
        {
            public double add(double a, double b)
            {
                return a + b;
            }

            public double subtract(double a, double b)
            {
                return a - b;
            }

            public double multiply(double a, double b)
            {
                return a * b;
            }

            public double divide(double a, double b)
            {
                if (b == 0)
                    throw new Exception("Нельзя делить на ноль!");

                return a / b;
            }

            public double power(double number, double exponent)
            {
                return Math.Pow(number, exponent);
            }
        }

    }
}

