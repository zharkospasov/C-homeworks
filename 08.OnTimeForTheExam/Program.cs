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
            if (totExamTime==totArrivalTime)
            {
                Console.WriteLine("On time");
            }
            else if (totExamTime>totArrivalTime)
            {
                if (totExamTime-totArrivalTime<=30&&totExamTime-totArrivalTime>=1)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{totExamTime - totArrivalTime} minutes before the start");
                }
                else if (totExamTime-totArrivalTime>30)
                {
                    Console.WriteLine("Early");
                    int hour = (totExamTime - totArrivalTime)/60;
                    int min= (totExamTime - totArrivalTime) %60;
                    if (hour<1)
                    {
                        Console.WriteLine($"{min.ToString("00")} minutes before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{hour}:{min.ToString("00")} hours before the start");
                    }
                }
            }
            else if (totArrivalTime>totExamTime)
            {
                if (totArrivalTime-totExamTime>=60)
                {
                    int hour = (totArrivalTime - totExamTime) / 60;
                    int min= (totArrivalTime -totExamTime)% 60;
                    Console.WriteLine("Late");
                    Console.WriteLine($"{hour}:{min.ToString("00")} hours after the start");
                }
                else if (totArrivalTime-totExamTime>=1&&totArrivalTime-totExamTime<60)
                {
                    int min = totArrivalTime - totExamTime;
                    Console.WriteLine("Late");
                    Console.WriteLine($"{min.ToString("00")} minutes after the start");
                }
            }
            Console.WriteLine();
        }
    }
}
