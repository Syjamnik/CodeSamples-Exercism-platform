using System;
using System.Linq;
using System.Collections.Generic;

public class GradeSchool
{

    private readonly Dictionary<string, int> _rosterDict;

    public GradeSchool()=> _rosterDict = new Dictionary<string, int>();




    public void Add(string student, int grade) {
        if (!_rosterDict.TryAdd(student, grade))
            throw new ArgumentException("this user alredy exist in database");
    } 

    public IEnumerable<string> Roster()=> _rosterDict.OrderBy(x => x.Value).ThenBy(x => x.Key).Select(x => x.Key);

    public IEnumerable<string> Grade(int grade)=> _rosterDict.Where(x => x.Value == grade).OrderBy(x => x.Value).ThenBy(x => x.Key).Select(x => x.Key);

}