﻿using System;

public class Character
{
	public int hitPoints = 5;
	public int armorClass = 10;
	
    public string Name { get; set; }
    public Alignment Alignment { get; set; } = Alignment.Neutral;

    public Character(string name)
    {
        Name = name;
    }
}

public enum Alignment
{
    Good,
    Neutral,
    Evil
};