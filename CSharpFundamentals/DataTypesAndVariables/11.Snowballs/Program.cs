using System;
using System.Numerics;

namespace _11.Snowballs
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            
            BigInteger qurent = 0;
            BigInteger bestqurrent = 0;
            double besttime = 0;
            double bestQuality = 0;
            double bestSnowball = 0;
            for (int i = 0; i < n; i++)
            {
                
                    int snow = int.Parse(Console.ReadLine());
                    int time = int.Parse(Console.ReadLine());
                    int quality = int.Parse(Console.ReadLine());
                if (time!=0)
                {
                    qurent = BigInteger.Pow(snow / time,quality);

                }

                
                if (qurent>=bestqurrent)
                {
                    bestqurrent = qurent;
                    bestSnowball = snow;
                    besttime = time;
                    bestQuality = quality;
                }
            }
            Console.WriteLine($"{bestSnowball} : {besttime} = {bestqurrent} ({bestQuality})");
        }
    }
}
