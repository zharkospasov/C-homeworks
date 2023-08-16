using System;

namespace _05.PrintPartOfASCIITable
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            for (int i = n; i <=x; i++)
            {
                Console.Write((char)i+" ");
            }
            
        }
    }
}
