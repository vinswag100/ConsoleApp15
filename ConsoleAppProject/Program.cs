using ConsoleAppProject.App01;
using ConsoleAppProject.App04;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Vincent Ogieva 05/02/2022
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("--------------------------------------------------=");
            Console.WriteLine("    BNU CO453 Applications Programming 2021-2022! ");
            Console.WriteLine("--------------------------------------------------=");
            Console.WriteLine();

            //DistanceConverter converter = new DistanceConverter();
            //converter.Run();
            NetworkApp app04 = new NetworkApp();
            app04.Run();

            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}
