# challenge_coolorange
Bewerbungschallenge

Abänderung des Rückgabewerts bei den methoden:

public static int[][] CreateRandomMatrix(int rows, int columns, int minValue, int maxValue)
    zu: public static int[,] CreateRandomMatrix(int rows, int columns, int minValue, int maxValue)

public static int[][] CopyArray(int[] array)
    zu: public static int[,] CopyArray(int[] array)

    begründung: Der Testfall erwartet ein rechteckiges Array(2D-Array) int[,] und kein jagged Array int[][]
    Die Methode: GetLength(int dimension) im testfall funktioniert nur bei rechteckige Ararys. Für jagged arrays müsste sie heißen: array[index].Length
