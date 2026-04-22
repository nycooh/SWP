using System;

namespace EinkaufslisteApp
{
    public class Einkaufsliste
    {
        private const int MaxArtikel = 10;
        private readonly string?[] artikel = new string?[MaxArtikel];
        private int anzahl;

        public int Anzahl => anzahl;

        public bool VersucheHinzufuegen(string artikelName, out string meldung)
        {
            if (anzahl >= MaxArtikel)
            {
                meldung = "Die Einkaufsliste ist voll. Kein Platz für weitere Artikel.";
                return false;
            }

            artikel[anzahl] = artikelName;
            anzahl++;
            meldung = $"Artikel '{artikelName}' wurde hinzugefügt. Aktuell {anzahl}/{MaxArtikel} Artikel.";
            return true;
        }

        public bool Enthaelt(string gesuchterArtikel)
        {
            bool gefunden = false;
            for (int i = 0; i < anzahl; i++)
            {
                if (artikel[i] == gesuchterArtikel)
                {
                    gefunden = true;
                    break;
                }
            }
            return gefunden;
        }

        public void GibKurzeNamenAus(int minLaenge)
        {
            Console.WriteLine($"Artikel mit weniger als {minLaenge} Zeichen:");
            for (int i = 0; i < anzahl; i++)
            {
                string current = artikel[i]!;
                if (current.Length >= minLaenge)
                {
                    continue;
                }
                Console.WriteLine($"- {current}");
            }
        }

        public void VergleicheStrings(string a, string b)
        {
            bool gleichMitOperator = a == b;
            bool gleichMitEquals = a.Equals(b, StringComparison.Ordinal);

            Console.WriteLine($"Vergleich mit '==': {gleichMitOperator}");
            Console.WriteLine($"Vergleich mit '.Equals()': {gleichMitEquals}");
            Console.WriteLine(gleichMitOperator == gleichMitEquals
                ? "Beide Vergleiche liefern dasselbe Ergebnis."
                : "Die Vergleiche liefern unterschiedliche Ergebnisse.");
        }
    }
}
