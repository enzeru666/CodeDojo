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

    public Character(string name)
    {
        Name = name;
    }

    public bool DefendAgainst(int diceRoll) =>
        diceRoll == 20 || (diceRoll > armorClass);
}

public enum Alignment
{
    Good,
    Neutral,
    Evil
};