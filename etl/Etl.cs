using System;
using System.Collections.Generic;
using System.Linq;

public static class Etl
{


    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
    {

        var newDict = new Dictionary<string, int>();
        foreach (var item in old)
        {
            foreach (var inItem in item.Value)
            {
                if (!newDict.TryAdd(inItem.ToLower(), item.Key))
                    throw new ArgumentException("Duplicate of letter " + inItem);
            }
        }
        return newDict;
    }
}