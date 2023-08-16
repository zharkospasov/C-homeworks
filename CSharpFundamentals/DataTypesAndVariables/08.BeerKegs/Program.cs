using System;

namespace _08.BeerKegs
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double volumeMax = 0;
            string biggest =string.Empty;
            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double volume = radius * radius * 3.14 * height;
                if (volume>volumeMax)
                {
                    biggest = model;
                    volumeMax = volume;
                }


            }
            Console.WriteLine(biggest);
        }
    }
}
