using System;
using System.Linq;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        var reversedArray = input
            .ToCharArray()
            .Reverse().ToArray();

            return  new string(reversedArray);
    }
}