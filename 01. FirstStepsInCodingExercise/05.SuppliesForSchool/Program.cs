using System;

namespace _05.SuppliesForSchool
{
    class Program
    {
        static void Main()
        {
            double pens = double.Parse(Console.ReadLine());
            double markers = double.Parse(Console.ReadLine());
            double detergent = double.Parse(Console.ReadLine());
            double percentDisscount = double.Parse(Console.ReadLine());
            double sum = pens * 5.80 + markers * 7.20 + detergent * 1.20;
            sum = sum - sum * percentDisscount / 100;
            Console.WriteLine(sum);
        }
    }
}
