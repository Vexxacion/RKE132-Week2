// See https://aka.ms/new-console-template for more information

// Rakendus küsib kasutajal sisestada tema vanus
// Kui kasutaja vanus on väiksem kui 13, siis konsoolis kuvatakse:
// "You are too young to use Facebook"
// Muul juhul
// Konsoolis kuvatakse "Welcome to Facebook!"

Console.WriteLine("Enter your age:");

string userAge = Console.ReadLine();

int userAgeNum = 0;

// Boolean - true/false

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);

Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} years old.");

if (isAgeNumber)
{
    if (userAgeNum >= 13)
    {
        Console.WriteLine("Welcome to Facebook!");
    }
    else
    {
        Console.WriteLine("You are too young to use Facebook!");
    }
}
else
{
    Console.WriteLine("Could not read your age.");
}

//int userAge = Int32.Parse(Console.ReadLine()); // "13" - heap, 13 - stack



//if (userAge >= 13)
//{
//    Console.WriteLine("Welcome to Facebook!");
//}
//else
//{
//    Console.WriteLine("You are too young to use Facebook!");
//}

