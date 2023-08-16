using System;

namespace _03.Elevator
{
    class Program
    {
        static void Main()
        {
            int persons = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int courcess = 0;
            courcess = persons / capacity;
            if (persons%capacity>0)
            {
                courcess++;
            }
            Console.WriteLine(courcess);
        }
    }
}
