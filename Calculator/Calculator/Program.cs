using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator app!");

            Console.Write("Enter your first number: ");
            double firstNum = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your second number: ");
            double secondNum = Convert.ToDouble(Console.ReadLine());

            Console.Write("Choose your operation(+, -, *, /): ");
            char operation = Convert.ToChar(Console.ReadLine());

            if (operation == '+')
            {
                var output = firstNum + secondNum;
                Console.WriteLine($"Result = {output}");
            }
            else if (operation == '-')
            {
                var output = firstNum - secondNum;
                Console.WriteLine($"Result = {output}");
            }
            else if (operation == '*')
            {
                var output = firstNum * secondNum;
                Console.WriteLine($"Result = {output}");
            }
            else if (operation == '/')
            {
                var output = firstNum / secondNum;
                Console.WriteLine($"Result = {output}");
            }
        }
    }
}
