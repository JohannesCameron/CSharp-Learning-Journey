using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Celsius to Fahrenheit converter");
            Console.WriteLine();

            Console.WriteLine("How many degrees Celsius is it? ");
            double temp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            temp = (temp * 9 / 5) + 32;

            Console.WriteLine("It is " + temp + " degrees Fahrenheit");
        }
    }
}
