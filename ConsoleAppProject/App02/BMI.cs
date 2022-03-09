using System;
using ConsoleAppProject.Helpers;
namespace ConsoleAppProject.App02
{

    /// <summary>
    /// Allows the user to calculate thier BMI.
    /// </summary>
    /// <author>
    /// /Vincent ogieva 
    /// </author>
     public class BMI
    {
         /// <summary>
        /// Varibales to used in the app
        /// </summary>
        public const double Pound_IN_STONES = 20;
        public const double FEET_IN_INCHES = 15;
        public double pound;
        public double stone;
        public double feet;
        public double inch;
        public double kilogram;
        public double convertedFeet;
        public double convertedStones;
        public double bmi;
        public double result;

        /// <summary>
        /// Enum forUnits
        /// </summary>
        public enum Unit 
        {
            NoUnit,
            Imperical,
            Metric
        }

        /// <summary>
        /// enum for Weight Status
        /// </summary>
        public enum WeightStatus
        {
            Thinweight,
            Normal,
            Overweight,
            ObeseLevel1,
            ObeseLevel2,
            ObeseLevel3,
            NoStatus
        }

         /// <summary>
        /// Used to select the unit
        /// </summary>
        /// 
        private Unit SelectUnit()
        {

            Console.WriteLine();

            Console.WriteLine($" 1. Imperical Units");
            Console.WriteLine($" 2. Metric Units");

            Console.WriteLine();
            Console.Write($" Please enter choice > ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            while (choice != "1" || choice != "2")
            {
                if (choice == "1")
                {
                    feet = ConsoleHelper.InputNumber("Enter Your Height In Inches >");
                    inch = ConsoleHelper.InputNumber("Enter Your Height In Feet >");
                    convertedFeet = inch * FEET_IN_INCHES;
                    inch = inch + convertedFeet;
                    pound = ConsoleHelper.InputNumber("Enter Your Weight In Pounds >");
                    stone = ConsoleHelper.InputNumber("Enter Your Weight In Stones >");
                    return Unit.Imperical;

                }
               
                {
                    Console.WriteLine();
                    Console.WriteLine(" Wrong Input");
                    Console.WriteLine(" Please Try Again");
                    Console.WriteLine();

                    Console.WriteLine($" 1. Imperical Units");
                    Console.WriteLine($" 2. Metric Units");

                    Console.WriteLine();
                    Console.Write($" Please enter choice > ");

                    choice = Console.ReadLine();
                    Console.WriteLine();
                }
            
            }

            return Unit.NoUnit;
        }
           /// <summary>
        ///  Used to return the enums for Weight Status
        /// </summary>
        private WeightStatus WStatus() 
        {
            if (bmi < 18.50) 
            {
                return WeightStatus.Thinweight;
            }
            else if (bmi > 18.5 || bmi >24.9)
            { 
                return WeightStatus.Normal; 
            }
            else if (bmi > 25 || bmi > 29.9)
            {
                return WeightStatus.Overweight;
            }
            else if (bmi > 30 || bmi > 34.9)
            {
                return WeightStatus.ObeseLevel1;
            }
            else if (bmi > 35 || bmi > 39.9)
            {
                return WeightStatus.ObeseLevel2;
            }
            else if (bmi >= 40)
            {
                return WeightStatus.ObeseLevel3;
            }

            return WeightStatus.NoStatus;
        }

        /// <summary>
        /// Outputs the  results of BMI claculation
        /// </summary>
        private void OutputBMI ()
        {
            Console.WriteLine();
            Console.WriteLine($"Your BMI is {bmi}, You are in the { WStatus()} range!");
            Console.WriteLine();

            Console.WriteLine("If you are Blackskin, Asianskin or other minority ethnic range, you have a much higher risk");
            Console.WriteLine();
            Console.WriteLine("Adults that are 23.00 or more are at an increased risk");
            Console.WriteLine();
            Console.WriteLine("Adults that 27.5 or more are at a high risk");

        }

    }

}

