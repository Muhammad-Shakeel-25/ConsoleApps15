using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.App04;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Muhammad Shakeel 05/02/2022
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("    BNU CO453 Applications Programming 2022-2022! ");
            Console.WriteLine("               by Muhammad Shakeel                ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();



            Console.WriteLine("1) Distance Converter\n2) BMI Calculater\n3) Student Marks\n4) Social Network");
            string selection = Console.ReadLine();

            if (selection == "1")
            {
                DistanceConverter distanceCalculater = new DistanceConverter();
                distanceCalculater.Run();
            }
            else if(selection=="2")
            {
                BMI bmi = new BMI();
                bmi.Calculate();
            }
            else if (selection == "3")
            {
                StudentGrades studentgrades = new StudentGrades();
                studentgrades.Run();            
            }
            else if (selection == "4")
            {
                SocialNetwork socialnetwork = new SocialNetwork();
                socialnetwork.Run();
            }
            else
            {
                Console.WriteLine("Invalid selection !!");
            }



        }
    }
}
