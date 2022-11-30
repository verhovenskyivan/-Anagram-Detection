using System;
using System.Linq;

public class Kata
{
    public static bool IsAnagram(string test, string original)
    {
        return SortLower(test) == SortLower(original);
    }

    public static string SortLower(string str)
    {
        return String.Concat(str.ToLower().OrderBy(c => c));
    }
}