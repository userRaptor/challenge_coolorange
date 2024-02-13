using System;

namespace coolOrange_CandidateChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 3, 1, 4, 0, 5, 9, 2, 6 };
            
            Console.WriteLine("\nExercise 01:");
            int maxValue = Array.FindMaxValue(myArray, 0, myArray.Length-1);
            Console.WriteLine($"maximum value: {maxValue}");

            Console.WriteLine("\nExercise 02:");
            int posMin = Array.FindMinPosition(myArray, 0, myArray.Length - 1);
            Console.WriteLine($"position of the minimum: {posMin}");

            Console.WriteLine("\nExercise 03:");
            Array.Swap(myArray, 0, myArray.Length - 1);

            Console.WriteLine("\nExercise 04:");
            Array.ShiftLeftByOne(myArray, 3, myArray.Length - 1);

            //Console.ReadLine();
        }
    }
}
