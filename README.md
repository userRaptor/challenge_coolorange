# Bewerbungschallenge CoolOrange


<!--## Explanation of the solution: -->

## Structure:
In this project, there are 3 project folders:
+ Assignment01
+ Assignment02_OOP
+ TestProject

The Folder "Assignment01" implements the tasks "Basic Operations" and "Recursion". The main function is in the file Program.cs. 

The Folder "Assignment02_OOP" implements the task "Object-Oriented Programming (OOP)". The main function is in the file TaskDriver.cs.

The Folder "TestProject" implements all files, that are needed for the UnitTests.


## How to run it:
To run the project, we need the .NET Framework. The Project use the .NET version 8.0. Why this is the case, read the [Problems](#problems) section.

## Problems:
Unfortunately, I was not able to create a new project for the task "Object-Oriented Programming (OOP)" with the .NET version 4.8. For me, it was only possible to create a new project with .NET version 8.0. 

Since there were always conflicts between the two .NET versions 4.8 and 8.0, I decided to create the entire project using version 8.0.


## Notes:
In the file Array.cs, I changed the return value of the following two methods:

    public static int[,] CreateRandomMatrix(int rows, int columns, int minValue, int maxValue) { ... }

    public static int[,] CopyArray(int[] array) { ... }

This is because the UnitTests expect a rectangular array (2D array) int[,] and not a jagged array int[][]. We can see this because the method **"GetLength(int dimension)"** in the test file works only for rectangular arrays. For a jagged array, the name must be instead **"array[index].Length"**.

***
***
[Project Link](https://github.com/userRaptor/challenge_coolorange.git)

### HOFER Lukas





