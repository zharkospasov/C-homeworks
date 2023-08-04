using System;

namespace _02.EquallSumsEvenOddPosition
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int odd = 0;
            int even = 0;

            for (int i = n; i <= x; i++)
            {
                string number = i.ToString();
                odd = 0;
                even = 0;
                for (int j = 0; j < number.Length; j++)
                {
                    int currentDigit = int.Parse(number[j].ToString());
                    if (j % 2 == 0)
                    {
                        even += currentDigit;
                    }
                    else
                    {
                        odd += currentDigit;
                    }
                }
                if (odd == even)
                {
                    Console.Write(i + " ");
                }
            }



        }
    }
}
