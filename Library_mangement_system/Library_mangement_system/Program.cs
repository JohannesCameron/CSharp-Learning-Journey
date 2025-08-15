using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_mangement_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> bookValues = new Dictionary<string, List<string>>();

            bookValues["Action"] = new List<string>();
            bookValues["Mystery"] = new List<string>();
            bookValues["Thriller"] = new List<string>();
            bookValues["Romance"] = new List<string>();

            bool again = true;

            while (again)
            {
                Console.WriteLine("Library management system");
                Console.WriteLine();

                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. View Genre");
                Console.WriteLine("3. Remove Book");
                Console.WriteLine("4. View All");
                Console.WriteLine("5. Exit");
                Console.WriteLine();

                Console.Write("Your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (choice == 1)
                {
                        Console.Write("Enter the game of the book: ");
                        string bookName = Console.ReadLine();
                        Console.WriteLine();

                        Console.WriteLine("Pick a genre(type the name)");
                        Console.WriteLine();

                        Console.WriteLine("1. Action");
                        Console.WriteLine("2. Mystery");
                        Console.WriteLine("3. Thriller");
                        Console.WriteLine("4. Romance");
                        Console.WriteLine();

                        Console.Write("Your choice: ");
                        string genreChoice = Console.ReadLine();

                        bookValues[genreChoice].Add(bookName);

                        continue;
                }
                else if (choice == 2)
                {
                        Console.WriteLine("Pick a genre(type the name)");
                        Console.WriteLine();

                        Console.WriteLine("1. Action");
                        Console.WriteLine("2. Mystery");
                        Console.WriteLine("3. Thriller");
                        Console.WriteLine("4. Romance");
                        Console.WriteLine();

                        Console.Write("Your choice: ");
                        string genreChoice = Console.ReadLine();
                        Console.WriteLine();

                        foreach (var book in bookValues[genreChoice])
                        {
                            Console.WriteLine(book);
                        }
                        Console.WriteLine();
                        continue;
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Pick a genre(type the name)");
                    Console.WriteLine();

                    Console.WriteLine("1. Action");
                    Console.WriteLine("2. Mystery");
                    Console.WriteLine("3. Thriller");
                    Console.WriteLine("4. Romance");
                    Console.WriteLine();

                    Console.Write("Your choice: ");
                    string genreChoice = Console.ReadLine();
                    Console.WriteLine();

                    Console.WriteLine("Books in genre");
                    foreach (var book in bookValues[genreChoice])
                    {
                        Console.WriteLine(book);
                    }
                    Console.WriteLine();

                    Console.Write("Type the name of book you want to remove: ");
                    string removeChoice = Console.ReadLine();
                    bookValues[genreChoice].Remove(removeChoice);
                }
                else if (choice == 4)
                {
                    foreach (var genre in bookValues)
                    {
                        Console.WriteLine(genre.Key + ":");
                        foreach (var book in genre.Value)
                        {
                            Console.WriteLine(" - " + book);
                        }
                    }
                    continue;
                }
                else if (choice == 5)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("PLease select a valid number!");
                    continue;
                }
            }

        }
    }
}
