using System;

namespace _05.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1111; i <= 9999; i++)
            {
                    int counter = 0;
                string special = i.ToString();
                for (int j = 0; j < special.Length; j++)
                {
                    int divider = int.Parse(special[j].ToString());
                    if ( divider > 0&&n %divider==0)
                    {
                        counter++;
                    }
                }
                if (counter==4)
                {
                    Console.Write(i+" ");
                }
            }
            
        }
    }
}
