# Bewerbungschallenge CoolOrange

+ (i) an explanation of your solution to the problem, 
+ (ii) the C# code, in a form that we can run it, 
+ (iii) instructions how to run it. Also put
the source code into your solution document.


## Explanation:


## How to run it:


## Notes:
In the file Array.cs I changed the return value at the following two methods:

    public static int[][] CreateRandomMatrix(int rows, int columns, int minValue, int maxValue) { ... }

    public static int[][] CopyArray(int[] array) { ... }

to **int[,]**.

This is, because the UnitTests expect a rectangular array(2D array) int[,] and not a jagged array int[][]. we can see this, because the Method **"GetLength(int dimension)"** in the testfile works only for rectangular array. For a jagged Array the name must be instead **"array[index].Length"**.


