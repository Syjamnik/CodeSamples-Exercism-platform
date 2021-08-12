using System;
using System.Collections.Generic;
using System.Linq;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        // now is case insensitive 
        input = input.ToLower();
        char[] tableOfChars = input.ToCharArray();
        List<char> tableOfAllowedChars = new List<char>();

        // 97 -a to 122-z
        for (byte i = 97; i <= 122; i++)
        {
            tableOfAllowedChars.Add((char)i);
        }


        foreach (var allowedChar in tableOfAllowedChars)
        {
            var containsCorrectChar = tableOfChars.Contains(allowedChar);


            if (containsCorrectChar)
                continue;
            else
                return false;
        }


        return true;


    }
}
