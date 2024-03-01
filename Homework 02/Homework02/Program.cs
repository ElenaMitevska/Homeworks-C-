// See https://aka.ms/new-console-template for more information
/*Create a new console application called “AverageNumber” that takes four numbers as input to calculate and print the average.

Test Data:
Enter the First number: 10
Enter the Second number: 15
Enter the third number: 20
Enter the fourth number: 30
Expected Output:
The average of 10, 15, 20 and 30 is: 18*/

Console.WriteLine("Write first number");
string input1 = Console.ReadLine();
Console.WriteLine("Write second number");
string input2 = Console.ReadLine();
Console.WriteLine("Write third number");
string input3 = Console.ReadLine();
Console.WriteLine("Write fourth number");
string input4 = Console.ReadLine();
int number1 = int.Parse(input1);
int number2 = int.Parse(input2);
int number3 = int.Parse(input3);
int number4 = int.Parse(input4);
bool success = int.TryParse(input1, out number1) && int.TryParse(input2, out number2) && int.TryParse(input3, out number3) && int.TryParse(input4, out number4);
if (success)
{
    int result = (number1 + number2 + number3 + number4) / 4;
    Console.WriteLine($"The average result is: {result} ");
}
if (!success) { Console.WriteLine("Your input is not a number");
    return;
}

Console.ReadLine();

/*2.Task 2:
Create a new console application called “SwapNumbers”. Input 2 numbers from the console and then swap the values of the variables so that the first variable has the second value and the second variable the first value. Please find example below:

Test Data:
Input the First Number: 5
Input the Second Number: 8
Expected Output:
After Swapping:
First Number: 8
Second Number: 5 */

Console.WriteLine("Input number1");
int inputNumber1 = int.Parse(Console.ReadLine());
Console.WriteLine("Input number 2");
int inputNumber2 = int.Parse(Console.ReadLine());
int tempValueHolder = inputNumber1;
inputNumber1 = inputNumber2;
inputNumber2 = tempValueHolder;
string result1 = ($"First number is:{inputNumber1} Second number is: {inputNumber2}");
Console.WriteLine(result1);
Console.ReadLine();


