﻿using System;

namespace _11.Orders
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double order = 0;
            double total = 0;
            for (int i = 0; i < n; i++)
            {
                double price = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsules = int.Parse(Console.ReadLine());
                order = (days * capsules) * price;
                Console.WriteLine($"The price for the coffee is: ${order:f2}");
                total += order;
                
            }
            Console.WriteLine($"Total: ${total:f2}");
        }
    }
}
