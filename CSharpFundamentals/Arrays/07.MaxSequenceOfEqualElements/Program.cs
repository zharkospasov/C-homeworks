using System;
using System.Collections;
using System.Linq;
namespace _07.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int counter = 0;
            int biggest = 0;
            int sequence = 0;
            int leftMost = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i]==array[i-1])
                {
                    sequence = array[i];
                    counter++;
                    if (counter>biggest)
                    {
                        biggest = counter;
                        leftMost = sequence;
                    }
                   
                }
                else
                {
                    counter = 0;
                }

            }
            for (int i = 0; i <= biggest; i++)
            {
                Console.Write(leftMost+" ");
            }
            Console.WriteLine();
        }
    }
}
