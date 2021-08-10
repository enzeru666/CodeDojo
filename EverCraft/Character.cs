using System;

public class Character
{
	public int hitPoints = 5;
	public int armorClass = 10;
    public int attackDamage = 0;
    public int attackRoll = 0;

	public string Name
	{ get; set; }

	public enum Alignment
	{	
		Good, 
		Neutral, 
		Evil 
	};
}