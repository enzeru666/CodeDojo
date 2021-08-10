using System;

public class Character
{
	public int hitPoints = 5;
	public int armorClass = 10;

	public string Name
	{ get; set; }

	public enum Alignment
	{	
		Good, 
		Neutral, 
		Evil 
	};
}