using System;
using System.Collections.Generic;
using System.Text;

public static class RotationalCipher
{
    private readonly static List<char> _alphabet;
    static RotationalCipher()
    {
        // alphabet has 26 characters
        _alphabet = new List<char>();

        for (int i = 'a'; i <= 'z'; i++)
        {
            _alphabet.Add((char)i);
        }
    }




    public static string Rotate(string text, int shiftKey)
    {
        StringBuilder strBuilder = new StringBuilder(text.Length);


        for (int i = 0; i < text.Length; i++)
        {
            char selectedCharacter = text[i];


            if (char.IsLetter(selectedCharacter))
            {
                bool isCharLower = char.IsLower(selectedCharacter);


                strBuilder.Append(
                        isCharLower ? 
                        _alphabet[(_alphabet.IndexOf(selectedCharacter) + shiftKey) % _alphabet.Count] 
                        : Char.ToUpper(_alphabet[(_alphabet.IndexOf(Char.ToLower(selectedCharacter)) + shiftKey) % _alphabet.Count])
                    );
            }
            else
                strBuilder.Append(selectedCharacter);
            
        }


        return strBuilder.ToString();
    }
}