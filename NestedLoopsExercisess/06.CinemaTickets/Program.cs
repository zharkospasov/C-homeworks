using System;

namespace _06.CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double studentTot = 0;
            double standartTot = 0;
            double kidTot = 0;
            int totTickets = 0;
            string input = Console.ReadLine();
            string ticket = String.Empty;
            int counter = 0;
            double sum= 0;
            while (input != "Finish")
            {

                int emptySpacess = int.Parse(Console.ReadLine());
                double student = 0;
                double standart = 0;
                double kid = 0;


                ticket = Console.ReadLine();
                while (ticket != "End")
                {

                    if (ticket == "student")
                    {
                        student++;
                        studentTot++;
                    }
                    if (ticket == "standard")
                    {
                        standart++;
                        standartTot++;
                    }
                    if (ticket == "kid")
                    {
                        kid++;
                        kidTot++;
                    }
                    counter++;
                     sum = student + standart + kid;
                    if (sum >= emptySpacess)
                    {
                        break;
                    }
                    ticket = Console.ReadLine();
                }

                double fulness = sum / emptySpacess * 100;
                Console.WriteLine($"{input} - {fulness:f2}% full.");

                input = Console.ReadLine();


            }
            Console.WriteLine($"Total tickets: {counter}");
            Console.WriteLine($"{studentTot / counter * 100:f2}% student tickets.");
            Console.WriteLine($"{standartTot / counter * 100:f2}% standard tickets.");
            Console.WriteLine($"{kidTot / counter * 100:f2}% kids tickets.");
        }
    }
}
