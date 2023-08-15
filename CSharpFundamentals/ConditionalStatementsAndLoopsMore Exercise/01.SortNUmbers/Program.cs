using System;

namespace _01.SortNUmbers
{
    class Program
    {
        static void Main()
        {

            int biggest = int.MinValue;
            int smallest = int.MinValue;
            int middle = int.MinValue;
            for (int i = 0; i < 3; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (input > biggest)
                {
                    smallest = middle;
                    middle = biggest;
                    biggest = input;

                }
                else
                {
                    if (input > middle)
                    {
                        smallest = middle;
                        middle = input;
                    }
                    else
                    {
                        smallest = input;
                    }
                }
               
                
            }
            Console.WriteLine(biggest);
            Console.WriteLine(middle);
            Console.WriteLine(smallest);
        }
    }
}
 