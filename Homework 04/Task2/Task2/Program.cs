// See https://aka.ms/new-console-template for more information
/*
Make a new console application called StudentGroup

Make 2 arrays called studentsG1 and studentsG2 and fill them with 5 student names.

Get a number from the console between 1 and 2 and print the students from that group in the console.

Ex: studentsG1 ["Zdravko", "Petko", "Stanko", "Branko", "Trajko"]

Test Data:

Enter student group: ( there are 1 and 2 )
1
Expected Output:

The Students in G1 are:
Zdravko
Petko
Stanko
Branko
Trajko*/


string[] studentsG1 = new string[] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
string[] studentsG2 = new string[] { "Clara", "Mia", "Dani", "Vesna", "Tea" };

while (true)
{

    Console.WriteLine("Enter students group");
    string input = Console.ReadLine();

    if (!int.TryParse(input, out int number))
    {
        Console.WriteLine("Wrong choice");
        continue;
    } 

    if (number == 1)
    {
        foreach (string student in studentsG1)
        {
            Console.WriteLine(student);
          
        }
    }
    else if (number == 2)
    {
        foreach (string student in studentsG2)
        {
            Console.WriteLine(student);
           
        }
    }
    else { 
        Console.WriteLine("Wrong number");
    }
}
