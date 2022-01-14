using System;

public abstract class Player
{
	public double strength = 0;
	public double dexterity = 0;
	public double intelligence = 0;
	public double constitution = 0;

	public Player(double str, double dex, double intell, double con) 
	{
		strength = str;
		dexterity = dex;
		intelligence = intell;
		constitution = con;
	}
}
