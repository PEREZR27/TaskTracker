using System;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TaskTracker
{
    class Program
    {
        static void Main(string[] args)
        {
 
            Console.WriteLine("**************************************************");
            Console.WriteLine("|                 My To Do List                  |");
            Console.WriteLine("**************************************************\n");
            
            
            Console.WriteLine("Write a list of task");
            Console.WriteLine("1.Add Task\n2.View List\n3.Quit");

            List<string> Tasks = new List<string>();
            programStart(Tasks);
        }

        public static void programStart(List<string> Tasks)
        {
            do
            {
                int commands = int.Parse(Console.ReadLine());
                switch (commands)
                {
                    case 1:
                        AddTask(Tasks);
                        break;
                    case 2:
                        ViewTask(Tasks);
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;

                }
            }
            while (Tasks.Count != 0);
            Console.WriteLine("List Complete!");
        }

        public static void ViewTask(List<string> Tasks)
        {
            Tasks.ForEach(Console.WriteLine);
        }

        public static void AddTask(List<string> Tasks)
        {
           do
            {
                Console.WriteLine("Add a Task to your existing list\n");
                Console.WriteLine("Enter nothing to exit");
                Tasks.Add($"{Console.ReadLine()}");
            }
            while (Console.ReadLine() != "") ;
        }
    }
}

