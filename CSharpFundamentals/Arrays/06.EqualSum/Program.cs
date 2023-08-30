using System;
using System.Collections;
using System.Linq;
namespace _06.EqualSum
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int sumLeft = 0;
            int sumRight = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array.Length==1)
                {
                    Console.WriteLine("0");
                    return;
                }
                if (i>0)
                {
                    sumLeft += array[i - 1];
                }
                for (int j = i+1; j < array.Length; j++)
                {
                    sumRight += array[j];
                }
                if (sumLeft==sumRight)
                {

                    Console.WriteLine(i);
                    return;
                }
                
                sumRight = 0;
            }
            Console.WriteLine("no");
        }
    }
}
