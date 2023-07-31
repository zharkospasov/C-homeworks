using System;

namespace _01.OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            string input = Console.ReadLine();
            int counter = 0;
            while (input!= "No More Books")
            {
                if (input==book)
                {
                    Console.WriteLine($"You checked {counter} books and found it.");
                    return;
                }
                counter++;
                input = Console.ReadLine();
            }
            Console.WriteLine("The book you search is not here!");
            Console.WriteLine($"You checked {counter} books.");
        }
    }
}
