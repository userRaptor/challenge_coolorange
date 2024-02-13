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
			throw new NotImplementedException();
		}

		public static void Swap(int[] array, int position1, int position2)
		{
			throw new NotImplementedException();
		}

		public static void ShiftLeftByOne(int[] array, int position1, int position2)
		{
			throw new NotImplementedException();
		}

		public static int[] CreateRandomArray(int size, int minValue, int maxValue)
		{
			throw new NotImplementedException();
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
