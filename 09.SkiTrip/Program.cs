using System;

namespace _09.SkiTrip
{
    class Program
    {
        static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string grade = Console.ReadLine();
            double totalPrice;
            int nights = 0;
            if (days==2)
            {
                nights = 1;
            }
            else
            {
                nights = days - 1;
            }
            if (roomType=="president apartment")
            {
                totalPrice = nights * 35.00;
                if (days<10)
                {
                    totalPrice -= totalPrice * 0.1;

                }
                else if(days>=10&&days<=15)
                {
                    totalPrice -= totalPrice * 0.15;
                }
                else
                {
                    totalPrice -= totalPrice * 0.2;
                }
            }
            else if (roomType== "apartment")

            {
                totalPrice = nights * 25.00;
                if (days < 10)
                {
                    totalPrice -= totalPrice * 0.30;

                }
                else if (days >= 10 && days <= 15)
                {
                    totalPrice -= totalPrice * 0.35;
                }
                else
                {
                    totalPrice -= totalPrice * 0.5;
                }
            }
            else
            {
                totalPrice = nights * 18.00;
            }
            if (grade=="positive")
            {
                totalPrice += totalPrice * 0.25;
            }
            else
            {
                totalPrice -= totalPrice * 0.10;
            }
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
