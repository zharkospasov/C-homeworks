using System;
using System.Linq;
using System.Collections;

namespace _03.Zig_ZagArrays
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array1 = new int[n];
            int[] array2 = new int[n];
            for (int i = 1; i <=n; i++)
            {
                int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                if (i%2!=0)
                {
                    array1[i-1] = input[0];
                    array2[i-1] = input[1];
                }
                else
                {
                    array2[i-1] = input[0];
                    array1[i-1] = input[1];
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(array1[i]+" ");
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write(array2[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
