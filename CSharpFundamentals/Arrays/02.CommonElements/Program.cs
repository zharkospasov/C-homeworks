using System;
using System.Collections;
using System.Linq;
namespace _02.CommonElements
{
    class Program
    {
        static void Main()
        {
            string[] input1 = Console.ReadLine().Split(" ");
            string[] input2 = Console.ReadLine().Split(" ");
            
            for (int i = 0; i < input1.Length; i++)
            {
                for (int j = 0; j < input2.Length; j++)
                {
                    if (input1[i]==input2[j])
                    {
                        Console.Write(input2[j]+" ");
                    }
                }
            }
            
        }
    }
}
