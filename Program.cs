using System;

namespace _02.SummerOutfit
{
    class Program
    {
        static void Main()
        {
            int degree = int.Parse(Console.ReadLine());
            string intervalOfDay = Console.ReadLine();
            string outfit=String.Empty;
            string shoes=String.Empty;

            if (10<=degree&&degree<=18)
            {
                if (intervalOfDay == "Morning")
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";

                }
                else if (intervalOfDay == "Afternoon")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if(intervalOfDay =="Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (18<degree&&degree<=24)
            {
                if (intervalOfDay == "Morning")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";

                }
                else if (intervalOfDay == "Afternoon")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (degree>=25)
            {
                if (intervalOfDay == "Morning")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";

                }
                else if (intervalOfDay == "Afternoon")
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
                else
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            Console.WriteLine("It's {0} degrees, get your {1} and {2}.",degree,outfit,shoes);
        }
    }
}
