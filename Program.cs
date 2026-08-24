using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Reverse a string");
            Console.WriteLine("0. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine() ?? string.Empty;

            switch (choice)
            {
                case "1":
                    Console.Write("Enter a string: ");
                    string input = Console.ReadLine() ?? string.Empty;
                    Console.WriteLine("******************************************************");
                    Console.WriteLine($"Reversed string: {StringFunctions.Reverse(input)}");
                    break;

                case "0":
                    return;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}