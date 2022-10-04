using System;

public class Kata
{
    public static double Index(int[] array, int n)
    {
        return n > (array.Length - 1) ? -1 : Math.Pow(array[n], n);
    }
}

/*using System.Linq;

public static class StringExtensions
{
    public static bool IsUpperCase(this string text)
    {
        return !text.Any(j => char.IsLower(j));
    }
}



/*using System;

public static class Kata
{
    public static string Greet(string name)
    {
        return "Hello, "+name+" how are you doing today?";
    }
}



/*using System.Linq;

public class Kata
{
    public static int[] CountPositivesSumNegatives(int[] input)
    {
        return input == null || input.Count() == 0
        ? new int[] { }
        : new int[] { input.Count(j => j > 0), input.Where(j => j < 0).Sum() };
    }
}

/*public static class SpacesRemover
{
    public static string NoSpace(string input)
    {
        return string.Join("", input.Split(' ', System.StringSplitOptions.RemoveEmptyEntries));
    }
}

/*
public static class Kata
{
    public static string boolToWord(bool word)
    {
        return word ? "Yes" : "No";
    }
}



/*
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static List<int> FindMultiples(int integer, int limit)
    {
        IEnumerable<int> temelSayilar = Enumerable.Range(1, limit / integer);

        return temelSayilar.Select(j => j * integer).ToList();
    }
}




/*using System.Linq;

public static class Kata
{
    public static int CountSheeps(bool[] sheeps)
    {
        return sheeps.Count(j => j);
    }
}






/*
using System;
using System.Linq;

public class Kata
{
    public static string[] FixTheMeerkat(string[] arr)
    {
        return arr.Reverse().ToArray();
    }
}



/*
using System.Linq;

public class Kata
{
    public static string AbbrevName(string name)
    {
        string[] dizi = name.Split(" ");

        char[] basHarfler = dizi.Select(j => j[0]).ToArray();

        return string.Join(".", basHarfler).ToUpper();
    }
}





/*
public class Kata
{
    public static bool AmIWilson(int p)
    {
        return (Faktoriyel(p - 1) + 1) % (p * p) == 0;
    }

    static int Faktoriyel(int p)
    {
        int faktoriyel = 1;

        if (p < 2)
            return faktoriyel;


        for (int j = 1; j <= p; j++)
        {
            faktoriyel *= j;
        }

        return faktoriyel;
    }
}
*/