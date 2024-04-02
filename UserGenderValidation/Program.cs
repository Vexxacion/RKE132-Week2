// See https://aka.ms/new-console-template for more information

// Rakendus küsib kasutajal valida sugu (m/f)
// Rakendus küsib kasutajal sisestada tema perekonnanime
// Lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
// "Welcome, Mr. [kasutaja perekonnanimi] / Welcome Ms. [kasutaja perekonnanimi]"

Console.WriteLine("Please, select your gender (M/F):");

char userGender = Char.Parse(Console.ReadLine()); // Loeb konsoolist maha andmeid string (Sõne) formaadis

Console.WriteLine("Please, enter your last name:");
string userLastName = Console.ReadLine();


if (userGender == 'M')
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");
}
else if (userGender == 'F')
{
    Console.WriteLine($"Welcome, Ms. {userLastName}!");    
}
else
{
    Console.WriteLine($"Welcome, {userLastName}!");
}
