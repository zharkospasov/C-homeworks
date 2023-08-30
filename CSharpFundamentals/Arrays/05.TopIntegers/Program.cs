using System;
using System.Linq;
using System.Collections;
namespace _05.TopIntegers
{
    class Program
    {
        static void Main()
        {
            int[] array= Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i]<=array[j])
                    {
                        counter++;
                    }
                }
                if (counter==0)
                {
                    Console.Write(array[i]+" ");
                }
                counter = 0;
            }
            Console.WriteLine();
        }
    }
}
