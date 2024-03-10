using Microsoft.VisualBasic;

namespace Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Make a method called AgeCalculator
 The method will have one input parameter, your birthday date
 The method should return your age
 Show the age of a user after he inputs a date
 Note: take into consideration if the birthday is today, after or before today*/
            
            int birthYear;
            while (true)
            {
                Console.WriteLine("Enter your Year of Birth");
                string input = Console.ReadLine();
                if (!int.TryParse(input, out birthYear))
                {
                    Console.WriteLine("Wrong input, try again");
                    continue;
              
                }
                break;
            }
            Console.WriteLine($"Your birthday year is: {birthYear}");
            Console.WriteLine($"Your age is: {YourAge(birthYear)}");


            Console.ReadLine();
        }
        public static int YourAge(int value)
        {
            DateTime currentDateTime = DateTime.Now;
            int currentYear = currentDateTime.Year;
            int result = currentYear - value;
            return result;
        }
    }
}
