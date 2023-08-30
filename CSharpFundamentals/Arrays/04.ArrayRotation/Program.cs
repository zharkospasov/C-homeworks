using System;
using System.Linq;
using System.Collections;
namespace _04.ArrayRotation
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n= int.Parse(Console.ReadLine());
            int mem = 0;
            for (int i = 0; i < n; i++)
            {
                mem = array[0];
                for (int j = 0; j < array.Length-1; j++)
                {
                    array[j] = array[j + 1];
                }
                array[array.Length - 1] = mem;
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
