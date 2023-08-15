using System;

namespace _03.GamingStore
{
    class Program
    {
        static void Main()
        {
            double balance = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double gamePrice = 0;
            double totalSpent = 0;
            while (input != "Game Time")
            {
                if (balance <= 0)
                {
                    Console.WriteLine($"Out of money!");
                   break;
                }

                else if (input == "OutFall 4")
                {
                    gamePrice = 39.99;
                    if (balance>=gamePrice)
                    {
                        Console.WriteLine($"Bought {input}");
                        balance -= gamePrice;
                        totalSpent -= gamePrice;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (input == "CS: OG")
                {
                    gamePrice = 15.99;
                    if (balance >= gamePrice)
                    {
                        Console.WriteLine($"Bought {input}");
                        balance -= gamePrice;
                        totalSpent -= gamePrice;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (input == "Zplinter Zell")
                {
                    gamePrice = 19.99;
                    if (balance >= gamePrice)
                    {
                        Console.WriteLine($"Bought {input}");
                        balance -= gamePrice;
                        totalSpent -= gamePrice;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (input == "Honored 2")
                {
                    gamePrice = 59.99;
                    if (balance >= gamePrice)
                    {
                        Console.WriteLine($"Bought {input}");
                        balance -= gamePrice;
                        totalSpent -= gamePrice;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (input == "RoverWatch")
                {
                    gamePrice = 29.99;
                    if (balance >= gamePrice)
                    {
                        Console.WriteLine($"Bought {input}");
                        balance -= gamePrice;
                        totalSpent -= gamePrice;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
                input = Console.ReadLine();

            }
            if (balance>0)
            {
                Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${balance:f2}");

            }
        }
    }
}
