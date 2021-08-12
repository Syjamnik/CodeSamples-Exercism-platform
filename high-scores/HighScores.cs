using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{

    private static List<int> _listOfScores;

    public HighScores(List<int> list) => _listOfScores = list;

    public List<int> Scores() => _listOfScores;

    public int Latest() => _listOfScores.Last();

    public int PersonalBest() => _listOfScores.Max();

    public List<int> PersonalTopThree() => _listOfScores.OrderBy(i => i).Skip(_listOfScores.Count - 3).Reverse().ToList();
}