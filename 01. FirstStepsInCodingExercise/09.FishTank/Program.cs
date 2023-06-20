using System;

namespace _09.FishTank
{
    class Program
    {
        static void Main()
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double occupiedVolume = double.Parse(Console.ReadLine());
            double volume = lenght * width * height;
            volume = volume * 0.001;
            volume = volume - volume * occupiedVolume/100;
            Console.WriteLine(volume);
        }
    }
}
