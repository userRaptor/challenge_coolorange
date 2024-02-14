using System;

namespace coolOrange_CandidateChallenge
{
    public enum Priority
    {
        MIN_PRIORITY = 1,
        MED_PRIORITY = 5,
        MAX_PRIORITY = 10
    }

    internal interface IPriority
    {
        void SetPriority(Priority priority);

        int GetPriority();
    }

    internal interface IComplexity
    {
        void SetComplexity(int complexity);
        int GetComplexity();

    }

    public class Task : IPriority, IComplexity, IComparable
    {
        private string name;
        private Priority priority;
        private int complexity;

        public Task(string name, Priority priority)
        {
            this.name = name;
            this.priority = Priority.MED_PRIORITY;
        }

        public void SetPriority(Priority priority)
        {
            this.priority = priority;
        }

        public int GetPriority()
        {
            return (int)this.priority;
        }

        public void SetComplexity(int complexity)
        {
            this.complexity = complexity;
        }

        public int GetComplexity()
        {
            return this.complexity;
        }

        public string GetName()
        {
            return name;
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
                return 1;

            // Typumwandlung mit Überprüfung auf null
            var compareTask = obj as Task;
            if (compareTask == null)
                throw new ArgumentException("Object is not of type Task.");

            return this.GetPriority().CompareTo(compareTask.GetPriority());
        }



        public override string ToString()
        {
            return $"{name} priority: {(int)priority} complexity: {complexity}";
        }

    }
}
