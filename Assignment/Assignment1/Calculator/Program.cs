using System;

class Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculator : <number1> <operator> <num>");
        int num1 = int.Parse(args[0]);
        int num2 = int.Parse(args[2]);
        string op = args[1];

        switch (op)
        {
            case "+":
                Console.WriteLine("Addition = " + (num1 + num2));
                break;

            case "-":
                Console.WriteLine("Subtraction = " + (num1 - num2));
                break;

            case "*":
                Console.WriteLine("Multiplication = " + (num1 * num2));
                break;

            case "/":
                Console.WriteLine("Division = " + (num1 / num2));
                break;

            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }
}



//to run right click on project ->go to properties->  