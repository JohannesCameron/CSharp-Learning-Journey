using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List_methods_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            Console.WriteLine("To do list app: ");
            Console.WriteLine();

            bool again = true;
            Console.WriteLine("Select a task below: ");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Remove Task");
            Console.WriteLine("4. Exit");

            while (again)
            {
                Console.Write("choice here: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddTask(list);
                        break;
                    case 2:
                        ViewTasks(list);
                        break;
                    case 3:
                        RemoveTask(list);
                        break;
                    case 4:
                        Exit();
                        break;
                    default:
                        Console.WriteLine("invalid input");
                        break;
                }
            }
        }

        static List<string> AddTask(List<string> list)
        {
            Console.WriteLine("Add a task: ");
            Console.WriteLine();

            Console.Write("Task: ");
            string task = Console.ReadLine();
            list.Add(task);
            return list;
        }

        static void ViewTasks(List<string> list)
        {
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }

        static List<string> RemoveTask(List<string> list)
        {
            Console.WriteLine("Remove a task: ");
            Console.WriteLine();
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Which task do you want to remove? (type the task out below)");
            string task = Console.ReadLine();

            list.Remove(task);
            return list;
        }

        static void Exit()
        {
            Environment.Exit(0);
        }
    }
}
