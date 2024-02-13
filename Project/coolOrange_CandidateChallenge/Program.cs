using System;
using System.Diagnostics.SymbolStore;

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
            int[] shiftArray = { 1, 2, 5, 3, 7, 9, 10 };
            Array.ShiftLeftByOne(shiftArray, 0, 5);

            Console.WriteLine("\nExercise 05:");
            int[] randomArray = Array.CreateRandomArray(8, 0, 9);
            Console.WriteLine(string.Join(", ", randomArray));

            Console.WriteLine("\nExercise 06:");
            int[,] randomMatrix = Array.CreateRandomMatrix(4, 4, 0, 9);

            Console.WriteLine("\nExercise 07:");
            //int[][] copyArray = Array.CopyArray(myArray);     // jagged array
            int[,] copyArray = Array.CopyArray(myArray);        // 2D-Array


            Console.WriteLine("\nExercise 08:");
            int[] sortedArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int posSortedArray = Array.FindInSortedArray(sortedArray, 9);
            Console.WriteLine(string.Join(", ", sortedArray));
            Console.WriteLine($"position of the number: {posSortedArray}");


            String phrase = "racecar";
            bool bPalindrome = PalindromeChecker.IsPalindrome(phrase);
            Console.WriteLine(bPalindrome);

            //Console.ReadLine();



        }
    }
}
