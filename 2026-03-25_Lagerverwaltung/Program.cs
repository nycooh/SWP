using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Schritt 1: Array (Das feste Regal)
        string[] regalPlatze = { "Zahnrad", "Kolben", "Ventil", "Dichtung", "Achse" };
        Array.Sort(regalPlatze);
        Console.WriteLine("Sortierte Regalplätze:");
        foreach (var teil in regalPlatze)
        {
            Console.WriteLine(teil);
        }
        Console.WriteLine();

        // Schritt 2: List (Die dynamische Einlagerung)
        List<string> eingangskorb = new List<string>();
        eingangskorb.Add("Schraube");
        eingangskorb.Add("Mutter");
        eingangskorb.Add("Bolzen");
        eingangskorb.Add("Feder");
        eingangskorb.RemoveAt(1); // Entfernt das zweite Element ("Mutter")
        if (eingangskorb.Contains("Schraube"))
        {
            Console.WriteLine("Schraube ist noch in der Liste.");
        }
        else
        {
            Console.WriteLine("Schraube ist nicht mehr in der Liste.");
        }
        Console.WriteLine($"Anzahl der verbleibenden Teile: {eingangskorb.Count}");
        Console.WriteLine();

        // Schritt 3: Dictionary (Das Such-System)
        Dictionary<int, string> artikel = new Dictionary<int, string>();
        artikel.Add(101, "Motor");
        artikel.Add(102, "Getriebe");
        artikel.Add(103, "Reifen");
        FindArtikel(artikel, 102);
        FindArtikel(artikel, 999);
        Console.WriteLine();

        // Zusatzaufgabe: Iteriere über das Dictionary
        Console.WriteLine("Alle Artikel:");
        foreach (var kvp in artikel)
        {
            Console.WriteLine($"ID: {kvp.Key}, Teil: {kvp.Value}");
        }
    }

    static void FindArtikel(Dictionary<int, string> dict, int id)
    {
        if (dict.TryGetValue(id, out string name))
        {
            Console.WriteLine($"Artikel gefunden: {name}");
        }
        else
        {
            Console.WriteLine("Fehlermeldung: ID unbekannt");
        }
    }
}
