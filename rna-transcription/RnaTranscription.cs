using System;
using System.Linq;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        char[] nucleoArr = nucleotide.ToUpper().ToCharArray();


        char[] baseArr = { 'G', 'C', 'T', 'A' };
        char[] convArr = { 'C', 'G', 'A', 'U' };

        for (int i = 0; i < nucleotide.Length; i++)
        {
            if(baseArr.Contains(nucleoArr[i]))
            {
                nucleoArr[i] = convArr[Array.IndexOf<char>(baseArr, nucleoArr[i])];
            }

        }
        return new string(nucleoArr);

    }
}