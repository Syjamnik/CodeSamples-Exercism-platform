using System;

public class SpaceAge
{
    public double AgeInYears { get; set; }
    public SpaceAge(int seconds)
    {
        this.AgeInYears = seconds/31557600.0;
    }

    public double OnEarth() => AgeInYears;

    public double OnMercury() => AgeInYears / 0.2408467;

    public double OnVenus() => AgeInYears / 0.61519726;

    public double OnMars() => AgeInYears / 1.8808158;

    public double OnJupiter() => AgeInYears / 11.862615;

    public double OnSaturn() => AgeInYears / 29.447498;

    public double OnUranus() => AgeInYears / 84.016846;

    public double OnNeptune() => AgeInYears / 164.79132;
}