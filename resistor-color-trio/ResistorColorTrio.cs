using System;
using System.Collections.Generic;
using System.Linq;

public static class ResistorColorTrio
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


    public static string Label(string[] colors)
    {
        colors = colors.Select(x => x.ToLower()).ToArray();


        var third = Int32.Parse(ResistorNumbers[colors[2]]);
        var thirdValue = 1;
        var response =0;



        for (int i = 1; i <= third; i++)
        {
            thirdValue *= 10;          
        }


        response= Int32.Parse(ResistorNumbers[colors[0]] + ResistorNumbers[colors[1]]) * thirdValue;


        if (response % 1000 > 0)
            return response + " ohms";

       return response/1000 + " kiloohms";
    }
}
