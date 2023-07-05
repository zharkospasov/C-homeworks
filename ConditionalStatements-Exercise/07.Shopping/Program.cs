using System;

namespace _07.Shopping
{
    class Program
    {
        static void Main()
        {
            double moneyAvailable = double.Parse(Console.ReadLine());
            int numberOfGPU = int.Parse(Console.ReadLine());
            int numberOfPCU = int.Parse(Console.ReadLine());
            int numberOfMemory = int.Parse(Console.ReadLine());
            double gpusPrice = numberOfGPU * 250;
            double pcuPrice = gpusPrice * 0.35*numberOfPCU;
            double memoryPrice = gpusPrice * 0.1*numberOfMemory;
            double totalExpencess = gpusPrice + memoryPrice + pcuPrice;
            if (numberOfGPU>numberOfPCU)
            {
                totalExpencess -= totalExpencess * 0.15;
            }
            if (moneyAvailable-totalExpencess>=0)
            {
                Console.WriteLine($"You have {moneyAvailable - totalExpencess:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(moneyAvailable - totalExpencess):f2} leva more!");
            }
            Console.WriteLine();
        }
    }
}
