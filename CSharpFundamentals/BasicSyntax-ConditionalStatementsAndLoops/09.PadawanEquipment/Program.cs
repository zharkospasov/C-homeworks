using System;

namespace _09.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double students = double.Parse(Console.ReadLine());
            double lightsabers = double.Parse(Console.ReadLine());
            double robes = double.Parse(Console.ReadLine());
            double belts = double.Parse(Console.ReadLine());
            double studentsPerscent = Math.Ceiling(students * 0.10);
            lightsabers = lightsabers * (students+studentsPerscent);
            if (students<6)
            {
                belts = belts * students;
            }
            if(students>=6)
            {

                belts = belts * (students - Math.Floor(students/6));
            }
            robes = robes * students;
            double total = belts + lightsabers + robes;
            if (total<=money)
            {
                Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {total-money:f2}lv more.");
            }
               
           
        }
    }
}
