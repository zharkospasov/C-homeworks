using System;

namespace _07.FoodDelivery
{
    class Program
    {
        static void Main()
        {
            int chickenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int veganMenu = int.Parse(Console.ReadLine());

            double result = chickenMenu * 10.35 + fishMenu * 12.40 + veganMenu * 8.15;
            result = result + result * 0.20 + 2.50;
            Console.WriteLine(result);
        }
    }
}
