﻿using System;

namespace _03.Histogram
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (input<200)
                {
                    p1++;
                }
                if (input>=200&&input<400)
                {
                    p2++;
                }
                if (input>=400&&input<600)
                {
                    p3++;
                }
                if (input>=600&&input<800)
                {
                    p4++;
                }
                if (input>=800&&input<=1000)
                {
                    p5++;
                }
            }
            p1 = p1 / n * 100;
            p2 = p2 / n * 100;
            p3 = p3 / n * 100;
            p4 = p4 / n * 100;
            p5 = p5 / n * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");

        }
    }
}
