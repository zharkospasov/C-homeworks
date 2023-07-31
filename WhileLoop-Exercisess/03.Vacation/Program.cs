using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripMoney = double.Parse(Console.ReadLine());
            double moneyAvailable = double.Parse(Console.ReadLine());
            int daysSpend = 0;
            int counter = 0;
            while (moneyAvailable<tripMoney)
            {
                counter++;
                string action = Console.ReadLine();
                double amount = double.Parse(Console.ReadLine());
                if (action=="spend")
                {
                    moneyAvailable -= amount;
                    daysSpend++;
                    if (daysSpend==5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(counter);
                        return;
                    }
                }
                else
                {
                    moneyAvailable += amount;
                    daysSpend = 0;
                }
                if (moneyAvailable<0)
                {
                    moneyAvailable = 0;
                }

            }
            Console.WriteLine($"You saved the money for {counter} days.");
        }
    }
}
