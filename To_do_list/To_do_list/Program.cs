using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_do_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> tasks = new List<string>();

            bool exit = false;

            while (exit == false)
            {
                Console.WriteLine("Please select one: ");
                Console.WriteLine();

                Console.WriteLine("1. Add a task");
                Console.WriteLine("2. Remove a task");
                Console.WriteLine("3. View all tasks");
                Console.WriteLine("4. Exit");
                Console.WriteLine();

                Console.Write("Choose an option: ");
                int option = Convert.ToInt32(Console.ReadLine());

                if (option == 1)
                {
                    Console.WriteLine("Adding a new task: ");
                    Console.WriteLine();

                    Console.Write("Enter task: ");
                    tasks.Add(Console.ReadLine());

                    Console.WriteLine("Task added!");
                }
                else if (option == 2)
                {
                    Console.WriteLine("Removing a task: ");
                    Console.WriteLine();

                    Console.Write("Enter task number of the task you want to remove: ");
                    tasks.RemoveAt(Convert.ToInt32(Console.ReadLine()) - 1);

                    Console.WriteLine("Task removed!");
                }
                else if (option == 3)
                {
                    Console.WriteLine("All items in list: ");
                    Console.WriteLine();

                    foreach (string task in tasks)
                    {
                        Console.WriteLine(task);
                    }
                }
                else if (option == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please input a valid option");
                }
            }
        }
    }
}
