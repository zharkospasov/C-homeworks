using System;

namespace _07.HotelRoom
{
    class Program
    {
        static void Main()
        {
            string month = Console.ReadLine();
            int nightsNumber = int.Parse(Console.ReadLine());
            double apartmentTotPrice = 0;
            double studioTotPrice = 0;
            if (month=="May"||month=="October")
            {
                studioTotPrice = 50 * nightsNumber;
                apartmentTotPrice = 65 * nightsNumber;
                if (nightsNumber>7&&nightsNumber<=14)
                {
                    studioTotPrice -= studioTotPrice * 0.05;
                }
                else if(nightsNumber>14)
                {
                    studioTotPrice -= studioTotPrice * 0.3;
                }
            }
            else if (month == "June" || month == "September")
            {
                studioTotPrice = 75.20 * nightsNumber;
                apartmentTotPrice = 68.70 * nightsNumber;
                if (nightsNumber>14)
                {
                    studioTotPrice -= studioTotPrice * 0.2;
                }
            }
            else if (month == "July" || month == "August")
            {
                studioTotPrice = 76 * nightsNumber;
                apartmentTotPrice = 77 * nightsNumber;
            }
            if (nightsNumber>14)
            {
                apartmentTotPrice -= apartmentTotPrice * 0.1;
            }

            Console.WriteLine($"Apartment: {apartmentTotPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioTotPrice:f2} lv.");
        }
    }
}
