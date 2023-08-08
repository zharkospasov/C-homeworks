using System;

namespace _07.VendingMachine
{
    class Program
    {
        static void Main()
        {
            double credit = 0;
            string input = Console.ReadLine().ToLower();
            
            while (input!="start")
            {
                if (double.Parse(input)==2)
                {
                    credit += 2;
                }
                else if (double.Parse(input) == 1)
                {
                    credit += 1;
                }
                else if (double.Parse(input) == 0.5)
                {
                    credit += 0.5;
                }
                else if (double.Parse(input) == 0.20)
                {
                    credit += 0.2;
                }
                else if (double.Parse(input) == 0.1)
                {
                    credit += 0.1;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {input}");
                }
                input = Console.ReadLine().ToLower();
            }
            input = Console.ReadLine().ToLower();
            while (input!="end")
            {
                if (input == "water")
                {
                    if (credit >= 0.70)
                    {
                        credit -= 0.70;
                        Console.WriteLine($"Purchased {input}");
                       
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input == "nuts")
                {
                    if (credit>=2)
                    {
                        credit -= 2;
                        Console.WriteLine($"Purchased {input}");
                        
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, not enough money");
                    }
                }
                else if (input== "coke")
                {
                     if (credit >= 1)
                    {
                        credit -= 1;
                        Console.WriteLine($"Purchased {input}");
                        
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input=="soda")
                {
                    if (credit >= 0.8)
                    {
                        credit -= 0.8;
                        Console.WriteLine($"Purchased {input}");
                        
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input=="crisps")
                {
                    if (credit >= 1.5)
                    {
                        credit -= 1.5;
                        Console.WriteLine($"Purchased {input}");
                        

                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                input = Console.ReadLine().ToLower();
            }
            Console.WriteLine($"Change: {credit:f2}");
        }
    }
}
