using System;

namespace Chapter2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "App";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("***************************************************");
            Console.WriteLine("***************** Welcome to my App ***************");
            Console.WriteLine("***************************************************");
            Console.BackgroundColor = ConsoleColor.Black;

            Console.ReadLine();
        }
    }
}
