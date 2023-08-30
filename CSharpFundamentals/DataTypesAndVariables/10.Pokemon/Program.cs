using System;

namespace _10.Pokemon
{
    class Program
    {
        static void Main()
        {
            int pokePower = int.Parse(Console.ReadLine());
            int pokeDistance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int poked = 0;
            double perscentPower = pokePower;
            while (pokePower>=pokeDistance)
            {
                
                pokePower -= pokeDistance;
                poked++;
                if (pokePower == perscentPower / 2)
                {
                    if (exhaustionFactor != 0)
                    {
                        pokePower = pokePower / exhaustionFactor;

                    }
                }
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(poked);
        }
    }
}
