using System;

using System.Collections.Generic;
using System.Linq;

public class Robot
{
    private static class RobotFactoryNames {
        public static HashSet<string> ListOfGivenNames { get; private set; }

        static RobotFactoryNames()
        {
            ListOfGivenNames = new HashSet<string>();
        }
    }

    private string _name;

    public string Name
    {
        get
        {
            if (string.IsNullOrEmpty(_name))
            {
                Reset();
                return Name;
            }
            return _name;
        }
    }

    private string CreateName(Random random) => $"{Convert.ToChar(random.Next(65, 91))}{Convert.ToChar(random.Next(65, 91))}{random.Next(0, 10)}{random.Next(0, 10)}{random.Next(0, 10)}";

    public void Reset()
    {
        var robotName = CreateName(new Random());

        if (!RobotFactoryNames.ListOfGivenNames.Add(robotName))
        {
            Reset();
            return;
        }

        RobotFactoryNames.ListOfGivenNames.Add(robotName);
        RobotFactoryNames.ListOfGivenNames.Remove(_name);
        _name = robotName;
    }



}