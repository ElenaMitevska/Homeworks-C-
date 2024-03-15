using System.Globalization;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Create a class Dog
Add properties: Name, breed, color
The dog needs to have an Eat method that returns a message: The dog is now eating.
A Play method returning a message : The dog is now playing.
And a ChaseTail method that returns a message: The dog is now chasing it's tail.
The user needs to create a dog object by using inputs from the console
            and then choose an option to choose one of the methods mentioned above.
For example, if he enters 1 to call the Eat method, if he enters 2
            to call the Play method or if the user enters 3 to call the ChaseTail method.*/

            Console.WriteLine("Write dog's name");
            string name = Console.ReadLine();
            Console.WriteLine("Write dog's breed");
            string breed = Console.ReadLine();
            Console.WriteLine("Write dog's color");
            string color = Console.ReadLine();
            Console.WriteLine("Enter 1,2 or 3");
            string number = Console.ReadLine();


            Dog dog1 = new Dog(name, breed, color);
            Console.WriteLine($"Your dog's name is {name}, breed - {breed} and it's color is {color}");
            if (number == "1")
            {
                Console.WriteLine($"{dog1.Eat()}");
            }
            else if (number == "2")
            {
                Console.WriteLine($"{dog1.Play()}");
            }
            else if (number == "3")
            {
                Console.WriteLine($"{dog1.ChaseTail()}");
            }
            else Console.WriteLine($"You entered wrong number");

        }
    }
}
