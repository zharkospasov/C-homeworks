﻿using System;

namespace _01.NumbersEndingIn7
{
    class Program
    {
        static void Main()
        {
            for (int i = 7; i <= 997; i++)
            {
                if (i%10==7)
                {
                    Console.WriteLine(i);
                }
            }
            
        }
    }
}
