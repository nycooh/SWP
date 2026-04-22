using System;
using EinkaufslisteApp;

var liste = new Einkaufsliste();

Console.WriteLine("Einkaufsliste Test\n");

string[] probeArtikel = { "Milch", "Brot", "Käse", "Apfel", "Orangensaft", "Eier", "Müsli", "Butter", "Tomaten", "Salat", "Wasser" };

foreach (var artikel in probeArtikel)
{
    bool success = liste.VersucheHinzufuegen(artikel, out string meldung);
    Console.WriteLine(meldung);
    if (!success)
    {
        Console.WriteLine("Stoppe weitere Einträge, weil die Liste voll ist.\n");
        break;
    }
}

Console.WriteLine();
Console.WriteLine($"Anzahl der Artikel: {liste.Anzahl}");
Console.WriteLine($"Enthält 'Käse'? {liste.Enthaelt("Käse")}");
Console.WriteLine($"Enthält 'Schokolade'? {liste.Enthaelt("Schokolade")}\n");

liste.GibKurzeNamenAus(5);
Console.WriteLine();

string a = "Milch";
string b = "Mil" + "ch";
Console.WriteLine("String-Vergleichstest:");
liste.VergleicheStrings(a, b);

Console.WriteLine("\nDrücke eine Taste zum Beenden...");
Console.ReadKey();
