using System;

namespace _06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int cake = width * height;
            
            string input = Console.ReadLine();
            while (input!="STOP")
            {
                int taken = int.Parse(input);
                cake -= taken;
                if (cake<=0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(cake)} pieces more.");
                    return;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{cake} pieces are left.");
        }
    }
}
