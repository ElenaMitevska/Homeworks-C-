// See https://aka.ms/new-console-template for more information
/*Make a console application called SumOfEven. Inside it create an array of 6 integers. Get input numbers from the console and push them to the array. Find and print the sum of the even numbers from the array:

Test Data:
Enter integer no.1:
4
Enter integer no.1:
3
Enter integer no.1:
7
Enter integer no.1:
3
Enter integer no.1:
2
Enter integer no.1:
8
Expected Output:
The result is: 14*/

int[] numbers = new int[0];

for (int i = 0; i < 6; i++)
{
    Console.WriteLine("Enter a number");

    string input = Console.ReadLine();

    if (!int.TryParse(input, out int number1))
    {
        Console.WriteLine("Wrong input");
        continue;
    }

    Array.Resize(ref numbers, numbers.Length + 1);
    numbers[numbers.Length - 1] = number1;
}
{ 
    int sum = 0;
    foreach(int number in numbers)
    { if (number % 2 == 0)
        {
            sum += number;
        }
    }
    Console.WriteLine($"The result is: {sum}");
}

