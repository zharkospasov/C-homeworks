using System;

namespace _05.Journey
{
    class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = String.Empty;
            string accomodation = String.Empty;
            double spent = 0;
            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    spent = budget * 0.30;
                    accomodation = "Camp";
                }
                else
                {
                    spent = budget * 0.70;
                    accomodation = "Hotel";
                }
            }
            else if (budget <= 1000 && budget > 100)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    spent = budget * 0.40;
                    accomodation = "Camp";
                }
                else
                {
                    spent = budget * 0.80;
                    accomodation = "Hotel";
                }
            }
            else
            {
                destination = "Europe";
                spent = budget * 0.9;
                accomodation = "Hotel";
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{accomodation} - {spent:f2}");
        }
    }
}
