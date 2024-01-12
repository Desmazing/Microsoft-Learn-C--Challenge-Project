/*
Revise a C# console application that uses nested foreach loops to access array data
based on an updated feature specification.
Update the variables and if statements in a C# console application to create the code 
branches and calculations required to satisfy an updated feature specification.
*/

int examAssignments = 5;
string studentGrade = "F";
string [] studentNames = ["Alice", "Brian", "Carl", "Dean"];

decimal averageScore;

int [] aliceScores = [80,83,79,92,72,94,90];
int [] brianScores = [76,75,72,70,85,89];
int [] carlScores = [82,78,75,90,67,89,89,89];
int [] deanScores = [62,90,84,80,64,96];

Console.WriteLine($"Student\tExam Score\tOverall\tGrade\tExtra Credit");
Console.WriteLine("-------\t----------\t-------\t-----\t------------");

foreach (string student in studentNames)
{
    int [] studentScores = [0,0,0,0,0];
    decimal sumScores = 0;
    decimal examTotal = 0;
    decimal examAverage;
    decimal creditAverage = 0;
    int gradedAssignments = 0;
    int creditNumber = 0;

    if (student == "Alice")
    {
        studentScores = aliceScores;
    }
    else if (student == "Brian")
    {
        studentScores = brianScores;
    }
    else if (student == "Carl")
    {
        studentScores = carlScores;
    }
    else if (student == "Dean")
    {
        studentScores = deanScores;
    }
    foreach (int mark in studentScores)
        {
            gradedAssignments += 1;
            if (gradedAssignments <= examAssignments)
            {
                sumScores += mark;
                examTotal += mark;
            }
            else
            {
                creditNumber = studentScores.Length - 5;
                sumScores += mark/10;
                creditAverage += mark;
            }
        }

    averageScore = Math.Round((decimal)sumScores / examAssignments, 2);
    examAverage = Math.Round((decimal)examTotal / examAssignments, 2);

    if (averageScore >= 97){studentGrade = "A+";}
    else if (averageScore >= 93){studentGrade = "A";}
    else if (averageScore >= 90){studentGrade = "A-";}
    else if (averageScore >= 87){studentGrade = "B+";}
    else if (averageScore >= 83){studentGrade = "B";}
    else if (averageScore >= 80){studentGrade = "B-";}
    else if (averageScore >= 77){studentGrade = "C+";}
    else if (averageScore >= 73){studentGrade = "C";}
    else if (averageScore >= 70){studentGrade = "C-";}
    else if (averageScore >= 67){studentGrade = "D+";}
    else if (averageScore >= 63){studentGrade = "D";}
    else if (averageScore >= 60){studentGrade = "D-";}
    else if (averageScore >= 0){studentGrade = "F";}

Console.WriteLine($"{student}\t{examAverage}\t\t{averageScore}\t{studentGrade}\t{Math.Round(creditAverage/creditNumber, 2)} ({averageScore-examAverage} points)");
}

Console.WriteLine("\nPlease press Enter to continue: ");
Console.ReadLine();
