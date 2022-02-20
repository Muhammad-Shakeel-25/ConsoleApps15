using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Convert distance from 4 different units and vice versa.
    /// </summary>
    /// <author>
    /// Muhammad Shakeel version 0.1
    /// </author>
    public class DistanceConverter
    {
        /// <summary>
        /// predifine variables
        /// </summary>
        string choice1;
        string choice2;
        string FromDistanceValue;
        string[] choices = new string[] { "Feet", "Metres", "Kilometres", "Miles" };
     
       ///Constructer to initlize the program 
        
        public DistanceConverter()
        {
            ShowChoices();
            Console.WriteLine("Enter your 1st choice?");
            choice1 = Console.ReadLine();
            if (Convert.ToInt32(choice1) < 5)
            {
                Console.WriteLine("Please enter Value in " + choices[Convert.ToInt32(choice1) - 1]);
                FromDistanceValue = Console.ReadLine();
                ShowChoices();
                Console.WriteLine("Enter your 2nd choice?");
                choice2 = Console.ReadLine();
                if (Convert.ToInt32(choice2) < 5)
                {
                    Console.WriteLine(FromDistanceValue + " " + choices[Convert.ToInt32(choice1) - 1] + " to " + choices[Convert.ToInt32(choice2) - 1] + " is");
                    
                    Console.WriteLine(OutputResult());
                }
                else
                {
                    InvalidChoice();
                }
            }
            else
            {
                InvalidChoice();

            }


        }

        /// <summary>
        /// use to return double value of the given distance.Calculate the from distance to, to distance
        /// </summary>
        /// <returns></returns>
        private double OutputResult()
        {
            if (choice1 == "1" && choice2 == "1")
            {

                return Convert.ToDouble(FromDistanceValue);
            }
            else if (choice1 == "1" && choice2 == "2")
            {
                return Convert.ToDouble(FromDistanceValue)/3.281;
            }
            else if (choice1 == "1" && choice2 == "3")
            {
                return Convert.ToDouble(FromDistanceValue)/ 3281;
            }
            else if (choice1 == "1" && choice2 == "4")
            {
                return Convert.ToDouble(FromDistanceValue)/ 5280;
            }
            else if (choice1 == "2" && choice2 == "1")
            {
                return Convert.ToDouble(FromDistanceValue)* 3.281;
            }
            else if (choice1 == "2" && choice2 == "2")
            {
                return Convert.ToDouble(FromDistanceValue);
            }
            else if (choice1 == "2" && choice2 == "3")
            {
                return Convert.ToDouble(FromDistanceValue)/ 1000;
            }
            else if (choice1 == "2" && choice2 == "4")
            {
                return Convert.ToDouble(FromDistanceValue)/ 1609;
            }
            else if (choice1 == "3" && choice2 == "1")
            {
                return Convert.ToDouble(FromDistanceValue)* 3281;
            }
            else if (choice1 == "3" && choice2 == "2")
            {
                return Convert.ToDouble(FromDistanceValue)* 1000;
            }
            else if (choice1 == "3" && choice2 == "3")
            {
                return Convert.ToDouble(FromDistanceValue);
            }
            else if (choice1 == "3" && choice2 == "4")
            {
                return Convert.ToDouble(FromDistanceValue)/ 1.609;
            }
            else if (choice1 == "4" && choice2 == "1")
            {
                return Convert.ToDouble(FromDistanceValue)* 5280;
            }
            else if (choice1 == "4" && choice2 == "2")
            {
                return Convert.ToDouble(FromDistanceValue)* 1609;
            }
            else if (choice1 == "4" && choice2 == "3")
            {
                return Convert.ToDouble(FromDistanceValue)* 1.609;
            }
            else if (choice1 == "4" && choice2 == "4")
            {
                return Convert.ToDouble(FromDistanceValue);
            }
            else
            {
                return Convert.ToDouble(FromDistanceValue);
            }

        }


        /// <summary>
        /// used to show all choices for distance converter 
        /// </summary>
        private void ShowChoices()
        {


            for (int i = 0; i < choices.Length; i++)
            {
                Console.WriteLine((i + 1) + ") " + choices[i] + "");
            }


        }


        /// <summary>
        /// if there is any invalid choice it will show the error message
        /// </summary>
        private void InvalidChoice()
        {

            Console.WriteLine("Your choice is invalid.");
            ///DistanceConverter d=new DistanceConverter();

        }



    }
}
