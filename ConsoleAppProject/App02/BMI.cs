using ConsoleAppProject.Helpers;
using System;
using System.Text;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// This class contains methods for calculating 
    /// the user's BMI (Body Mass Index) using 
    /// imperial or metric units.
    /// </summary>
    /// <Author>
    /// Muhammad Shakeel App02: Version 1.0
    /// </Author>
    public class BMI
    {

        string[] choices = new string[] { $"{UnitSystems.Metric}", $"{UnitSystems.Imperial}" };

        public void Calculate()
        {
            int choice = ConsoleHelper.SelectChoice(choices);
            if (choice == 1)
            {
                MetricCalculator();
            }
            else if (choice == 2)
            {


            }
            else
            {
                Console.WriteLine("Invalid Choice !!");
            }
            BMIMessage();

        }



        public void MetricCalculator()
            {

           int Centimetres = (int)ConsoleHelper.InputNumber(" \n Enter your height in centimetres > ");

           double metres = (double)Centimetres / 100;

           int Kilograms = (int)ConsoleHelper.InputNumber(" Enter your weight in kilograms > ");

            double value = Kilograms / (metres * metres);
            Console.WriteLine("Your BMI is "+value);
        }

        public void BMIMessage()
        {
            Console.WriteLine(" If you are Black, Asian or other minority");
            Console.WriteLine("\n ethnic groups, you have a higher risk");
            Console.WriteLine("\n");
            Console.WriteLine("\n Adults 23.0 or more are at increased risk");
            Console.WriteLine("\n Adults 27.5 or more are at high risk");
            Console.WriteLine("\n");
        }

    }
}