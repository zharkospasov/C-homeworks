using System;

namespace _08.OnTimeForTheExam
{
    class Program
    {
        static void Main()
        {
            int examH = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());
            int arrivalH = int.Parse(Console.ReadLine());
            int arrivalMin = int.Parse(Console.ReadLine());
            int totExamTime = examH * 60 + examMin;
            int totArrivalTime = arrivalH * 60 + arrivalMin;
            if (totExamTime>totArrivalTime)
            {
                if (totExamTime-totArrivalTime<=30&&totExamTime-totArrivalTime>=0)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{totExamTime - totArrivalTime} minutes before the start");
                }
                else if (totExamTime-totArrivalTime>30)
                {
                    Console.WriteLine("Early");
                    int hour = (totExamTime - totArrivalTime)/60;
                    int min= (totExamTime - totArrivalTime) %10;
                    Console.WriteLine($"{hour}:{min:mm} hours before the start");
                }
            }
            Console.WriteLine();
        }
    }
}
