using System;
using System.Collections.Generic;

namespace Phonebook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> phonebook = new Dictionary<string, int>();
            bool again = true;

            while (again)
            {
                Console.WriteLine("1. Add a contact");
                Console.WriteLine("2. Search for a contact");
                Console.WriteLine("3. Remove a contact");
                Console.WriteLine("4. View all contacts");
                Console.WriteLine("5. Exit");
                Console.WriteLine();

                Console.Write("Enter choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (choice == 1)
                {
                    Console.Write("Enter name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine();

                    Console.Write("Enter number: ");
                    int number = Convert.ToInt32(Console.ReadLine());

                    phonebook[name] = number;
                }
                else if (choice == 2)
                {
                    Console.Write("Enter name: ");
                    string name = Console.ReadLine();

                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine(name + " " + phonebook[name]);
                    }
                    else
                    {
                        Console.WriteLine("Name not found");
                    }
                    Console.WriteLine();
                }
                else if (choice == 3)
                {
                    Console.Write("Enter a name: ");
                    string name = Console.ReadLine();

                    phonebook.Remove(name);
                    Console.WriteLine();
                }
                else if (choice == 4)
                {
                    foreach (var entry in phonebook)
                    {
                        Console.WriteLine($"{entry.Key} - {entry.Value}");
                    }
                }
                else if (choice == 5)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Input a vaild option");
                }
            }
        }
    }
}
