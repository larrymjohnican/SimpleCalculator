using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start an infinite loop to repeatedly display the menu until the user chooses to exit
            while (true)
            {
                // Display the menu options to the user
                Console.WriteLine("Simple Calculator");
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");

                // Read the user's choice
                string choice = Console.ReadLine();

                // Check if the user wants to exit
                if (choice == "5")
                {
                    // Exit the loop and end the program
                    break;
                }

                // Prompt the user for the first number
                Console.WriteLine("Enter the first number:");
                double num1 = Convert.ToDouble(Console.ReadLine());

                // Prompt the user for the second number
                Console.WriteLine("Enter the second number:");
                double num2 = Convert.ToDouble(Console.ReadLine());

                // Variable to store the result of the operation
                double result = 0;

                // Perform the operation based on the user's choice
                switch (choice)
                {
                    case "1":
                        // Addition
                        result = num1 + num2;
                        break;
                    case "2":
                        // Subtraction
                        result = num1 - num2;
                        break;
                    case "3":
                        // Multiplication
                        result = num1 * num2;
                        break;
                    case "4":
                        // Division
                        result = num1 / num2;
                        break;
                    default:
                        // Handle invalid choices
                        Console.WriteLine("Invalid choice.");
                        // Continue to the next iteration of the loop
                        continue;
                }

                // Display the result of the operation
                Console.WriteLine($"The result is: {result}");
            }
        }
    }
}
