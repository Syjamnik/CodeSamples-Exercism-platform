using System;
using System.Linq;

public static class ResistorColor
{
    public static int ColorCode(string color)=> (int) Enum.Parse(typeof(ResistorColors), color.ToLower());

    public static string[] Colors() => Enum.GetNames(typeof(ResistorColors));


    public enum ResistorColors {
        black,
        brown,
        red,
        orange,
        yellow,
        green,
        blue,
        violet,
        grey,
        white
    }

}