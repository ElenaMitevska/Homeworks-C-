// See https://aka.ms/new-console-template for more information
/*Create an array with names
Give an option to the user to enter a name from the keyboard

After entering the name put it in the array

Ask the user if they want to enter another name(Y / N)

Do the same process over and over until the user enters N

Print all the names after user enters N*/

string[] names = new string[0];

do
{
    Console.WriteLine("Please enter a name");
    string input = Console.ReadLine();

    Array.Resize(ref names, names.Length + 1);
    names[names.Length - 1] = input;
    Console.WriteLine("Do you want to enter another name y/n?");
    string input2 = Console.ReadLine();
    if (input2 == "n" || input2 == "N")
    {
        break;
    } } while (true);
foreach(string name in names)
{
    Console.WriteLine(name);
}
