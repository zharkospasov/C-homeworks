using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double ticketPrice = 0;
            double total = 0;
            if (type=="Students")
            {
                if (day=="Friday")
                {
                    ticketPrice = 8.45;
                    total = ticketPrice * n;
                    if (n>=30)
                    {
                        total -= total * 0.15;
                    }
                }
                if (day=="Saturday")
                {
                    ticketPrice = 9.80;
                    total = ticketPrice * n;
                    if (n >= 30)
                    {
                        total -= total * 0.15;
                    }
                }
                if (day=="Sunday")
                {
                    ticketPrice = 10.46;
                    total = ticketPrice * n;
                    if (n >= 30)
                    {
                        total -= total * 0.15;
                    }
                }
            }
            if (type == "Business")
            {
                if (day == "Friday")
                {
                    ticketPrice = 10.90;
                    total = ticketPrice * n;
                    if (n >= 100)
                    {
                        total -= ticketPrice*10;
                    }
                }
                if (day == "Saturday")
                {
                    ticketPrice = 15.60;
                    total = ticketPrice * n;
                    if (n >= 100)
                    {
                        total -= ticketPrice * 10;
                    }
                }
                if (day == "Sunday")
                {
                    ticketPrice = 16;
                    total = ticketPrice * n;
                    if (n >= 100)
                    {
                        total -= ticketPrice * 10;
                    }
                }
            }
            if(type=="Regular")
            {
                if (day == "Friday")
                {
                    ticketPrice = 15;
                    total = ticketPrice * n;
                    if (n >= 10 && n <= 20)
                    {
                        total -= total * 0.05;
                    }
                }
                if (day == "Saturday")
                {
                    ticketPrice = 20;
                    total = ticketPrice * n;
                    if (n >=10&&n<=20)
                    {
                        total -= total*0.05;
                    }
                }
                if (day == "Sunday")
                {
                    ticketPrice = 22.50;
                    total = ticketPrice * n;
                    if (n >= 100)
                    {
                        total -= ticketPrice * 10;
                    }
                }
            }
            Console.WriteLine($"Total price: {total:f2}");
        }
    }
}
