using System;

namespace _06.Repainting
{
    class Program
    {
        static void Main()
        {
            double nailon = double.Parse(Console.ReadLine());
            double paint = double.Parse(Console.ReadLine());
            double paintThinner = double.Parse(Console.ReadLine());
            double hoursToWork = double.Parse(Console.ReadLine());
            double nailonPrice = 1.50;
            double paintPrice = 14.50;
            double paintThinnerPrice = 5;

            nailonPrice = (nailon + 2) * nailonPrice;
            paintPrice = (paint + paint * 0.1) * paintPrice;
            paintThinnerPrice = paintThinner * paintThinnerPrice;
            double result = nailonPrice + paintPrice + paintThinnerPrice + 0.40;
            result = result + result * 0.30 * hoursToWork;

            Console.WriteLine(result);
        }
    }
}
