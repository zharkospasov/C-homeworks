using System;

namespace _04.SumOfChars
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
               var x =Console.ReadLine();
                
                sum +=x[0];
            }

            Console.WriteLine("The sum equals: {0}",sum);
        }
    }
}
