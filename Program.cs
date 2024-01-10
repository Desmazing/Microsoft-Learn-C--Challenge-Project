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

Console.WriteLine($"Student\t\tGrade");
Console.WriteLine("---------------------");

foreach (string student in studentNames)
{
    decimal sumScores = 0;
    int gradedAssignments = 0;

    if (student == "Alice")
    {
        foreach (int mark in aliceScores)
        {
            gradedAssignments += 1;
            if (gradedAssignments <= examAssignments)
            {
                sumScores += mark;
            }
            else
            {
                sumScores += mark/10;
            }    
        }
    }
    else if (student == "Brian")
    {
        foreach (int mark in brianScores)
        {
            gradedAssignments += 1;
            if (gradedAssignments <= examAssignments)
            {
                sumScores += mark;
            }
            else
            {
                sumScores += mark/10;
            } 
        }
    }
    else if (student == "Carl")
    {
        foreach (int mark in carlScores)
        {
            gradedAssignments += 1;
            if (gradedAssignments <= examAssignments)
            {
                sumScores += mark;
            }
            else
            {
                sumScores += mark/10;
            } 
        }
    }
    else if (student == "Dean")
    {
        foreach (int mark in deanScores)
        {
            gradedAssignments += 1;
            if (gradedAssignments <= examAssignments)
            {
                sumScores += mark;
            }
            else
            {
                sumScores += mark/10;
            } 
        }
    }

    averageScore = Math.Round((decimal)sumScores / examAssignments, 2);

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

Console.WriteLine($"{student}\t\t{averageScore}\t{studentGrade}");
}

Console.WriteLine("\nPlease press Enter to continue: ");
Console.ReadLine();
