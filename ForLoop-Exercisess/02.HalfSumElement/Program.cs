using System;

namespace _02.HalfSumElement
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int num = 0;
            int sum = 0;
            int max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                num = int.Parse(Console.ReadLine());
                sum += num;
                if (max<num)
                {
                    max = num;

                }
            }
            if (max==sum-max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = "+max);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = "+Math.Abs(max-(sum-max)));
            }
        }
    }
}
