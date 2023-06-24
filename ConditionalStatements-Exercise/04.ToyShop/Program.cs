using System;

namespace _04.ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzels = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int teddyBears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double totalSales = puzzels * 2.60 + dolls * 3 + teddyBears * 4.10 + minions * 8.20 + trucks * 2;
            if (puzzels+dolls+teddyBears+minions+trucks>50)
            {
                totalSales = totalSales - totalSales * 0.25;
            }
            totalSales -= totalSales * 0.1;
            if (totalSales-tripPrice>0)
            {
                Console.WriteLine($"Yes! {totalSales-tripPrice} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {Math.Abs(totalSales-tripPrice):f2} lv needed.");
            }
            Console.WriteLine();
        }
    }
}
