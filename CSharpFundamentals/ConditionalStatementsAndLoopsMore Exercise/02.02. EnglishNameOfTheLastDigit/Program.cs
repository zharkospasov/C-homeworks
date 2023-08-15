using System;

namespace _02._02._EnglishNameOfTheLastDigit
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int digit = n % 10;
            string exit = String.Empty;
            if (digit==1)
            {
                exit = "one";
            }
            if (digit==2)
            {
                exit = "two";
            }
            if (digit == 3)
            {
                exit = "three";
            }
            if (digit == 4)
            {
                exit = "four";
            }
            if (digit == 5)
            {
                exit = "five";
            }
            if (digit == 6)
            {
                exit = "six";
            }
            if (digit == 7)
            {
                exit = "seven";
            }
            if (digit == 8)
            {
                exit = "eight";
            }
            if (digit == 9)
            {
                exit = "nine";
            }
            if (digit == 0)
            {
                exit = "zero";
            }
            Console.WriteLine(exit);
        }
    }
}
