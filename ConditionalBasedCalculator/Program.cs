// See https://aka.ms/new-console-template for more information
// TODO: Implement the calculator logic here
double num1;
double num2;

Console.WriteLine("Enter the first number:");
bool userInput1 = double.TryParse(Console.ReadLine(), out num1);

Console.WriteLine("Enter the second number:");
bool userInput2 = double.TryParse(Console.ReadLine(), out num2);


if (userInput1 && userInput2)
{
    Console.WriteLine("Choose an operation: +, -, *, /");
    string operation = Console.ReadLine();
    if (operation == "+")
        Console.WriteLine($"Result: {num1 + num2}");
    else if (operation == "-")
        Console.WriteLine($"Result: {num1 - num2}");
    else if (operation == "*")
        Console.WriteLine($"Result: {num1 * num2}");
    else if (operation == "/" && num2 == 0)
        Console.WriteLine("Error: Division by zero is not allowed.");
    else if (operation == "/")
        Console.WriteLine($"Result: {num1 / num2}");
    else
    {
        Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
    }
}

Console.ReadLine();