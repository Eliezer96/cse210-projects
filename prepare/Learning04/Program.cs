using System;

class Program
{
 
    static void Main(string[] args)
    {
        AssignmentClass newAssignment = new AssignmentClass("Josep", "Functions");
        Console.WriteLine(newAssignment.GetSummary());
        Console.WriteLine();


        MathAssignment math1 =  new MathAssignment("Eliezer Rivera", "Functions", "7.5", "8-19");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());
        Console.WriteLine();
        
        WrittingAssignment writting1 = new WrittingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writting1.GetSummary());
        Console.WriteLine(writting1.GetWritingInformation());
    }


}