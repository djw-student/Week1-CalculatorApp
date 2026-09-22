using System.Xml.Serialization;

CalculatorApp();
void CalculatorApp()
{
    int firstNumber = 0;
    int secondNumber = 0;
    int result = 0;
    int choice = 0;

    Console.WriteLine("Enter the first number:");
    firstNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the second number:");
    secondNumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Choose an operation: +, -, *, /");
    Console.WriteLine("1 - Add");
    Console.WriteLine("2 - Subtract");
    Console.WriteLine("3 - Multiply");
    Console.WriteLine("4 - Divide");

    choice = Convert.ToInt32(Console.ReadLine());
    while (choice < 1 || choice > 4)
    {
        Console.WriteLine("Invalid choice - please select a valid option");
        Console.WriteLine("Choose an operation: +, -, *, /");
        Console.WriteLine("1 - Add");
        Console.WriteLine("2 - Subtract");
        Console.WriteLine("3 - Multiply");
        Console.WriteLine("4 - Divide");
        choice = Convert.ToInt32(Console.ReadLine());
    }
    if (choice == 1) {
        result = firstNumber + secondNumber;
        Console.WriteLine("Adding {0} and {1} gives {2}", firstNumber, secondNumber, result);
    }
    else if (choice == 2) {
        result = firstNumber - secondNumber;
        Console.WriteLine("Subtracting {0} from {1} gives {2}", secondNumber, firstNumber, result);
    } else if (choice == 3) {
        result = firstNumber * secondNumber;
        Console.WriteLine("Multiplying {0} and {1} gives {2}", firstNumber, secondNumber, result);
    } else if (choice == 4) {
        result = firstNumber / secondNumber;
        Console.WriteLine("Dividing {0} by {1} gives {2}", firstNumber, secondNumber, result);
    }
   
    }
