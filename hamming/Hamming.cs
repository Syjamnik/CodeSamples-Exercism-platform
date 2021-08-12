using System;
using System.Linq;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        if (firstStrand.Length != secondStrand.Length)
            throw new ArgumentException("size of elements is incorrect !");

        return firstStrand.Where((t, i) => t != secondStrand[i]).Count();

    }
}