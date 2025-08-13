using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grade Checker app!");

            Console.Write("What was your score on your exam? ");
            int score = Convert.ToInt32(Console.ReadLine());

            if (score > 80)
            {
                Console.WriteLine("Your grade is 'A'");
            }
            else if (score > 70 && score < 79)
            {
                Console.WriteLine("Your grade is 'B'");
            }
            else if (score > 60 && score < 69)
            {
                Console.WriteLine("Your grade is 'C'");
            }
            else if (score > 50 && score < 59)
            {
                Console.WriteLine("Your grade is 'D'");
            }
            else
            {
                Console.WriteLine("Your grade is 'F'");
            }
        }
    }
}
