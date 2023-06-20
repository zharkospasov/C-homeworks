using System;

namespace _04.VacationBookList
{
    class Program
    {
        static void Main()
        {
            int numberOfPages = int.Parse(Console.ReadLine());
            int pagesPerHourRed=int.Parse(Console.ReadLine());
            int daysToRead = int.Parse(Console.ReadLine());
            int hoursDaily;
            hoursDaily = numberOfPages / pagesPerHourRed / daysToRead;
            Console.WriteLine(hoursDaily);
        }
    }
}
