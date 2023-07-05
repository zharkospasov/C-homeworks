using System;

namespace _06.WorldSwimmingRecord
{
    class Program
    {
        static void Main()
        {
            double worldRecordTime = double.Parse(Console.ReadLine());
            double distanceToSwim = double.Parse(Console.ReadLine());
            double timePer1Meter= double.Parse(Console.ReadLine());
            double ivansTime = distanceToSwim * timePer1Meter + (int)(distanceToSwim / 15) * 12.5;
            if (worldRecordTime>ivansTime)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {ivansTime:f2} seconds.");

            }
            else
            {
                Console.WriteLine($"No, he failed! He was {ivansTime-worldRecordTime:f2} seconds slower.");
            }
        }
    }
}
