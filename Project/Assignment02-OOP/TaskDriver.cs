using System;

namespace Assignment02_OOP
{
    public class TaskDriver
    {
        static void Main(string[] args)
        {
            List<Task> tasks = new List<Task>();

            Task homework = new Task("Doing Homework", Priority.MAX_PRIORITY);
            Task programming = new Task("Programming", Priority.MED_PRIORITY);
            Task eatingLunch = new Task("Eating Lunch", Priority.MIN_PRIORITY);
            

            tasks.Add(homework);
            tasks.Add(programming);
            tasks.Add(eatingLunch);
            

            homework.SetComplexity(8);
            homework.SetPriority(Priority.MAX_PRIORITY);

            programming.SetComplexity(5);
            programming.SetPriority(Priority.MED_PRIORITY);

            eatingLunch.SetComplexity(2);
            eatingLunch.SetPriority(Priority.MIN_PRIORITY);

            


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
