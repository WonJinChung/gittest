using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Calculator
    {
        static double Adder(double a, double b)
        {
            return a + b;
        }
        static double Substrater(double a, double b)
        {
            return a - b;
        }
        static double Multiplier(double a, double b)
        {
            return a * b;
        }
        static double Divider(double a, double b)
        {
            return a / b;
        }
        static double Reciprocator(double a)
        {
            return Divider(1, a);
        }
        static double Modulus(double a, double b)
        {
            return a % b;
        }
        static double Interpreter(string test)
        {
            double Result = 0;
            // 연산우선순위 stack infix?
            return Result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string test;
            //test = "Hello World!";
            test = Console.ReadLine();
            Console.WriteLine(test);
        }
    }
}
