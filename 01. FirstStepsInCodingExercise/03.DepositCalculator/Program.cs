using System;

namespace _03.DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositAmount = double.Parse(Console.ReadLine());
            int depoisitTime = int.Parse(Console.ReadLine());
            double yearlyInterest= double.Parse(Console.ReadLine());
            double result;
            double accumulatedInterst = depositAmount * yearlyInterest/100;
            result = accumulatedInterst / 12 * depoisitTime + depositAmount;
            Console.WriteLine(result);
        }
    }
}
