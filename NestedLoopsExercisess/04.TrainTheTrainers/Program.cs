using System;

namespace _04.TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            double averageAll = 0;
            int numberOfStudents = 0;
            while (name!="Finish")
            {
                numberOfStudents++;
                double grade=0;
                for (int i = 0; i < n; i++)
                {
                    grade += double.Parse(Console.ReadLine());

                }
                double average = grade / n;
                Console.WriteLine($"{name} - {average:f2}.");
                averageAll += average;
                name = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {averageAll/numberOfStudents:f2}.");
            
        }
    }
}
