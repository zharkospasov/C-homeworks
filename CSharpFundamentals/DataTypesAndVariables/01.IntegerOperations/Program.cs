using System;

namespace _01.IntegerOperations
{
    class Program
    {
        static void Main()
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double third = double.Parse(Console.ReadLine());
            double fourth = double.Parse(Console.ReadLine());
            double operations = first + second;
            operations /= third;
            operations *= fourth;
            Console.WriteLine(operations);
        }
    }
}
