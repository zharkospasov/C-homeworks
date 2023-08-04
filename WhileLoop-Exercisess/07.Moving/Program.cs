using System;

namespace _07.Moving
{
    class Program
    {
        static void Main()
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int volume = width * length * height;

            string input = Console.ReadLine();
            while (input!="Done")
            {
                int boxes = int.Parse(input);
                volume -= boxes;
                if (volume<=0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(volume)} Cubic meters more.");
                    return;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{volume} Cubic meters left.");
        }
    }
}
