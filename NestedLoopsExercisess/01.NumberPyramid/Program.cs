using System;

namespace _01.NumberPyramid
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int x =1;
            int columns = 1;
            int counter = 1;
            while (x<=n)
            {
                while (columns<=counter)
                {
                    Console.Write(x+" ");
                    columns++;
                    if (x==n)
                    {
                        return;
                    }
                    x++;
                }
                Console.WriteLine();
                counter++;
                columns = 1;
            }
        }
    }
}
