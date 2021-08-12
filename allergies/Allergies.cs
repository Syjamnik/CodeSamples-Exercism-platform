using System;
using System.Linq;
using System.Collections.Generic;

public enum Allergen
{
    Eggs=1,
    Peanuts=2,
    Shellfish=4,
    Strawberries=8,
    Tomatoes=16,
    Chocolate=32,
    Pollen=64,
    Cats=128
}

public class Allergies
{

    private readonly int binSumOfAllergies;
    public Allergies(int mask)
    {
        binSumOfAllergies=mask;

    }

    public bool IsAllergicTo(Allergen allergen)
    {
        return (binSumOfAllergies & (int)allergen) == (int)allergen;
    }

    private IEnumerable<Allergen> getAllAllergens()
    {
        foreach (Allergen allergy in Enum.GetValues(typeof(Allergen)))
        {
            if (IsAllergicTo(allergy))
                yield return allergy;
        }
    }

    public Allergen[] List()
    {
        return getAllAllergens().ToArray();
    }
}