using System;

namespace _07.TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());
            double musala = 0;
            double monblan = 0;
            double kilimont = 0;
            double kTwo = 0;
            double everest = 0;
            double totClimbers = 0;
            for (int i = 0; i < groups; i++)
            {
                int climbers = int.Parse(Console.ReadLine());
                totClimbers += climbers;
                if (climbers<=5)
                {
                    musala += climbers;
                }
                if (climbers>=6&&climbers<=12)
                {
                    monblan += climbers;
                }
                if (climbers>=13&&climbers<=25)
                {
                    kilimont += climbers;
                }
                if (climbers>=26&&climbers<=40)
                {
                    kTwo += climbers;
                }
                if (climbers>40)
                {
                    everest += climbers;
                }
            }
            Console.WriteLine($"{musala/totClimbers*100:f2}%");
            Console.WriteLine($"{monblan / totClimbers * 100:f2}%");
            Console.WriteLine($"{kilimont / totClimbers * 100:f2}%");
            Console.WriteLine($"{kTwo / totClimbers * 100:f2}%");
            Console.WriteLine($"{everest / totClimbers * 100:f2}%");
        }
    }
}
