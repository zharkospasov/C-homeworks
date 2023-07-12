using System;

namespace _04.CleverLilly
{
    class Program
    {
        static void Main()
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());
            int toys = 0;
            double totalMoney = 0;
            double moneyLeft = 0;
            int money = 0;
            for (int i = 1; i <= age; i++)
            {
                if (i%2==0)
                {
                    money++;
                    totalMoney = totalMoney + 10 * money;
                    totalMoney -= 1;
                }
                else
                {
                    toys++;
                }
            }
            toyPrice = toyPrice * toys;
            moneyLeft = totalMoney + toyPrice-washingMachinePrice;

            if (moneyLeft>=0)
            {
                Console.WriteLine($"Yes! {moneyLeft:f2}");

            }
            else
            {
                Console.WriteLine($"No! {Math.Abs(moneyLeft):f2}");

            }
        }
    }
}
