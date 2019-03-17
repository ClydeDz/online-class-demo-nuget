using System;
using OnlineClassDemo.Helper;

namespace OnlineClassDemo
{
    public class Calculator
    {
        public static int Add(int a, int b)
        {
            return CalculatorHelper.AddHelper(a, b);
        }              

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static int Divide(int a, int b)
        {
            return a / b;
        }
    }
}
