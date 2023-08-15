using System;

namespace _05.Messages
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                if (int.Parse(input)==0)
                {
                    Console.Write(" ");
                }
                else
                {
                    int numberOfDigits = input.Length;
                    int mainNumber = int.Parse(input) % 10;
                    int offset = (mainNumber - 2) * 3;
                    if (mainNumber == 8 || mainNumber == 9)
                    {
                        offset += 1;
                    }
                    int letterIndex = offset + numberOfDigits - 1;
                    char letter = (char)(letterIndex + 97);
                    Console.Write(letter);
                }
                
            }
        }
    }
}
