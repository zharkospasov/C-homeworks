using System;

namespace _06.OperationsBetweenNumbers
{
    class Program
    {
        static void Main()
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            char oper= (char)Console.Read();
            double result;
            string resultType = String.Empty;
            if (oper=='+')
            {
                result = n1 + n2;
                if (result%2==0)
                {
                    resultType = "even";
                }
                else
                {
                    resultType = "odd";
                }
                    Console.WriteLine($"{n1} {oper} {n2} = {result} - {resultType}");
            }
            else if (oper=='-')
            {
                result = n1 - n2;
                if (result % 2 == 0)
                {
                    resultType = "even";
                }
                else
                {
                    resultType = "odd";
                }
                Console.WriteLine($"{n1} {oper} {n2} = {result} - {resultType}");
            }
            else if (oper == '*')
            {
                result = n1 * n2;
                if (result % 2 == 0)
                {
                    resultType = "even";
                }
                else
                {
                    resultType = "odd";
                }
                Console.WriteLine($"{n1} {oper} {n2} = {result} - {resultType}");
            }
            else if (oper=='/')
            {
                if (n2>0)
                {
                        
                    Console.WriteLine($"{n1} {oper} {n2} = {n1/n2:f2}");

                }
                else
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
            }
            else if(oper=='%')
            {
                if (n2==0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    result = n1 % n2;
                    Console.WriteLine($"{n1} {oper} {n2} = {result}");

                }
            }

        }
    }
}
