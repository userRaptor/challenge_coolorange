using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coolOrange_CandidateChallenge
{
    internal class TaskDriver
    {
        static void Main(string[] args)
        {
            List<Task> tasks = new List<Task>();

            Task homework = new Task("Doing Homework", Priority.MAX_PRIORITY, 8);
            Task eatingLunch = new Task("Eating Lunch", Priority.MIN_PRIORITY, 2);
            Task programming = new Task("Programming", Priority.MED_PRIORITY, 5);

            tasks.Add(homework);
            tasks.Add(eatingLunch);
            tasks.Add(programming);

            foreach (var task in tasks)
            {
                Console.WriteLine(task);
            }

        }
            
    }
}
