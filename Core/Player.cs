using System;

public abstract class Player
{
	public double strength = 0;
	public double dexterity = 0;
	public double intelligence = 0;
	public double constitution = 0;
	public double health = 0;
	public double mana = 0;

	public Player(double str, double dex, double intell, double con) 
	{
		strength = str;
		dexterity = dex;
		intelligence = intell;
		constitution = con;
	}
	public static double Health(double con, double str) 
	{
		health = 2 * con + 0.5 * str;
	}
	public static double Mana(double intell) 
	{
		Mana = intell * 3;
	}
}
