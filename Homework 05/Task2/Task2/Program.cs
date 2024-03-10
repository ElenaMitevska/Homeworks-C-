namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Create a new console application and a new method called Substrings

 In that method enter the following string :
 "Hello from SEDC Codecademy 2024"
 Ask the user to enter a number n.
 Print the first n characters from that string and print the length of the new string.
 Try to handle all the scenarios.*/
            string greeting = "Hello from SEDC Codeacademy 2024";
            string result;
            result = Substring(greeting);

        }
        public static string Substring(string value)
        {

            int n;
            while (true)
            {
                Console.WriteLine("Enter a number");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out n))
                {
                    Console.WriteLine("Wrong input");
                    continue;
                }
                break;
            }
          
            string substring = value.Substring(0, n);
            Console.WriteLine(substring);
            Console.WriteLine(substring.Length);
            return substring;

        }
    }
}
