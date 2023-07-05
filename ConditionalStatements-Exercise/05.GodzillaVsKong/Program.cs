using System;

namespace _05.GodzillaVsKong
{
    class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            int numberOfStatists = int.Parse(Console.ReadLine());
            double clothingPrice = double.Parse(Console.ReadLine());
            double deccorCost = budget * 0.10;
            double clothedStatists = clothingPrice * numberOfStatists;
            if (numberOfStatists>150)
            {
                clothedStatists = clothedStatists - clothedStatists * 0.1;

            }
            double expencess = clothedStatists + deccorCost;
            if (expencess>budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(budget-expencess):f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget-expencess:f2} leva left.");
            }
            Console.WriteLine();
        }
    }
}
