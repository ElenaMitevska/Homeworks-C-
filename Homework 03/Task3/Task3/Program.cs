// See https://aka.ms/new-console-template for more information
/*Get an input number from the console
● Print all even numbers starting from 2
● Get another input number from the console
● Print all odd numbers starting from 1
*/

{
    int number1;
    while (true)
    {
        Console.WriteLine("Input number1");
        string input = Console.ReadLine();
        if(int.TryParse(input, out number1))
        {
            break;
        }
        Console.WriteLine("Wrong input, try again");
    }
    for (int i = 2; i < number1; i++)
    {
        if(i % 2 == 0)
        {
            Console.WriteLine($"{i}");
        }
    }
    int number2;
    while (true)
    {
        Console.WriteLine("Input number2");
        string input2 = Console.ReadLine();
        if(int.TryParse(input2, out number2))
        {
            break;
        }
        Console.WriteLine("Wrong input, please try again");
    }
    for (int j = 1; j < number2; j++)
    {
        if(j % 2 == 1)
        {
            Console.WriteLine($"{j}");
        }
    }
}
