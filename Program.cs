using System;

class Program
{
   public static void Main()
    {
        Console.WriteLine("Enter the first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the operation (+, -, *, /):");
        string operation = Console.ReadLine();

        double result = 0;

        if (operation == "+")
        {
            result = num1 + num2;
            Console.WriteLine($"\nResult: {num1} + {num2} = {result}");
        }
        else if (operation == "-")
        {
            result = num1 - num2;
            Console.WriteLine($"\nResult: {num1} - {num2} = {result}");
        }
        else if (operation == "*")
        {
            result = num1 * num2;
            Console.WriteLine($"\nResult: {num1} * {num2} = {result}");
        }
        else if (operation == "/")
        {
            
                result = num1 / num2;
                Console.WriteLine($"\nResult: {num1} / {num2} = {result}");
        }
        else
        {
            Console.WriteLine("Invalid operation. Please enter +, -, *, or /.");
        }
    }
}