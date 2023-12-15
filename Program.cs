/*
Revise a C# console application that uses nested foreach loops to access array data
based on an updated feature specification.
Update the variables and if statements in a C# console application to create the code 
branches and calculations required to satisfy an updated feature specification.
*/

int studentScore = 0;
string studentGrade = "A";

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
else{studentGrade = "F";}

Console.WriteLine($"Student\t\tGrade");
Console.WriteLine($"Alice\t\t{studentGrade}");