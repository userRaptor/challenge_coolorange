using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02_OOP
{
    internal class TaskDriver
    {
        static void Main(string[] args)
        {
            List<Task> tasks = new List<Task>();

            Task homework = new Task("Doing Homework", Priority.MAX_PRIORITY, 8);
            Task eatingLunch = new Task("Eating Lunch", Priority.MAX_PRIORITY, 2);
            Task programming = new Task("Programming", Priority.MED_PRIORITY, 5);

            tasks.Add(homework);
            tasks.Add(eatingLunch);
            tasks.Add(programming);


            Console.WriteLine("TO-DO\n-------------");

            foreach (var task in tasks)
            {
                Console.WriteLine(task);
            }

            Task highestPriorityTask = tasks[0]; 

            for (int i = 1; i < tasks.Count; i++)
            {
                if (tasks[i].CompareTo(highestPriorityTask) > 0)
                {
                    highestPriorityTask = tasks[i];
                }
            }

            Console.WriteLine("\n" + highestPriorityTask.GetName() + " is one of the most important tasks");



        }

    }
}
