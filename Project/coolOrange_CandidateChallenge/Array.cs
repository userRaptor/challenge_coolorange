using System;

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
            if (array == null || array.Length == 0 || position1 > position2 || position1 < 0 || position2 > array.Length - 1)
            {
                throw new ArgumentException("error in input");
            }

            Console.WriteLine(string.Join(", ", array));

            for (int i = position1; i < position2; i++)
            {
                array[i] = array[i + 1];
            }

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
				randomArray[i] = rnd.Next(minValue, maxValue);
			}

			return randomArray;
		}

		public static int[][] CreateRandomMatrix(int rows, int columns, int minValue, int maxValue)
		{
			throw new NotImplementedException();
		}

		public static int[][] CopyArray(int[] array)
		{
			throw new NotImplementedException();
		}

		public static int FindInSortedArray(int[] array, int number)
		{
			throw new NotImplementedException();
		}

	}
}
