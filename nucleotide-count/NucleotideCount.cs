using System;
using System.Collections.Generic;
using System.Linq;

public static class NucleotideCount
{


/*    public static IDictionary<char, int> Count(string sequence)
    {

        if (sequence.Any(x => !nucleotide.ContainsKey(x)))
            throw new ArgumentException();

        for (int i = 0; i < nucleotide.Count; i++)
            nucleotide[nucleotide.ElementAt(i).Key] = sequence.ToUpper().Where(x => nucleotide.ElementAt(i).Key == x).Count();

        return nucleotide;
    }*/
    public class NucleotideCountTests{
        public char[] nucleotide = new char[] { 'a', 'c', 'g', 't' };

       public void funcDoSmthng (char[] tableToGive) => tableToGive['0'] = 'x';
    }

  public static void main(string[] args)
    {
        NucleotideCountTests someTestObj = new NucleotideCountTests();
        Console.WriteLine(someTestObj.nucleotide);

        someTestObj.funcDoSmthng(someTestObj.nucleotide);
        Console.WriteLine(someTestObj.nucleotide);


    }
}