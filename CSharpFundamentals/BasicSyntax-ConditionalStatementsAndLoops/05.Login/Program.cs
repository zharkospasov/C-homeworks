using System;

namespace _05.Login
{
    class Program
    {
        static void Main()
        {
            string username = Console.ReadLine();
            
            string password = String.Empty;
            int tries = 0;

            for (int i = username.Length-1; i >=0 ; i--)
            {
                char x = username[i];
                
                password+= String.Join("",x);
            }
            while (Console.ReadLine()!=password)
            {
                
                    tries++;
                    if (tries == 4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password. Try again.");

                    }
                
                
            }
            Console.WriteLine($"User {username} logged in.");
        }
    }
}
