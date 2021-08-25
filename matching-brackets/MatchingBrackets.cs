using System;
using System.Collections.Generic;
using System.Linq;

public static class MatchingBrackets
{

    public static bool IsPaired(string input)
    {
        var pairedPunktationMarks = new Dictionary<char, char>{{'[', ']'}, {'{', '}'},{'(', ')'}};
        var stack = new Stack<char>();



        foreach (var character in input)
        {
            if (pairedPunktationMarks.ContainsKey(character))
                stack.Push(character);
            else if (pairedPunktationMarks.ContainsValue(character) && (stack.Count == 0 || pairedPunktationMarks[stack.Pop()] != character))
                return false;
        }



        return stack.Count == 0;

    }
}
