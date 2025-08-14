using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Favourite_movie_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] movies = {"(1) Spider-Man", "(2) Wall-E", "(3) Real Steel", "(4) Big Hero 6", "(5) Attack On Titan"};

            foreach (string movie in movies)
            {
                Console.WriteLine(movie);
            }

            Console.Write("Pick a movie by typing in its corresponding number: ");
            int index = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(movies[index - 1]);
        }
    }
}
