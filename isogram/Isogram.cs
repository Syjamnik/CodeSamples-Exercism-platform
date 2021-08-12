using System;
using System.Linq;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {

        var items = word.ToLower()
             .Where(char.IsLetter);


        var allItems = items.Count();
        var uniqueItems = items.Distinct().Count();

        return allItems == uniqueItems;
             
    }
}
