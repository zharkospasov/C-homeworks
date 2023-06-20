using System;

namespace _08.BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double yearlyPrice = double.Parse(Console.ReadLine());
            double snickers = yearlyPrice - yearlyPrice * 0.40;
            double clothes = snickers - snickers * 0.20;
            double ballPrice = clothes / 4;
            double accessories = ballPrice / 5;
            double result = yearlyPrice + snickers + clothes + ballPrice + accessories;

            Console.WriteLine(result);
        }
    }
}
