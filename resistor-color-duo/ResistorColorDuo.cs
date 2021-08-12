using System;
using System.Collections.Generic;
using System.Linq;

public static class ResistorColorDuo
{

    private static Dictionary<string, string> ResistorNumbers = new Dictionary<string, string>() {
         {"black","0"},
         {"brown","1"},
         {"red","2"},
         {"orange","3"},
         {"yellow","4"},
         {"green","5"},
         {"blue","6"},
         {"violet","7"},
         {"grey","8"},
         {"white","9"}
     };



    public static int Value(string[] colors)
    {

        colors= colors.Select(x => x.ToLower()).ToArray();   


         var resistorConcatVal= ResistorNumbers[colors[0]] + ResistorNumbers[colors[1]];


        try
        {
            return Convert.ToInt32(resistorConcatVal);
        }
        catch (FormatException exc)
        {

            throw exc;
        }
        catch (Exception exc)
        {
            throw exc;
        }

    }
}
