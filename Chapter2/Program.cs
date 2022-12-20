﻿using System;

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

            FormatNumericalData();

            Console.ReadLine();
        }

        private static void FormatNumericalData()
        {
            Console.WriteLine("The value 99999 in various formats");
            Console.WriteLine("C format: {0:c}",99999);
            Console.WriteLine("d9 format: {0:d9}", 99999);
            Console.WriteLine("f3 format: {0:f3}", 99999);
            Console.WriteLine("n format: {0:n}", 99999);
            Console.WriteLine("E format: {0:E}", 99999);
            Console.WriteLine("e format: {0:e}", 99999);
            Console.WriteLine("X format: {0:X}", 99999);
            Console.WriteLine("x format: {0:x}", 99999);
        }
    }
}
