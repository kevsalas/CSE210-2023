using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hello Prep2 World!");

        Console.Write("What is your grade percentaje? ");
        string grade = Console.ReadLine();
        int userGrade = int.Parse(grade);

        // Giving grades in order
        int gradeA = 90;
        string gradeLetterA = "A";
        //////////////////////////
        int gradeB = 80;
        string gradeLetterB = "B";
        //////////////////////////
        int gradeC = 70;
        string gradeLetterC = "C";
        /////////////////////////
        int gradeD = 60;
        string gradeLetterD = "D";
        // Grade F IS IT less than 60
        string gradeLetterF = "F";
        if (userGrade >= gradeA)
        {
            Console.WriteLine($"Congrats your grade is {gradeLetterA}!");
        }
        else if (userGrade >= gradeB && userGrade < gradeA)
        {
            Console.WriteLine($"Congrats your grade is {gradeLetterB}");
        }
           else if (userGrade >= gradeC && userGrade < gradeB)
        {
            Console.WriteLine($"Congrats your grade is {gradeLetterC}");
        }
           else if (userGrade >= gradeD && userGrade < gradeC)
        {
            Console.WriteLine($"Congrats your grade is {gradeLetterD}");
        }
        else
        {
            Console.WriteLine($"Your grade is {gradeLetterF}");
        }

        
    }
}