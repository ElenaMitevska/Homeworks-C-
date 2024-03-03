// See https://aka.ms/new-console-template for more information
/*Create a new console application “RealCalculator” that takes two numbers from the console and asks what operation would the user want to be done ( +, - , * , / ). Then it returns the result. Use a switch statement.

Test Data:
Enter the First number: 10
Enter the Second number: 15
Enter the Operation: +
Expected Output:
The result is: 25

BONUS: If the user enters a wrong input he/she can re-enter the value(use while-loop).*/


{
    int number1;
    while (true)
    {
        Console.WriteLine("Enter the first number:");
        string input = Console.ReadLine();
        if (int.TryParse(input, out number1))
        {
            break;
        }
        Console.WriteLine("Wrong input, please try again");
    }
    int number2;
        while (true)
        {
            Console.WriteLine("Enter the second number:");
            string input2 = Console.ReadLine();
            if (int.TryParse(input2, out number2))
            {
                break;
            }
            Console.WriteLine("Wrong input, please try again");
        }
  
            Console.WriteLine("Choose the operation");
    string input3 = Console.ReadLine();
    int result;
    switch (input3)
    {
        case "+":
             result = number1 + number2;
            Console.WriteLine($"The result is: {result = number1 + number2}");
            break;
            
        case "-":
            Console.WriteLine($"The result is: {result = number1 - number2}");
               break;
            
        case "*":
            Console.WriteLine($"The result is: {result = number1 * number2}");
             break;
            
        case "/":
            Console.WriteLine($"The result is: {result = number1 / number2}");
              break;
           
        default:
            Console.WriteLine("Wrong choice");
            break;
    }
}