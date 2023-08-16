using System;

namespace _07.WaterFlow
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int capacity = 255;
            int filled = 0;
            for (int i = 0; i < n; i++)
            {
                int amount = int.Parse(Console.ReadLine());
                if (amount<=capacity)
                {
                    filled += amount;
                    capacity -= amount;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }

            }
            Console.WriteLine(filled);
        }
    }
}
