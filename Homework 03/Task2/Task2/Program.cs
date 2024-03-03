// See https://aka.ms/new-console-template for more information
/*Create a new console application with the following requirements:

Get an input from the console
Print all numbers from 1 to that number
Get another input number from the console
Print all numbers from that number to 1*/

{
    int number1;
    while (true)
    {
        Console.WriteLine("Input number1");
        string input1 = Console.ReadLine();
       if(int.TryParse(input1, out number1))
        {
            break;
        }
        Console.WriteLine("Wrong input,try again");
    }

    for (int i = 1; i<= number1; i++)
    {
        Console.WriteLine($"{i}");
    }
    int number2;
    while (true)
    {
        Console.WriteLine("Input number2");
        string input2 = Console.ReadLine();
        if (int.TryParse(input2, out number2))
        {
            break;
        }
        Console.WriteLine("Wrong input,try again");
    }
    for (int j = number2; j > 0; j--)
    {
        Console.WriteLine($"{j}");
    }
    Console.ReadLine();
}