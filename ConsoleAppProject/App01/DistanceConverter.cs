using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Vincent 0.1
    /// </author>
    public class DistanceConverter
    {
        public const double FEET_IN_MILES = 5280;

        public const double METRES_IN_MILES = 1630;

        public const double FEET_IN_METRES = 3.2;

        public const string FEET = "feet";
        public const string MILES = "miles";
        public const string Metres = "metres";

        private double toDistance;

        private string fromUnit;
        private string toUnit;
        private double fromDistance;

        /// <summary>
        /// This method will output a heading, ask for the
        /// Input for miles, calculate and output the some
        /// distance in feet.
        /// </summary>
        public void Run()
        {
              OutputHeading();
           


            ConvertFeetToMiles();
            //ConvertMilesToMetres();
            ConvertMilesToFeet();
        }
         public void ConvertFeetToMiles()
         {
            fromUnit= FEET;
            toUnit= MILES;
            InputDistance(fromUnit);
            toDistance= fromDistance/FEET_IN_MILES;
            OutputDistance();
         }

         public void ConvertMilesToFeet()
         {
            fromUnit= MILES;
            toUnit= FEET;
            InputDistance(fromUnit);
            toDistance= fromDistance / FEET_IN_MILES;
            OutputDistance();
        }

         public void ConvertFeetToMetres()
         {
             fromUnit= FEET;
            toUnit = Metres;
             InputDistance(fromUnit);
            toDistance = fromDistance / FEET_IN_METRES;
             OutputDistance();
         }

         private void inputFeet()
         {
             Console.Write("please input the distance in feet > ");

             string number = Console.ReadLine();
             fromDistance = Convert.ToDouble(number);
         }

        private static void OutputHeading()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("\n------------------------------");
            Console.WriteLine("         Covert Miles to feet ");
            Console.WriteLine("            by Vincent Ogieva ");
            Console.WriteLine(" =================================================\n");
        }

        /// <summary>
        /// Prompt the user to enter the distance in miles
        /// Input the miles as a double number
        /// </summary>
        private void InputDistance(string unit)
        {
            Console.Write($"Please enter the number of {unit} > ");
            
            string number = Console.ReadLine();
            fromDistance = Convert.ToDouble(number);
        }   

        private void CalculateMiles()
        {
            toDistance = fromDistance / 5280;
        }

        private void OutputDistance()
        {
            Console.WriteLine($"{fromDistance} {fromUnit} is {toDistance}  {toUnit}");
        }
    }
}
    