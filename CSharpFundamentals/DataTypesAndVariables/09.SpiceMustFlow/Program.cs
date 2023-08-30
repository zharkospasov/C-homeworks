using System;

namespace _09.SpiceMustFlow
{
    class Program
    {
        static void Main()
        {
            int yield = int.Parse(Console.ReadLine());
            int days = 0;
            int extracted = 0;

            while (yield>=100)
            {
                extracted += yield;
                extracted -= 26;
                yield -= 10;
                days++;

            }
            if (extracted>=26)
            {
                extracted -= 26;
            }
            Console.WriteLine(days);
            Console.WriteLine(extracted);
        }
    }
}
