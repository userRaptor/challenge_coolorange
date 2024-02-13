using System;
using System.Security.Policy;

namespace coolOrange_CandidateChallenge
{
	public class Array
	{
		//ToDo

		public static int FindMaxValue(int[] array, int position1, int position2)
		{
			if (array == null || array.Length == 0 || position1 > position2 || position1 < 0 || position2 > array.Length-1)
			{
				throw new ArgumentException("error in input");
			}
			int maxValue = array[position1];
			for (int i = position1; i <= position2; i++)
			{
				if(maxValue < array[i])
				{
					maxValue = array[i];
				}
			}
			return maxValue;
        }

		public static int FindMinPosition(int[] array, int position1, int position2)
		{
            if (array == null || array.Length == 0 || position1 > position2 || position1 < 0 || position2 > array.Length - 1)
            {
                throw new ArgumentException("error in input");
            }
            int minValue = array[position1];
			int positionOfMinimum = position1;
            for (int i = position1; i <= position2; i++)
            {
                if (minValue > array[i])
                {
                    minValue = array[i];
                    positionOfMinimum = i;
                }
            }
            return positionOfMinimum;
        }

		public static void Swap(int[] array, int position1, int position2)
		{
            if (array == null || array.Length == 0 || position1 > position2 || position1 < 0 || position2 > array.Length - 1)
            {
                throw new ArgumentException("error in input");
            }
            int pos1Value = array[position1];
			int pos2Value = array[position2];

            Console.WriteLine(string.Join(", ", array));

            array[position1] = pos2Value;
			array[position2] = pos1Value;

            Console.WriteLine(string.Join(", ", array));

        }

		public static void ShiftLeftByOne(int[] array, int position1, int position2)
		{
            if (array == null || array.Length == 0 || position1 > position2 || position1 < 0 || position2 > array.Length - 1 || position2<1)
            {
                throw new ArgumentException("error in input");
            }

            Console.WriteLine(string.Join(", ", array));

            int helperPos1 = array[position1];

            for (int i = position1; i < position2; i++)
            {
                array[i] = array[i + 1];
            }

            array[position2 - 1] = helperPos1;

            Console.WriteLine(string.Join(", ", array));
        }

		public static int[] CreateRandomArray(int size, int minValue, int maxValue)
		{
            if (minValue > maxValue || size < 0)
            {
                throw new ArgumentException("error in input");
            }

            int[] randomArray = new int[size];
			Random rnd = new Random();
			for (int i = 0; i < size; i++)
			{
				randomArray[i] = rnd.Next(minValue+1, maxValue);    // The random number must be between min and max. Excluded the values min and max
            }

			return randomArray;
		}

		public static int[,] CreateRandomMatrix(int rows, int columns, int minValue, int maxValue)
		{
            if (minValue > maxValue || rows <= 0 || columns <= 0)
            {
                throw new ArgumentException("error in input");
            }

            int[,] randomMatrix = new int[rows, columns];

            Random rnd = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    randomMatrix[i, j] = rnd.Next(minValue, maxValue+1);        
                }
            }

            return randomMatrix;
        }

        public static int[,] CopyArray(int[] array)
        {
            int[,] copyArray = new int[2, array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                copyArray[0, i] = array[i];
                copyArray[1, i] = array[i];
            }

            return copyArray;
        }


        public static int FindInSortedArray(int[] array, int number)
		{
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = (left + right)/2;

                if (array[mid] == number)
                {
                    return mid;
                } else if (array[mid] < number)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;     
                }
            }

            return -1;  // target was not found
        }

	}
}
