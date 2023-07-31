using System;

namespace _06.Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actor = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            double result = academyPoints;
            for (int i = 0; i < n; i++)
            {
                string judge = Console.ReadLine();
                double judgePoints = double.Parse(Console.ReadLine());
                result +=  judge.Length * judgePoints / 2;
                if (result>=1250.5)
                {
                    Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {result:f1}!");
                    return;
                }

            }

            Console.WriteLine($"Sorry, {actor} you need {1250.5-result:f1} more!");
        }
    }
}
