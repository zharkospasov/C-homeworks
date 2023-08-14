using System;

namespace _10.RageExpencess
{
    class Program
    {
        static void Main()
        {
            int games = int.Parse(Console.ReadLine());
            double headset = double.Parse(Console.ReadLine());
            double mouse = double.Parse(Console.ReadLine());
            double keyboard = double.Parse(Console.ReadLine());
            double display = double.Parse(Console.ReadLine());
            double expenses = 0;
            int counter = 0;
            for (int i = 1; i <= games; i++)
            {
                if (i%2==0)
                {
                    expenses += headset;
                }
                if (i%3==0)
                {
                    expenses += mouse;
                }
                if (i%2==0&&i%3==0)
                {
                    expenses +=keyboard;
                    counter++;
                    if (counter==2)
                    {
                        expenses += display;
                        counter = 0;
                    }
                }
            }
            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}
