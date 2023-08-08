using System;

namespace _04.PrintAndSum
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int x = 0;
            
            for (int i = n; i <= m; i++)
            {
                Console.Write(i+" ");
                x += i;

            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {x}");
        }
    }
}
