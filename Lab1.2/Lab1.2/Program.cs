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
            public double Add(double a, double b)
            {
                return a + b;
            }

            public double Subtract(double a, double b)
            {
                return a - b;
            }

            public double Multiply(double a, double b)
            {
                return a * b;
            }

            public double Divide(double a, double b)
            {
                if (b == 0)
                    throw new Exception("Нельзя делить на ноль!");

                return a / b;
            }

            public double Power(double number, double exponent)
            {
                return Math.Pow(number, exponent);
            }
        }

    }
}

