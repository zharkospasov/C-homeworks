using System;

namespace _08.LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            double movieDuration = int.Parse(Console.ReadLine());
            double brakeLenght = int.Parse(Console.ReadLine());
            double lunchtime = brakeLenght /8;
            double freeTime = brakeLenght / 4;
            double totalFreeTime = brakeLenght - lunchtime - freeTime;
            if (totalFreeTime-movieDuration>=0)
            {
                Console.WriteLine($"You have enough time to watch {movieName} and left with {Math.Ceiling(totalFreeTime - movieDuration)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {movieName}, you need {Math.Ceiling(Math.Abs(totalFreeTime - movieDuration))} more minutes.");
            }
            Console.WriteLine();
        }
    }
}
