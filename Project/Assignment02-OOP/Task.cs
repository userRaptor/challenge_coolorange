using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02_OOP
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

        int GetPriority();
    }

    internal interface IComplexity
    {
        void SetComplexity(int complexity);
        int GetComplexity();

    }

    internal class Task : IPriority, IComplexity, IComparable
    {
        private string name;
        private Priority priority;
        private int complexity;

        public Task(string name, Priority priority, int complexity)
        {
            this.name = name;
            this.priority = priority;
            this.complexity = complexity;
        }

        public void SetPriority(Priority priority)
        {
            throw new NotImplementedException();
        }

        public int GetPriority()
        {
            return (int)this.priority;
        }

        public void SetComplexity(int complexity)
        {
            throw new NotImplementedException();
        }

        public int GetComplexity()
        {
            throw new NotImplementedException();
        }

        public string GetName()
        {
            return name;
        }


        public int CompareTo(object obj)
        {
            Task compareTask = obj as Task;
            return this.GetPriority().CompareTo(compareTask.GetPriority());
        }




        public override string ToString()
        {
            return $"{name} priority: {(int)priority} complexity: {complexity}";
        }

    }
}
