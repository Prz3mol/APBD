using System;
using System.Collections.Generic;
using System.Linq;

namespace APBD;

// 1. Definiujemy model danych (nasza "tabelka" w C#)
public class Student 
{
    public int Id { get; set; }
    public string Nazwisko { get; set; }
    public string Kierunek { get; set; }
    public double Srednia { get; set; }
}

public class Program 
{
    public static void Main() 
    {
        // 2. Tworzymy listę studentów (nasza "baza danych" w pamięci)
        var bazaStudentow = new List<Student>
        {
            new Student { Id = 1, Nazwisko = "Kowalski", Kierunek = "Informatyka", Srednia = 4.5 },
            new Student { Id = 2, Nazwisko = "Nowak", Kierunek = "Sztuczna Inteligencja", Srednia = 3.8 },
            new Student { Id = 3, Nazwisko = "Wisniewski", Kierunek = "Informatyka", Srednia = 4.8 },
            new Student { Id = 4, Nazwisko = "Wojcik", Kierunek = "Data Science", Srednia = 4.2 }
        };

        // 3. Używamy LINQ do filtrowania danych
        // Chcemy tylko studentów z Informatyki ze średnią powyżej 4.0
        var wybraniStudenci = bazaStudentow
            .Where(s => s.Kierunek == "Informatyka" && s.Srednia > 4.0)
            .OrderByDescending(s => s.Srednia) // Sortujemy od najwyższej średniej
            .ToList();

        // 4. Wyświetlamy wynik
        Console.WriteLine("Studenci Informatyki z wysoką średnią:");
        foreach (var s in wybraniStudenci)
        {
            Console.WriteLine($"- {s.Nazwisko}: {s.Srednia} ({s.Kierunek})");
        }
    }
}