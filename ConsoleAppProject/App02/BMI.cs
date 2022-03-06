using ConsoleAppProject.Helpers;
using System;
using System.Text;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// This class contains methods for calculating 
    /// the user's BMI (Body Mass value) using 
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
                double value = MetricCalculator();
                Console.WriteLine("Your BMI is " + value);
                HelthMessage(value);
            }
            else if (choice == 2)
            {
                ImperialCalculator();

            }
            else
            {
                Console.WriteLine("Invalid Choice !!");
            }
            BMIMessage();

        }



        public double MetricCalculator()
            {

           int Centimetres = (int)ConsoleHelper.InputNumber(" \n Enter your height in centimetres > ");

           double metres = (double)Centimetres / 100;

           int Kilograms = (int)ConsoleHelper.InputNumber(" Enter your weight in kilograms > ");

            double value = Kilograms / (metres * metres);
            return value;
        }



        public void ImperialCalculator()
        {
            Console.WriteLine(" Enter your height to the nearest feet and inches ");
            Console.WriteLine();

            int Feet = (int)ConsoleHelper.InputNumber("\n Enter your height in feet > ");
            int Inches = (int)ConsoleHelper.InputNumber(" Enter your height in inches > ");

            Console.WriteLine();
            Console.Write(" Enter your weight to the nearest stones and pounds");
            Console.WriteLine();

            int Stones = (int)ConsoleHelper.InputNumber(" Enter your weight in stones > ");
            int Pounds = (int)ConsoleHelper.InputNumber(" Enter your weight in pounds > ");

            Inches += Feet * 12;
            Pounds += Stones * 14;

            double value = (double)Pounds * 703 / (Inches * Inches);

            Console.WriteLine("Your BMI is " + value);
            HelthMessage(value);
        }



        public void HelthMessage(double value)
        {
            if (value < 18.5)
            {
                Console.WriteLine("You are underweight! ");
            }
            else if (value <= 24.9)
            {
                Console.WriteLine("You are in the normal range! ");

            }
            else if (value <= 29.9)
            {
                Console.WriteLine("You are overweight! ");

            }
            else if (value <= 34.9)
            {
                Console.WriteLine("You are obese class I ");

            }
            else if (value <= 39.9)
            {
                Console.WriteLine("You are obese class II ");

            }
            else if (value <= 40)
            {
                Console.WriteLine("You are obese class III ");

            }

        }


        public void BMIMessage()
        {
            Console.WriteLine("If you are Black, Asian or other minority");
            Console.WriteLine("ethnic groups, you have a higher risk");
            Console.WriteLine("Adults 23.0 or more are at increased risk");
            Console.WriteLine("Adults 27.5 or more are at high risk");
            Console.WriteLine("\n");
        }

    }
}