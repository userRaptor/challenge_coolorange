using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coolOrange_CandidateChallenge
{
    enum Priority
    {
        MIN_PRIORITY = 1,
        MED_PRIORITY = 5,
        MAX_PRIORITY = 10
    }

    internal interface IPriority
    {
        void SetPriority(Priority priority);

        Priority GetPriority();
    }

    internal interface IComplexity
    {
        void SetComplexity();
        void GetComplexity();

    }

    internal class Task : IPriority, IComplexity, IComparable
    {
        private string name;
        private Priority priority;
        private int complexity;

        public Task(string name, Priority priority, int complexity)
        {
            this.name = name;
            this.priority = Priority.MED_PRIORITY;
            this.complexity = complexity;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Task otherTask = obj as Task;
            if (otherTask != null)
            {
                // Vergleich der Prioritäten der Tasks
                return this.GetPriority().CompareTo(otherTask.GetPriority());
            }
            else
            {
                throw new ArgumentException("Object is not a Task");
            }
        }

        public void GetComplexity()
        {
            throw new NotImplementedException();
        }

        public Priority GetPriority()
        {
            throw new NotImplementedException();
        }

        public void SetComplexity()
        {
            throw new NotImplementedException();
        }

        public void SetPriority(Priority priority)
        {
            throw new NotImplementedException();
        }
    }
}
