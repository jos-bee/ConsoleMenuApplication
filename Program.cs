using System;
 
namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Console Menu Program");
            Console.WriteLine("====================");
            ShowOptions();

            switch (Console.ReadLine())
            {
                case "1":
                    ReverseString();
                    return true;
                case "2":
                    RemoveWhitespace();
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }

        private static string CaptureInput()
        {
            Console.Write("Please, enter the string you want to modify: ");
            return Console.ReadLine();
        }

        private static void ReverseString()
        {
            Console.Clear();
            Console.WriteLine("Reversing a string");
            Console.WriteLine("==================");

            char[] charArray = CaptureInput().ToCharArray();
            Array.Reverse(charArray);
            DisplayResult(String.Concat(charArray));
        }

        private static void RemoveWhitespace()
        {
            Console.Clear();
            Console.WriteLine("Removing Whitespace");
            Console.WriteLine("===================");


            DisplayResult(CaptureInput().Replace(" ", ""));
        }

        private static void DisplayResult(string message)
        {
            Console.WriteLine($"\r\nYour resulting string is: {message}");
            Console.Write("\r\nPlease, press Enter to return to the Menu");
            Console.ReadLine();
        }

        private static void ShowOptions()
        {
            Console.WriteLine("1) Reversing a string");
            Console.WriteLine("2) Removing Whitespace from a string");
            Console.WriteLine("3) Exit");
            Console.Write("\r\nPlease, select an option: ");
        }
    }
}