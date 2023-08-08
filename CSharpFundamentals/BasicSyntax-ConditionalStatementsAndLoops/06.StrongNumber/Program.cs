using System;

namespace _06.StrongNumber
{
    class Program
    {
        static void Main()
        {
            string  n = Console.ReadLine();
            int sum = 1;
            int sumFacturiel = 0;
            for (int i = 0; i < n.Length; i++)
            {

                int number = int.Parse(n[i].ToString());
                for (int j = 1; j <=number; j++)
                {
                    sum *= j;
                    
                }
                sumFacturiel += sum;
                sum = 1;
            }
            if (sumFacturiel==int.Parse(n))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
           
        }
    }
}
