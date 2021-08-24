using System;
using System.Linq;
public static class Bob
{
    public static string Response(string statement)
    {
        if (string.IsNullOrWhiteSpace(statement))
            return "Fine. Be that way!";

        var statementLetters= statement.Trim().Where(char.IsLetter);
        var statmentLastDigitIsQuestionMark = statement.Trim().Last().Equals('?');


        if (statementLetters.Count() > 0 && statementLetters.All(char.IsUpper))
        {
            if (statmentLastDigitIsQuestionMark)
                return "Calm down, I know what I'm doing!";
            else
                return "Whoa, chill out!";
        }

        if (statmentLastDigitIsQuestionMark)
            return "Sure.";
        else
            return "Whatever.";

    }
}