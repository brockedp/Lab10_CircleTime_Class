using System;
using System.Collections.Generic;

namespace Lab10_CircleTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Welcome to Circle Tester");
            int num = 0;
            bool again = true;
            while (again)
            {
                
                Circle circles = new Circle(TryCatchInput("Please enter a radius length: "));

                Console.WriteLine($"Circumference: {circles.CalculateFormattedCircumference()}");
                Console.WriteLine($"Area: {circles.CalculateFormattedArea()}");
                num++;


                if(!PlayAgain("Would you like to add another circle?(y/n): "))
                {
                    //int numberOfCircles = circles.Count;
                    Console.WriteLine($"You have {num} circles.\nGood Bye!");
                    again = false;
                }
                
            }
        }

        public static string GetUserInput(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
        public static double ParseInput(string message)
        {
            string input = GetUserInput(message);
            if(double.TryParse(input, out double userDouble))
            {
                return userDouble;
            }
            else
            {
                return ParseInput("Error! That is improper input. Please try again: ");
            }
        }
        public static bool PlayAgain(string message)
        {
            string input = "";
            while (input != "y" && input != "n")
            {
                Console.Write(message);
                input = Console.ReadLine();
            }
            if (input == "y")
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        public static double TryCatchInput(string message)
        {
            string input = GetUserInput(message);
            try
            {
                double userNumber = double.Parse(input);
                return userNumber;
            }
            catch (FormatException)
            {

                return TryCatchInput("That was not a number. Please try again: ");
            }
            catch (OverflowException)
            {
                return TryCatchInput("That number is too large. Please try again: ");

            }
            catch
            {
                return TryCatchInput("Error! Please try again: ");

            }
        }
    }
}
