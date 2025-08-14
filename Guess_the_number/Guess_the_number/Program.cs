using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_the_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the number game");
            Console.WriteLine();

            bool isGuessTrue = false;

            while (isGuessTrue == false)
            {
                Random rnd = new Random();
                int randomNum = rnd.Next(1, 21);

                //Console.WriteLine(randomNum);
                Console.Write("Guess a number(1-10): ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num == randomNum)
                {
                    Console.WriteLine("Correct! You win!!");
                    break;
                }
                else
                {
                    Console.WriteLine("Guess again!");
                    continue;
                }
            }
        }
    }
}
