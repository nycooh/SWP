using System;
using System.Collections.Generic;

namespace Inventarsystem;

interface IInventarGegenstand
{
    string Name { get; }
    string BeschreibeDich();
}

class Waffe : IInventarGegenstand
{
    public string Name { get; }
    public int Schaden { get; }

    public Waffe(string name, int schaden)
    {
        Name = name;
        Schaden = schaden;
    }

    public string BeschreibeDich()
    {
        return $"Ich bin das {Name} und mache {Schaden} Schaden.";
    }
}

class Heiltrank : IInventarGegenstand
{
    public string Name { get; }
    public int Heilwert { get; }

    public Heiltrank(string name, int heilwert)
    {
        Name = name;
        Heilwert = heilwert;
    }

    public string BeschreibeDich()
    {
        return $"Ich bin der {Name} und stelle {Heilwert} Lebenspunkte wieder her.";
    }
}

class Program
{
    static void Main()
    {
        List<IInventarGegenstand> inventar = new()
        {
            new Waffe("Schwert", 15),
            new Heiltrank("Heiltrank", 20)
        };

        foreach (IInventarGegenstand gegenstand in inventar)
        {
            Console.WriteLine(gegenstand.BeschreibeDich());
        }
    }
}
