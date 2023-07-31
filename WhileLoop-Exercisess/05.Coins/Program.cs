using System;

namespace _05.Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal change = decimal.Parse(Console.ReadLine());
            int coins = 0;

            while (change>(decimal)0)
            {
                if (change>=(decimal)2)
                {
                    change -=(decimal) 2;
                    coins++;
                }
                else if (change>=1)
                {
                    change -=(decimal)1;
                    coins++;
                }
                else if (change >=(decimal) 0.50)
                {
                    change -=(decimal) 0.50;
                    coins++;
                }
                else if (change>=(decimal)0.20)
                {
                    change -= (decimal)0.20;
                    coins++;
                }
                else if (change>=(decimal)0.10)
                {
                    change -= (decimal)0.10;
                    coins++;
                }
                else if (change>=(decimal)0.05)
                {
                    change -=(decimal) 0.05;
                    coins++;
                }
                else if (change>=(decimal)0.02)
                  
                {
                    change -=(decimal) 0.02;
                    coins++;
                }
                else if (change>=(decimal)0.01)
                {
                    change -= (decimal)0.01;
                    coins++;
                }
            }
            Console.WriteLine(coins);
        }
    }
}
