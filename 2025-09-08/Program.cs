using System;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length != 2)
        {
            Console.WriteLine("Usage: dotnet run \"2 3/8\" \"1 5/6\"");
            return;
        }

        var bruch1 = ParseMixedFraction(args[0]);
        var bruch2 = ParseMixedFraction(args[1]);

        var sum = AddFractions(bruch1, bruch2);

        Console.WriteLine($"{sum.Item1} {sum.Item2}/{sum.Item3}");
    }

    // Parses "2 3/8" to (whole:2, numerator:3, denominator:8)
    static (int, int, int) ParseMixedFraction(string input)
    {
        var parts = input.Split(' ');
        int whole = 0, numerator = 0, denominator = 1;

        if (parts.Length == 2)
        {
            whole = int.Parse(parts[0]);
            var frac = parts[1].Split('/');
            numerator = int.Parse(frac[0]);
            denominator = int.Parse(frac[1]);
        }
        else if (parts.Length == 1 && parts[0].Contains('/'))
        {
            var frac = parts[0].Split('/');
            numerator = int.Parse(frac[0]);
            denominator = int.Parse(frac[1]);
        }
        else if (parts.Length == 1)
        {
            whole = int.Parse(parts[0]);
        }

        return (whole, numerator, denominator);
    }

    // Adds two mixed fractions and returns the result as (whole, numerator, denominator)
    static (int, int, int) AddFractions((int, int, int) a, (int, int, int) b)
    {
        // Convert to improper fractions
        int num1 = a.Item1 * a.Item3 + a.Item2;
        int den1 = a.Item3;
        int num2 = b.Item1 * b.Item3 + b.Item2;
        int den2 = b.Item3;

        // Common denominator
        int den = den1 * den2;
        int num = num1 * den2 + num2 * den1;

        // Convert back to mixed fraction
        int whole = num / den;
        int restNum = num % den;

        // Kürzen
        int gcd = GCD(restNum, den);
        restNum /= gcd;
        den /= gcd;

        return (whole, restNum, den);
    }

    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int t = b;
            b = a % b;
            a = t;
        }
        return a;
    }
}