using System;

namespace _05._Paycheck
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                if (name == "Facebook")
                {
                    salary -= 150;
                }
                if (name == "Instagram")
                {
                    salary -= 100;
                }
                if (name == "Reddit")
                {
                    salary -= 50;
                }
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    return;
                }
                name = Console.ReadLine();

            }
            if (salary > 0)
            {
                Console.WriteLine(salary);
            }
        }
    }
}
