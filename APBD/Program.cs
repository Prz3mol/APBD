// See https://aka.ms/new-console-template for more information

// Wypisywanie na konsolę
Console.WriteLine("Witaj w projekcie APBD!");

// Pobieranie danych od użytkownika
Console.Write("Jak masz na imię? ");
string user = Console.ReadLine();

Console.WriteLine($"Cześć {user}, zaczynamy naukę C#!");

// Prosta instrukcja warunkowa
int punkty = 55;

if (punkty >= 50) 
{
    Console.WriteLine("Zaliczone!");
} 
else 
{
    Console.WriteLine("Spróbuj jeszcze raz.");
}

// Pętla for - wykonaj coś 5 razy
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"To jest obieg nr: {i}");
}

Console.WriteLine("Press any key to exit...");
