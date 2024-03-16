
namespace Homework07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Create a method called NumberStats that accepts a number. This method should:

 Find out if the number is negative or positive

 Find out if the number is odd or even

 Find out if the number is decimal or integer

 After finding all the stats it should print them like this:

 Stats for number: 25

 Positive
 Integer
 Odd
 The number should be entered in the console by the user.

 Bonus: Validate if the user is entering a number

 Bonus: Ask the user to press Y to try again or X to exit*/
            //i/*nt number1;*/
            double number1;

            while (true)
            {
                Console.WriteLine("Enter a number");
                string input = Console.ReadLine();
                if  (!double.TryParse(input, out number1))
                {
        
               
                    Console.WriteLine("Wrong input");
                    continue;
                }

               
                
                
                NumberStats number = new NumberStats(number1);
            Console.WriteLine($"{number.NumberPosOrNegative()}{number.NumberOddOrEven()}{number.DecimalOrInteger()}");
               

                Console.WriteLine("Do you want to enter another number y/n?");
                string input1 = Console.ReadLine();
                if (input1 != "y" && input1 != "Y")
                {
                    break;
                }
            }

        }

        }
    }

