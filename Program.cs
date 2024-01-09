/*
Revise a C# console application that uses nested foreach loops to access array data
based on an updated feature specification.
Update the variables and if statements in a C# console application to create the code 
branches and calculations required to satisfy an updated feature specification.
*/

string studentGrade = "A";
string [] studentNames = ["Alice", "Brian", "Carl", "Dean"];


int [] aliceScores = [80,83,79,65,72];
int [] brianScores = [76,75,72,70,85];
int [] carlScores = [82,78,75,90,67];
int [] deanScores = [62,90,84,80,64];

int sumScores;
int studentScore = 0;

foreach (string student in studentNames)
{
    if (student == "Alice")
    {
        sumScores = aliceScores[0]+ aliceScores[1]+aliceScores[2]+aliceScores[3]+aliceScores[4];
        Console.WriteLine(sumScores);
        studentScore = sumScores / 5;
        Console.WriteLine(studentScore);
    }

if (studentScore >= 97){studentGrade = "A+";}
else if (studentScore >= 93){studentGrade = "A";}
else if (studentScore >= 90){studentGrade = "A";}
else if (studentScore >= 87){studentGrade = "A";}
else if (studentScore >= 83){studentGrade = "A";}
else if (studentScore >= 80){studentGrade = "A";}
else if (studentScore >= 77){studentGrade = "A";}
else if (studentScore >= 73){studentGrade = "A";}
else if (studentScore >= 70){studentGrade = "A";}
else if (studentScore >= 67){studentGrade = "A";}
else if (studentScore >= 63){studentGrade = "A";}
else if (studentScore >= 60){studentGrade = "A";}
else if (studentScore >= 0){studentGrade = "F";}


Console.WriteLine($"Student\t\tGrade");
Console.WriteLine($"{student}\t\t{studentScore}\t\t{studentGrade}");
}
