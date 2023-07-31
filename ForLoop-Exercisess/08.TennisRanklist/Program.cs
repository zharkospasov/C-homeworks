using System;

namespace _08.TennisRanklist
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double startingPoints = double.Parse(Console.ReadLine());
            double wins = 0;
            double points = 0;
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                if (input=="W")
                {
                    points += 2000;
                    wins += 1;
                }
                if (input=="SF")
                {
                    points +=720;
                }
                if (input=="F")
                {
                    points += 1200;
                }
            }
            Console.WriteLine($"Final points: {startingPoints+points}");
            Console.WriteLine($"Average points: {Math.Floor(points/n)}");
            Console.WriteLine($"{wins/n*100:f2}%");
        }
    }
}
