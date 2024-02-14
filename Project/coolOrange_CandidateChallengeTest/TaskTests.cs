using coolOrange_CandidateChallenge;
using NUnit.Framework;
using System.Threading.Tasks;

namespace coolOrange_CandidateChallenge
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
            task1.SetPriority(Priority.MIN_PRIORITY);

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
            task1.SetPriority(Priority.MAX_PRIORITY);

            int comparisonResult = task1.CompareTo(task2);

            Assert.AreEqual(-1, comparisonResult);
        }

        [Test]
        public void Task_CompareTo_Even_Test()
        {
            Task task1 = new Task("Task 1", Priority.MED_PRIORITY);
            Task task2 = new Task("Task 2", Priority.MED_PRIORITY);

            task1.SetPriority(Priority.MAX_PRIORITY);
            task1.SetPriority(Priority.MAX_PRIORITY);

            int comparisonResult = task1.CompareTo(task2);

            Assert.AreEqual(0, comparisonResult);
        }

    }
}
