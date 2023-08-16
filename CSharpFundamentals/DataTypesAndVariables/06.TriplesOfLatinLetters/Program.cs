using System;

namespace _06.TriplesOfLatinLetters
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <n; i++)
            {
                for (int j = 0; j <n; j++)
                {
                    for (int z = 0; z < n; z++)
                    {

                        Console.WriteLine((char)(i+97)+""+(char)(j+97)+""+(char)(z+97));
                    }
                }
            }
            
        }
    }
}
