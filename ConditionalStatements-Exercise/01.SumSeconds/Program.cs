using System;

namespace _01.SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());
            int summedTime = firstTime + secondTime + thirdTime;
            int minutes = summedTime / 60;
            int seconds = summedTime % 60;
            if (seconds<10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");

            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
            
        }
    }
}
