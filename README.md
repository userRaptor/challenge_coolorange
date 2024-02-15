# Bewerbungschallenge CoolOrange


<!--## Explanation of the solution: -->

## Structure:
In this project, there are 3 project folders:
+ Assignment02_OOP
+ coolOrange_CandidateChallenge
+ coolOrange_CandidateChallengeTest

The Folder "Assignment02_OOP" implements the task "Object-Oriented Programming (OOP)". The main function is in the file TaskDriver.cs.

The Folder "coolOrange_CandidateChallenge" implements the tasks "Basic Operations" and "Recursion". The main function is in the file Program.cs. Also included in this project folder is the file "Task.cs" from the Task "OOP" so that we can test it. See [Problems](#problems).

The Folder "coolOrange_CandidateChallengeTest" implements all the unit tests.



## How to run it:
To run the project, we need the .NET Framework. For the tasks "Basic Operations" and "Recursion," and for the unit tests, it is enough to use .NET version 4.8. However, for the task "Object-Oriented Programming (OOP)," we need .NET version 8.0. Why this is the case, read the [Problems](#problems) section.


## Problems:
Unfortunately, I was not able to create a new project for the task "Object-Oriented Programming (OOP)" with .NET version 4.8. For me, it was only possible to create a new project with .NET version 8.0. So, the project folder "Assignment02_OOP" runs only with .NET version 8.0.

***
The project folder **"Assignment02_OOP"** works with the Framework version .NET 8.0.
Due to the different .NET versions used in the coolOrange_CandidateChallengeTest and Assignment02_OOP project folders, it is impossible to test the Task.cs class in coolOrange_CandidateChallengeTest.
Therefore, I decided to put a copy of the Task.cs class into the coolOrange_CandidateChallenge folder.



## Notes:
In the file Array.cs, I changed the return value of the following two methods:

    public static int[,] CreateRandomMatrix(int rows, int columns, int minValue, int maxValue) { ... }

    public static int[,] CopyArray(int[] array) { ... }

This is because the UnitTests expect a rectangular array (2D array) int[,] and not a jagged array int[][]. We can see this because the method **"GetLength(int dimension)"** in the test file works only for rectangular arrays. For a jagged array, the name must be instead **"array[index].Length"**.

***
***
[Project Link](https://)

### HOFER Lukas





