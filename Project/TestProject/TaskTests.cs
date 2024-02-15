using Assignment02_OOP;
using NUnit.Framework;

namespace Assignment02_OOP
{
    [TestFixture]
    public class TaskTests
    {

        [Test]
        public void Task_CompareTo_Greater_Test()
        {
            Task task1 = new Task("Task 1", Priority.MED_PRIORITY);
            Task task2 = new Task("Task 2", Priority.MED_PRIORITY);

            task1.SetPriority(Priority.MAX_PRIORITY);
            task2.SetPriority(Priority.MIN_PRIORITY);

            // x1 <  x2 return -1
            // x1 == x2 return  0
            // x1 >  x2 return  1

            int comparisonResult = task1.CompareTo(task2);

            Assert.AreEqual(1, comparisonResult);
        }

        [Test]
        public void Task_CompareTo_Smaller_Test()
        {
            Task task1 = new Task("Task 1", Priority.MED_PRIORITY);
            Task task2 = new Task("Task 2", Priority.MED_PRIORITY);

            task1.SetPriority(Priority.MIN_PRIORITY);
            task2.SetPriority(Priority.MAX_PRIORITY);

            int comparisonResult = task1.CompareTo(task2);

            Assert.AreEqual(-1, comparisonResult);
        }

        [Test]
        public void Task_CompareTo_Even_Test()
        {
            Task task1 = new Task("Task 1", Priority.MED_PRIORITY);
            Task task2 = new Task("Task 2", Priority.MED_PRIORITY);

            task1.SetPriority(Priority.MAX_PRIORITY);
            task2.SetPriority(Priority.MAX_PRIORITY);

            int comparisonResult = task1.CompareTo(task2);

            Assert.AreEqual(0, comparisonResult);
        }

        [Test]
        public void Task_CompareTo_Null_Test()
        {
            Task task1 = new Task("Task 1", Priority.MED_PRIORITY);
            Task task2 = new Task("Task 2", Priority.MED_PRIORITY);

            task1.SetPriority(Priority.MAX_PRIORITY);
            task2.SetPriority(Priority.MAX_PRIORITY);

            Assert.Throws<ArgumentException>(() => task1.CompareTo(null));
        }

        [Test]
        public void Task_ToString_Test()
        {
            Task task1 = new Task("TaskX", Priority.MED_PRIORITY);
            Assert.AreEqual("TaskX priority: 5 complexity: 0", task1.ToString());
        }

    }
}
