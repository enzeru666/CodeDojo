using System;

public class Character
{
    public static class Defaults
    {
        public const int hitPoints = 5;
        public const int armor = 10;
    }

    public int hitPoints = Defaults.hitPoints;
	public int armorClass = Defaults.armor;
	
    public string Name { get; set; }
    public Alignment Alignment { get; set; } = Alignment.Neutral;
    public bool IsDead { get; set; }

    public Character(string name)
    {
        Name = name;
    }

    public HitType DefendAgainst(int diceRoll)
    {
        if (diceRoll == 20)
            return HitType.Critical;
        if (diceRoll > armorClass)
            return HitType.Success;
        else
            return HitType.Miss;
    }

    public void Attack(Character defender, int diceRoll)
    {
        var hitResult = defender.DefendAgainst(diceRoll);
        if (hitResult == HitType.Success)
        {
            defender.hitPoints -= 1;
        }

        if (hitResult == HitType.Critical)
        {
            defender.hitPoints -= 2;
        }

        if (defender.hitPoints <= 0)
        {
            defender.IsDead = true;
        }
    }
}

public enum HitType
{
    Miss,
    Success,
    Critical,
}

public enum Alignment
{
    Good,
    Neutral,
    Evil
};