using System;

namespace _02._ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int badGrades = 0;
            int counter = 0;
            double sum = 0;
            string lastProblem = String.Empty;
            while (input != "Enough")
            {
                int grade = int.Parse(Console.ReadLine());
                sum += grade;
                counter++;
                if (grade <= 4)
                {
                    badGrades += 1;
                    if (badGrades == n)
                    {
                        Console.WriteLine($"You need a break, {badGrades} poor grades.");
                        return;
                    }
                }
                lastProblem = input;
                input = Console.ReadLine();

            }
            Console.WriteLine($"Average score: {sum / counter:f2}");
            Console.WriteLine($"Number of problems: {counter}");
            Console.WriteLine($"Last problem:{lastProblem}");
        }  }
}
