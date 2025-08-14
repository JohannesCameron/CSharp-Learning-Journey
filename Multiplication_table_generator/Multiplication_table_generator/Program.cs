using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_table_generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Time table generator");
            Console.WriteLine();

            bool again = true;

            while (again)
            {
                Console.Write("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                for (int i = 1; i < 11; i++)
                {
                    Console.WriteLine($"{num} x {i} = {num * i}");
                }
                Console.WriteLine();
                Console.Write("Do you want to do another number? (yes/no): ");
                string input = Console.ReadLine();

                if (input == "yes")
                {
                    again = true;
                }
                else if (input == "no")
                {
                    again = false;
                }
                else
                {
                    Console.WriteLine("Incorrect input, try again!");
                    again = true;
                }
                
            }
        }
    }
}
